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
using HaRepackerLib;
using MapleLib.WzLib;
using HaRepackerLib.Controls;

namespace HaRepacker.GUI
{
    public partial class NewForm : Form
    {
        private HaRepackerMainPanel panel;

        public NewForm(HaRepackerMainPanel panel)
        {
            this.panel = panel;
            InitializeComponent();
            encryptionBox.SelectedIndex = (int)ApplicationSettings.MapleVersion;
            versionBox.Value = 1;
        }

        private void regBox_CheckedChanged(object sender, EventArgs e)
        {
            copyrightBox.Enabled = regBox.Checked;
            versionBox.Enabled = regBox.Checked;
            nameBox.Enabled = regBox.Checked;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (regBox.Checked)
            {
                WzFile file = new WzFile((short)versionBox.Value, (WzMapleVersion)encryptionBox.SelectedIndex);
                file.Header.Copyright = copyrightBox.Text;
                file.Header.RecalculateFileStart();
                file.Name = nameBox.Text + ".wz";
                file.WzDirectory.Name = nameBox.Text + ".wz";
                panel.DataTree.Nodes.Add(new WzNode(file));
            }
            else
                new ListEditor(null, (WzMapleVersion)encryptionBox.SelectedIndex).Show();
            Close();
        }
    }
}
