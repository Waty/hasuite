/*  HaCreator - MapleStory Map Editor
 * Copyright (C) 2009, 2010  haha01haha01
   
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

namespace HaCreator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.FPSUpdater = new System.Windows.Forms.Timer(this.components);
            this.multiBoard = new HaCreator.MapEditor.MultiBoard();
            this.Tabs = new TabPages.PageCollection();
            this.SuspendLayout();
            // 
            // FPSUpdater
            // 
            this.FPSUpdater.Enabled = true;
            this.FPSUpdater.Interval = 1000;
            this.FPSUpdater.Tick += new System.EventHandler(this.FPSUpdater_Tick);
            // 
            // multiBoard
            // 
            this.multiBoard.Location = new System.Drawing.Point(184, 120);
            this.multiBoard.Name = "multiBoard";
            this.multiBoard.SelectedBoard = null;
            this.multiBoard.Size = new System.Drawing.Size(166, 120);
            this.multiBoard.TabIndex = 0;
            // 
            // Tabs
            // 
            this.Tabs.CurrentPage = null;
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.Size = new System.Drawing.Size(693, 388);
            this.Tabs.TabColor = System.Drawing.Color.LightSteelBlue;
            this.Tabs.TabIndex = 1;
            this.Tabs.Text = "pageCollection1";
            this.Tabs.TopMargin = 3;
            this.Tabs.CurrentPageChanged += new TabPages.PageCollection.CurrentPageChangedEventHandler(this.Tabs_CurrentPageChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 388);
            this.Controls.Add(this.multiBoard);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer FPSUpdater;
        private HaCreator.MapEditor.MultiBoard multiBoard;
        private TabPages.PageCollection Tabs;
    }
}

