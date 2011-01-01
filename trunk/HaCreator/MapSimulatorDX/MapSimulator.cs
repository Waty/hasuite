//#define FULLSCREEN

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Graphics;
//using Microsoft.Xna.Framework.Content;
//using Microsoft.Xna.Framework.Input;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using Microsoft.DirectX.AudioVideoPlayback;
using DI = Microsoft.DirectX.DirectInput;
using System.IO;
using MapleLib.WzLib;
using MapleLib.WzLib.WzProperties;
using System.Collections;
using HaCreator.MapEditor;
using System.Drawing;
namespace HaCreator.MapSimulator
{
    public partial class MapSimulator : Form//, IServiceProvider
    {
        public static int mapShiftX = 0;
        public static int mapShiftY = 0;
        public static Point mapCenter;

        private Device DxDevice;
        private DI.Device DiDevice = new DI.Device(DI.SystemGuid.Keyboard);
        private Sprite sprite;
        private PresentParameters pParams = new PresentParameters();
        //private IGraphicsDeviceService graphicsDeviceService;
        //private ContentManager contentMan;
        //private SpriteFont defaultFont;
        public List<MapItem>[] mapObjects = CreateLayersArray();
        public List<BackgroundItem> backgrounds = new List<BackgroundItem>();
        public static Hashtable footholds;
        //public Character character;
        private Rectangle vr;
        private TextureS minimap;
        //private bool debug = true;
        private TextureS pixel;
        private Audio audio;
        private bool usePhysics = false;

        private static List<MapItem>[] CreateLayersArray()
        {
            List<MapItem>[] result = new List<MapItem>[8];
            for (int i = 0; i < 8; i++)
                result[i] = new List<MapItem>();
            return result;
        }

        public MapSimulator(Board mapBoard)
        {
            DiDevice.SetCooperativeLevel(this, DI.CooperativeLevelFlags.Background | DI.CooperativeLevelFlags.NonExclusive);
            DiDevice.Acquire();
            WzSoundProperty bgm = Program.InfoManager.BGMs[mapBoard.MapInfo.bgm];
            if (bgm != null)
            {
                string tempBgmFile = Path.GetTempFileName();
                bgm.SaveToFile(tempBgmFile);
                audio = new Audio(tempBgmFile);
                audio.Ending += new EventHandler(audio_Ending);
            }
            MapSimulator.mapCenter = new Point(mapBoard.CenterPoint.X, mapBoard.CenterPoint.Y);
            if (mapBoard.MapInfo.VR == null) vr = new Rectangle(0, 0, mapBoard.MapSize.X, mapBoard.MapSize.Y);
            else vr = new Rectangle(mapBoard.MapInfo.VR.Value.X + mapCenter.X, mapBoard.MapInfo.VR.Value.Y + mapCenter.Y, mapBoard.MapInfo.VR.Value.Width, mapBoard.MapInfo.VR.Value.Height);
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque, true);
            InitializeComponent();
#if FULLSCREEN
            pParams.BackBufferWidth = 800;
            pParams.BackBufferHeight = 600;
            //pParams.BackBufferFormat = SurfaceFormat.Color;
            //pParams.EnableAutoDepthStencil = true;
            //pParams.AutoDepthStencilFormat = DepthFormat.Depth24;
            //pParams.IsFullScreen = true;
            presentParams.BackBufferFormat = Format.R5G6B5;
            presentParams.Windowed = false;
            pParams.FullScreenRefreshRateInHz = 60;
#else
            pParams.Windowed = true;
            pParams.SwapEffect = SwapEffect.Discard;
//            pParams.BackBufferWidth = Math.Max(Width, 1);
//            pParams.BackBufferHeight = Math.Max(Height, 1);
            //pParams.BackBufferFormat = SurfaceFormat.Depth24;
//            pParams.EnableAutoDepthStencil = true;
//            pParams.AutoDepthStencilFormat = DepthFormat.d2;
#endif
            try
            {
                DxDevice = new Device(0, DeviceType.Hardware, this, CreateFlags.SoftwareVertexProcessing, new PresentParameters[] { pParams });
                //DxDevice = new GraphicsDevice(GraphicsAdapter.DefaultAdapter, DeviceType.Hardware, Handle, pParams);
            }
            catch
            {
                DxDevice = new Device(0, DeviceType.NullReference, this, CreateFlags.SoftwareVertexProcessing, new PresentParameters[] { pParams });
                //DxDevice = new GraphicsDevice(GraphicsAdapter.DefaultAdapter, DeviceType.NullReference, Handle, pParams);
            }
            //graphicsDeviceService = new HaCreator.MapEditor.GraphicsDeviceService(DxDevice);
            //this.minimap = HaCreator.MapEditor.BoardItem.TextureFromBitmap(DxDevice, mapBoard.MiniMap);
            this.minimap = new TextureS(DxDevice, mapBoard.MiniMap);
            //pixel = HaCreator.MapEditor.BoardItem.TextureFromBitmap(DxDevice, new System.Drawing.Bitmap(1, 1));
            pixel = new TextureS(DxDevice, new System.Drawing.Bitmap(1, 1));
            //contentMan = new ContentManager(this);
            //defaultFont = contentMan.Load<SpriteFont>("Arial");
            //sprite = new SpriteBatch(DxDevice);
            sprite = new Sprite(DxDevice);
            //character = new Character(400 + mapCenter.X, 300 + mapCenter.Y);
            //character.DoFly();
        }

