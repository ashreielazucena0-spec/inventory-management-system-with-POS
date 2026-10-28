using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{
    // ------------------------------------------------------------------
    // Small hand-drawn icon set so the UI doesn't depend on any image
    // assets or icon fonts that may not be installed on the machine.
    // Each icon is drawn on a 24x24 design grid and scaled to fit
    // whatever rectangle it's given.
    // ------------------------------------------------------------------
    public enum IconKind
    {
        Clipboard, Calendar, Clock, Tag, Search, Refresh, Download, Print, DocumentAlert
    }

    public static class Icons
    {
        public static void Draw(Graphics g, Rectangle bounds, IconKind kind, Color color, float strokeWidth = 1.6f)
        {
            var oldMode = g.SmoothingMode;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            float scale = Math.Min(bounds.Width, bounds.Height) / 24f;
            if (scale <= 0) { g.SmoothingMode = oldMode; return; }

            var state = g.Save();
            g.TranslateTransform(bounds.X + (bounds.Width - 24 * scale) / 2f, bounds.Y + (bounds.Height - 24 * scale) / 2f);
            g.ScaleTransform(scale, scale);

            using (var pen = new Pen(color, strokeWidth / scale) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round })
            using (var brush = new SolidBrush(color))
            {
                switch (kind)
                {
                    case IconKind.Clipboard: DrawClipboard(g, pen, brush); break;
                    case IconKind.Calendar: DrawCalendar(g, pen, brush); break;
                    case IconKind.Clock: DrawClock(g, pen); break;
                    case IconKind.Tag: DrawTag(g, pen, brush); break;
                    case IconKind.Search: DrawSearch(g, pen); break;
                    case IconKind.Refresh: DrawRefresh(g, pen, brush); break;
                    case IconKind.Download: DrawDownload(g, pen); break;
                    case IconKind.Print: DrawPrint(g, pen); break;
                    case IconKind.DocumentAlert: DrawDocumentAlert(g, pen, brush); break;
                }
            }

            g.Restore(state);
            g.SmoothingMode = oldMode;
        }

        private static void DrawClipboard(Graphics g, Pen pen, Brush brush)
        {
            using (var body = RoundedPanel.RoundedPath(new RectangleF(4, 3, 16, 19), 2))
                g.DrawPath(pen, body);
            using (var clip = RoundedPanel.RoundedPath(new RectangleF(8.5f, 1.5f, 7, 3.5f), 1.2f))
                g.FillPath(brush, clip);
            g.DrawLine(pen, 7.5f, 9.5f, 16.5f, 9.5f);
            g.DrawLine(pen, 7.5f, 13f, 16.5f, 13f);
            g.DrawLine(pen, 7.5f, 16.5f, 13.5f, 16.5f);
        }

        private static void DrawCalendar(Graphics g, Pen pen, Brush brush)
        {
            using (var body = RoundedPanel.RoundedPath(new RectangleF(3, 4.5f, 18, 16), 2.2f))
                g.DrawPath(pen, body);
            g.DrawLine(pen, 3, 9.5f, 21, 9.5f);
            g.DrawLine(pen, 7.5f, 2, 7.5f, 6.5f);
            g.DrawLine(pen, 16.5f, 2, 16.5f, 6.5f);
            g.FillEllipse(brush, 15.2f, 13.2f, 5.6f, 5.6f);
        }

        private static void DrawClock(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, 3, 3, 18, 18);
            g.DrawLine(pen, 12, 12, 12, 6.5f);
            g.DrawLine(pen, 12, 12, 16.5f, 13.5f);
        }

        private static void DrawTag(Graphics g, Pen pen, Brush brush)
        {
            var pts = new[]
            {
                new PointF(4, 4), new PointF(13, 4), new PointF(20, 11),
                new PointF(11, 20), new PointF(4, 13)
            };
            using (var path = new GraphicsPath())
            {
                path.AddPolygon(pts);
                g.DrawPath(pen, path);
            }
            g.FillEllipse(brush, 8, 8, 3, 3);
        }

        private static void DrawSearch(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, 3.5f, 3.5f, 11, 11);
            g.DrawLine(pen, 13, 13, 20.5f, 20.5f);
        }

        private static void DrawRefresh(Graphics g, Pen pen, Brush brush)
        {
            g.DrawArc(pen, 4, 4, 16, 16, -30, 270);
            var head = new[] { new PointF(19.5f, 4.5f), new PointF(20.5f, 9.5f), new PointF(15.5f, 8f) };
            g.FillPolygon(brush, head);
        }

        private static void DrawDownload(Graphics g, Pen pen)
        {
            g.DrawLine(pen, 12, 3, 12, 15);
            g.DrawLine(pen, 7, 10, 12, 15);
            g.DrawLine(pen, 17, 10, 12, 15);
            g.DrawLine(pen, 4.5f, 20, 19.5f, 20);
        }

        private static void DrawPrint(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, 5, 8, 14, 8);
            g.DrawLine(pen, 7, 8, 7, 3);
            g.DrawLine(pen, 17, 8, 17, 3);
            g.DrawLine(pen, 7, 3, 17, 3);
            g.DrawRectangle(pen, 8, 14, 8, 6);
        }

        private static void DrawDocumentAlert(Graphics g, Pen pen, Brush brush)
        {
            var pts = new[]
            {
                new PointF(5, 2), new PointF(14, 2), new PointF(19, 7),
                new PointF(19, 22), new PointF(5, 22)
            };
            using (var path = new GraphicsPath())
            {
                path.AddPolygon(pts);
                g.DrawPath(pen, path);
            }
            g.DrawLines(pen, new[] { new PointF(14, 2), new PointF(14, 7), new PointF(19, 7) });
            g.DrawLine(pen, 8, 11, 15, 11);
            g.DrawLine(pen, 8, 14.5f, 13, 14.5f);
            g.FillEllipse(brush, 13.5f, 15.5f, 8, 8);
            using (var whitePen = new Pen(Color.White, 1.6f) { StartCap = LineCap.Round, EndCap = LineCap.Round })
            {
                g.DrawLine(whitePen, 17.5f, 17.7f, 17.5f, 20.3f);
                g.DrawEllipse(whitePen, 17.15f, 21.3f, 0.7f, 0.7f);
            }
        }
    }

    // ------------------------------------------------------------------
    // A borderless icon that draws directly on its (assumed solid-color)
    // parent — used for the footer icon, the empty-state graphic, etc.
    // ------------------------------------------------------------------
    public class IconGlyph : Control
    {
        public IconKind Icon { get; set; } = IconKind.Calendar;
        public Color IconColor { get; set; } = Color.Gray;
        public float StrokeWidth { get; set; } = 1.6f;

        public IconGlyph()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (Parent != null) e.Graphics.Clear(Parent.BackColor);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Icons.Draw(e.Graphics, new Rectangle(0, 0, Width, Height), Icon, IconColor, StrokeWidth);
        }
    }

    // ------------------------------------------------------------------
    // A panel with rounded corners. Paints its own background and clears
    // whatever sits outside the rounded rect using the parent's color,
    // so it blends in instead of showing square corners.
    // ------------------------------------------------------------------
    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 10;
        public Color BorderColor { get; set; } = Color.Transparent;
        public int BorderThickness { get; set; } = 1;

        public RoundedPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.Clear(Parent?.BackColor ?? Color.White);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = new RectangleF(0.5f, 0.5f, Width - 1, Height - 1);
            using (var path = RoundedPath(rect, CornerRadius))
            using (var brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(brush, path);
                if (BorderColor != Color.Transparent && BorderThickness > 0)
                    using (var pen = new Pen(BorderColor, BorderThickness))
                        e.Graphics.DrawPath(pen, path);
            }
        }

        internal static GraphicsPath RoundedPath(RectangleF r, float radius)
        {
            return Styles.RoundedPath(r, radius);   // one shared implementation
        }
    }

    // ------------------------------------------------------------------
    // A colored circular (or rounded-square, via CornerRadius) badge
    // with a centered icon. Used for the summary-card icons and the
    // header logo mark.
    // ------------------------------------------------------------------
    public class IconBadge : Panel
    {
        public IconKind Icon { get; set; } = IconKind.Calendar;
        public Color IconColor { get; set; } = Color.White;
        public Color CircleColor { get; set; } = Color.SteelBlue;
        /// <summary>0 = circle. Greater than 0 = rounded square with this corner radius.</summary>
        public int CornerRadius { get; set; } = 0;

        public IconBadge()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.Clear(Parent?.BackColor ?? Color.White);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var brush = new SolidBrush(CircleColor))
            {
                if (CornerRadius <= 0)
                {
                    e.Graphics.FillEllipse(brush, 0, 0, Width - 1, Height - 1);
                }
                else
                {
                    using (var path = RoundedPanel.RoundedPath(new RectangleF(0, 0, Width - 1, Height - 1), CornerRadius))
                        e.Graphics.FillPath(brush, path);
                }
            }

            int inset = Math.Max(2, Width / 4);
            var iconRect = new Rectangle(inset, inset, Width - inset * 2, Height - inset * 2);
            Icons.Draw(e.Graphics, iconRect, Icon, IconColor, 1.8f);
        }
    }

    // ------------------------------------------------------------------
    // A flat, rounded, icon-capable button with a hover fill.
    // ------------------------------------------------------------------
    public class IconButton : Button
    {
        public IconKind? Icon { get; set; }
        public Color IconColor { get; set; } = Color.White;
        public int CornerRadius { get; set; } = 8;
        public Color HoverBackColor { get; set; } = Color.Empty;

        private bool _hover;

        public IconButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            MouseEnter += (s, e) => { _hover = true; Invalidate(); };
            MouseLeave += (s, e) => { _hover = false; Invalidate(); };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = new RectangleF(0, 0, Width - 1, Height - 1);
            var fill = (_hover && HoverBackColor != Color.Empty) ? HoverBackColor : BackColor;

            using (var path = RoundedPanel.RoundedPath(rect, CornerRadius))
            using (var brush = new SolidBrush(fill))
                e.Graphics.FillPath(brush, path);

            int textX = 14;
            if (Icon.HasValue)
            {
                var iconRect = new Rectangle(12, (Height - 16) / 2, 16, 16);
                Icons.Draw(e.Graphics, iconRect, Icon.Value, IconColor, 1.6f);
                textX = 34;
            }

            TextRenderer.DrawText(e.Graphics, Text, Font,
                new Rectangle(textX, 0, Math.Max(0, Width - textX - 8), Height),
                ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPadding);
        }
    }

    // ------------------------------------------------------------------
    // A rounded search field: magnifier icon + borderless TextBox.
    // ------------------------------------------------------------------
    public class SearchBox : RoundedPanel
    {
        public TextBox TextBox { get; }
        public IconGlyph Glyph { get; }

        public SearchBox()
        {
            BackColor = Color.White;
            BorderColor = Theme.Border;
            BorderThickness = 1;
            CornerRadius = 10;
            Padding = new Padding(36, 0, 10, 0);

            Glyph = new IconGlyph
            {
                Icon = IconKind.Search,
                IconColor = Theme.TextHint,
                Size = new Size(18, 18),
                Location = new Point(10, 0)
            };
            TextBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Font = Theme.Body,
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            Controls.Add(TextBox);
            Controls.Add(Glyph);
            Resize += (s, e) => Glyph.Top = (Height - Glyph.Height) / 2;
        }
    }

    // ------------------------------------------------------------------
    // A simple rounded container for controls that can't be restyled
    // directly (ComboBox, NumericUpDown) — gives them a matching,
    // borderless look by hosting them with padding inside a rounded box.
    // ------------------------------------------------------------------
    public class FieldContainer : RoundedPanel
    {
        public FieldContainer()
        {
            BackColor = Color.White;
            BorderColor = Theme.Border;
            BorderThickness = 1;
            CornerRadius = 10;
            Padding = new Padding(10, 4, 10, 4);
        }
    }

    // ------------------------------------------------------------------
    // Null-safe lookups for purely decorative / display-only controls
    // (labels, icons, captions, toolbar buttons).
    //
    // Form code used to talk to these controls through the designer-made
    // fields (e.g. "lblEmptyIcon.Text = ..."). Deleting such a control in
    // the designer removed the field, so the rest of the form no longer
    // compiled and the designer showed an error. Going through these
    // helpers looks the control up by name at run time and simply does
    // nothing when it is missing, so a label or icon can be deleted (or
    // renamed) in the designer without breaking anything.
    // ------------------------------------------------------------------
    public static class SafeUi
    {
        public static T Find<T>(Control root, string name) where T : Control
        {
            if (root == null || string.IsNullOrEmpty(name)) return null;
            foreach (Control c in root.Controls.Find(name, true))
            {
                T match = c as T;
                if (match != null) return match;
            }
            return null;
        }

        public static ToolStripItem FindItem(Control root, string name)
        {
            if (root == null || string.IsNullOrEmpty(name)) return null;
            foreach (ToolStrip strip in Enumerate<ToolStrip>(root))
            {
                ToolStripItem[] hits = strip.Items.Find(name, true);
                if (hits.Length > 0) return hits[0];
            }
            return null;
        }

        private static System.Collections.Generic.IEnumerable<T> Enumerate<T>(Control root) where T : Control
        {
            foreach (Control c in root.Controls)
            {
                T match = c as T;
                if (match != null) yield return match;
                foreach (T inner in Enumerate<T>(c)) yield return inner;
            }
        }

        public static void Run<T>(Control root, string name, Action<T> action) where T : Control
        {
            T control = Find<T>(root, name);
            if (control != null && action != null) action(control);
        }

        public static void SetText(Control root, string name, string text)
        {
            Control c = Find<Control>(root, name);
            if (c != null) c.Text = text;
        }

        public static string GetText(Control root, string name)
        {
            Control c = Find<Control>(root, name);
            return c == null ? string.Empty : c.Text;
        }

        public static void SetVisible(Control root, string name, bool visible)
        {
            Control c = Find<Control>(root, name);
            if (c != null) c.Visible = visible;
        }

        public static void CenterHorizontally(Control root, string name, Control container)
        {
            Control c = Find<Control>(root, name);
            if (c != null && container != null) c.Left = (container.Width - c.Width) / 2;
        }
    }
}
