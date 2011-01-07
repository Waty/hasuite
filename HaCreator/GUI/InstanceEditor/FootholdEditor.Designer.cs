namespace HaCreator.GUI.InstanceEditor
{
    partial class FootholdEditor
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
            this.forceInt = new DevComponents.Editors.IntegerInput();
            this.forceEnable = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.pieceEnable = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.pieceInt = new DevComponents.Editors.IntegerInput();
            this.cantThroughBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.forbidFallDownBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.forceInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieceInt)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // forceInt
            // 
            // 
            // 
            // 
            this.forceInt.BackgroundStyle.Class = "DateTimeInputBackground";
            this.forceInt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.forceInt.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.forceInt.Location = new System.Drawing.Point(69, 12);
            this.forceInt.Name = "forceInt";
            this.forceInt.ShowUpDown = true;
            this.forceInt.Size = new System.Drawing.Size(123, 20);
            this.forceInt.TabIndex = 1;
            // 
            // forceEnable
            // 
            this.forceEnable.AutoSize = true;
            // 
            // 
            // 
            this.forceEnable.BackgroundStyle.Class = "";
            this.forceEnable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.forceEnable.Location = new System.Drawing.Point(12, 14);
            this.forceEnable.Name = "forceEnable";
            this.forceEnable.Size = new System.Drawing.Size(51, 15);
            this.forceEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.forceEnable.TabIndex = 2;
            this.forceEnable.Text = "Force";
            this.forceEnable.CheckedChanged += new System.EventHandler(this.forceEnable_CheckedChanged);
            // 
            // pieceEnable
            // 
            this.pieceEnable.AutoSize = true;
            // 
            // 
            // 
            this.pieceEnable.BackgroundStyle.Class = "";
            this.pieceEnable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pieceEnable.Location = new System.Drawing.Point(12, 40);
            this.pieceEnable.Name = "pieceEnable";
            this.pieceEnable.Size = new System.Drawing.Size(50, 15);
            this.pieceEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pieceEnable.TabIndex = 4;
            this.pieceEnable.Text = "Piece";
            // 
            // pieceInt
            // 
            // 
            // 
            // 
            this.pieceInt.BackgroundStyle.Class = "DateTimeInputBackground";
            this.pieceInt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pieceInt.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.pieceInt.Location = new System.Drawing.Point(69, 38);
            this.pieceInt.Name = "pieceInt";
            this.pieceInt.ShowUpDown = true;
            this.pieceInt.Size = new System.Drawing.Size(123, 20);
            this.pieceInt.TabIndex = 3;
            // 
            // cantThroughBox
            // 
            this.cantThroughBox.AutoSize = true;
            // 
            // 
            // 
            this.cantThroughBox.BackgroundStyle.Class = "";
            this.cantThroughBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cantThroughBox.Location = new System.Drawing.Point(12, 64);
            this.cantThroughBox.Name = "cantThroughBox";
            this.cantThroughBox.Size = new System.Drawing.Size(90, 15);
            this.cantThroughBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cantThroughBox.TabIndex = 5;
            this.cantThroughBox.Text = "Cant Through";
            // 
            // forbidFallDownBox
            // 
            this.forbidFallDownBox.AutoSize = true;
            // 
            // 
            // 
            this.forbidFallDownBox.BackgroundStyle.Class = "";
            this.forbidFallDownBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.forbidFallDownBox.Location = new System.Drawing.Point(108, 64);
            this.forbidFallDownBox.Name = "forbidFallDownBox";
            this.forbidFallDownBox.Size = new System.Drawing.Size(106, 15);
            this.forbidFallDownBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.forbidFallDownBox.TabIndex = 6;
            this.forbidFallDownBox.Text = "Forbid Fall Down";
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.Location = new System.Drawing.Point(33, 85);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(71, 26);
            this.okButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.cancelButton.Location = new System.Drawing.Point(110, 85);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(71, 26);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FootholdEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 123);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.forbidFallDownBox);
            this.Controls.Add(this.cantThroughBox);
            this.Controls.Add(this.pieceEnable);
            this.Controls.Add(this.pieceInt);
            this.Controls.Add(this.forceEnable);
            this.Controls.Add(this.forceInt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FootholdEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Foothold Editor";
            ((System.ComponentModel.ISupportInitialize)(this.forceInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieceInt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.Editors.IntegerInput forceInt;
        private DevComponents.DotNetBar.Controls.CheckBoxX forceEnable;
        private DevComponents.DotNetBar.Controls.CheckBoxX pieceEnable;
        private DevComponents.Editors.IntegerInput pieceInt;
        private DevComponents.DotNetBar.Controls.CheckBoxX cantThroughBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX forbidFallDownBox;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
    }
}