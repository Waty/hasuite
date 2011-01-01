namespace HaCreator.GUI.InstanceEditor
{
    partial class RopeInstanceEditor
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
            this.ropeBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ladderBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ufBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.xInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInput)).BeginInit();
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
            this.pathLabel.Size = new System.Drawing.Size(179, 16);
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
            this.xInput.Location = new System.Drawing.Point(79, 34);
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
            this.labelX1.Location = new System.Drawing.Point(63, 37);
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
            this.labelX2.Location = new System.Drawing.Point(63, 63);
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
            this.yInput.Location = new System.Drawing.Point(79, 60);
            this.yInput.Name = "yInput";
            this.yInput.ShowUpDown = true;
            this.yInput.Size = new System.Drawing.Size(50, 20);
            this.yInput.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.Location = new System.Drawing.Point(12, 128);
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
            this.cancelButton.Location = new System.Drawing.Point(94, 128);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(73, 28);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ropeBox
            // 
            this.ropeBox.AutoSize = true;
            // 
            // 
            // 
            this.ropeBox.BackgroundStyle.Class = "";
            this.ropeBox.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ropeBox.Location = new System.Drawing.Point(39, 86);
            this.ropeBox.Name = "ropeBox";
            this.ropeBox.Size = new System.Drawing.Size(49, 15);
            this.ropeBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ropeBox.TabIndex = 9;
            this.ropeBox.Text = "Rope";
            // 
            // ladderBox
            // 
            this.ladderBox.AutoSize = true;
            // 
            // 
            // 
            this.ladderBox.BackgroundStyle.Class = "";
            this.ladderBox.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ladderBox.Location = new System.Drawing.Point(94, 86);
            this.ladderBox.Name = "ladderBox";
            this.ladderBox.Size = new System.Drawing.Size(57, 15);
            this.ladderBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ladderBox.TabIndex = 10;
            this.ladderBox.Text = "Ladder";
            // 
            // ufBox
            // 
            this.ufBox.AutoSize = true;
            // 
            // 
            // 
            this.ufBox.BackgroundStyle.Class = "";
            this.ufBox.Location = new System.Drawing.Point(45, 107);
            this.ufBox.Name = "ufBox";
            this.ufBox.Size = new System.Drawing.Size(98, 15);
            this.ufBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ufBox.TabIndex = 11;
            this.ufBox.Text = "Upper Foothold";
            // 
            // RopeInstanceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 167);
            this.Controls.Add(this.ufBox);
            this.Controls.Add(this.ladderBox);
            this.Controls.Add(this.ropeBox);
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
            this.Name = "RopeInstanceEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.xInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInput)).EndInit();
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
        private DevComponents.DotNetBar.Controls.CheckBoxX ropeBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX ladderBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX ufBox;
    }
}