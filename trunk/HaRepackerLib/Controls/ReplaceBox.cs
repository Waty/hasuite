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
using System.Windows.Forms;

namespace HaRepackerLib
{
    public enum ReplaceResult
    {
        Yes,
        No,
        YesToAll,
        NoToAll
    }

    public partial class ReplaceBox : Form
    {
        public ReplaceResult result = ReplaceResult.No;

        public ReplaceBox(string name)
        {
            InitializeComponent();
            label1.Text = "The node \"" + name + "\" already exists. Do you want it to be replaced?";
        }

        private void ReplaceBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            result = ReplaceResult.Yes;
            FormClosing -= ReplaceBox_FormClosing;
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            result = ReplaceResult.No;
            FormClosing -= ReplaceBox_FormClosing;
            Close();
        }

        private void btnYestoall_Click(object sender, EventArgs e)
        {
            result = ReplaceResult.YesToAll;
            FormClosing -= ReplaceBox_FormClosing;
            Close();
        }

        private void btnNotoall_Click(object sender, EventArgs e)
        {
            result = ReplaceResult.NoToAll;
            FormClosing -= ReplaceBox_FormClosing;
            Close();
        }
    }
}
