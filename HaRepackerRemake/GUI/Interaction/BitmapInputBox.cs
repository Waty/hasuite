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
using System.Drawing;
using System.Windows.Forms;

namespace HaRepacker.GUI.Interaction
{
    public partial class BitmapInputBox : Form
    {
        public static bool Show(string title, out string name, out Bitmap bmp)
        {
            BitmapInputBox form = new BitmapInputBox(title);
            bool result = form.ShowDialog() == DialogResult.OK;
            name = form.nameResult;
            bmp = form.bmpResult;
            return result;
        }

        private string nameResult = null;
        private Bitmap bmpResult = null;

        public BitmapInputBox(string title)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            Text = title;
        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                okButton_Click(null, null);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != null && nameBox.Text != "" && pathBox.Text != null && pathBox.Text != "" && pictureBox.Image != null)
            {
                nameResult = nameBox.Text;
                bmpResult = (Bitmap)pictureBox.Image;
                DialogResult = DialogResult.OK;
                Close();
            }
            else MessageBox.Show("Please enter valid input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog() { Title = "Select the image", Filter = "Images(*.jpg;*.bmp;*.png;*.gif;*.tiff)|*.jpg;*.bmp;*.png;*.gif;*.tiff" };
            if (dialog.ShowDialog() == DialogResult.OK) pathBox.Text = dialog.FileName;
        }

        private void pathBox_TextChanged(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }
            try { pictureBox.Image = Image.FromFile(pathBox.Text); }
            catch { }
        }
    }
}