        private void audio_Ending(object sender, EventArgs e)
        {
            audio.CurrentPosition = 0;
            audio.Play();
        }

        /*public new object GetService(Type serviceType)
        {
            if (serviceType == typeof(Microsoft.Xna.Framework.Graphics.IGraphicsDeviceService))
                return this.graphicsDeviceService;
            else
                return base.GetService(serviceType);
        }*/

        private Vector3 emptyV3 = new Vector3(0, 0, 0);

        protected override void OnPaint(PaintEventArgs e)
        {
            //if (WindowState == FormWindowState.Minimized) { if (usePhysics) character.ProcessPhysics(); return; }
            base.OnPaint(e);
            //DxDevice.Clear(ClearOptions.Target, Color.Black, 1.0f, 0); // Clear the window to black
            //sprite.Begin(SpriteBlendMode.AlphaBlend, SpriteSortMode.Immediate, SaveStateMode.None);
            DxDevice.Clear(ClearFlags.Target, Color.Black, 1.0f, 0); // Clear the window to black
            DxDevice.BeginScene();
            sprite.Begin(SpriteFlags.AlphaBlend);
            foreach (BackgroundItem bg in backgrounds)
                if (!bg.Front)
                    bg.Draw(sprite);
            for (int i =0; i< mapObjects.Length; i++)
            {
                foreach (MapItem item in mapObjects[i])
                    item.Draw(sprite);
                /*if (i == character.Layer)
                    character.Draw(sprite,pixel);*/
            }
            foreach (BackgroundItem bg in backgrounds)
                if (bg.Front)
                    bg.Draw(sprite);
/*            if (debug)
            {
                foreach (DictionaryEntry fhEntry in footholds)
                {
                    Foothold fh = (Foothold)fhEntry.Value;
                    int x1 = fh.x1 + mapCenter.X - mapShiftX - 3;
                    int x2 = fh.x2 + mapCenter.X - mapShiftX - 3;
                    int y1 = fh.y1 + mapCenter.Y - mapShiftY - 3;
                    int y2 = fh.y2 + mapCenter.Y - mapShiftY - 3;
                    FillRectangle(sprite, new Rectangle(x1, y1, 6, 6), Color.Red);
                    FillRectangle(sprite, new Rectangle(x2, y2, 6, 6), Color.Red);
                    DrawLine(sprite, new Vector2(x1, y1), new Vector2(x2, y2), Color.Red);
                    sprite.DrawString(defaultFont, fh.prev.ToString(), new Vector2(x1, y1 - 20), Color.Black);
                    sprite.DrawString(defaultFont, fh.next.ToString(), new Vector2(x2, y2 + 20), Color.Black);
                }
                sprite.DrawString(defaultFont, character.X.ToString(), new Vector2(), Color.Black);
                sprite.DrawString(defaultFont, character.Y.ToString(), new Vector2(0,50), Color.Black);
            }*/

            if (minimap != null)
            {
                //sprite.Draw(minimap, new Rectangle(0, 0, minimap.Width, minimap.Height), Color.White);
                sprite.Draw2D(minimap.Texture, Point.Empty, 0f, Point.Empty, Color.White);
                int minimapPosX = (mapShiftX + 400) / 16;
                int minimapPosY = (mapShiftY + 300) / 16;
                FillRectangle(sprite, new Rectangle(minimapPosX - 4, minimapPosY - 4, 4, 4), Color.Yellow);
                //sprite.Draw2D(minimap.Texture, Point.Empty, 0f, Point.Empty, Color.White);
            }
            sprite.End();
            DxDevice.EndScene();
/*            try
            {*/
                DxDevice.Present();
/*            }
            catch (DeviceNotResetException)
            {
                try
                {
                    ResetDevice();
                }
                catch (DeviceLostException)
                {
                }
            }
            catch (DeviceLostException)
            {
            }*/
            HandleKeyPresses();
            //if (usePhysics) character.ProcessPhysics();
            System.Threading.Thread.Sleep(10);
            Invalidate();
        }

/*        private void ResetDevice()
        {
            DxDevice.PresentationParameters.BackBufferWidth = Math.Max(Width, 1);
            DxDevice.PresentationParameters.BackBufferHeight = Math.Max(Height, 1);
            DxDevice.Reset(DxDevice.PresentationParameters);
        }*/

