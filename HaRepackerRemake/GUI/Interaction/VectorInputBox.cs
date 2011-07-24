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
    public partial class VectorInputBox : Form
    {
        public static bool Show(string title, out string name, out Point? pt)
        {
            VectorInputBox form = new VectorInputBox(title);
            bool result = form.ShowDialog() == DialogResult.OK;
            name = form.nameResult;
            pt = form.pointResult;
            return result;
        }

        private string nameResult = null;
        private Point? pointResult = null;

        public VectorInputBox(string title)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            Text = title;
        }

        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                okButton_Click(null, null);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int x = xBox.Value;
            int y = yBox.Value;
            nameResult = resultBox.Text;
            pointResult = new Point(x, y);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
