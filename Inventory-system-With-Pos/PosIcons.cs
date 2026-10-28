using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace inventory_management_system_with_POS
{
    // =====================================================================
    //  PosIcons  -  all the small vector icons used on the POS screen.
    // =====================================================================
    //  The icons are drawn in code (simple line art), so no image files are
    //  needed. They were moved out of frmPOS so that file only contains
    //  cashier logic. Colours come from Theme.cs.
    // =====================================================================
    internal static class PosIcons
    {
        // ---------------------------------------------------------------
        // Icon rendering.
        // ---------------------------------------------------------------
        internal static void AttachPictureIcons(Control root)
        {
            // Icons are looked up by name so any of them can be deleted in
            // the designer without breaking this method.
            var painters = new List<KeyValuePair<string, Action<Graphics, Rectangle>>>
            {
                Painter("pictureBoxStoreIcon",   (g, r) => DrawStoreLogo(g, r)),
                Painter("pictureBoxClockIcon",   (g, r) => DrawClockGlyph(g, r, Color.White)),
                Painter("pictureBoxSearchIcon",  (g, r) => DrawSearchGlyph(g, r, Theme.TextHint)),
                Painter("pictureBoxBarcodeIcon", (g, r) => DrawBarcodeGlyph(g, r, Theme.TextHint)),
                Painter("pictureBoxProductIcon", (g, r) => DrawBoxGlyph(g, r, Color.White)),
                Painter("pictureBoxOrderIcon",   (g, r) => DrawCartGlyph(g, r, Color.White)),
                Painter("pictureBoxEmptyCart",   (g, r) => DrawCartGlyph(g, r, Theme.BorderStrong)),
                Painter("pictureBoxRemarksIcon", (g, r) => DrawNoteGlyph(g, r, Theme.TextHint)),
            };

            foreach (var painter in painters)
            {
                PictureBox target = SafeUi.Find<PictureBox>(root, painter.Key);
                if (target == null) continue;

                Action<Graphics, Rectangle> draw = painter.Value;
                target.Paint += (s, e) => draw(e.Graphics, target.ClientRectangle);
                target.Invalidate();
            }
        }

        private static KeyValuePair<string, Action<Graphics, Rectangle>> Painter(string controlName, Action<Graphics, Rectangle> draw)
        {
            return new KeyValuePair<string, Action<Graphics, Rectangle>>(controlName, draw);
        }

        private static Pen GlyphPen(Rectangle bounds, Color color)
        {
            float width = Math.Max(1.4f, Math.Min(bounds.Width, bounds.Height) / 12f);
            return new Pen(color, width)
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round,
                LineJoin = LineJoin.Round
            };
        }

        // Maps points given in a normalized 0..24 icon grid onto the
        // control's actual pixel bounds.
        private static PointF[] Norm(Rectangle bounds, params float[] xy)
        {
            var pts = new PointF[xy.Length / 2];
            float sx = bounds.Width / 24f;
            float sy = bounds.Height / 24f;
            for (int i = 0; i < pts.Length; i++)
            {
                pts[i] = new PointF(bounds.X + xy[i * 2] * sx, bounds.Y + xy[i * 2 + 1] * sy);
            }
            return pts;
        }

        private static void DrawStoreLogo(Graphics g, Rectangle bounds)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var bg = new SolidBrush(Color.White))
            {
                g.FillEllipse(bg, bounds);
            }

            var inner = Rectangle.Inflate(bounds,
                -(int)(bounds.Width * 0.22f), -(int)(bounds.Height * 0.22f));
            DrawCartGlyph(g, inner, Theme.Primary);
        }

        private static void DrawCartGlyph(Graphics g, Rectangle bounds, Color color)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var pen = GlyphPen(bounds, color))
            {
                var body = Norm(bounds,
                    2, 3, 5, 3, 6.5f, 7,
                    21, 7, 18, 16, 9, 16,
                    6.5f, 7);
                g.DrawLines(pen, body);

                float wheelD = 24f / 24f * bounds.Width * (3.0f / 24f);
                float wheelDh = bounds.Height * (3.0f / 24f);
                var w1 = Norm(bounds, 8.4f, 16.6f)[0];
                var w2 = Norm(bounds, 15.4f, 16.6f)[0];

                g.DrawEllipse(pen, w1.X, w1.Y, wheelD, wheelDh);
                g.DrawEllipse(pen, w2.X, w2.Y, wheelD, wheelDh);
            }
        }

        private static void DrawClockGlyph(Graphics g, Rectangle bounds, Color color)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var pen = GlyphPen(bounds, color))
            {
                var circleRect = new RectangleF(
                    bounds.X + bounds.Width * 0.08f, bounds.Y + bounds.Height * 0.08f,
                    bounds.Width * 0.84f, bounds.Height * 0.84f);
                g.DrawEllipse(pen, circleRect);

                var center = new PointF(bounds.X + bounds.Width / 2f, bounds.Y + bounds.Height / 2f);
                var minuteTip = new PointF(center.X, bounds.Y + bounds.Height * 0.22f);
                var hourTip = new PointF(center.X + bounds.Width * 0.20f, center.Y + bounds.Height * 0.02f);

                g.DrawLine(pen, center, minuteTip);
                g.DrawLine(pen, center, hourTip);
            }
        }

        private static void DrawSearchGlyph(Graphics g, Rectangle bounds, Color color)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var pen = GlyphPen(bounds, color))
            {
                var circleRect = new RectangleF(
                    bounds.X + bounds.Width * 0.08f, bounds.Y + bounds.Height * 0.08f,
                    bounds.Width * 0.60f, bounds.Height * 0.60f);
                g.DrawEllipse(pen, circleRect);

                var handleStart = new PointF(
                    circleRect.Right - circleRect.Width * 0.12f,
                    circleRect.Bottom - circleRect.Height * 0.12f);
                var handleEnd = new PointF(
                    bounds.Right - bounds.Width * 0.08f,
                    bounds.Bottom - bounds.Height * 0.08f);

                g.DrawLine(pen, handleStart, handleEnd);
            }
        }

        private static void DrawBarcodeGlyph(Graphics g, Rectangle bounds, Color color)
        {
            g.SmoothingMode = SmoothingMode.None;
            using (var brush = new SolidBrush(color))
            {
                float[] widths = { 2f, 1f, 1f, 2f, 1f, 3f, 1f, 2f, 1f };
                float totalUnits = widths.Sum();
                float gap = bounds.Width * 0.03f;
                float totalGap = gap * (widths.Length - 1);
                float unit = (bounds.Width - totalGap) / totalUnits;

                float x = bounds.X;
                float top = bounds.Y + bounds.Height * 0.1f;
                float barHeight = bounds.Height * 0.8f;

                foreach (var w in widths)
                {
                    float barWidth = w * unit;
                    g.FillRectangle(brush, x, top, barWidth, barHeight);
                    x += barWidth + gap;
                }
            }
        }

        private static void DrawBoxGlyph(Graphics g, Rectangle bounds, Color color)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var pen = GlyphPen(bounds, color))
            {
                var lid = Norm(bounds, 1, 4, 23, 4, 23, 9, 1, 9, 1, 4);
                g.DrawLines(pen, lid);

                var body = Norm(bounds, 3, 9, 21, 9, 21, 21, 3, 21, 3, 9);
                g.DrawLines(pen, body);

                g.DrawLine(pen, Norm(bounds, 12, 9)[0], Norm(bounds, 12, 4)[0]);
            }
        }

        private static void DrawNoteGlyph(Graphics g, Rectangle bounds, Color color)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var pen = GlyphPen(bounds, color))
            {
                var outline = Norm(bounds, 4, 2, 17, 2, 21, 6, 21, 22, 4, 22, 4, 2);
                g.DrawLines(pen, outline);

                g.DrawLine(pen, Norm(bounds, 8, 9)[0], Norm(bounds, 17, 9)[0]);
                g.DrawLine(pen, Norm(bounds, 8, 13)[0], Norm(bounds, 17, 13)[0]);
                g.DrawLine(pen, Norm(bounds, 8, 17)[0], Norm(bounds, 14, 17)[0]);
            }
        }

        // ---------------------------------------------------------------
        // Small icons drawn onto the action buttons themselves.
        // ---------------------------------------------------------------
        internal static void SetButtonIcon(Button button, Action<Graphics, Rectangle, Color> draw, int size)
        {
            button.Image = CreateGlyphBitmap(size, draw, Color.White);
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.Padding = new Padding(12, 0, 0, 0);
        }

        private static Bitmap CreateGlyphBitmap(int size, Action<Graphics, Rectangle, Color> draw, Color color)
        {
            var bmp = new Bitmap(size, size);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                draw(g, new Rectangle(0, 0, size, size), color);
            }
            return bmp;
        }

        internal static void DrawPlusGlyph(Graphics g, Rectangle bounds, Color color)
        {
            using (var pen = GlyphPen(bounds, color))
            {
                g.DrawLine(pen,
                    bounds.Left + bounds.Width * 0.15f, bounds.Top + bounds.Height / 2f,
                    bounds.Right - bounds.Width * 0.15f, bounds.Top + bounds.Height / 2f);
                g.DrawLine(pen,
                    bounds.Left + bounds.Width / 2f, bounds.Top + bounds.Height * 0.15f,
                    bounds.Left + bounds.Width / 2f, bounds.Bottom - bounds.Height * 0.15f);
            }
        }

        internal static void DrawTrashGlyph(Graphics g, Rectangle bounds, Color color)
        {
            using (var pen = GlyphPen(bounds, color))
            {
                var lid = Norm(bounds, 5, 6, 19, 6);
                g.DrawLine(pen, lid[0], lid[1]);

                var body = Norm(bounds, 6, 6, 7, 21, 17, 21, 18, 6);
                g.DrawLines(pen, body);

                var handle = Norm(bounds, 9, 6, 9, 3, 15, 3, 15, 6);
                g.DrawLines(pen, handle);

                g.DrawLine(pen, Norm(bounds, 10, 10)[0], Norm(bounds, 10, 17)[0]);
                g.DrawLine(pen, Norm(bounds, 14, 10)[0], Norm(bounds, 14, 17)[0]);
            }
        }

        internal static void DrawBroomGlyph(Graphics g, Rectangle bounds, Color color)
        {
            using (var pen = GlyphPen(bounds, color))
            {
                var handleTip = Norm(bounds, 10, 13)[0];
                g.DrawLine(pen, Norm(bounds, 17, 2)[0], handleTip);

                g.DrawLine(pen, handleTip, Norm(bounds, 3, 22)[0]);
                g.DrawLine(pen, handleTip, Norm(bounds, 8, 22)[0]);
                g.DrawLine(pen, handleTip, Norm(bounds, 13, 22)[0]);
            }
        }

        internal static void DrawPersonGlyph(Graphics g, Rectangle bounds, Color color)
        {
            using (var pen = GlyphPen(bounds, color))
            {
                var headRect = new RectangleF(
                    bounds.X + bounds.Width * 0.32f, bounds.Y + bounds.Height * 0.06f,
                    bounds.Width * 0.36f, bounds.Height * 0.36f);
                g.DrawEllipse(pen, headRect);

                var shoulders = Norm(bounds, 4, 22, 6, 15, 18, 15, 20, 22);
                g.DrawLines(pen, shoulders);
            }
        }

        internal static void DrawCardGlyph(Graphics g, Rectangle bounds, Color color)
        {
            using (var pen = GlyphPen(bounds, color))
            {
                float x = bounds.X + bounds.Width * 0.06f;
                float y = bounds.Y + bounds.Height * 0.18f;
                float w = bounds.Width * 0.88f;
                float h = bounds.Height * 0.64f;

                g.DrawRectangle(pen, x, y, w, h);
                float stripeY = y + h * 0.28f;
                g.DrawLine(pen, x, stripeY, x + w, stripeY);
            }
        }

    }
}
