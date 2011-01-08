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

namespace Footholds
{
    partial class DisplayMap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MapPBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MapPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MapPBox
            // 
            this.MapPBox.Location = new System.Drawing.Point(0, 0);
            this.MapPBox.Name = "MapPBox";
            this.MapPBox.Size = new System.Drawing.Size(705, 469);
            this.MapPBox.TabIndex = 0;
            this.MapPBox.TabStop = false;
            this.MapPBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MapPBox_MouseMove);
            this.MapPBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MapPBox_MouseClick);
            this.MapPBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MapPBox_MouseDown);
            this.MapPBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MapPBox_MouseUp);
            // 
            // DisplayMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(693, 461);
            this.Controls.Add(this.MapPBox);
            this.Name = "DisplayMap";
            this.ShowIcon = false;
            this.Text = "Map";
            this.Load += new System.EventHandler(this.DisplayMap_Load);
            this.Resize += new System.EventHandler(this.DisplayMap_Resize);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DisplayMap_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.MapPBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MapPBox;
    }
}