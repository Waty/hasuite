﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HaCreator.CustomControls
{
    public partial class ScrollablePictureBox : UserControl
    {
        public ScrollablePictureBox()
        {
            InitializeComponent();
        }

        private void ScrollablePictureBox_SizeChanged(object sender, EventArgs e)
        {
            if (Width * Height == 0) return;
            AutoScrollPosition = new Point();
            pictureBox.Location = new Point();
            pictureBox.Size = pictureBox.Image == null ? new Size(0, 0) : pictureBox.Image.Size;
        }

        public Bitmap Image
        {
            get { return (Bitmap)pictureBox.Image; }
            set { pictureBox.Image = value; }
        }
    }
}