        public static float Distance(Point value1, Point value2)
        {
            float num2 = value1.X - value2.X;
            float num = value1.Y - value2.Y;
            float num3 = (num2 * num2) + (num * num);
            return (float)Math.Sqrt((double)num3);
        }

        public void DrawLine(Sprite sprite, Point start, Point end, Color color)
        {
            int width = (int)Distance(start, end);
            float rotation = (float)Math.Atan2((double)(end.Y - start.Y), (double)(end.X - start.X));
            sprite.Draw2D(pixel.Texture, new Rectangle(0, 0, 1, 1), new Rectangle((int)start.X, (int)start.Y, width, UserSettings.LineWidth), Point.Empty, rotation, new Point(start.X, start.Y), color);
        }

        public void FillRectangle(Sprite sprite, Rectangle rectangle, Color color)
        {
            sprite.Draw2D(pixel.Texture,new Rectangle(0,0,1,1), rectangle,new Point(rectangle.X,rectangle.Y), color);
        }

        //int lastHotKeyPressTime = 0;

        void HandleKeyPresses()
        {
            if (usePhysics)
            {
            }
            DI.KeyboardState state = DiDevice.GetCurrentKeyboardState();
            //KeyboardState state = Keyboard.GetState();
/*            if (state[Microsoft.Xna.Framework.Input.Keys.F5] == KeyState.Down && Environment.TickCount - lastHotKeyPressTime > 500)
            {
                usePhysics = !usePhysics;
                lastHotKeyPressTime = Environment.TickCount;
                character.ResetLastProcessTime();
            }*/
            /*if (!usePhysics)
            {*/
                /*if (state[Microsoft.Xna.Framework.Input.Keys.Left] == KeyState.Down)
                    mapShiftX = Math.Max(vr.Left, mapShiftX - 10);
                if (state[Microsoft.Xna.Framework.Input.Keys.Up] == KeyState.Down)
                    mapShiftY = Math.Max(vr.Top, mapShiftY - 10);
                if (state[Microsoft.Xna.Framework.Input.Keys.Right] == KeyState.Down)
                    mapShiftX = Math.Min(vr.Right - 800, mapShiftX + 10);
                if (state[Microsoft.Xna.Framework.Input.Keys.Down] == KeyState.Down)
                    mapShiftY = Math.Min(vr.Bottom - 600, mapShiftY + 10);
                if (state[Microsoft.Xna.Framework.Input.Keys.Escape] == KeyState.Down)
                    Close();*/
            if (state[DI.Key.Left])
                    mapShiftX = Math.Max(vr.Left, mapShiftX - 10);
            if (state[DI.Key.Up])
                    mapShiftY = Math.Max(vr.Top, mapShiftY - 10);
            if (state[DI.Key.Right])
                    mapShiftX = Math.Min(vr.Right - 800, mapShiftX + 10);
            if (state[DI.Key.Down])
                    mapShiftY = Math.Min(vr.Bottom - 600, mapShiftY + 10);
            if (state[DI.Key.Escape])
                    Close();
                /*character.X = mapShiftX + 400;
                character.Y = mapShiftY + 300;*/
            /*}
            else
            {
                mapShiftX = character.X - 400;
                mapShiftY = character.Y - 300;
                bool prone = true;
                if (state[Microsoft.Xna.Framework.Input.Keys.Left] == KeyState.Down)
                {
                    character.DoWalk(-1);
                    prone = false;
                }
                if (state[Microsoft.Xna.Framework.Input.Keys.Right] == KeyState.Down)
                {
                    character.DoWalk(1);
                    prone = false;
                }
                if (state[Microsoft.Xna.Framework.Input.Keys.Space] == KeyState.Down)
                {
                    character.DoJump();
                    prone = false;
                }
                if (state[Microsoft.Xna.Framework.Input.Keys.Escape] == KeyState.Down)
                    Close();
                if (prone) character.DoProne();
            }*/
        }

