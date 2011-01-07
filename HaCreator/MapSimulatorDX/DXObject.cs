using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Graphics;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using Microsoft.DirectX.AudioVideoPlayback;
using System.Drawing;
using HaCreator.MapEditor;

namespace HaCreator.MapSimulator
{
    public class DXObject
    {
        Matrix flipMat = CreateFlipMatrix();
        protected TextureS texture;
        private int x;
        private int y;

        private int delay;

        public static Matrix CreateFlipMatrix()
        {
            Matrix m = Matrix.Identity;
            m.Scale(-1, 1, 1);
            return m;
        }

        public DXObject(int x, int y, TextureS texture)
        {
            this.x = x;
            this.y = y;
            this.texture = texture;
        }

        public DXObject(int x, int y, int delay, TextureS texture)
            : this(x, y, texture)
        {
            this.delay = delay;
        }

        public virtual void Draw(Sprite sprite, bool flip)
        {
/*            if (flip)
            {
                sprite.Transform = flipMat;
                //sprite.Draw(texture, new Rectangle(X - MapSimulator.mapShiftX, Y - MapSimulator.mapShiftY, texture.Width, texture.Height), null, Color, 0f, new Vector2(0f, 0f), flip ? SpriteEffects.FlipHorizontally : SpriteEffects.None, 0f);
                sprite.Draw2D(texture.Texture, Point.Empty, 0f, new Point(X - MapSimulator.mapShiftX, Y - MapSimulator.mapShiftY), Color);
                sprite.Transform = Matrix.Identity;
            }
            else*/
                sprite.Draw2D(texture.Texture, Point.Empty, 0f, new Point(X - MapSimulator.mapShiftX, Y - MapSimulator.mapShiftY), Color);
        }

        public virtual void Draw(Sprite sprite, int x, int y, Color color, bool flip)
        {
            //sprite.Draw(texture, new Rectangle(x, y, texture.Width, texture.Height), null, color, 0f, new Vector2(0f, 0f), flip ? SpriteEffects.FlipHorizontally : SpriteEffects.None, 0f);
/*            if (flip)
            {
                sprite.Transform = flipMat;
                sprite.Draw2D(texture.Texture, Point.Empty, 0f, new Point(-x, y), Color);
                sprite.Transform = Matrix.Identity;
            }
            else*/
                sprite.Draw2D(texture.Texture, Point.Empty, 0f, new Point(x, y), Color);
        }

        public int Delay
        {
            get { return delay; }
        }

        public virtual Color Color { get { return Color.White; } }
        public virtual int X { get { return x; } }
        public virtual int Y { get { return y; } }

        public virtual int Width { get { return texture.Width; } }
        public virtual int Height { get { return texture.Height; } }
    }

    public class MapItem
    {
        private List<DXObject> frames;
        private int currFrame = 0;
        private int lastFrameSwitchTime = 0;

        protected bool flip;
        protected bool notAnimated;
        private DXObject frame0;

        public MapItem(List<DXObject> frames, bool flip)
        {
            this.frames = frames;
            notAnimated = false;
            this.flip = flip;
        }

        public MapItem(DXObject frame0, bool flip)
        {
            this.frame0 = frame0;
            notAnimated = true;
            this.flip = flip;
        }

        protected DXObject GetCurrFrame()
        {
            if (notAnimated) return frame0;
            else
            {
                int tc = Environment.TickCount;
                if (tc - lastFrameSwitchTime > frames[currFrame].Delay)
                { //advance frame
                    currFrame++;
                    if (currFrame == frames.Count) currFrame = 0;
                    lastFrameSwitchTime = tc;
                }
                return frames[currFrame];
            }
        }

        public virtual void Draw(Sprite sprite)
        {
            if (notAnimated)
            {
                if (frame0.X - MapSimulator.mapShiftX + frame0.Width > 0 && frame0.Y - MapSimulator.mapShiftY + frame0.Height > 0 && frame0.X - MapSimulator.mapShiftX < 800 && frame0.Y - MapSimulator.mapShiftY < 600)
                    frame0.Draw(sprite, flip);
            }
            else
                GetCurrFrame().Draw(sprite, flip);
        }
    }

    public class BackgroundItem : MapItem
    {
        private int rx;
        private int ry;
        private int cx;
        private int cy;
        private BackgroundType type;
        private int a;
        private Color color;
        private bool front;

        private int bgMoveShiftX = 0;
        private int bgMoveShiftY = 0;

