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
using MapleLib.WzLib;
using MapleLib.WzLib.WzProperties;
using System.IO;
using HaRepackerLib;
using HaRepackerLib.Controls;

namespace HaRepacker.GUI
{
    public partial class SaveForm : Form
    {
        private WzNode wzNode;
        private WzFile wzf;
        public string path;
        HaRepackerMainPanel panel;
        
        public SaveForm(HaRepackerMainPanel panel, WzNode wzNode)
        {
            InitializeComponent();
            this.wzNode = wzNode;
            this.wzf = (WzFile)wzNode.Tag;
            this.panel = panel;
        }

        public void PrepareAllImgs(WzDirectory dir)
        {
            foreach (WzImage img in dir.WzImages)
                img.Changed = true;
            foreach (WzDirectory subdir in dir.WzDirectories)
                PrepareAllImgs(subdir);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (versionBox.Value < 0) { Warning.Error("Version must be above 0"); return; }
            SaveFileDialog dialog = new SaveFileDialog() { Title = "Select where to save the file", Filter = "WZ Files(*.wz)|*.wz" };
            if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            if (wzf is WzFile && wzf.MapleVersion != (WzMapleVersion)encryptionBox.SelectedIndex)
                PrepareAllImgs(((WzFile)wzf).WzDirectory);
            wzf.MapleVersion = (WzMapleVersion)encryptionBox.SelectedIndex;
            if (wzf is WzFile)
                ((WzFile)wzf).Version = (short)versionBox.Value;
            if (wzf.FilePath != null && wzf.FilePath.ToLower() == dialog.FileName.ToLower())
            {
                wzf.SaveToDisk(dialog.FileName + "$tmp");
                wzNode.Delete();
                File.Delete(dialog.FileName);
                File.Move(dialog.FileName + "$tmp", dialog.FileName);
            }
            else
            {
                wzf.SaveToDisk(dialog.FileName);
                wzNode.Delete();
            }
            Program.WzMan.LoadWzFile(dialog.FileName, (WzMapleVersion)encryptionBox.SelectedIndex, panel);
            Close();
        }

        private void SaveForm_Load(object sender, EventArgs e)
        {
            encryptionBox.SelectedIndex = (int)wzf.MapleVersion;
            versionBox.Value = wzf.Version;
        }
    }
}
