/*  TabPages - A tab control simlar to IE 7's. Created by christophilus,
    translated from VB to C# by haha01haha01.
 * Copyright (C) 2009, 2010  christophilus, haha01haha01
   
 * This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

 * This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

 * You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.*/

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TabPages
{
    /// <summary>
    /// This class serves as the base for all the tabs (including the dropdown).  It provides common
    /// rendering logic and highlighting behavior.
    /// </summary>
    internal class TabBaseControl : Control
    {

        protected int TopMargin
        {
            get
            {
                if ((this.Pages != null)) return this.Pages.TopMargin;
                return 0;
            }
        }

        protected PageCollection Pages
        {
            get
            {
                if ((this.Parent == null)) return null;
                return ((TabView)this.Parent).Pages;
            }
        }

        public static Color AddColor(Color color, int value)
        {
            if ((value > 0))
            {
                return Color.FromArgb(Math.Min(color.R + value, 255), Math.Min(color.G + value, 255), Math.Min(color.B + value, 255));
            }
            else
            {
                return Color.FromArgb(Math.Max(color.R + value, 0), Math.Max(color.G + value, 0), Math.Max(color.B + value, 0));
            }
        }

        public static Pen GetBorderPen(Color tabColor)
        {
            return new Pen(AddColor(tabColor, -50));
        }

        protected virtual bool IsHighlighted
        {
            get { return this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)); }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Invalidate();
        }

        protected void PaintBackground(PaintEventArgs e, Rectangle bounds, RectangleF gradientBounds, Color color1, Color color2, bool paintRightLine /*default false*/)
        {
            // OK. Ready to paint the background gradient and whatnot.
            using (LinearGradientBrush bgBrush = new LinearGradientBrush(gradientBounds, color1, color2, LinearGradientMode.Vertical))
            {
                GraphicsPath path = new GraphicsPath();
                float arcSize = 5;

                SmoothingMode smoothMode = e.Graphics.SmoothingMode;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                path.AddLine(bounds.Right, bounds.Bottom, bounds.Left, bounds.Bottom);
                path.AddLine(bounds.Left, bounds.Bottom, bounds.Left, bounds.Top + arcSize);
                path.AddArc(bounds.Left, bounds.Top, arcSize, arcSize, 180, 90);
                path.AddLine(bounds.Left + arcSize, bounds.Top, bounds.Width - arcSize, bounds.Top);
                path.AddArc(bounds.Width - arcSize, bounds.Top, arcSize, arcSize, 270, 90);

                bgBrush.WrapMode = WrapMode.TileFlipXY;
                e.Graphics.FillPath(bgBrush, path);

                using (Pen borderPen = GetBorderPen(Pages.TabColor))
                {
                    path = new GraphicsPath();
                    path.AddLine(bounds.Right - 1, bounds.Bottom, bounds.Left, bounds.Bottom);
                    path.AddLine(bounds.Left, bounds.Bottom, bounds.Left, bounds.Top + arcSize);
                    path.AddArc(bounds.Left, bounds.Top, arcSize, arcSize, 180, 90);
                    path.AddLine(bounds.Left + arcSize - 1, bounds.Top, bounds.Width - 1 - arcSize, bounds.Top);
                    path.AddArc(bounds.Width - arcSize - 1, bounds.Top, arcSize, arcSize, 270, 90);
                    if ((paintRightLine || object.ReferenceEquals(this.Parent.Controls[this.Parent.Controls.Count - 1], this))) path.CloseFigure();
                    e.Graphics.DrawPath(borderPen, path);
                }

                e.Graphics.SmoothingMode = smoothMode;
            }
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            if ((this.Pages == null)) return;


            // Set up the gradient parameters.
            Rectangle bounds = new Rectangle();

            // Modify the gradient based on the state of the control (IsSelected, IsHighlighted, Default)
            bounds = new Rectangle(0, TopMargin, this.Width, this.Height - TopMargin - 1);
            if ((this.IsHighlighted))
            {
                PaintBackground(e, bounds, new RectangleF(0, 0, bounds.Width, bounds.Height / 2), AddColor(Pages.TabColor, 50), Pages.TabColor, false);
            }
            else
            {
                PaintBackground(e, bounds, bounds, AddColor(Pages.TabColor, 25), AddColor(Pages.TabColor, -25), false);
            }
        }
    }
}