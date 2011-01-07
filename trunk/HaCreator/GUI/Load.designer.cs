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
    partial class Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load));
            this.loadButton = new DevComponents.DotNetBar.ButtonX();
            this.WZSelect = new System.Windows.Forms.RadioButton();
            this.XMLSelect = new System.Windows.Forms.RadioButton();
            this.XMLBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.minimapBox = new System.Windows.Forms.PictureBox();
            this.NewSelect = new System.Windows.Forms.RadioButton();
            this.newWidth = new DevComponents.Editors.IntegerInput();
            this.newHeight = new DevComponents.Editors.IntegerInput();
            this.label1 = new DevComponents.DotNetBar.LabelX();
            this.label2 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mapNotExist = new DevComponents.DotNetBar.LabelX();
            this.linkLabel = new DevComponents.DotNetBar.LabelX();
            this.searchBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.browseXML = new DevComponents.DotNetBar.ButtonX();
            this.mapNamesBox = new System.Windows.Forms.ListBox();
            this.newTab = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.minimapBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newHeight)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.loadButton.Location = new System.Drawing.Point(169, 290);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(200, 30);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load";
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // WZSelect
            // 
            this.WZSelect.AutoSize = true;
            this.WZSelect.Checked = true;
            this.WZSelect.Location = new System.Drawing.Point(11, 60);
            this.WZSelect.Name = "WZSelect";
            this.WZSelect.Size = new System.Drawing.Size(43, 17);
            this.WZSelect.TabIndex = 2;
            this.WZSelect.TabStop = true;
            this.WZSelect.Text = "WZ";
            this.WZSelect.UseVisualStyleBackColor = true;
            this.WZSelect.CheckedChanged += new System.EventHandler(this.selectionChanged);
            // 
            // XMLSelect
            // 
            this.XMLSelect.AutoSize = true;
            this.XMLSelect.Location = new System.Drawing.Point(11, 36);
            this.XMLSelect.Name = "XMLSelect";
            this.XMLSelect.Size = new System.Drawing.Size(47, 17);
            this.XMLSelect.TabIndex = 3;
            this.XMLSelect.Text = "XML";
            this.XMLSelect.UseVisualStyleBackColor = true;
            this.XMLSelect.CheckedChanged += new System.EventHandler(this.selectionChanged);
            // 
            // XMLBox
            // 
            // 
            // 
            // 
            this.XMLBox.Border.Class = "";
            this.XMLBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.XMLBox.Enabled = false;
            this.XMLBox.Location = new System.Drawing.Point(64, 35);
            this.XMLBox.Name = "XMLBox";
            this.XMLBox.Size = new System.Drawing.Size(158, 20);
            this.XMLBox.TabIndex = 5;
            this.XMLBox.Click += new System.EventHandler(this.XMLBox_Click);
            // 
            // minimapBox
            // 
            this.minimapBox.Location = new System.Drawing.Point(0, 0);
            this.minimapBox.Name = "minimapBox";
            this.minimapBox.Size = new System.Drawing.Size(262, 199);
            this.minimapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.minimapBox.TabIndex = 6;
            this.minimapBox.TabStop = false;
            // 
            // NewSelect
            // 
            this.NewSelect.AutoSize = true;
            this.NewSelect.Location = new System.Drawing.Point(11, 13);
            this.NewSelect.Name = "NewSelect";
            this.NewSelect.Size = new System.Drawing.Size(47, 17);
            this.NewSelect.TabIndex = 8;
            this.NewSelect.TabStop = true;
            this.NewSelect.Text = "New";
            this.NewSelect.UseVisualStyleBackColor = true;
            this.NewSelect.CheckedChanged += new System.EventHandler(this.selectionChanged);
            // 
            // newWidth
            // 
            // 
            // 
            // 
            this.newWidth.BackgroundStyle.Class = "DateTimeInputBackground";
            this.newWidth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.newWidth.Enabled = false;
            this.newWidth.Location = new System.Drawing.Point(64, 12);
            this.newWidth.Name = "newWidth";
            this.newWidth.Size = new System.Drawing.Size(45, 20);
            this.newWidth.TabIndex = 9;
            this.newWidth.Value = 800;
            // 
            // newHeight
            // 
            // 
            // 
            // 
            this.newHeight.BackgroundStyle.Class = "DateTimeInputBackground";
            this.newHeight.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.newHeight.Enabled = false;
            this.newHeight.Location = new System.Drawing.Point(169, 12);
            this.newHeight.Name = "newHeight";
            this.newHeight.Size = new System.Drawing.Size(41, 20);
            this.newHeight.TabIndex = 11;
            this.newHeight.Value = 800;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            // 
            // 
            // 
            this.label1.BackgroundStyle.Class = "";
            this.label1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label1.Location = new System.Drawing.Point(109, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Width    X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            // 
            // 
            // 
            this.label2.BackgroundStyle.Class = "";
            this.label2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label2.Location = new System.Drawing.Point(210, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Height";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.mapNotExist);
            this.panel1.Controls.Add(this.linkLabel);
            this.panel1.Controls.Add(this.minimapBox);
            this.panel1.Location = new System.Drawing.Point(284, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 199);
            this.panel1.TabIndex = 14;
            // 
            // mapNotExist
            // 
            this.mapNotExist.AutoSize = true;
            // 
            // 
            // 
            this.mapNotExist.BackgroundStyle.Class = "";
            this.mapNotExist.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mapNotExist.ForeColor = System.Drawing.Color.Red;
            this.mapNotExist.Location = new System.Drawing.Point(65, 96);
            this.mapNotExist.Name = "mapNotExist";
            this.mapNotExist.Size = new System.Drawing.Size(135, 15);
            this.mapNotExist.TabIndex = 19;
            this.mapNotExist.Text = "Map does not actually exist";
            this.mapNotExist.Visible = false;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            // 
            // 
            // 
            this.linkLabel.BackgroundStyle.Class = "";
            this.linkLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.linkLabel.ForeColor = System.Drawing.Color.Red;
            this.linkLabel.Location = new System.Drawing.Point(96, 96);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(67, 15);
            this.linkLabel.TabIndex = 18;
            this.linkLabel.Text = "Map is linked";
            this.linkLabel.Visible = false;
            // 
            // searchBox
            // 
            // 
            // 
            // 
            this.searchBox.Border.Class = "";
            this.searchBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.searchBox.Location = new System.Drawing.Point(64, 59);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(158, 20);
            this.searchBox.TabIndex = 15;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // browseXML
            // 
            this.browseXML.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.browseXML.Location = new System.Drawing.Point(228, 36);
            this.browseXML.Name = "browseXML";
            this.browseXML.Size = new System.Drawing.Size(36, 19);
            this.browseXML.TabIndex = 16;
            this.browseXML.Text = "...";
            this.browseXML.Click += new System.EventHandler(this.browseXML_Click);
            // 
            // mapNamesBox
            // 
            this.mapNamesBox.FormattingEnabled = true;
            this.mapNamesBox.Location = new System.Drawing.Point(11, 85);
            this.mapNamesBox.Name = "mapNamesBox";
            this.mapNamesBox.Size = new System.Drawing.Size(253, 199);
            this.mapNamesBox.TabIndex = 17;
            this.mapNamesBox.SelectedIndexChanged += new System.EventHandler(this.mapNamesBox_SelectedIndexChanged);
            // 
            // newTab
            // 
            this.newTab.AutoSize = true;
            // 
            // 
            // 
            this.newTab.BackgroundStyle.Class = "";
            this.newTab.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.newTab.Location = new System.Drawing.Point(284, 62);
            this.newTab.Name = "newTab";
            this.newTab.Size = new System.Drawing.Size(109, 15);
            this.newTab.TabIndex = 18;
            this.newTab.Text = "Load into new tab";
            this.newTab.Visible = false;
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 332);
            this.Controls.Add(this.newTab);
            this.Controls.Add(this.mapNamesBox);
            this.Controls.Add(this.browseXML);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newHeight);
            this.Controls.Add(this.newWidth);
            this.Controls.Add(this.NewSelect);
            this.Controls.Add(this.XMLBox);
            this.Controls.Add(this.XMLSelect);
            this.Controls.Add(this.WZSelect);
            this.Controls.Add(this.loadButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load";
            this.Load += new System.EventHandler(this.Load_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minimapBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newHeight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX loadButton;
        private System.Windows.Forms.RadioButton WZSelect;
        private System.Windows.Forms.RadioButton XMLSelect;
        private DevComponents.DotNetBar.Controls.TextBoxX XMLBox;
        private System.Windows.Forms.PictureBox minimapBox;
        private System.Windows.Forms.RadioButton NewSelect;
        private DevComponents.Editors.IntegerInput newWidth;
        private DevComponents.Editors.IntegerInput newHeight;
        private DevComponents.DotNetBar.LabelX label1;
        private DevComponents.DotNetBar.LabelX label2;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX searchBox;
        private DevComponents.DotNetBar.ButtonX browseXML;
        private System.Windows.Forms.ListBox mapNamesBox;
        private DevComponents.DotNetBar.LabelX linkLabel;
        private DevComponents.DotNetBar.LabelX mapNotExist;
        private DevComponents.DotNetBar.Controls.CheckBoxX newTab;
        private DevComponents.DotNetBar.StyleManager styleManager;
    }
}