        private static MapItem CreateMapItemFromProperty(IWzImageProperty source, int x, int y, int mapCenterX, int mapCenterY, Device device, ref List<IWzObject> usedProps,bool flip)
        {
            if (source is WzSubProperty && ((WzSubProperty)source).WzProperties.Count == 1)
                source = ((WzSubProperty)source).WzProperties[0];
            if (source is WzCanvasProperty) //one-frame
            {
                WzVectorProperty origin = (WzVectorProperty)source["origin"];
                if (source.Tag2 == null)
                {
                    //source.Tag2 = BoardItem.TextureFromBitmap(device, ((WzCanvasProperty)source).PngProperty.GetPNG(false));
                    Bitmap bmp = ((WzCanvasProperty)source).PngProperty.GetPNG(false);
                    if (flip) bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    source.Tag2 = new TextureS(device, bmp);
                    usedProps.Add(source);
                }
                return new MapItem(new DXObject(x - origin.X.Value + mapCenterX, y - origin.Y.Value + mapCenterY, (TextureS)source.Tag2), flip);
            }
            else if (source is WzSubProperty) //animooted
            {
                IWzImageProperty frameProp;
                int i = 0;
                List<DXObject> frames = new List<DXObject>();
                while ((frameProp = source[(i++).ToString()]) != null)
                {
                    if (frameProp is WzUOLProperty) frameProp = (IWzImageProperty)((WzUOLProperty)frameProp).LinkValue;
                    int? delay = MapInfo.GetOptionalInt(frameProp["delay"]);
                    if (delay == null) delay = 100;
                    if (frameProp.Tag2 == null)
                    {
                        //frameProp.Tag2 = BoardItem.TextureFromBitmap(device, ((WzCanvasProperty)frameProp).PngProperty.GetPNG(false));
                        Bitmap bmp = ((WzCanvasProperty)frameProp).PngProperty.GetPNG(false);
                        if (flip) bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        frameProp.Tag2 = new TextureS(device, bmp);
                        usedProps.Add(frameProp);
                    }
                    WzVectorProperty origin = (WzVectorProperty)frameProp["origin"];
                    frames.Add(new DXObject(x - origin.X.Value + mapCenterX, y - origin.Y.Value + mapCenterY, (int)delay, (TextureS)frameProp.Tag2));
                }
                return new MapItem(frames, flip);
            }
            else throw new Exception("unsupported property type in map simulator");
        }