        public BackgroundItem(int cx, int cy, int rx, int ry, BackgroundType type, int a, bool front, List<DXObject> frames, bool flip)
            : base(frames, flip)
        {
            this.rx = rx;
            this.cx = cx;
            this.ry = ry;
            this.cy = cy;
            this.type = type;
            this.a = a;
            this.front = front;
            color = Color.FromArgb(a, 0xFF, 0xFF, 0xFF);
        }

        public BackgroundItem(int cx, int cy, int rx, int ry, BackgroundType type, int a, bool front, DXObject frame0, bool flip)
            : base(frame0, flip)
        {
            this.rx = rx;
            this.cx = cx;
            this.ry = ry;
            this.cy = cy;
            this.type = type;
            this.a = a;
            this.front = front;
            color = Color.FromArgb(a, 0xFF, 0xFF, 0xFF);
        }

        private void DrawHorizontalCopies(Sprite sprite, int x, int y, int cx, DXObject frame)
        {
            int width = frame.Width;
            Draw2D(sprite, x, y, frame);
            int copyX = x - cx;
            while (copyX + width > 0)
            {
                Draw2D(sprite, copyX, y, frame);
                copyX -= cx;
            }
            copyX = x + cx;
            while (copyX < 800)
            {
                Draw2D(sprite, copyX, y, frame);
                copyX += cx;
            }
        }

        private void DrawVerticalCopies(Sprite sprite, int x, int y, int cy, DXObject frame)
        {
            int height = frame.Height;
            Draw2D(sprite, x, y, frame);
            int copyY = y - cy;
            while (copyY + height > 0)
            {
                Draw2D(sprite, x, copyY, frame);
                copyY -= cy;
            }
            copyY = y + cy;
            while (copyY < 800)
            {
                Draw2D(sprite, x, copyY, frame);
                copyY += cy;
            }
        }

        private void DrawHVCopies(Sprite sprite, int x, int y, int cx, int cy, DXObject frame)
        {
            int width = frame.Width;
            DrawVerticalCopies(sprite, x, y, cy, frame);
            int copyX = x - cx;
            while (copyX + width > 0)
            {
                DrawVerticalCopies(sprite, copyX, y, cy, frame);
                copyX -= cx;
            }
            copyX = x + cx;
            while (copyX < 800)
            {
                DrawVerticalCopies(sprite, copyX, y, cy, frame);
                copyX += cx;
            }
        }

        public void Draw2D(Sprite sprite, int x, int y, DXObject frame)
        {
            frame.Draw(sprite, x, y, Color, flip);
        }

        public void IncreaseShiftX(int cx)
        {
            bgMoveShiftX++;
            bgMoveShiftX %= cx;
        }

        public void IncreaseShiftY(int cy)
        {
            bgMoveShiftY++;
            bgMoveShiftY %= cy;
        }

        public override void Draw(Sprite sprite)
        {
            DXObject frame = GetCurrFrame();
            int X = CalculateBackgroundPosX(frame);
            int Y = CalculateBackgroundPosY(frame);
            int _cx = cx == 0 ? frame.Width : cx;
            int _cy = cy == 0 ? frame.Height : cy;
            switch (type)
            {
                default:
                case BackgroundType.Regular:
                    Draw2D(sprite, X, Y, frame);
                    break;
                case BackgroundType.HorizontalTiling:
                    DrawHorizontalCopies(sprite, X, Y, _cx, frame);
                    break;
                case BackgroundType.VerticalTiling:
                    DrawVerticalCopies(sprite, X, Y, _cy, frame);
                    break;
                case BackgroundType.HVTiling:
                    DrawHVCopies(sprite, X, Y, _cx, _cy, frame);
                    break;
                case BackgroundType.HorizontalMoving:
                    DrawHorizontalCopies(sprite, X - bgMoveShiftX, Y, _cx, frame);
                    IncreaseShiftX(_cx);
                    break;
                case BackgroundType.VerticalMoving:
                    DrawVerticalCopies(sprite, X, Y - bgMoveShiftY, _cy, frame);
                    IncreaseShiftY(_cy);
                    break;
            }
        }

        public int CalculateBackgroundPosX(DXObject frame)
        {
            return (rx * (MapSimulator.mapShiftX - MapSimulator.mapCenter.X + 400) / 100) + frame.X + 400;
        }

        public int CalculateBackgroundPosY(DXObject frame)
        {
            return (ry * (MapSimulator.mapShiftY - MapSimulator.mapCenter.Y + 300) / 100) + frame.Y + 300;
        }

        public Color Color
        {
            get
            {
                return color;
            }
        }

        public bool Front { get { return front; } }
    }
}