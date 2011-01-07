namespace HaCreator.GUI.InstanceEditor
{
    partial class ReactorInstanceEditor
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
            this.styleManager = new DevComponents.DotNetBar.StyleManager();
            this.pathLabel = new DevComponents.DotNetBar.LabelX();
            this.xInput = new DevComponents.Editors.IntegerInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.yInput = new DevComponents.Editors.IntegerInput();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.nameBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.useName = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.timeBox = new DevComponents.Editors.IntegerInput();
            ((System.ComponentModel.ISupportInitialize)(this.xInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // pathLabel
            // 
            // 
            // 
            // 
            this.pathLabel.BackgroundStyle.Class = "";
            this.pathLabel.Location = new System.Drawing.Point(0, 12);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(179, 37);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "labelX1";
            this.pathLabel.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // xInput
            // 
            this.xInput.AllowEmptyState = false;
            // 
            // 
            // 
            this.xInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.xInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.xInput.Location = new System.Drawing.Point(79, 52);
            this.xInput.Name = "xInput";
            this.xInput.ShowUpDown = true;
            this.xInput.Size = new System.Drawing.Size(50, 20);
            this.xInput.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(63, 55);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(10, 15);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "X";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Location = new System.Drawing.Point(63, 81);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(10, 15);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Y";
            // 
            // yInput
            // 
            this.yInput.AllowEmptyState = false;
            // 
            // 
            // 
            this.yInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.yInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.yInput.Location = new System.Drawing.Point(79, 78);
            this.yInput.Name = "yInput";
            this.yInput.ShowUpDown = true;
            this.yInput.Size = new System.Drawing.Size(50, 20);
            this.yInput.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.Location = new System.Drawing.Point(12, 156);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(76, 28);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Location = new System.Drawing.Point(94, 156);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(73, 28);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameBox
            // 
            // 
            // 
            // 
            this.nameBox.Border.Class = "TextBoxBorder";
            this.nameBox.Location = new System.Drawing.Point(50, 104);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(93, 20);
            this.nameBox.TabIndex = 9;
            // 
            // useName
            // 
            // 
            // 
            // 
            this.useName.BackgroundStyle.Class = "";
            this.useName.Checked = true;
            this.useName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useName.CheckValue = "Y";
            this.useName.Location = new System.Drawing.Point(149, 106);
            this.useName.Name = "useName";
            this.useName.Size = new System.Drawing.Size(18, 18);
            this.useName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.useName.TabIndex = 10;
            this.useName.CheckedChanged += new System.EventHandler(this.useName_CheckedChanged);
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.Location = new System.Drawing.Point(12, 105);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(32, 15);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "Name";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.Location = new System.Drawing.Point(12, 133);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(27, 15);
            this.labelX3.TabIndex = 13;
            this.labelX3.Text = "Time";
            // 
            // timeBox
            // 
            this.timeBox.AllowEmptyState = false;
            // 
            // 
            // 
            this.timeBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.timeBox.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.timeBox.Location = new System.Drawing.Point(50, 130);
            this.timeBox.MinValue = 0;
            this.timeBox.Name = "timeBox";
            this.timeBox.ShowUpDown = true;
            this.timeBox.Size = new System.Drawing.Size(93, 20);
            this.timeBox.TabIndex = 14;
            // 
            // ReactorInstanceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 196);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.useName);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.yInput);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.xInput);
            this.Controls.Add(this.pathLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReactorInstanceEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.xInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.DotNetBar.LabelX pathLabel;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.IntegerInput xInput;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.IntegerInput yInput;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.Controls.TextBoxX nameBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX useName;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.IntegerInput timeBox;
    }
}