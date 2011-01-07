using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using Microsoft.DirectX.AudioVideoPlayback;
using System.Drawing;
using MapleLib.WzLib;
using MapleLib.WzLib.WzProperties;
using System.Collections;
using HaCreator.MapEditor;

namespace HaCreator.MapSimulator
{
    public class Character
    {
        private static double gravityAcc;
        private static double walkSpeed;
        private static double jumpSpeed;
        private static double fallSpeed;

        //.cctor
        static Character()
        {
            WzImage physicsImage = (WzImage)Program.WzManager["map"]["Physics.img"];
            if (!physicsImage.Parsed) physicsImage.ParseImage();
            jumpSpeed = MapInfo.GetDouble(physicsImage["jumpSpeed"]);
            walkSpeed = MapInfo.GetDouble(physicsImage["walkSpeed"]);
            fallSpeed = MapInfo.GetDouble(physicsImage["fallSpeed"]);
            gravityAcc = MapInfo.GetDouble(physicsImage["gravityAcc"]);
        }

        private int layer = 7;
        private int x = 400;
        private int y = 300;
        private int footholdNum = 0;
        private Foothold foothold = new Foothold();
        private CharacterMode mode = CharacterMode.Fly;
        private int lastProcessTimeStamp;

        private int direction = 1; //-1 | 1
        private Vector2 Velocity = new Vector2(); //- <----> +, -^ +v
        private Vector2 Acceleration = new Vector2();

        public Character(int x, int y)
        {
            lastProcessTimeStamp = Environment.TickCount;
        }

        public void ResetLastProcessTime()
        {
            lastProcessTimeStamp = Environment.TickCount;
        }

        //measurement units are second and pixel
        public void ProcessPhysics()
        {
            double timeDiff = (Environment.TickCount - lastProcessTimeStamp) / 1000d;
            if (timeDiff == 0) return;
            if (mode == CharacterMode.Prone) goto end;
            int x_threshold = (int)(timeDiff * Velocity.X + (Acceleration.X / 2) * timeDiff * timeDiff);//x = vt + 0.5at^2
            int y_threshold = (int)(timeDiff * Velocity.Y + (Acceleration.Y / 2) * timeDiff * timeDiff);
            Velocity.X += (int)(Acceleration.X * timeDiff); //v = at
            Velocity.Y += (int)(Acceleration.Y * timeDiff);
            if (Velocity.Y > fallSpeed) Velocity.Y = (int)fallSpeed;

            if (mode != CharacterMode.Fly)
            {
                if (direction == 1 && x + x_threshold > foothold.x2)
                {
                    if (foothold.next != 0)
                    {
                        Foothold = foothold.next;
                        x = foothold.x1;
                        y = foothold.y1;
                        SetVelocity((int)Velocity.X);
                    }
                }
                else if (direction == -1 && x - x_threshold < foothold.x1)
                {
                    if (foothold.prev != 0)
                    {
                        Foothold = foothold.prev;
                        x = foothold.x2;
                        y = foothold.y2;
                        SetVelocity((int)Velocity.X);
                    }
                }
                else
                {
                    y += y_threshold;
                    x += x_threshold;
                }
                if (foothold.num == 0)
                    DoProne();
            }
            else
            {
                if (Velocity.Y > 0)
                foreach (DictionaryEntry fhEntry in MapSimulator.footholds)
                {
                    Foothold fh = (Foothold)fhEntry.Value;
                    if (fh.x1 < x + x_threshold && fh.x2 > x + x_threshold)
                    {
                        int slope = (fh.y2 - fh.y1) / (fh.x2 - fh.x1);
                        int yPos = fh.y1 + slope * ((x + x_threshold) - fh.x1);
                        if (y < yPos && y + y_threshold >= yPos)
                        {
                            y = yPos;
                            x += x_threshold;
                            foothold = fh;
                            footholdNum = fh.num;
                            mode = CharacterMode.Prone;
                            goto end;
                        }
                    }
                }
                y += y_threshold;
                if (y_threshold < 0)
                {
                }
                x += x_threshold;
            }
        end:
            lastProcessTimeStamp = Environment.TickCount;
        }

        public void DoFly()
        {
            Acceleration = new Vector2(0, (float)gravityAcc);
            mode = CharacterMode.Fly;
        }

        public void DoJump()
        {
            if (mode == CharacterMode.Fly) return;
            Velocity.Y = (float)-jumpSpeed;
            DoFly();
        }

        public void DoWalk(int direction)
        {
            if (mode == CharacterMode.Fly) return;
            this.direction = direction;
            SetVelocity((int)(walkSpeed * direction));
            mode = CharacterMode.Walk;
        }

        public void SetVelocity(int vx)
        {
            if (foothold.IsWall()) Velocity = new Vector2();
            else
            {
                float fhSlope = (float)(foothold.y2 - foothold.y1) / (float)(foothold.x2 - foothold.x1);
                Velocity = new Vector2(vx, fhSlope * vx);
            }
        }

        public void DoProne()
        {
            if (mode == CharacterMode.Fly) return;
            if (mode == CharacterMode.Walk)
            {
            }
            Velocity = new Vector2();
            Acceleration = new Vector2();
            mode = CharacterMode.Prone;
        }

        public void Draw(Sprite sprite, TextureS pixel)
        {
            sprite.Draw2D(pixel.Texture, new Rectangle(0, 0, pixel.Width, pixel.Height), new Rectangle(X - MapSimulator.mapShiftX - 10, Y - MapSimulator.mapShiftY - 10, 20, 10), new Point(X - MapSimulator.mapShiftX - 10, Y - MapSimulator.mapShiftY - 10), Color.Red);
            //sprite.Draw(pixel, new Rectangle(X - MapSimulator.mapShiftX - 10, Y - MapSimulator.mapShiftY - 10, 20, 10), Color.Red);
        }

        public int Layer { get { return layer; } set { layer = value; } }
        public int X { get { return x + MapSimulator.mapCenter.X; } set { x = value - MapSimulator.mapCenter.X; } }
        public int Y { get { return y + MapSimulator.mapCenter.Y; } set { y = value - MapSimulator.mapCenter.Y; } }
        public int Foothold { get { return footholdNum; } set { footholdNum = value; object fh = MapSimulator.footholds[value]; foothold = fh == null ? new Foothold() : (Foothold)fh; } }
        public CharacterMode Mode { get { return mode; } set { mode = value; } }

    }

    public enum CharacterMode
    {
        None,
        Prone,
        Walk,
        Float,
        Fly,
        Swim
    }
}
