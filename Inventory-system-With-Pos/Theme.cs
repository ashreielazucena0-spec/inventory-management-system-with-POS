using System.Drawing;

namespace inventory_management_system_with_POS
{
    // =====================================================================
    //  Theme  -  the "variables" part of our stylesheet (like :root in CSS)
    // =====================================================================
    //  Every colour, font and size used by the screens is declared HERE and
    //  nowhere else. To restyle the whole system, edit this file only.
    //
    //  Styles.cs holds the "rules" (how a button / grid / card should look)
    //  and uses these values.
    // =====================================================================
    public static class Theme
    {
        // ---------- Brand colours ----------
        public static readonly Color Primary      = Color.FromArgb(37, 99, 235);    // main blue (buttons, links)
        public static readonly Color PrimaryDark  = Color.FromArgb(29, 78, 216);    // hover / pressed
        public static readonly Color PrimaryTint  = Color.FromArgb(219, 234, 254);  // light blue chips, selection
        public static readonly Color PrimaryLight = Color.FromArgb(96, 165, 250);   // light accents on dark bars
        public static readonly Color PrimaryDeep  = Color.FromArgb(30, 58, 138);    // deep blue text / banners

        // ---------- Dark navy (title bars, sidebars) ----------
        public static readonly Color Navy         = Color.FromArgb(20, 40, 70);
        public static readonly Color NavyMid      = Color.FromArgb(20, 54, 105);
        public static readonly Color NavyDark     = Color.FromArgb(15, 23, 42);

        // ---------- Text ----------
        public static readonly Color TextStrong   = Color.FromArgb(30, 41, 59);     // headings, typed text
        public static readonly Color TextBody     = Color.FromArgb(51, 65, 85);     // normal text
        public static readonly Color TextMuted    = Color.FromArgb(100, 116, 139);  // captions, grid headers
        public static readonly Color TextHint     = Color.FromArgb(148, 163, 184);  // placeholders

        // ---------- Surfaces ----------
        public static readonly Color Page         = Color.FromArgb(241, 245, 249);  // form background
        public static readonly Color Surface      = Color.White;                    // cards, inputs
        public static readonly Color SurfaceAlt   = Color.FromArgb(248, 250, 252);  // alternate rows, headers
        public static readonly Color Border       = Color.FromArgb(226, 232, 240);  // thin outlines
        public static readonly Color BorderStrong = Color.FromArgb(203, 213, 225);

        // ---------- Status colours (each has a strong colour + a soft tint) ----------
        public static readonly Color Success      = Color.FromArgb(34, 139, 87);
        public static readonly Color SuccessTint  = Color.FromArgb(232, 245, 233);
        public static readonly Color Warning      = Color.FromArgb(217, 119, 6);
        public static readonly Color WarningTint  = Color.FromArgb(255, 247, 230);
        public static readonly Color WarningSoft  = Color.FromArgb(253, 230, 180);    // selected warning rows
        public static readonly Color WarningDark  = Color.FromArgb(120, 53, 15);    // text on a warning tint
        public static readonly Color Danger       = Color.FromArgb(220, 38, 38);
        public static readonly Color DangerTint   = Color.FromArgb(253, 242, 242);
        public static readonly Color DangerSoft   = Color.FromArgb(249, 219, 221);  // selected / bordered danger rows
        public static readonly Color DangerDark   = Color.FromArgb(127, 29, 29);    // text on a danger tint

        // ---------- Fonts ----------
        private const string Family      = "Segoe UI";
        private const string EmojiFamily = "Segoe UI Emoji";
        private const string MonoFamily  = "Consolas";   // receipts only
        private const string GlyphFamily = "Segoe MDL2 Assets";   // built-in Windows icon font

        public static readonly Font Caption      = new Font(Family, 8.25F);
        public static readonly Font CaptionBold  = new Font(Family, 8.25F, FontStyle.Bold);
        public static readonly Font Body         = new Font(Family, 9.5F);
        public static readonly Font BodyBold     = new Font(Family, 9.5F, FontStyle.Bold);
        public static readonly Font Large        = new Font(Family, 10.5F);
        public static readonly Font LargeBold    = new Font(Family, 10.5F, FontStyle.Bold);
        public static readonly Font Input        = new Font(Family, 13F);
        public static readonly Font Heading      = new Font(Family, 13F, FontStyle.Bold);
        public static readonly Font Title        = new Font(Family, 17F, FontStyle.Bold);
        public static readonly Font Display      = new Font(Family, 22F, FontStyle.Bold);
        public static readonly Font Emoji        = new Font(EmojiFamily, 12F);
        public static readonly Font EmojiLarge   = new Font(EmojiFamily, 20F);
        public static readonly Font Receipt      = new Font(MonoFamily, 9F);
        public static readonly Font ReceiptBold  = new Font(MonoFamily, 9F, FontStyle.Bold);
        public static readonly Font ReceiptTitle = new Font(MonoFamily, 12F, FontStyle.Bold);

        // Printed reports (kept as Calibri so printed column positions stay aligned).
        public static readonly Font PrintTitle   = new Font("Calibri", 14F, FontStyle.Bold);
        public static readonly Font PrintHeader  = new Font("Calibri", 9F, FontStyle.Bold);
        public static readonly Font PrintBody    = new Font("Calibri", 9F);

        // One-off sizes used by big numbers, hero emoji and icon-font glyphs.
        // Plain fields (not methods) so the Visual Studio designer can read them.
        public static readonly Font Hero24       = new Font(Family, 24F);
        public static readonly Font Hero24Bold   = new Font(Family, 24F, FontStyle.Bold);
        public static readonly Font Hero34       = new Font(Family, 34F);
        public static readonly Font Emoji26      = new Font(EmojiFamily, 26F);
        public static readonly Font Emoji38      = new Font(EmojiFamily, 38F);
        public static readonly Font Emoji54      = new Font(EmojiFamily, 54F);
        public static readonly Font Glyph11      = new Font(GlyphFamily, 11F);
        public static readonly Font Glyph12      = new Font(GlyphFamily, 12F);
        public static readonly Font Glyph16      = new Font(GlyphFamily, 16F);
        public static readonly Font Glyph36      = new Font(GlyphFamily, 36F);

        // ---------- Sizes (pixels) ----------
        public const int RadiusSmall  = 8;    // buttons, small chips
        public const int RadiusMedium = 10;   // inputs
        public const int RadiusLarge  = 16;   // cards
        public const int GridRowHeight    = 38;
        public const int GridHeaderHeight = 36;
    }
}