        public static BackgroundItem CreateBackgroundFromProperty(IWzImageProperty source, int x, int y, int rx, int ry, int cx, int cy, int a, BackgroundType type, bool front, int mapCenterX, int mapCenterY, Device device, ref List<IWzObject> usedProps, bool flip)
        {
            if (source is WzSubProperty && ((WzSubProperty)source).WzProperties.Count == 1)
                source = ((WzSubProperty)source).WzProperties[0];
            if (source is WzCanvasProperty) //one-frame
            {
                WzVectorProperty origin = (WzVectorProperty)source["origin"];
                if (source.Tag2 == null)
                {
                    //source.Tag2 = BoardItem.TextureFromBitmap(device, ((WzCanvasProperty)source).PngProperty.GetPNG(false));
                    Bitmap bmp = ((WzCanvasProperty)source).PngProperty.GetPNG(false);
                    if (flip) bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    source.Tag2 = new TextureS(device, bmp);
                    usedProps.Add(source);
                }
                return new BackgroundItem(cx, cy, rx, ry, type, a, front, new DXObject(x - origin.X.Value/* - mapCenterX*/, y - origin.Y.Value/* - mapCenterY*/, (TextureS)source.Tag2), flip);
            }
            else if (source is WzSubProperty) //animooted
            {
                WzCanvasProperty frameProp;
                int i = 0;
                List<DXObject> frames = new List<DXObject>();
                while ((frameProp = (WzCanvasProperty)source[(i++).ToString()]) != null)
                {
                    int? delay = MapInfo.GetOptionalInt(frameProp["delay"]);
                    if (delay == null) delay = 100;
                    if (frameProp.Tag2 == null)
                    {
                        //frameProp.Tag2 = BoardItem.TextureFromBitmap(device, frameProp.PngProperty.GetPNG(false));
                        Bitmap bmp = frameProp.PngProperty.GetPNG(false);
                        if (flip) bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        frameProp.Tag2 = new TextureS(device, bmp);
                        usedProps.Add(frameProp);
                    }
                    WzVectorProperty origin = (WzVectorProperty)frameProp["origin"];
                    frames.Add(new DXObject(x - origin.X.Value/* - mapCenterX*/, y - origin.Y.Value/* - mapCenterY*/, (int)delay, (TextureS)frameProp.Tag2));
                }
                return new BackgroundItem(cx, cy, rx, ry, type, a, front, frames, flip);
            }
            else throw new Exception("unsupported property type in map simulator");
        }

