using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace inventory_management_system_with_POS
{

    public static class PasswordHelper
    {
        private const int SaltSize = 16;      
        private const int HashSize = 32;      
        private const int Iterations = 100_000;


        private const string EncryptionPassphrase = "CHANGE_ME_INVENTORY_POS_KEY";

        public static string EncryptPassword(string plainText)
        {
            if (plainText == null) throw new ArgumentNullException(nameof(plainText));

            using (var aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.Key = DeriveKey(EncryptionPassphrase, aes.KeySize / 8);
                aes.GenerateIV();

                using (var encryptor = aes.CreateEncryptor())
                using (var ms = new MemoryStream())
                {
                    // Prepend the IV so it's available again at decrypt time.
                    ms.Write(aes.IV, 0, aes.IV.Length);

                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (var sw = new StreamWriter(cs, Encoding.UTF8))
                    {
                        sw.Write(plainText);
                    }

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public static string DecryptPassword(string cipherText)
        {
            if (string.IsNullOrEmpty(cipherText)) throw new ArgumentNullException(nameof(cipherText));

            byte[] fullCipher = Convert.FromBase64String(cipherText);

            using (var aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.Key = DeriveKey(EncryptionPassphrase, aes.KeySize / 8);

                int ivLength = aes.BlockSize / 8; // 16 bytes for AES
                byte[] iv = new byte[ivLength];
                byte[] cipherBytes = new byte[fullCipher.Length - ivLength];
                Buffer.BlockCopy(fullCipher, 0, iv, 0, ivLength);
                Buffer.BlockCopy(fullCipher, ivLength, cipherBytes, 0, cipherBytes.Length);

                aes.IV = iv;

                using (var decryptor = aes.CreateDecryptor())
                using (var ms = new MemoryStream(cipherBytes))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs, Encoding.UTF8))
                {
                    return sr.ReadToEnd();
                }
            }
        }

       
        private static byte[] DeriveKey(string passphrase, int keyLengthBytes)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] fullHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(passphrase));
                byte[] key = new byte[keyLengthBytes];
                Array.Copy(fullHash, key, keyLengthBytes);
                return key;
            }
        }

        // True if this looks like our "iterations.salt.hash" format from
        // HashPassword, as opposed to a legacy plain-text value.
        public static bool LooksHashed(string storedValue)
        {
            if (string.IsNullOrEmpty(storedValue)) return false;

            string[] parts = storedValue.Split('.');
            return parts.Length == 3 && int.TryParse(parts[0], out _);
        }

        public static string HashPassword(string password)
        {
            if (password == null) throw new ArgumentNullException(nameof(password));

            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[SaltSize];
                rng.GetBytes(salt);

                byte[] hash = Pbkdf2(password, salt, Iterations, HashSize);

                return string.Join(".",
                    Iterations.ToString(),
                    Convert.ToBase64String(salt),
                    Convert.ToBase64String(hash));
            }
        }

        public static bool VerifyPassword(string password, string storedHash)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(storedHash))
                return false;

            string[] parts = storedHash.Split('.');
            if (parts.Length != 3) return false;

            if (!int.TryParse(parts[0], out int iterations)) return false;

            byte[] salt;
            byte[] expectedHash;
            try
            {
                salt = Convert.FromBase64String(parts[1]);
                expectedHash = Convert.FromBase64String(parts[2]);
            }
            catch (FormatException)
            {
                return false;
            }

            byte[] actualHash = Pbkdf2(password, salt, iterations, expectedHash.Length);

            return FixedTimeEquals(actualHash, expectedHash);
        }

        private static byte[] Pbkdf2(string password, byte[] salt, int iterations, int outputBytes)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256))
            {
                return pbkdf2.GetBytes(outputBytes);
            }
        }

        // Constant-time comparison to avoid timing attacks.
        private static bool FixedTimeEquals(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return false;

            int diff = 0;
            for (int i = 0; i < a.Length; i++)
            {
                diff |= a[i] ^ b[i];
            }
            return diff == 0;
        }
    }
}