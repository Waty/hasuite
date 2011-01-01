/*  HaRepacker Foothold Mapper - MapleStory Map + Foothold Renderer and Editor
 * Copyright (C) 2009, 2010  haha01haha01 and Odecey
   
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
using System.Windows.Forms;
using MapleLib.WzLib.WzProperties;

namespace Footholds
{
    public partial class EditPortals : Form
    {
        public List<Object> Settings;
        public Portals.Portal portal;
        public EditPortals()
        {
            InitializeComponent();
        }

        private void EditPortals_Load(object sender, EventArgs e)
        {
            TypeLbl.Text = ((WzCompressedIntProperty)portal.Data["pt"]).Value.ToString();
            DestLbl.Text = ((WzCompressedIntProperty)portal.Data["tm"]).Value.ToString();
            XPosLbl.Text = ((WzCompressedIntProperty)portal.Data["x"]).Value.ToString();
            YPosLbl.Text = ((WzCompressedIntProperty)portal.Data["y"]).Value.ToString();
            if (!(bool)Settings.ToArray()[11])
                TypeTBox.Text = ((WzCompressedIntProperty)portal.Data["pt"]).Value.ToString();
            else
                TypeTBox.Text = Settings.ToArray()[10].ToString();
            if (!(bool)Settings.ToArray()[7])
                XTBox.Text = ((WzCompressedIntProperty)portal.Data["x"]).Value.ToString();
            else
                XTBox.Text = Settings.ToArray()[6].ToString();
            if (!(bool)Settings.ToArray()[9])
                YTBox.Text = ((WzCompressedIntProperty)portal.Data["y"]).Value.ToString();
            else
                YTBox.Text = Settings.ToArray()[8].ToString();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TypeTBox.Text != "")
                {
                    ((WzCompressedIntProperty)portal.Data["pt"]).Value = int.Parse(TypeTBox.Text);
                    portal.Data["pt"].ParentImage.Changed = true;
                }
                if (XTBox.Text != "")
                {
                    ((WzCompressedIntProperty)portal.Data["x"]).Value = int.Parse(XTBox.Text);
                    portal.Data["x"].ParentImage.Changed = true;
                }
                if (YTBox.Text != "")
                {
                    ((WzCompressedIntProperty)portal.Data["y"]).Value = int.Parse(YTBox.Text);
                    portal.Data["y"].ParentImage.Changed = true;
                }
            }
            catch (FormatException) { MessageBox.Show("Input was invalid.\nPlease provide valid values before confirming.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            this.Close();

        }
    }
}