        public static Hashtable ConvertToMapleFootholds(List<FootholdLine> footholds, List<FootholdAnchor> anchors)
        {
            Hashtable fhListByPoint = new Hashtable();
            foreach (FootholdAnchor anchor in anchors)
            {
                Point anchorPos = new Point(anchor.X, anchor.Y);
                List<HaCreator.MapEditor.FootholdLine> fhList = (List<HaCreator.MapEditor.FootholdLine>)fhListByPoint[anchorPos];
                if (fhList == null)
                {
                    fhList = new List<HaCreator.MapEditor.FootholdLine>(2);
                    fhListByPoint.Add(anchorPos, fhList);
                }
                fhList.AddRange(anchor.connectedLines.Cast<HaCreator.MapEditor.FootholdLine>());
            }
            Hashtable fhByNum = new Hashtable();
            for (int i = 1; i <= footholds.Count; i++)
            {
                HaCreator.MapEditor.FootholdLine fhClass = footholds[i - 1];
                if (fhClass.FirstDot.X == fhClass.SecondDot.X && fhClass.FirstDot.Y == fhClass.SecondDot.Y) continue;
                fhClass.num = i;
                Foothold mapleFh = new Foothold();
                mapleFh.num = i;
                mapleFh.layer = ((FootholdAnchor)fhClass.FirstDot).LayerNumber;
                fhByNum[i] = mapleFh;
            }
            for (int i = 1; i <= footholds.Count; i++)
            {
                HaCreator.MapEditor.FootholdLine fhClass = footholds[i - 1];
                Foothold mapleFh = (Foothold)fhByNum[i];
                HaCreator.MapEditor.FootholdLine firstOtherFh = GetOtherFh((FootholdAnchor)fhClass.FirstDot, fhClass, fhListByPoint);
                HaCreator.MapEditor.FootholdLine secondOtherFh = GetOtherFh((FootholdAnchor)fhClass.SecondDot, fhClass, fhListByPoint);
                if (fhClass.FirstDot.X < fhClass.SecondDot.X)
                {
                    mapleFh.x1 = fhClass.FirstDot.X;
                    mapleFh.x2 = fhClass.SecondDot.X;
                    mapleFh.y1 = fhClass.FirstDot.Y;
                    mapleFh.y2 = fhClass.SecondDot.Y;
                    mapleFh.prev = firstOtherFh == null ? 0 : firstOtherFh.num;
                    mapleFh.next = secondOtherFh == null ? 0 : secondOtherFh.num;
                }
                else if (fhClass.FirstDot.X > fhClass.SecondDot.X)
                {
                    mapleFh.x1 = fhClass.SecondDot.X;
                    mapleFh.x2 = fhClass.FirstDot.X;
                    mapleFh.y1 = fhClass.SecondDot.Y;
                    mapleFh.y2 = fhClass.FirstDot.Y;
                    mapleFh.prev = secondOtherFh == null ? 0 : secondOtherFh.num;
                    mapleFh.next = firstOtherFh == null ? 0 : firstOtherFh.num;
                }
                else
                {
                    bool fhDir = GetVerticalFootholdDirection(fhClass, fhListByPoint);
                    if (fhDir) //prev = firstdot
                    {
                        mapleFh.x1 = fhClass.FirstDot.X;
                        mapleFh.x2 = fhClass.SecondDot.X;
                        mapleFh.y1 = fhClass.FirstDot.Y;
                        mapleFh.y2 = fhClass.SecondDot.Y;
                        mapleFh.prev = firstOtherFh == null ? 0 : firstOtherFh.num;
                        mapleFh.next = secondOtherFh == null ? 0 : secondOtherFh.num;
                    }
                    else //prev = seconddot
                    {
                        mapleFh.x1 = fhClass.SecondDot.X;
                        mapleFh.x2 = fhClass.FirstDot.X;
                        mapleFh.y1 = fhClass.SecondDot.Y;
                        mapleFh.y2 = fhClass.FirstDot.Y;
                        mapleFh.prev = secondOtherFh == null ? 0 : secondOtherFh.num;
                        mapleFh.next = firstOtherFh == null ? 0 : firstOtherFh.num;
                    }
                }
                fhByNum[i] = mapleFh;
            }
            return fhByNum;
        }

        private static HaCreator.MapEditor.FootholdLine GetOtherFh(HaCreator.MapEditor.FootholdAnchor anchor, HaCreator.MapEditor.FootholdLine source, Hashtable fhListByPoint)
        {
            List<HaCreator.MapEditor.FootholdLine> connectedLines = (List<HaCreator.MapEditor.FootholdLine>)fhListByPoint[new Point(anchor.X, anchor.Y)];
            if (connectedLines.Count < 2) return null;
            else if (connectedLines.Count == 2)
            {
                return connectedLines[1].FhEquals(source) ? connectedLines[0] : connectedLines[1];
            }
            else //reaching this part means whoever made the map is a fucking idiot
            {
                HaCreator.MapEditor.FootholdLine longestFh = null;
                int longestFhLenth = 0;
                foreach (HaCreator.MapEditor.FootholdLine fh in connectedLines)
                {
                    int length = (int)Math.Sqrt(Math.Pow((fh.SecondDot.X - fh.FirstDot.X), 2) + Math.Pow((fh.SecondDot.Y - fh.FirstDot.Y), 2));
                    if (!fh.FhEquals(source) && length > longestFhLenth)
                    {
                        longestFh = fh;
                        longestFhLenth = length;
                    }
                }
                return longestFh;
            }
        }

        private static FootholdAnchor GetTopAnchor(HaCreator.MapEditor.FootholdLine fh)
        {
            return fh.FirstDot.Y > fh.SecondDot.Y ? (FootholdAnchor)fh.SecondDot : (FootholdAnchor)fh.FirstDot;
        }

