/*  HaRepacker - WZ extractor and repacker
 * Copyright (C) 2009, 2010 haha01haha01
   
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using MapleLib.WzLib.WzProperties;
using MapleLib.WzLib;
using SharpApng;
using GifComponents;

namespace HaRepackerLib
{
    public static class AnimationBuilder
    {
        #region Gif\APNG Extracting
/*        private Bitmap OptimizeBitmap(Bitmap source, Point origin, Point biggestPng, Point SmallestEmptySpace, Point MaximumMapEndingPts, Brush color)
        {
            Point Size = new Point(biggestPng.X - SmallestEmptySpace.X, biggestPng.Y - SmallestEmptySpace.Y);
            Bitmap empty = new Bitmap(MaximumMapEndingPts.X - SmallestEmptySpace.X, MaximumMapEndingPts.Y - SmallestEmptySpace.Y);
            Graphics process = Graphics.FromImage((Image)empty);
            process.FillRectangle(color, 0, 0, empty.Width, empty.Height);
            process.DrawImage(source, Size.X - origin.X, Size.Y - origin.Y);
            return empty;
        }*/

        private static Bitmap OptimizeBitmapTransparent(Bitmap source, WzVectorProperty origin, Point biggestPng, Point SmallestEmptySpace, Point MaximumMapEndingPts)
        {
            Point Size = new Point(biggestPng.X - SmallestEmptySpace.X, biggestPng.Y - SmallestEmptySpace.Y);
            Bitmap empty = new Bitmap(MaximumMapEndingPts.X - SmallestEmptySpace.X, MaximumMapEndingPts.Y - SmallestEmptySpace.Y);
            Graphics process = Graphics.FromImage((Image)empty);
            process.DrawImage(source, Size.X - origin.X.Value, Size.Y - origin.Y.Value);
            return empty;
        }

        public static int PropertySorter(WzCanvasProperty a, WzCanvasProperty b)
        {
            int aIndex = 0;
            int bIndex = 0;
            if (!int.TryParse(a.Name, out aIndex) || !int.TryParse(b.Name, out bIndex)) return 0;
            return aIndex.CompareTo(bIndex);
        }

        public static void ExtractAnimation(WzSubProperty parent, string savePath, bool apng, bool apngFirstFrame)
        {
            List<Bitmap> bmpList = new List<Bitmap>(parent.WzProperties.Count);
            List<int> delayList = new List<int>(parent.WzProperties.Count);
            Point biggestPng = new Point(0, 0);
            Point SmallestEmptySpace = new Point(65535, 65535);
            Point MaximumPngMappingEndingPts = new Point(0, 0);
            foreach (IWzImageProperty subprop in parent.WzProperties)
            {
                if (subprop is WzCanvasProperty)
                {
                    //WzVectorProperty origin = (WzVectorProperty)subprop["origin"];
                    WzPngProperty png = ((WzCanvasProperty)subprop).PngProperty;
                    if (png.Height > biggestPng.Y)
                        biggestPng.Y = png.Height;
                    if (png.Width > biggestPng.X)
                        biggestPng.X = png.Width;
                }
            }
            List<WzCanvasProperty> sortedProps = new List<WzCanvasProperty>();
            foreach (IWzImageProperty subprop in parent.WzProperties)
            {
                if (subprop is WzCanvasProperty)
                {
                    sortedProps.Add((WzCanvasProperty)subprop);
                    WzPngProperty png = ((WzCanvasProperty)subprop).PngProperty;
                    WzVectorProperty origin = (WzVectorProperty)subprop["origin"];
                    Point StartPoints = new Point(biggestPng.X - origin.X.Value, biggestPng.Y - origin.Y.Value);
                    Point PngMapppingEndingPts = new Point(StartPoints.X + png.Width, StartPoints.Y + png.Height);
                    if (StartPoints.X < SmallestEmptySpace.X)
                        SmallestEmptySpace.X = StartPoints.X;
                    if (StartPoints.Y < SmallestEmptySpace.Y)
                        SmallestEmptySpace.Y = StartPoints.Y;
                    if (PngMapppingEndingPts.X > MaximumPngMappingEndingPts.X)
                        MaximumPngMappingEndingPts.X = PngMapppingEndingPts.X;
                    if (PngMapppingEndingPts.Y > MaximumPngMappingEndingPts.Y)
                        MaximumPngMappingEndingPts.Y = PngMapppingEndingPts.Y;
                }
            }
            sortedProps.Sort(new Comparison<WzCanvasProperty>(PropertySorter));
/*            foreach (IWzImageProperty subprop in parent.WzProperties)
            {
                if (subprop is WzCanvasProperty)
                {
                    WzCompressedIntProperty delayProp = (WzCompressedIntProperty)subprop["delay"];
                    if (delayProp != null) delay = delayProp.Value;
                }
            }*/
/*            Brush bgcolor = null;
            switch (toolStripComboBox2.SelectedIndex)
            {
                case 0:
                    bgcolor = Brushes.Widthhite;
                    break;
                case 1:
                    bgcolor = Brushes.Black;
                    break;
                default:
                    bgcolor = Brushes.Black;
                    break;
            }*/

            for (int i = 0; i<sortedProps.Count; i++)
            {
                WzCanvasProperty subprop = sortedProps[i];
                if (i.ToString() != subprop.Name)
                {
                    Warning.Error("Something fucked up at animation builder, frame " + i.ToString());
                    return;
                }
                    Bitmap bmp = subprop.PngProperty.GetPNG(false);
                    WzVectorProperty origin = (WzVectorProperty)subprop["origin"];
//                    if (apng)
                        bmpList.Add(OptimizeBitmapTransparent(bmp, origin, biggestPng, SmallestEmptySpace, MaximumPngMappingEndingPts));
/*                    else
                        bmpList.Add(OptimizeBitmap(bmp, origin, biggestPng, SmallestEmptySpace, MaximumPngMappingEndingPts, bgcolor));*/
                WzCompressedIntProperty delayProp = (WzCompressedIntProperty)subprop["delay"];
                int delay =100;
                if (delayProp != null) delay = delayProp.Value;
                delayList.Add(delay);
                //}
            }
            if (apng)
            {
                //List<Frame> frameList = new List<Frame>();
                /*                List<int> delayList = new List<int>();
                                foreach (TreeNode subnode in parent.Nodes)
                                {
                                    if (subnode.Tag2 is PNG)
                                    {
                                        TreeNode delayNode = FindNodeInSubnodes(subnode, "delay");
                                        if (delayNode == null) delayList.Add(0);
                                        else delayList.Add((int)delayNode.Tag2);
                                    }
                                }
                                if (delayList.Count != bmp.Count)
                                {
                                    MessageBox.Show("Weird error, seems like there are more PNGs than delay values");
                                    return;
                                }*/
                Apng apngBuilder = new Apng();
                if (apngFirstFrame) apngBuilder.AddFrame(new Frame(CreateIncompatibilityFrame(new Size(bmpList[0].Width, bmpList[0].Height)),1,1));
                for (int i = 0; i < bmpList.Count; i++)
                    apngBuilder.AddFrame(new Frame(bmpList[i], getNumByDelay(delayList[i]), getDenByDelay(delayList[i])));
                apngBuilder.WriteApng(savePath, apngFirstFrame, true);
                //createapng(frameList, savePath);
            }
            else
            {
                AnimatedGifEncoder gifEncoder = new AnimatedGifEncoder();
                for (int i = 0; i < bmpList.Count; i++)
                    gifEncoder.AddFrame(new GifFrame(bmpList[i]) { Delay = delayList[i] / 10 });
                gifEncoder.WriteToFile(savePath);
            }
        }

        private static int getNumByDelay(int delay)
        {
            int num = delay;
            int den = 1000;
            while (num % 10 == 0 && num != 0)
            {
                num = num / 10;
                den = den / 10;
            }
            return num;
        }

        private static int getDenByDelay(int delay)
        {
            int num = delay;
            int den = 1000;
            while (num % 10 == 0 && num != 0)
            {
                num = num / 10;
                den = den / 10;
            }
            return den;
        }

        private static Bitmap CreateIncompatibilityFrame(Size frameSize)
        {
            Bitmap frame = new Bitmap(frameSize.Width, frameSize.Height);
            using (Graphics g = Graphics.FromImage(frame))
                g.DrawString("Your browser or image viewer is too OLD to view this image. Please download a newer browser such as Firefox.", System.Drawing.SystemFonts.MessageBoxFont, Brushes.Black, new Rectangle(0, 0, frame.Width, frame.Height));
            return frame;
        }

        /*private void createapng(List<SharpApng.Frame> imageFiles, string outputFilePath)
        {
            if (imageFiles.Count < 1) return;
            Apng apng = new Apng();
            Size size = new Size(imageFiles[0].Bitmap.Width, imageFiles[0].Bitmap.Height);
            Bitmap lolFrame = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(lolFrame))
            {
                g.DrawString("Your browser or image viewer is too OLD to view this image. Please download a newer browser such as Firefox.", System.Drawing.SystemFonts.DefaultFont, Brushes.Black, new Rectangle(0, 0, lolFrame.Width, lolFrame.Height));
            }
            apng.AddFrame(new SharpApng.Frame(lolFrame, 1, 1));
            foreach (SharpApng.Frame frame in imageFiles)
            {
                apng.AddFrame(frame);
            }
            apng.WriteApng(outputFilePath, true, true);
        }*/

/*        private void creategif(List<Bitmap> imageFiles, string outputFilePath, int delay)
        {
            int w = 0, h = 0;
            AnimatedGifEncoder e = new AnimatedGifEncoder();
            e.Start(outputFilePath);
            e.SetDelay(delay);
            //-1:no repeat,0:always repeat
            e.SetRepeat(0);
            e.SetQuality(Convert.ToInt32(toolStripTextBox1.TextBox.Text));
            foreach (Bitmap bitmap in imageFiles)
            {
                if (bitmap.Width > w)
                {
                    w = bitmap.Width;
                }
                if (bitmap.Height > h)
                {
                    h = bitmap.Height;
                }
            }
            e.SetSize(w, h);
            foreach (Bitmap bitmap in imageFiles)
            {
                e.AddFrame((Image)bitmap);
            }
            e.Finish();
        }*/
        #endregion
    }
}
