using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Microsoft.Xna.Framework.Graphics;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace HaCreator.MapEditor
{
    internal class CharTexture
    {
        internal Texture2D texture;
        internal int w;
        internal int h;

        internal CharTexture(Texture2D texture, int w, int h)
        {
            this.texture = texture;
            this.w = w;
            this.h = h;
        }
    }

    public class FontEngine
    {
        private Bitmap globalBitmap;
        private Graphics globalGraphics;
        private Font font;
        private GraphicsDevice device;

        private CharTexture[] characters = new CharTexture[0x60];

        public FontEngine(string fontName, FontStyle fontStyle, float size, bool antialias, GraphicsDevice device)
        {
            this.device = device;
            font = new Font(fontName, size, fontStyle);
            globalBitmap = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
            globalGraphics = Graphics.FromImage(globalBitmap);

            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Near;

            for (char ch = (char)0x20; ch < 0x80; ch++)
            {
                characters[(int)ch - 0x20] = RasterizeCharacter(ch, antialias);
            }
        }

        Brush brush = new SolidBrush(Color.White);
        StringFormat format = new StringFormat();

        private CharTexture RasterizeCharacter(char ch, bool antialias)
        {
            string text = ch.ToString();

            SizeF size = globalGraphics.MeasureString(text, font);

            int width = (int)Math.Ceiling(size.Width);
            int height = (int)Math.Ceiling(size.Height);

            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                if (antialias)
                {
                    graphics.TextRenderingHint =
                        TextRenderingHint.AntiAliasGridFit;
                }
                else
                {
                    graphics.TextRenderingHint =
                        TextRenderingHint.SingleBitPerPixelGridFit;
                }

                graphics.DrawString(text, font, brush, 0, 0, format);
            }

            return new CharTexture(BoardItem.TextureFromBitmap(device, bitmap), width, height);
        }


        //draws a string to the global device using the font textures.
        //if the string exceedds maxWidth, it will be truncated with dots
        public void DrawString(SpriteBatch sprite, Point position, Microsoft.Xna.Framework.Color color, string str, int maxWidth)
        {
            //if the string is too long, truncate it and place "..."
            if (globalGraphics.MeasureString(str, font).Width > maxWidth)
            {
                int dotsWidth = (int)globalGraphics.MeasureString("...", font).Width;
                do
                {
                    str = str.Substring(0, str.Length - 1);
                }
                while (globalGraphics.MeasureString(str, font).Width + dotsWidth > maxWidth);
            }
            int xOffs = 0;
            foreach (char c in str.ToCharArray())
            {
                SizeF cSize = globalGraphics.MeasureString(new string(new char[] { c }), font);
                sprite.Draw(characters[c - 0x20].texture, new Microsoft.Xna.Framework.Rectangle(position.X + xOffs, position.Y, (int)cSize.Width, (int)cSize.Height), color);
                xOffs += (int)Math.Ceiling(cSize.Width);
            }
        }
    }
}
