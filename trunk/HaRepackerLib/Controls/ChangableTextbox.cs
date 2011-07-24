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

namespace HaRepackerLib
{
    public partial class ChangableTextbox : UserControl
    {
        public ChangableTextbox()
        {
            InitializeComponent();
        }

        public new string Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            if (this.Size.Height != textBox.Size.Height)
                this.Size = new Size(this.Size.Width, textBox.Size.Height);
            textBox.Location = new Point(0, 0);
            textBox.Size = new Size(this.Size.Width - applyButton.Width - applyButton.Margin.Left, textBox.Size.Height);
            applyButton.Location = new Point(textBox.Size.Width + textBox.Margin.Right, 0);
            base.OnSizeChanged(e);
        }

        public event EventHandler ButtonClicked;

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (ButtonClicked != null) ButtonClicked.Invoke(sender, e);
            applyButton.Enabled = false;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        public bool ButtonEnabled
        {
            get { return applyButton.Enabled; }
            set { applyButton.Enabled = value; }
        }
    }
}
