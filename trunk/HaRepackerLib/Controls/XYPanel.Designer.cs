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

namespace HaRepackerLib
{
    partial class XYPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xBox = new DevComponents.Editors.IntegerInput();
            this.yBox = new DevComponents.Editors.IntegerInput();
            ((System.ComponentModel.ISupportInitialize)(this.xBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // xBox
            // 
            this.xBox.AllowEmptyState = false;
            // 
            // 
            // 
            this.xBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.xBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.xBox.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.xBox.Location = new System.Drawing.Point(26, 3);
            this.xBox.Name = "xBox";
            this.xBox.ShowUpDown = true;
            this.xBox.Size = new System.Drawing.Size(59, 20);
            this.xBox.TabIndex = 4;
            // 
            // yBox
            // 
            this.yBox.AllowEmptyState = false;
            // 
            // 
            // 
            this.yBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.yBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.yBox.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.yBox.Location = new System.Drawing.Point(26, 29);
            this.yBox.Name = "yBox";
            this.yBox.ShowUpDown = true;
            this.yBox.Size = new System.Drawing.Size(59, 20);
            this.yBox.TabIndex = 5;
            // 
            // XYPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(90, 53);
            this.MinimumSize = new System.Drawing.Size(90, 53);
            this.Name = "XYPanel";
            this.Size = new System.Drawing.Size(90, 53);
            ((System.ComponentModel.ISupportInitialize)(this.xBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.Editors.IntegerInput xBox;
        private DevComponents.Editors.IntegerInput yBox;
    }
}