        private static FootholdAnchor GetBottomAnchor(HaCreator.MapEditor.FootholdLine fh)
        {
            return fh.FirstDot.Y < fh.SecondDot.Y ? (FootholdAnchor)fh.SecondDot : (FootholdAnchor)fh.FirstDot;
        }

        //false = prev is in second point, true = prev is in first point
        private static bool GetVerticalFootholdDirection(HaCreator.MapEditor.FootholdLine fh, Hashtable fhListByPoint)
        {
            HaCreator.MapEditor.FootholdLine oldFh = null;
            HaCreator.MapEditor.FootholdLine currFh = fh;
            while (currFh.FirstDot.X == currFh.SecondDot.X)
            {
                oldFh = currFh;
                currFh = GetOtherFh(GetTopAnchor(currFh), currFh, fhListByPoint);
                if (currFh == null) goto try_other_side; //no more connections, try from other side
            }

            FootholdAnchor oldFhConnectAnchor = GetTopAnchor(oldFh);
            FootholdAnchor otherAnchor = oldFhConnectAnchor == currFh.FirstDot ? (FootholdAnchor)currFh.SecondDot : (FootholdAnchor)currFh.FirstDot;
            return !((otherAnchor.X > oldFhConnectAnchor.X) ^ (fh.FirstDot.Y > fh.SecondDot.Y));

            try_other_side:
            oldFh = null;
            currFh = fh;
            while (currFh.FirstDot.X == currFh.SecondDot.X)
            {
                oldFh = currFh;
                currFh = GetOtherFh(GetBottomAnchor(currFh), currFh, fhListByPoint);
                if (currFh == null) return false; //no more connections, return false (could be true too) because this foothold is 100% wall
            }

            oldFhConnectAnchor = GetBottomAnchor(oldFh);
            otherAnchor = oldFhConnectAnchor == currFh.FirstDot ? (FootholdAnchor)currFh.SecondDot : (FootholdAnchor)currFh.FirstDot;
            return !((otherAnchor.X > oldFhConnectAnchor.X) ^ (fh.FirstDot.Y < fh.SecondDot.Y));
        }

        public static MapSimulator CreateMapSimulator(Board mapBoard)
        {
            mapShiftX = 0;
            mapShiftY = 0;
            MapSimulator result = new MapSimulator(mapBoard);
            List<IWzObject> usedProps = new List<IWzObject>();
            WzFile MapFile = Program.WzManager["map"];
            WzDirectory tileDir = (WzDirectory)MapFile["Tile"];
            Device device = result.DxDevice;
            foreach (LayeredItem tileObj in mapBoard.BoardItems.TileObjs)
                result.mapObjects[tileObj.LayerNumber].Add(CreateMapItemFromProperty((IWzImageProperty)tileObj.BaseInfo.ParentObject, tileObj.X, tileObj.Y, mapBoard.CenterPoint.X,mapBoard.CenterPoint.Y, result.DxDevice, ref usedProps, tileObj is IFlippable ? ((IFlippable)tileObj).Flip : false));
            foreach (BackgroundInstance background in mapBoard.BoardItems.Backgrounds)
                result.backgrounds.Add(CreateBackgroundFromProperty((IWzImageProperty)background.BaseInfo.ParentObject, background.BaseX, background.BaseY, background.rx, background.ry, background.cx, background.cy, background.a, background.type, background.front, mapBoard.CenterPoint.X, mapBoard.CenterPoint.Y, result.DxDevice, ref usedProps, background.Flip));
            foreach (IWzObject obj in usedProps) obj.Tag2 = null;
            Hashtable fhs = ConvertToMapleFootholds(mapBoard.FootholdLines, mapBoard.BoardItems.FHAnchors);
            MapSimulator.footholds = fhs;
            usedProps.Clear();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            return result;
        }

        private void MapSimulator_Resize(object sender, EventArgs e)
        {
            //ResetDevice();
        }

        private void MapSimulator_Load(object sender, EventArgs e)
        {
            if (audio != null) audio.Play();
        }

        private void MapSimulator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (audio != null)
            {
                audio.Stop();
                audio.Dispose();
            }
        }
    }
}
