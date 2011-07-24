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
using MapleLib.WzLib.Serialization;
using HaRepackerLib.Controls;

namespace HaRepacker.GUI
{
    public partial class OptionsForm : Form
    {
        private HaRepackerMainPanel panel;

        public OptionsForm(HaRepackerMainPanel panel)
        {
            this.panel = panel;
            InitializeComponent();
            sortBox.Checked = panel.Sort;
            apngIncompEnable.Checked = UserSettings.UseApngIncompatibilityFrame;
            autoAssociateBox.Checked = UserSettings.AutoAssociate;
            if (UserSettings.DefaultXmlFolder != "") 
            { 
                defXmlFolderEnable.Checked = true; 
                defXmlFolderBox.Text = UserSettings.DefaultXmlFolder; 
            }
            indentBox.Value = UserSettings.Indentation;
            lineBreakBox.SelectedIndex = (int)UserSettings.LineBreakType;
            autoUpdate.Checked = UserSettings.AutoUpdate;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (indentBox.Value < 0) { Warning.Error("Indent must be above 0"); return; }
            panel.Sort = sortBox.Checked;
            UserSettings.UseApngIncompatibilityFrame = apngIncompEnable.Checked;
            UserSettings.AutoAssociate = autoAssociateBox.Checked;
            if (defXmlFolderEnable.Checked)
                UserSettings.DefaultXmlFolder = defXmlFolderBox.Text;
            else
                UserSettings.DefaultXmlFolder = "";
            UserSettings.Indentation = indentBox.Value;
            UserSettings.LineBreakType = (LineBreak)lineBreakBox.SelectedIndex;
            UserSettings.AutoUpdate = autoUpdate.Checked;
            Program.SettingsManager.Save();
            Close();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            SavedFolderBrowser.Show("Select default XML folder");
        }

        private void defXmlFolderEnable_CheckedChanged(object sender, EventArgs e)
        {
            browse.Enabled = defXmlFolderEnable.Checked;
            defXmlFolderBox.Enabled = defXmlFolderEnable.Checked;
        }
    }
}
