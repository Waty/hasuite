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
    public partial class Edit : Form
    {
        public List<Object> settings;
        public FootHold.Foothold fh;
        public Edit()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            PrevLbl.Text = ((WzCompressedIntProperty)fh.Data["prev"]).Value.ToString();
            NextLbl.Text = ((WzCompressedIntProperty)fh.Data["next"]).Value.ToString();
            if (!(bool)settings.ToArray()[1])
                PrevTBox.Text = ((WzCompressedIntProperty)fh.Data["prev"]).Value.ToString();
            else
                PrevTBox.Text = settings.ToArray()[0].ToString();
            if (!(bool)settings.ToArray()[3])
                NextTBox.Text = ((WzCompressedIntProperty)fh.Data["next"]).Value.ToString();
            else
                NextTBox.Text = settings.ToArray()[2].ToString();
            if (!(bool)settings.ToArray()[5])
                try {ForceTBox.Text = ((WzCompressedIntProperty)fh.Data["force"]).Value.ToString();} catch { }
            else
                ForceTBox.Text = settings.ToArray()[4].ToString();
            try { ForceLbl.Text = ((WzCompressedIntProperty)fh.Data["force"]).Value.ToString(); }
            catch { ForceLbl.Text = "None"; }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (PrevTBox.Text != "")
                {
                    ((WzCompressedIntProperty)fh.Data["prev"]).Value = int.Parse(PrevTBox.Text);
                    fh.Data["prev"].ParentImage.Changed = true;
                }
                if (NextTBox.Text != "")
                {
                    ((WzCompressedIntProperty)fh.Data["next"]).Value = int.Parse(NextTBox.Text);
                    fh.Data["next"].ParentImage.Changed = true;
                }

                if (ForceTBox.Text != "")
                {
                    if (ForceLbl.Text == "None")
                    {
                        WzCompressedIntProperty forceProperty = new WzCompressedIntProperty("force", int.Parse(ForceTBox.Text));
                        fh.Data.AddProperty(forceProperty);
                        fh.Data.ParentImage.Changed = true;
                    }
                    else
                    {
                        ((WzCompressedIntProperty)fh.Data["force"]).Value = int.Parse(ForceTBox.Text);
                        fh.Data["force"].ParentImage.Changed = true;
                    }
                }
                this.Close();
            }
            catch { MessageBox.Show("Input was invalid.\n Please provide valid values before confirming.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}