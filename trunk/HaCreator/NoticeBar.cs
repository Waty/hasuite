using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace NoticeBar
{
    public partial class NoticeBar : Form
    {
        private Color fg = Color.FromArgb(255, 0, 51, 101);
        private Color textColor = Color.White;
        private int fontSize = 30;
        DirectText[] notices;
        Bitmap noticeImage;
        byte[] recvdata = new byte[1024 * 1024];

        public NoticeBar()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque, true);
            InitNotices();
        }

        private void RunLoop(object sender, EventArgs e)
        {
            foreach (DirectText notice in notices)
            {
                if (IsNoticeVisible(notice.y, notice.text))
                {
                    notice.y++;
                }
                else
                {
                    notice.y = 0;
                }
            }
        }

        private void InitNotices()
        {
            string[] lines = new string[] { "asadf", "bdafg", "Qwer", "qrwe" };
            notices = new DirectText[lines.Length];
            for (int i = 0; i < lines.Length; i++)
                notices[i] = new DirectText(lines[i], i * 500, this);
        }

        private void DrawRTLImage(Graphics processor, Bitmap image, Point location)
        {
            processor.DrawImage(image, new Point(location.X - image.Width + 1, location.Y));
        }

        private Bitmap CreateBitmapImage(string sImageText)
        {
            Bitmap objBmpImage = new Bitmap(1, 1);
            int intWidth = 0;
            int intHeight = 0;
            Font objFont = new Font("Arial", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            Graphics objGraphics = Graphics.FromImage(objBmpImage);
            intWidth = (int)objGraphics.MeasureString(sImageText, objFont).Width;
            intHeight = (int)objGraphics.MeasureString(sImageText, objFont).Height;
            objBmpImage = new Bitmap(objBmpImage, new Size(intWidth, intHeight));
            objGraphics = Graphics.FromImage(objBmpImage);
            objGraphics.Clear(fg);
            objGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            objGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            StringFormat sf = new StringFormat();
            sf.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
            sf.FormatFlags |= StringFormatFlags.NoWrap;
            objGraphics.DrawString(sImageText, objFont, new SolidBrush(textColor), new RectangleF(0, 0, objBmpImage.Width + 1, Height), sf);
            objGraphics.Flush();
            return objBmpImage;
        }

        private void DrawRTLText(Graphics processor, string text, int x)
        {
            Bitmap img = CreateBitmapImage(text);
            DrawRTLImage(processor, noticeImage, new Point(x, (Height / 2) - (noticeImage.Height / 2)));
        }

        private int CalculateStringWidth(string text)
        {
            Font objFont = new Font("Arial", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            Bitmap objBmpImage = new Bitmap(1, 1);
            Graphics objGraphics = Graphics.FromImage(objBmpImage);
            return (int)objGraphics.MeasureString(text, objFont).Width;
        }

        private int CalculateStringHeight(string text)
        {
            Font objFont = new Font("Arial", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            Bitmap objBmpImage = new Bitmap(1, 1);
            Graphics objGraphics = Graphics.FromImage(objBmpImage);
            return (int)objGraphics.MeasureString(text, objFont).Height;
        }

        private void NoticeBar_Paint(object sender, PaintEventArgs e)
        {
            Bitmap image = new Bitmap(Width, Height);
            Graphics graphics = Graphics.FromImage(image);
            graphics.Clear(fg);
            foreach (DirectText notice in notices)
            {
                Bitmap noticeImage = CreateBitmapImage(notice.text);
                graphics.DrawImage(noticeImage, (Width / 2) - (noticeImage.Width / 2), notice.y - noticeImage.Height);
            }
            e.Graphics.DrawImage(image, new Point(0, 0));
        }

        private class DirectText
        {
            public string text;
            public int y;
            public NoticeBar parent;

            public DirectText(string text, int y, NoticeBar parent)
            {
                this.text = text;
                this.y = y;
                this.parent = parent;
            }

            public void Draw(Graphics processor)
            {
                if (parent.IsNoticeVisible(y, text))
                    parent.DrawRTLText(processor, text, y);
            }
        }

        private bool IsNoticeVisible(int y, string text)
        {
            if (y - CalculateStringHeight(text) <= Width && y >= 0)
                return true;
            return false;
        }

/*        delegate void SetBoundsDelegate(int x, int y, int width, int height);

        private void NoticeBar_Load(object sender, EventArgs e)
        {
            if (InvokeRequired)
                Invoke(new SetBoundsDelegate(SetBounds), new object[] { 0, Screen.PrimaryScreen.Bounds.Height - 50, Screen.PrimaryScreen.Bounds.Width, 50 });
            else
                SetBounds(0, Screen.PrimaryScreen.Bounds.Height - 50, Screen.PrimaryScreen.Bounds.Width, 50);
        }*/
    }
}
