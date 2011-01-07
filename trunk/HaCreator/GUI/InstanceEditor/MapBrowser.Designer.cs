namespace HaCreator.GUI.InstanceEditor
{
    partial class MapBrowser
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
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.mapNamesBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mapNotExist = new DevComponents.DotNetBar.LabelX();
            this.linkLabel = new DevComponents.DotNetBar.LabelX();
            this.minimapBox = new System.Windows.Forms.PictureBox();
            this.loadButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.searchBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimapBox)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // mapNamesBox
            // 
            this.mapNamesBox.FormattingEnabled = true;
            this.mapNamesBox.Location = new System.Drawing.Point(12, 38);
            this.mapNamesBox.Name = "mapNamesBox";
            this.mapNamesBox.Size = new System.Drawing.Size(253, 199);
            this.mapNamesBox.TabIndex = 19;
            this.mapNamesBox.SelectedIndexChanged += new System.EventHandler(this.mapNamesBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.mapNotExist);
            this.panel1.Controls.Add(this.linkLabel);
            this.panel1.Controls.Add(this.minimapBox);
            this.panel1.Location = new System.Drawing.Point(285, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 199);
            this.panel1.TabIndex = 18;
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
            this.linkLabel.ForeColor = System.Drawing.Color.Yellow;
            this.linkLabel.Location = new System.Drawing.Point(96, 96);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(67, 15);
            this.linkLabel.TabIndex = 18;
            this.linkLabel.Text = "Map is linked";
            this.linkLabel.Visible = false;
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
            // loadButton
            // 
            this.loadButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.loadButton.Location = new System.Drawing.Point(65, 243);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(200, 30);
            this.loadButton.TabIndex = 20;
            this.loadButton.Text = "OK";
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.Location = new System.Drawing.Point(285, 243);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(200, 30);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // searchBox
            // 
            // 
            // 
            // 
            this.searchBox.Border.Class = "TextBoxBorder";
            this.searchBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.searchBox.Location = new System.Drawing.Point(12, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(253, 20);
            this.searchBox.TabIndex = 23;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // MapBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 288);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.mapNamesBox);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Map Browser";
            this.Load += new System.EventHandler(this.MapBrowser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimapBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager;
        private System.Windows.Forms.ListBox mapNamesBox;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX mapNotExist;
        private DevComponents.DotNetBar.LabelX linkLabel;
        private System.Windows.Forms.PictureBox minimapBox;
        private DevComponents.DotNetBar.ButtonX loadButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.Controls.TextBoxX searchBox;
    }
}