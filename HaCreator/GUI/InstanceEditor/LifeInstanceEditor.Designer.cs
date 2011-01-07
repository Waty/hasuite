namespace HaCreator.GUI.InstanceEditor
{
    partial class LifeInstanceEditor
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
            this.pathLabel = new DevComponents.DotNetBar.LabelX();
            this.xInput = new DevComponents.Editors.IntegerInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.yInput = new DevComponents.Editors.IntegerInput();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.rx0Box = new DevComponents.Editors.IntegerInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.rx1Box = new DevComponents.Editors.IntegerInput();
            this.mobTimeBox = new DevComponents.Editors.IntegerInput();
            this.mobTimeEnable = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.limitedNameEnable = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.typeEnable = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.infoEnable = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.teamEnable = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.hideBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.infoBox = new DevComponents.Editors.IntegerInput();
            this.teamBox = new DevComponents.Editors.IntegerInput();
            this.typeBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.limitedNameBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.xInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rx0Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rx1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobTimeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBox)).BeginInit();
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
            this.pathLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pathLabel.Location = new System.Drawing.Point(0, 12);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(309, 37);
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
            this.xInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.xInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.xInput.Location = new System.Drawing.Point(39, 52);
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
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(23, 55);
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
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(23, 81);
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
            this.yInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.yInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.yInput.Location = new System.Drawing.Point(39, 78);
            this.yInput.Name = "yInput";
            this.yInput.ShowUpDown = true;
            this.yInput.Size = new System.Drawing.Size(50, 20);
            this.yInput.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.Location = new System.Drawing.Point(103, 193);
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
            this.cancelButton.Location = new System.Drawing.Point(185, 193);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(73, 28);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(14, 107);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(24, 15);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "RX0";
            // 
            // rx0Box
            // 
            this.rx0Box.AllowEmptyState = false;
            // 
            // 
            // 
            this.rx0Box.BackgroundStyle.Class = "DateTimeInputBackground";
            this.rx0Box.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rx0Box.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.rx0Box.Location = new System.Drawing.Point(38, 104);
            this.rx0Box.Name = "rx0Box";
            this.rx0Box.ShowUpDown = true;
            this.rx0Box.Size = new System.Drawing.Size(50, 20);
            this.rx0Box.TabIndex = 9;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(15, 133);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(24, 15);
            this.labelX4.TabIndex = 12;
            this.labelX4.Text = "RX1";
            // 
            // rx1Box
            // 
            this.rx1Box.AllowEmptyState = false;
            // 
            // 
            // 
            this.rx1Box.BackgroundStyle.Class = "DateTimeInputBackground";
            this.rx1Box.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rx1Box.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.rx1Box.Location = new System.Drawing.Point(38, 130);
            this.rx1Box.Name = "rx1Box";
            this.rx1Box.ShowUpDown = true;
            this.rx1Box.Size = new System.Drawing.Size(50, 20);
            this.rx1Box.TabIndex = 11;
            // 
            // mobTimeBox
            // 
            this.mobTimeBox.AllowEmptyState = false;
            // 
            // 
            // 
            this.mobTimeBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.mobTimeBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mobTimeBox.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.mobTimeBox.Enabled = false;
            this.mobTimeBox.Location = new System.Drawing.Point(227, 50);
            this.mobTimeBox.Name = "mobTimeBox";
            this.mobTimeBox.ShowUpDown = true;
            this.mobTimeBox.Size = new System.Drawing.Size(50, 20);
            this.mobTimeBox.TabIndex = 13;
            // 
            // mobTimeEnable
            // 
            this.mobTimeEnable.AutoSize = true;
            // 
            // 
            // 
            this.mobTimeEnable.BackgroundStyle.Class = "";
            this.mobTimeEnable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mobTimeEnable.Location = new System.Drawing.Point(131, 52);
            this.mobTimeEnable.Name = "mobTimeEnable";
            this.mobTimeEnable.Size = new System.Drawing.Size(71, 15);
            this.mobTimeEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mobTimeEnable.TabIndex = 15;
            this.mobTimeEnable.Text = "Mob Time";
            this.mobTimeEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBoxCheckChanged);
            // 
            // limitedNameEnable
            // 
            this.limitedNameEnable.AutoSize = true;
            // 
            // 
            // 
            this.limitedNameEnable.BackgroundStyle.Class = "";
            this.limitedNameEnable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.limitedNameEnable.Location = new System.Drawing.Point(131, 156);
            this.limitedNameEnable.Name = "limitedNameEnable";
            this.limitedNameEnable.Size = new System.Drawing.Size(90, 15);
            this.limitedNameEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.limitedNameEnable.TabIndex = 16;
            this.limitedNameEnable.Text = "Limited Name";
            this.limitedNameEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBoxCheckChanged);
            // 
            // typeEnable
            // 
            this.typeEnable.AutoSize = true;
            // 
            // 
            // 
            this.typeEnable.BackgroundStyle.Class = "";
            this.typeEnable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.typeEnable.Location = new System.Drawing.Point(131, 131);
            this.typeEnable.Name = "typeEnable";
            this.typeEnable.Size = new System.Drawing.Size(47, 15);
            this.typeEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.typeEnable.TabIndex = 17;
            this.typeEnable.Text = "Type";
            this.typeEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBoxCheckChanged);
            // 
            // infoEnable
            // 
            this.infoEnable.AutoSize = true;
            // 
            // 
            // 
            this.infoEnable.BackgroundStyle.Class = "";
            this.infoEnable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.infoEnable.Location = new System.Drawing.Point(131, 79);
            this.infoEnable.Name = "infoEnable";
            this.infoEnable.Size = new System.Drawing.Size(41, 15);
            this.infoEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.infoEnable.TabIndex = 18;
            this.infoEnable.Text = "Info";
            this.infoEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBoxCheckChanged);
            // 
            // teamEnable
            // 
            this.teamEnable.AutoSize = true;
            // 
            // 
            // 
            this.teamEnable.BackgroundStyle.Class = "";
            this.teamEnable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.teamEnable.Location = new System.Drawing.Point(131, 105);
            this.teamEnable.Name = "teamEnable";
            this.teamEnable.Size = new System.Drawing.Size(51, 15);
            this.teamEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.teamEnable.TabIndex = 19;
            this.teamEnable.Text = "Team";
            this.teamEnable.CheckedChanged += new System.EventHandler(this.enablingCheckBoxCheckChanged);
            // 
            // hideBox
            // 
            this.hideBox.AutoSize = true;
            // 
            // 
            // 
            this.hideBox.BackgroundStyle.Class = "";
            this.hideBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hideBox.Location = new System.Drawing.Point(38, 156);
            this.hideBox.Name = "hideBox";
            this.hideBox.Size = new System.Drawing.Size(45, 15);
            this.hideBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.hideBox.TabIndex = 20;
            this.hideBox.Text = "Hide";
            // 
            // infoBox
            // 
            this.infoBox.AllowEmptyState = false;
            // 
            // 
            // 
            this.infoBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.infoBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.infoBox.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.infoBox.Enabled = false;
            this.infoBox.Location = new System.Drawing.Point(227, 76);
            this.infoBox.Name = "infoBox";
            this.infoBox.ShowUpDown = true;
            this.infoBox.Size = new System.Drawing.Size(50, 20);
            this.infoBox.TabIndex = 21;
            // 
            // teamBox
            // 
            this.teamBox.AllowEmptyState = false;
            // 
            // 
            // 
            this.teamBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.teamBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.teamBox.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.teamBox.Enabled = false;
            this.teamBox.Location = new System.Drawing.Point(227, 102);
            this.teamBox.Name = "teamBox";
            this.teamBox.ShowUpDown = true;
            this.teamBox.Size = new System.Drawing.Size(50, 20);
            this.teamBox.TabIndex = 22;
            // 
            // typeBox
            // 
            // 
            // 
            // 
            this.typeBox.Border.Class = "TextBoxBorder";
            this.typeBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.typeBox.Enabled = false;
            this.typeBox.Location = new System.Drawing.Point(227, 128);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(63, 20);
            this.typeBox.TabIndex = 23;
            // 
            // limitedNameBox
            // 
            // 
            // 
            // 
            this.limitedNameBox.Border.Class = "TextBoxBorder";
            this.limitedNameBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.limitedNameBox.Enabled = false;
            this.limitedNameBox.Location = new System.Drawing.Point(227, 154);
            this.limitedNameBox.Name = "limitedNameBox";
            this.limitedNameBox.Size = new System.Drawing.Size(63, 20);
            this.limitedNameBox.TabIndex = 24;
            // 
            // LifeInstanceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 233);
            this.Controls.Add(this.limitedNameBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.teamBox);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.hideBox);
            this.Controls.Add(this.teamEnable);
            this.Controls.Add(this.infoEnable);
            this.Controls.Add(this.typeEnable);
            this.Controls.Add(this.limitedNameEnable);
            this.Controls.Add(this.mobTimeEnable);
            this.Controls.Add(this.mobTimeBox);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.rx1Box);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.rx0Box);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.yInput);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.xInput);
            this.Controls.Add(this.pathLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LifeInstanceEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.xInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rx0Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rx1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobTimeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBox)).EndInit();
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
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.IntegerInput rx0Box;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.IntegerInput rx1Box;
        private DevComponents.Editors.IntegerInput mobTimeBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX mobTimeEnable;
        private DevComponents.DotNetBar.Controls.CheckBoxX limitedNameEnable;
        private DevComponents.DotNetBar.Controls.CheckBoxX typeEnable;
        private DevComponents.DotNetBar.Controls.CheckBoxX infoEnable;
        private DevComponents.DotNetBar.Controls.CheckBoxX teamEnable;
        private DevComponents.DotNetBar.Controls.CheckBoxX hideBox;
        private DevComponents.Editors.IntegerInput infoBox;
        private DevComponents.Editors.IntegerInput teamBox;
        private DevComponents.DotNetBar.Controls.TextBoxX typeBox;
        private DevComponents.DotNetBar.Controls.TextBoxX limitedNameBox;
    }
}