using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace inventory_management_system_with_POS
{
    /// <summary>
    /// What kind of value a column holds, so it gets the right look.
    /// Date = date only; Status = text coloured red when it says "Expired", amber otherwise.
    /// </summary>
    internal enum XlsxKind { Text, Integer, Money, DateTime, Date, Status }

    /// <summary>
    /// Tiny, dependency-free writer for styled .xlsx files: no NuGet package
    /// and no extra assembly reference (it writes the zip container itself).
    /// Build sheets with Title / Subtitle / KeyValue / Table, then Save().
    /// </summary>
    internal sealed class XlsxWorkbook
    {
        private readonly List<XlsxSheet> _sheets = new List<XlsxSheet>();

        public XlsxSheet AddSheet(string name)
        {
            var sheet = new XlsxSheet(name);
            _sheets.Add(sheet);
            return sheet;
        }

        public void Save(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("A file path is required.", "path");

            if (_sheets.Count == 0)
                throw new InvalidOperationException("A workbook needs at least one sheet.");

            var entries = new List<KeyValuePair<string, string>>();
            entries.Add(new KeyValuePair<string, string>("[Content_Types].xml", BuildContentTypes()));
            entries.Add(new KeyValuePair<string, string>("_rels/.rels", RootRels));
            entries.Add(new KeyValuePair<string, string>("xl/workbook.xml", BuildWorkbookXml()));
            entries.Add(new KeyValuePair<string, string>("xl/_rels/workbook.xml.rels", BuildWorkbookRels()));
            entries.Add(new KeyValuePair<string, string>("xl/styles.xml", StylesXml));
            for (int i = 0; i < _sheets.Count; i++)
                entries.Add(new KeyValuePair<string, string>("xl/worksheets/sheet" + (i + 1) + ".xml", _sheets[i].BuildXml(i == 0)));

            // Write to a temp file first so a failure halfway through never leaves a
            // corrupt or half-written .xlsx at the destination (or destroys an old one).
            string tempPath = path + ".tmp";
            try
            {
                SimpleZip.Write(tempPath, entries);
                if (File.Exists(path)) File.Delete(path);
                File.Move(tempPath, path);
            }
            catch
            {
                try { if (File.Exists(tempPath)) File.Delete(tempPath); } catch { }
                throw; // callers show the error; nothing is swallowed here
            }
        }

        private string BuildContentTypes()
        {
            var sb = new StringBuilder();
            sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>\r\n");
            sb.Append("<Types xmlns=\"http://schemas.openxmlformats.org/package/2006/content-types\">");
            sb.Append("<Default Extension=\"rels\" ContentType=\"application/vnd.openxmlformats-package.relationships+xml\"/>");
            sb.Append("<Default Extension=\"xml\" ContentType=\"application/xml\"/>");
            sb.Append("<Override PartName=\"/xl/workbook.xml\" ContentType=\"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml\"/>");
            for (int i = 1; i <= _sheets.Count; i++)
                sb.Append("<Override PartName=\"/xl/worksheets/sheet").Append(i)
                  .Append(".xml\" ContentType=\"application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml\"/>");
            sb.Append("<Override PartName=\"/xl/styles.xml\" ContentType=\"application/vnd.openxmlformats-officedocument.spreadsheetml.styles+xml\"/>");
            sb.Append("</Types>");
            return sb.ToString();
        }

        private string BuildWorkbookXml()
        {
            var sb = new StringBuilder();
            sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>\r\n");
            sb.Append("<workbook xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\" ");
            sb.Append("xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\">");
            sb.Append("<bookViews><workbookView/></bookViews><sheets>");
            for (int i = 0; i < _sheets.Count; i++)
                sb.Append("<sheet name=\"").Append(XlsxSheet.Esc(_sheets[i].Name))
                  .Append("\" sheetId=\"").Append(i + 1)
                  .Append("\" r:id=\"rId").Append(i + 1).Append("\"/>");
            sb.Append("</sheets></workbook>");
            return sb.ToString();
        }

        private string BuildWorkbookRels()
        {
            var sb = new StringBuilder();
            sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>\r\n");
            sb.Append("<Relationships xmlns=\"http://schemas.openxmlformats.org/package/2006/relationships\">");
            for (int i = 1; i <= _sheets.Count; i++)
                sb.Append("<Relationship Id=\"rId").Append(i)
                  .Append("\" Type=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet\" Target=\"worksheets/sheet")
                  .Append(i).Append(".xml\"/>");
            sb.Append("<Relationship Id=\"rId").Append(_sheets.Count + 1)
              .Append("\" Type=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles\" Target=\"styles.xml\"/>");
            sb.Append("</Relationships>");
            return sb.ToString();
        }

        private const string RootRels = @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
<Relationships xmlns=""http://schemas.openxmlformats.org/package/2006/relationships""><Relationship Id=""rId1"" Type=""http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument"" Target=""xl/workbook.xml""/></Relationships>";

        // The order of <xf> entries in <cellXfs> must match the St* constants in XlsxSheet.
        private const string StylesXml = @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
<styleSheet xmlns=""http://schemas.openxmlformats.org/spreadsheetml/2006/main"">
<numFmts count=""3""><numFmt numFmtId=""164"" formatCode=""&quot;₱&quot;#,##0.00""/><numFmt numFmtId=""165"" formatCode=""yyyy-mm-dd hh:mm""/><numFmt numFmtId=""166"" formatCode=""yyyy-mm-dd""/></numFmts>
<fonts count=""8"">
<font><sz val=""11""/><color rgb=""FF1F2937""/><name val=""Calibri""/><family val=""2""/></font>
<font><b/><sz val=""18""/><color rgb=""FFFFFFFF""/><name val=""Calibri""/><family val=""2""/></font>
<font><i/><sz val=""10""/><color rgb=""FF6B7280""/><name val=""Calibri""/><family val=""2""/></font>
<font><b/><sz val=""11""/><color rgb=""FFFFFFFF""/><name val=""Calibri""/><family val=""2""/></font>
<font><b/><sz val=""11""/><color rgb=""FF1F3A5F""/><name val=""Calibri""/><family val=""2""/></font>
<font><b/><sz val=""13""/><color rgb=""FF1F3A5F""/><name val=""Calibri""/><family val=""2""/></font>
<font><b/><sz val=""11""/><color rgb=""FF991B1B""/><name val=""Calibri""/><family val=""2""/></font>
<font><b/><sz val=""11""/><color rgb=""FF92400E""/><name val=""Calibri""/><family val=""2""/></font>
</fonts>
<fills count=""8"">
<fill><patternFill patternType=""none""/></fill>
<fill><patternFill patternType=""gray125""/></fill>
<fill><patternFill patternType=""solid""><fgColor rgb=""FF1F3A5F""/><bgColor indexed=""64""/></patternFill></fill>
<fill><patternFill patternType=""solid""><fgColor rgb=""FF2F5597""/><bgColor indexed=""64""/></patternFill></fill>
<fill><patternFill patternType=""solid""><fgColor rgb=""FFF3F4F6""/><bgColor indexed=""64""/></patternFill></fill>
<fill><patternFill patternType=""solid""><fgColor rgb=""FFE5E7EB""/><bgColor indexed=""64""/></patternFill></fill>
<fill><patternFill patternType=""solid""><fgColor rgb=""FFFEE2E2""/><bgColor indexed=""64""/></patternFill></fill>
<fill><patternFill patternType=""solid""><fgColor rgb=""FFFEF3C7""/><bgColor indexed=""64""/></patternFill></fill>
</fills>
<borders count=""3"">
<border><left/><right/><top/><bottom/><diagonal/></border>
<border><left style=""thin""><color rgb=""FFD1D5DB""/></left><right style=""thin""><color rgb=""FFD1D5DB""/></right><top style=""thin""><color rgb=""FFD1D5DB""/></top><bottom style=""thin""><color rgb=""FFD1D5DB""/></bottom><diagonal/></border>
<border><left style=""thin""><color rgb=""FFD1D5DB""/></left><right style=""thin""><color rgb=""FFD1D5DB""/></right><top style=""medium""><color rgb=""FF1F3A5F""/></top><bottom style=""thin""><color rgb=""FFD1D5DB""/></bottom><diagonal/></border>
</borders>
<cellStyleXfs count=""1""><xf numFmtId=""0"" fontId=""0"" fillId=""0"" borderId=""0""/></cellStyleXfs>
<cellXfs count=""23"">
<xf numFmtId=""0"" fontId=""0"" fillId=""0"" borderId=""0"" xfId=""0""/>
<xf numFmtId=""0"" fontId=""1"" fillId=""2"" borderId=""0"" xfId=""0"" applyFont=""1"" applyFill=""1"" applyAlignment=""1""><alignment horizontal=""left"" vertical=""center"" indent=""1""/></xf>
<xf numFmtId=""0"" fontId=""2"" fillId=""0"" borderId=""0"" xfId=""0"" applyFont=""1"" applyAlignment=""1""><alignment horizontal=""left"" vertical=""center""/></xf>
<xf numFmtId=""0"" fontId=""3"" fillId=""3"" borderId=""1"" xfId=""0"" applyFont=""1"" applyFill=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""center"" vertical=""center"" wrapText=""1""/></xf>
<xf numFmtId=""0"" fontId=""0"" fillId=""0"" borderId=""1"" xfId=""0"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""left"" vertical=""center"" wrapText=""1""/></xf>
<xf numFmtId=""3"" fontId=""0"" fillId=""0"" borderId=""1"" xfId=""0"" applyNumberFormat=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""right"" vertical=""center""/></xf>
<xf numFmtId=""164"" fontId=""0"" fillId=""0"" borderId=""1"" xfId=""0"" applyNumberFormat=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""right"" vertical=""center""/></xf>
<xf numFmtId=""165"" fontId=""0"" fillId=""0"" borderId=""1"" xfId=""0"" applyNumberFormat=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""left"" vertical=""center""/></xf>
<xf numFmtId=""0"" fontId=""0"" fillId=""4"" borderId=""1"" xfId=""0"" applyFill=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""left"" vertical=""center"" wrapText=""1""/></xf>
<xf numFmtId=""3"" fontId=""0"" fillId=""4"" borderId=""1"" xfId=""0"" applyNumberFormat=""1"" applyFill=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""right"" vertical=""center""/></xf>
<xf numFmtId=""164"" fontId=""0"" fillId=""4"" borderId=""1"" xfId=""0"" applyNumberFormat=""1"" applyFill=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""right"" vertical=""center""/></xf>
<xf numFmtId=""165"" fontId=""0"" fillId=""4"" borderId=""1"" xfId=""0"" applyNumberFormat=""1"" applyFill=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""left"" vertical=""center""/></xf>
<xf numFmtId=""0"" fontId=""4"" fillId=""4"" borderId=""1"" xfId=""0"" applyFont=""1"" applyFill=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""left"" vertical=""center""/></xf>
<xf numFmtId=""3"" fontId=""5"" fillId=""0"" borderId=""1"" xfId=""0"" applyNumberFormat=""1"" applyFont=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""left"" vertical=""center""/></xf>
<xf numFmtId=""164"" fontId=""5"" fillId=""0"" borderId=""1"" xfId=""0"" applyNumberFormat=""1"" applyFont=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""left"" vertical=""center""/></xf>
<xf numFmtId=""0"" fontId=""5"" fillId=""0"" borderId=""1"" xfId=""0"" applyFont=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""left"" vertical=""center""/></xf>
<xf numFmtId=""0"" fontId=""4"" fillId=""5"" borderId=""2"" xfId=""0"" applyFont=""1"" applyFill=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""left"" vertical=""center""/></xf>
<xf numFmtId=""3"" fontId=""4"" fillId=""5"" borderId=""2"" xfId=""0"" applyNumberFormat=""1"" applyFont=""1"" applyFill=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""right"" vertical=""center""/></xf>
<xf numFmtId=""164"" fontId=""4"" fillId=""5"" borderId=""2"" xfId=""0"" applyNumberFormat=""1"" applyFont=""1"" applyFill=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""right"" vertical=""center""/></xf>
<xf numFmtId=""166"" fontId=""0"" fillId=""0"" borderId=""1"" xfId=""0"" applyNumberFormat=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""left"" vertical=""center""/></xf>
<xf numFmtId=""166"" fontId=""0"" fillId=""4"" borderId=""1"" xfId=""0"" applyNumberFormat=""1"" applyFill=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""left"" vertical=""center""/></xf>
<xf numFmtId=""0"" fontId=""6"" fillId=""6"" borderId=""1"" xfId=""0"" applyFont=""1"" applyFill=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""center"" vertical=""center""/></xf>
<xf numFmtId=""0"" fontId=""7"" fillId=""7"" borderId=""1"" xfId=""0"" applyFont=""1"" applyFill=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""center"" vertical=""center""/></xf>
</cellXfs>
<cellStyles count=""1""><cellStyle name=""Normal"" xfId=""0"" builtinId=""0""/></cellStyles>
</styleSheet>";
    }

    /// <summary>
    /// Minimal zip writer (deflate-compressed entries). DeflateStream lives in
    /// System.dll, so this needs no extra assembly reference.
    /// </summary>
    internal static class SimpleZip
    {
        private static uint[] _crcTable;

        public static void Write(string path, List<KeyValuePair<string, string>> entries)
        {
            var utf8 = new UTF8Encoding(false);
            DateTime now = DateTime.Now;
            ushort dosTime = (ushort)((now.Hour << 11) | (now.Minute << 5) | (now.Second / 2));
            ushort dosDate = (ushort)(((now.Year - 1980) << 9) | (now.Month << 5) | now.Day);

            var names = new List<byte[]>();
            var crcs = new List<uint>();
            var packedSizes = new List<uint>();
            var rawSizes = new List<uint>();
            var offsets = new List<uint>();

            using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            using (var w = new BinaryWriter(fs))
            {
                // Local file headers + data
                foreach (KeyValuePair<string, string> entry in entries)
                {
                    byte[] name = utf8.GetBytes(entry.Key);
                    byte[] raw = utf8.GetBytes(entry.Value);
                    byte[] packed = Deflate(raw);
                    uint crc = Crc32(raw);

                    names.Add(name);
                    crcs.Add(crc);
                    packedSizes.Add((uint)packed.Length);
                    rawSizes.Add((uint)raw.Length);
                    offsets.Add((uint)fs.Position);

                    w.Write(0x04034B50u);            // local file header signature
                    w.Write((ushort)20);             // version needed
                    w.Write((ushort)0);              // flags
                    w.Write((ushort)8);              // method: deflate
                    w.Write(dosTime);
                    w.Write(dosDate);
                    w.Write(crc);
                    w.Write((uint)packed.Length);
                    w.Write((uint)raw.Length);
                    w.Write((ushort)name.Length);
                    w.Write((ushort)0);              // extra length
                    w.Write(name);
                    w.Write(packed);
                }

                // Central directory
                uint centralStart = (uint)fs.Position;
                for (int i = 0; i < names.Count; i++)
                {
                    w.Write(0x02014B50u);            // central directory signature
                    w.Write((ushort)20);             // version made by
                    w.Write((ushort)20);             // version needed
                    w.Write((ushort)0);              // flags
                    w.Write((ushort)8);              // method: deflate
                    w.Write(dosTime);
                    w.Write(dosDate);
                    w.Write(crcs[i]);
                    w.Write(packedSizes[i]);
                    w.Write(rawSizes[i]);
                    w.Write((ushort)names[i].Length);
                    w.Write((ushort)0);              // extra length
                    w.Write((ushort)0);              // comment length
                    w.Write((ushort)0);              // disk number
                    w.Write((ushort)0);              // internal attributes
                    w.Write(0u);                     // external attributes
                    w.Write(offsets[i]);
                    w.Write(names[i]);
                }
                uint centralSize = (uint)fs.Position - centralStart;

                // End of central directory
                w.Write(0x06054B50u);
                w.Write((ushort)0);                  // this disk
                w.Write((ushort)0);                  // disk with central directory
                w.Write((ushort)names.Count);
                w.Write((ushort)names.Count);
                w.Write(centralSize);
                w.Write(centralStart);
                w.Write((ushort)0);                  // comment length
            }
        }

        private static byte[] Deflate(byte[] raw)
        {
            using (var ms = new MemoryStream())
            {
                using (var ds = new DeflateStream(ms, CompressionMode.Compress, true))
                    ds.Write(raw, 0, raw.Length);
                return ms.ToArray();
            }
        }

        private static uint Crc32(byte[] data)
        {
            if (_crcTable == null)
            {
                var table = new uint[256];
                for (uint i = 0; i < 256; i++)
                {
                    uint c = i;
                    for (int k = 0; k < 8; k++)
                        c = (c & 1) != 0 ? 0xEDB88320u ^ (c >> 1) : c >> 1;
                    table[i] = c;
                }
                _crcTable = table;
            }

            uint crc = 0xFFFFFFFFu;
            foreach (byte b in data)
                crc = _crcTable[(crc ^ b) & 0xFF] ^ (crc >> 8);
            return crc ^ 0xFFFFFFFFu;
        }
    }

    internal sealed class XlsxSheet
    {
        // Indexes into <cellXfs> in XlsxWorkbook.StylesXml.
        private const int StTitle = 1;
        private const int StSubtitle = 2;
        private const int StHeader = 3;
        private const int StBodyText = 4;     // + ZebraOffset for the shaded variant
        private const int StBodyInt = 5;
        private const int StBodyMoney = 6;
        private const int StBodyDate = 7;
        private const int ZebraOffset = 4;
        private const int StKpiLabel = 12;
        private const int StKpiInt = 13;
        private const int StKpiMoney = 14;
        private const int StKpiText = 15;
        private const int StTotalText = 16;
        private const int StTotalInt = 17;
        private const int StTotalMoney = 18;
        private const int StBodyDateOnly = 19;
        private const int StBodyDateOnlyZebra = 20;
        private const int StStatusBad = 21;
        private const int StStatusWarn = 22;

        private sealed class Cell
        {
            public int Col;
            public object Value;
            public int Style;
            public bool SkipWidth;
        }

        private readonly List<List<Cell>> _rows = new List<List<Cell>>();
        private readonly Dictionary<int, double> _heights = new Dictionary<int, double>();
        private readonly List<string> _merges = new List<string>();
        private string _filterRef;
        private int _freezeRows;
        private int _maxCols;

        public string Name { get; private set; }

        public XlsxSheet(string name)
        {
            Name = CleanName(name);
        }

        // ------------------------------------------------------------------
        // Layout API
        // ------------------------------------------------------------------

        /// <summary>Big white-on-navy banner merged across colSpan columns.</summary>
        public void Title(string text, int colSpan)
        {
            if (colSpan < 1) colSpan = 1;
            var row = AddRow();
            int r = _rows.Count;
            for (int c = 1; c <= colSpan; c++)
                row.Add(new Cell { Col = c, Value = c == 1 ? text : null, Style = StTitle, SkipWidth = true });
            if (colSpan > 1) _merges.Add("A" + r + ":" + ColName(colSpan) + r);
            _heights[r] = 34;
            Track(colSpan);
        }

        /// <summary>Small grey italic line (period, generated time ...).</summary>
        public void Subtitle(string text)
        {
            var row = AddRow();
            row.Add(new Cell { Col = 1, Value = text, Style = StSubtitle, SkipWidth = true });
            Track(1);
        }

        public void Blank()
        {
            AddRow();
        }

        /// <summary>A "label | value" summary line (label shaded, value large and bold).</summary>
        public void KeyValue(string label, object value, XlsxKind kind)
        {
            var row = AddRow();
            row.Add(new Cell { Col = 1, Value = label, Style = StKpiLabel });
            int style = kind == XlsxKind.Integer ? StKpiInt
                      : kind == XlsxKind.Money ? StKpiMoney
                      : StKpiText;
            row.Add(new Cell { Col = 2, Value = value, Style = style });
            Track(2);
        }

        /// <summary>
        /// A formatted table: coloured header, striped rows, optional total row.
        /// sumColumns = zero-based columns to total (never column 0, it holds the "Total" label).
        /// filterAndFreeze adds Excel filter buttons and freezes the header row.
        /// </summary>
        public void Table(string[] headers, List<object[]> rows, XlsxKind[] kinds, int[] sumColumns, bool filterAndFreeze)
        {
            int cols = headers.Length;
            int headerRow = _rows.Count + 1;

            var hr = AddRow();
            for (int c = 0; c < cols; c++)
                hr.Add(new Cell { Col = c + 1, Value = headers[c], Style = StHeader });
            _heights[headerRow] = 26;
            Track(cols);

            if (rows == null || rows.Count == 0)
            {
                var empty = AddRow();
                empty.Add(new Cell { Col = 1, Value = "No records to show.", Style = StSubtitle, SkipWidth = true });
                return;
            }

            int index = 0;
            foreach (object[] data in rows)
            {
                var row = AddRow();
                bool zebra = (index++ % 2) == 1;
                for (int c = 0; c < cols; c++)
                {
                    object v = c < data.Length ? data[c] : null;
                    int style = kinds[c] == XlsxKind.Status ? StatusStyle(v) : BodyStyle(kinds[c], zebra);
                    row.Add(new Cell { Col = c + 1, Value = v, Style = style });
                }
            }
            int lastDataRow = _rows.Count;

            if (sumColumns != null && sumColumns.Length > 0)
            {
                var total = AddRow();
                for (int c = 0; c < cols; c++)
                {
                    if (c == 0)
                    {
                        total.Add(new Cell { Col = 1, Value = "Total", Style = StTotalText });
                    }
                    else if (Array.IndexOf(sumColumns, c) >= 0)
                    {
                        decimal sum = 0m;
                        foreach (object[] data in rows)
                            if (c < data.Length && IsNumber(data[c]))
                                sum += Convert.ToDecimal(data[c], CultureInfo.InvariantCulture);
                        total.Add(new Cell { Col = c + 1, Value = sum, Style = TotalStyle(kinds[c]) });
                    }
                    else
                    {
                        total.Add(new Cell { Col = c + 1, Value = null, Style = StTotalText });
                    }
                }
            }

            if (filterAndFreeze)
            {
                _filterRef = "A" + headerRow + ":" + ColName(cols) + lastDataRow;
                _freezeRows = headerRow;
            }
        }

        // ------------------------------------------------------------------
        // XML output
        // ------------------------------------------------------------------

        internal string BuildXml(bool selected)
        {
            var sb = new StringBuilder();
            sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>\r\n");
            sb.Append("<worksheet xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\" ");
            sb.Append("xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\">");
            sb.Append("<sheetPr><pageSetUpPr fitToPage=\"1\"/></sheetPr>");

            if (_rows.Count > 0 && _maxCols > 0)
                sb.Append("<dimension ref=\"A1:").Append(ColName(_maxCols)).Append(_rows.Count).Append("\"/>");

            sb.Append("<sheetViews><sheetView showGridLines=\"0\"");
            if (selected) sb.Append(" tabSelected=\"1\"");
            sb.Append(" workbookViewId=\"0\">");
            if (_freezeRows > 0)
            {
                int top = _freezeRows + 1;
                sb.Append("<pane ySplit=\"").Append(_freezeRows).Append("\" topLeftCell=\"A").Append(top)
                  .Append("\" activePane=\"bottomLeft\" state=\"frozen\"/>");
                sb.Append("<selection pane=\"bottomLeft\" activeCell=\"A").Append(top)
                  .Append("\" sqref=\"A").Append(top).Append("\"/>");
            }
            sb.Append("</sheetView></sheetViews>");
            sb.Append("<sheetFormatPr defaultRowHeight=\"15\"/>");

            // Column widths sized to the content.
            double[] widths = MeasureColumns();
            if (_maxCols > 0)
            {
                sb.Append("<cols>");
                for (int c = 1; c <= _maxCols; c++)
                    sb.Append("<col min=\"").Append(c).Append("\" max=\"").Append(c)
                      .Append("\" width=\"").Append(widths[c].ToString("0.##", CultureInfo.InvariantCulture))
                      .Append("\" customWidth=\"1\"/>");
                sb.Append("</cols>");
            }

            sb.Append("<sheetData>");
            for (int i = 0; i < _rows.Count; i++)
            {
                int r = i + 1;
                sb.Append("<row r=\"").Append(r).Append('"');
                double h;
                if (_heights.TryGetValue(r, out h))
                    sb.Append(" ht=\"").Append(h.ToString(CultureInfo.InvariantCulture)).Append("\" customHeight=\"1\"");

                List<Cell> cells = _rows[i];
                if (cells.Count == 0)
                {
                    sb.Append("/>");
                    continue;
                }
                sb.Append('>');
                foreach (Cell cell in cells) AppendCell(sb, r, cell);
                sb.Append("</row>");
            }
            sb.Append("</sheetData>");

            if (_filterRef != null)
                sb.Append("<autoFilter ref=\"").Append(_filterRef).Append("\"/>");

            if (_merges.Count > 0)
            {
                sb.Append("<mergeCells count=\"").Append(_merges.Count).Append("\">");
                foreach (string m in _merges) sb.Append("<mergeCell ref=\"").Append(m).Append("\"/>");
                sb.Append("</mergeCells>");
            }

            sb.Append("<pageMargins left=\"0.5\" right=\"0.5\" top=\"0.6\" bottom=\"0.6\" header=\"0.3\" footer=\"0.3\"/>");
            sb.Append("<pageSetup orientation=\"landscape\" fitToWidth=\"1\" fitToHeight=\"0\"/>");

            if (_rows.Count > 0 && _maxCols > 0)
                sb.Append("<ignoredErrors><ignoredError sqref=\"A1:").Append(ColName(_maxCols)).Append(_rows.Count)
                  .Append("\" numberStoredAsText=\"1\"/></ignoredErrors>");

            sb.Append("</worksheet>");
            return sb.ToString();
        }

        private static void AppendCell(StringBuilder sb, int row, Cell cell)
        {
            string reference = ColName(cell.Col) + row;
            object v = cell.Value;

            if (v == null)
            {
                sb.Append("<c r=\"").Append(reference).Append("\" s=\"").Append(cell.Style).Append("\"/>");
                return;
            }

            if (v is DateTime)
            {
                sb.Append("<c r=\"").Append(reference).Append("\" s=\"").Append(cell.Style).Append("\"><v>")
                  .Append(((DateTime)v).ToOADate().ToString("R", CultureInfo.InvariantCulture)).Append("</v></c>");
            }
            else if (IsNumber(v))
            {
                sb.Append("<c r=\"").Append(reference).Append("\" s=\"").Append(cell.Style).Append("\"><v>")
                  .Append(Convert.ToString(v, CultureInfo.InvariantCulture)).Append("</v></c>");
            }
            else
            {
                string text = v as string ?? v.ToString();
                sb.Append("<c r=\"").Append(reference).Append("\" s=\"").Append(cell.Style)
                  .Append("\" t=\"inlineStr\"><is><t xml:space=\"preserve\">").Append(Esc(text)).Append("</t></is></c>");
            }
        }

        // ------------------------------------------------------------------
        // Helpers
        // ------------------------------------------------------------------

        private List<Cell> AddRow()
        {
            var row = new List<Cell>();
            _rows.Add(row);
            return row;
        }

        private void Track(int cols)
        {
            if (cols > _maxCols) _maxCols = cols;
        }

        private static int StatusStyle(object v)
        {
            return string.Equals(v as string, "Expired", StringComparison.OrdinalIgnoreCase) ? StStatusBad : StStatusWarn;
        }

        private static int BodyStyle(XlsxKind kind, bool zebra)
        {
            if (kind == XlsxKind.Date) return zebra ? StBodyDateOnlyZebra : StBodyDateOnly;
            if (kind == XlsxKind.Status) return zebra ? StBodyText + ZebraOffset : StBodyText;

            int style = kind == XlsxKind.Integer ? StBodyInt
                      : kind == XlsxKind.Money ? StBodyMoney
                      : kind == XlsxKind.DateTime ? StBodyDate
                      : StBodyText;
            return zebra ? style + ZebraOffset : style;
        }

        private static int TotalStyle(XlsxKind kind)
        {
            return kind == XlsxKind.Integer ? StTotalInt
                 : kind == XlsxKind.Money ? StTotalMoney
                 : StTotalText;
        }

        private static bool IsNumber(object v)
        {
            return v is int || v is long || v is short || v is byte
                || v is decimal || v is double || v is float;
        }

        // Width (in Excel character units) wide enough for the longest value in each column.
        private double[] MeasureColumns()
        {
            var widths = new double[_maxCols + 1];
            foreach (List<Cell> row in _rows)
            {
                foreach (Cell cell in row)
                {
                    if (cell.SkipWidth || cell.Value == null) continue;

                    double len;
                    object v = cell.Value;
                    if (v is DateTime) len = (cell.Style == StBodyDateOnly || cell.Style == StBodyDateOnlyZebra) ? 10 : 16;
                    else if (v is decimal || v is double || v is float)
                        len = Convert.ToDecimal(v, CultureInfo.InvariantCulture).ToString("#,##0.00", CultureInfo.InvariantCulture).Length + 2;
                    else if (IsNumber(v)) len = Convert.ToString(v, CultureInfo.InvariantCulture).Length;
                    else len = LongestLine(v.ToString());

                    if (cell.Style == StHeader) len += 4;                       // room for the filter button
                    else if (cell.Style >= StKpiInt && cell.Style <= StKpiText) len *= 1.2;   // larger KPI font
                    else len += 2;

                    if (len > widths[cell.Col]) widths[cell.Col] = len;
                }
            }
            for (int c = 1; c <= _maxCols; c++)
                widths[c] = Math.Min(60, Math.Max(10, widths[c]));
            return widths;
        }

        private static int LongestLine(string s)
        {
            int best = 0;
            foreach (string line in s.Split('\n'))
                if (line.Length > best) best = line.Length;
            return best;
        }

        internal static string ColName(int n)
        {
            string s = "";
            while (n > 0)
            {
                n--;
                s = (char)('A' + n % 26) + s;
                n /= 26;
            }
            return s;
        }

        // Escapes text for XML and drops characters XML can't contain.
        internal static string Esc(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            var sb = new StringBuilder(s.Length + 8);
            foreach (char ch in s)
            {
                if (ch < 0x20 && ch != '\t' && ch != '\n' && ch != '\r') continue;
                if (ch == '\uFFFE' || ch == '\uFFFF') continue;
                switch (ch)
                {
                    case '&': sb.Append("&amp;"); break;
                    case '<': sb.Append("&lt;"); break;
                    case '>': sb.Append("&gt;"); break;
                    case '"': sb.Append("&quot;"); break;
                    default: sb.Append(ch); break;
                }
            }
            return sb.ToString();
        }

        // Excel sheet names: max 31 chars, none of  [ ] : * ? / \
        private static string CleanName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) name = "Sheet";
            foreach (char bad in new[] { '[', ']', ':', '*', '?', '/', '\\' })
                name = name.Replace(bad, ' ');
            name = name.Trim();
            if (name.Length > 31) name = name.Substring(0, 31);
            return name.Length == 0 ? "Sheet" : name;
        }
    }
}