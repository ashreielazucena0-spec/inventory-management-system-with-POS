using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{
    // =====================================================================
    //  Styles  -  the "rules" part of our stylesheet (like the .btn / .card
    //  classes in CSS).
    // =====================================================================
    //  A form never decides what a button or grid looks like. It just says
    //  what the control IS:
    //
    //      Styles.PrimaryButton(btnSave);
    //      Styles.Grid(dgvProducts);
    //      Styles.RoundCorners(pnlCard, Theme.RadiusLarge);
    //      Styles.Placeholder(txtSearch, "Search...");
    //
    //  The actual colours / fonts come from Theme.cs.
    // =====================================================================
    public static class Styles
    {
        // -----------------------------------------------------------------
        //  Shapes
        // -----------------------------------------------------------------

        /// <summary>Builds a rounded-rectangle outline (reused by every rounded control).</summary>
        public static GraphicsPath RoundedPath(RectangleF r, float radius)
        {
            var path = new GraphicsPath();
            float d = radius * 2;
            if (d > r.Width) d = r.Width;
            if (d > r.Height) d = r.Height;
            if (d <= 0) { path.AddRectangle(r); return path; }

            path.AddArc(r.X, r.Y, d, d, 180, 90);                  // top-left
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);          // top-right
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);   // bottom-right
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);          // bottom-left
            path.CloseFigure();
            return path;
        }

        /// <summary>Clips a control to rounded corners and keeps it rounded when resized.</summary>
        public static void RoundCorners(Control control, int radius)
        {
            ApplyRoundRegion(control, radius);
            control.Resize += (s, e) => ApplyRoundRegion(control, radius);
        }

        private static void ApplyRoundRegion(Control control, int radius)
        {
            if (control.Width <= 0 || control.Height <= 0) return;

            Region old = control.Region;
            using (var path = RoundedPath(new RectangleF(0, 0, control.Width - 1, control.Height - 1), radius))
                control.Region = new Region(path);
            if (old != null) old.Dispose();
        }

        /// <summary>Rounded card with a thin border (summary tiles, panels).</summary>
        public static void Card(Control card, int radius = Theme.RadiusLarge)
        {
            RoundCorners(card, radius);
            card.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (var path = RoundedPath(new RectangleF(0, 0, card.Width - 1, card.Height - 1), radius))
                using (var pen = new Pen(Theme.Border))
                    e.Graphics.DrawPath(pen, path);
            };
        }

        /// <summary>Thin separator line along the bottom edge of a control.</summary>
        public static void BottomRule(Control control)
        {
            control.Paint += (s, e) =>
            {
                using (var pen = new Pen(Theme.Border))
                    e.Graphics.DrawLine(pen, 0, control.Height - 1, control.Width, control.Height - 1);
            };
        }

        /// <summary>Clips a small square control (e.g. an icon label) into a circle.</summary>
        public static void Circle(Control control)
        {
            Action apply = () =>
            {
                if (control.Width <= 0 || control.Height <= 0) return;
                using (var path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, control.Width - 1, control.Height - 1);
                    control.Region = new Region(path);
                }
            };
            apply();
            control.Resize += (s, e) => apply();
        }

        /// <summary>Paints a diagonal two-colour gradient (banners, sidebars).</summary>
        public static void Gradient(Graphics g, Rectangle rect, Color from, Color to)
        {
            if (rect.Width <= 0 || rect.Height <= 0) return;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var brush = new LinearGradientBrush(rect, from, to, LinearGradientMode.ForwardDiagonal))
                g.FillRectangle(brush, rect);
        }

        /// <summary>Paints a white rounded field with a thin border (behind a text box).</summary>
        public static void RoundedField(Graphics g, Control field, int radius)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var path = RoundedPath(new RectangleF(0, 0, field.Width - 1, field.Height - 1), radius))
            {
                field.Region = new Region(path);
                using (var brush = new SolidBrush(Theme.Surface)) g.FillPath(brush, path);
                using (var pen = new Pen(Theme.Border)) g.DrawPath(pen, path);
            }
        }

        /// <summary>Paints a light-blue rounded chip with an emoji in the middle (icon beside a form field).</summary>
        public static void IconChip(Graphics g, Rectangle rect, string emoji)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var path = RoundedPath(new RectangleF(0, 0, rect.Width - 1, rect.Height - 1), 12))
            using (var brush = new SolidBrush(Theme.PrimaryTint))
                g.FillPath(brush, path);

            if (string.IsNullOrEmpty(emoji)) return;

            using (var textBrush = new SolidBrush(Theme.PrimaryDark))
            {
                SizeF size = g.MeasureString(emoji, Theme.EmojiLarge);
                g.DrawString(emoji, Theme.EmojiLarge, textBrush,
                    rect.X + (rect.Width - size.Width) / 2f,
                    rect.Y + (rect.Height - size.Height) / 2f);
            }
        }

        /// <summary>Same chip, but with a little hand-drawn barcode (there is no good barcode emoji).</summary>
        public static void BarcodeChip(Graphics g, Rectangle rect)
        {
            IconChip(g, rect, null);

            int[] barWidths = { 2, 1, 3, 1, 2, 1, 1, 3, 2, 1 };
            int totalWidth = 0;
            foreach (int w in barWidths) totalWidth += w + 1;

            int barHeight = rect.Height / 2;
            int x = rect.X + (rect.Width - totalWidth) / 2;
            int y = rect.Y + (rect.Height - barHeight) / 2;

            using (var brush = new SolidBrush(Theme.PrimaryDark))
            {
                foreach (int w in barWidths)
                {
                    g.FillRectangle(brush, x, y, w, barHeight);
                    x += w + 1;
                }
            }
        }

        // -----------------------------------------------------------------
        //  Buttons
        // -----------------------------------------------------------------

        /// <summary>Solid blue button (main action: Save, Add, Scan).</summary>
        public static void PrimaryButton(Button button, int radius = Theme.RadiusMedium)
        {
            FlatButton(button, Theme.Primary, Theme.Surface, radius);
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = Theme.PrimaryDark;
            button.FlatAppearance.MouseDownBackColor = Theme.PrimaryDark;
        }

        /// <summary>White button with a blue outline (secondary action: Cancel).</summary>
        public static void OutlineButton(Button button, int radius = Theme.RadiusMedium)
        {
            FlatButton(button, Theme.Surface, Theme.Primary, radius);
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Theme.Primary;
            button.FlatAppearance.MouseOverBackColor = Theme.PrimaryTint;
        }

        /// <summary>Changes a button's colour while the mouse is over it.</summary>
        public static void HoverColor(Button button, Color normal, Color hover)
        {
            button.BackColor = normal;
            button.MouseEnter += (s, e) => button.BackColor = hover;
            button.MouseLeave += (s, e) => button.BackColor = normal;
        }

        /// <summary>Red button for destructive actions (Delete, Deactivate).</summary>
        public static void DangerButton(Button button, int radius = Theme.RadiusMedium)
        {
            FlatButton(button, Theme.Danger, Theme.Surface, radius);
            button.FlatAppearance.BorderSize = 0;
        }

        /// <summary>Button that blends into a coloured bar (e.g. the window's close "X").</summary>
        public static void GhostButton(Button button, Color barColor, int radius = Theme.RadiusLarge)
        {
            FlatButton(button, barColor, Theme.Surface, radius);
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = Theme.PrimaryDark;
        }

        // Shared by all the button styles above.
        private static void FlatButton(Button button, Color back, Color fore, int radius)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = back;
            button.ForeColor = fore;
            button.Cursor = Cursors.Hand;
            button.Paint += (s, e) => ApplyRoundRegion(button, radius);
        }

        // -----------------------------------------------------------------
        //  Data grids
        // -----------------------------------------------------------------

        /// <summary>Flat, borderless table with alternating rows and a soft header.</summary>
        public static void Grid(DataGridView grid)
        {
            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = Theme.Surface;
            grid.GridColor = Theme.Border;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.RowHeadersVisible = false;
            grid.RowTemplate.Height = Theme.GridRowHeight;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = Theme.GridHeaderHeight;

            // Header row
            var header = grid.ColumnHeadersDefaultCellStyle;
            header.BackColor = Theme.SurfaceAlt;
            header.ForeColor = Theme.TextMuted;
            header.Font = Theme.CaptionBold;
            header.Alignment = DataGridViewContentAlignment.MiddleLeft;
            header.Padding = new Padding(10, 0, 0, 0);

            // Normal rows
            var cell = grid.DefaultCellStyle;
            cell.BackColor = Theme.Surface;
            cell.ForeColor = Theme.TextBody;
            cell.Font = Theme.Body;
            cell.SelectionBackColor = Theme.PrimaryTint;
            cell.SelectionForeColor = Theme.NavyDark;
            cell.Padding = new Padding(10, 4, 4, 4);

            grid.AlternatingRowsDefaultCellStyle.BackColor = Theme.SurfaceAlt;
        }

        /// <summary>Behaviour for a grid that only displays rows (no typing, one row selected at a time).</summary>
        public static void ReadOnlyGrid(DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>Colours one grid row with a status colour (e.g. expired = red, near-expiry = orange).</summary>
        public static void StatusRow(DataGridViewRow row, Color text, Color background, Color selection)
        {
            row.DefaultCellStyle.ForeColor = text;
            row.DefaultCellStyle.BackColor = background;
            row.DefaultCellStyle.SelectionForeColor = text;
            row.DefaultCellStyle.SelectionBackColor = selection;
        }

        // -----------------------------------------------------------------
        //  Text boxes
        // -----------------------------------------------------------------

        [DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
        private static extern IntPtr SendText(IntPtr hWnd, int msg, int wParam, string lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern IntPtr SendNumber(IntPtr hWnd, int msg, int wParam, int lParam);

        private const int EM_SETCUEBANNER = 0x1501;   // Windows "ghost text" message
        private const int EM_SETMARGINS   = 0xD3;
        private const int EC_LEFTMARGIN   = 0x1;

        /// <summary>
        /// Shows grey "ghost" hint text while a text box is empty. Windows draws it
        /// for us, so the box's real .Text stays empty - no need to check for the hint.
        /// leftMargin leaves room for an icon drawn over the left edge.
        /// </summary>
        public static void Placeholder(TextBox box, string hint, int leftMargin = 0, bool showWhenFocused = false)
        {
            Action apply = () =>
            {
                SendText(box.Handle, EM_SETCUEBANNER, showWhenFocused ? 1 : 0, hint);
                if (leftMargin > 0) SendNumber(box.Handle, EM_SETMARGINS, EC_LEFTMARGIN, leftMargin);
            };

            if (box.IsHandleCreated) apply();
            else box.HandleCreated += (s, e) => apply();
        }
    }
}
