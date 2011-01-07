namespace HaCreator.GUI.InstanceEditor
{
    partial class PortalInstanceEditor
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
            this.xInput = new DevComponents.Editors.IntegerInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.yInput = new DevComponents.Editors.IntegerInput();
            this.okButton = new DevComponents.DotNetBar.ButtonX();
            this.cancelButton = new DevComponents.DotNetBar.ButtonX();
            this.ptComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ptLabel = new DevComponents.DotNetBar.LabelX();
            this.pnLabel = new DevComponents.DotNetBar.LabelX();
            this.pnBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tmBox = new DevComponents.Editors.IntegerInput();
            this.tmLabel = new DevComponents.DotNetBar.LabelX();
            this.btnBrowseMap = new DevComponents.DotNetBar.ButtonX();
            this.thisMap = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tnBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tnLabel = new DevComponents.DotNetBar.LabelX();
            this.btnBrowseTn = new DevComponents.DotNetBar.ButtonX();
            this.scriptBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.delayBox = new DevComponents.Editors.IntegerInput();
            this.delayEnable = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.hRangeBox = new DevComponents.Editors.IntegerInput();
            this.vRangeBox = new DevComponents.Editors.IntegerInput();
            this.vImpactEnable = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.vImpactBox = new DevComponents.Editors.IntegerInput();
            this.impactLabel = new DevComponents.DotNetBar.LabelX();
            this.hImpactEnable = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.hImpactBox = new DevComponents.Editors.IntegerInput();
            this.hideTooltip = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.onlyOnce = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.imageLabel = new DevComponents.DotNetBar.LabelX();
            this.portalImageList = new System.Windows.Forms.ListBox();
            this.scriptLabel = new DevComponents.DotNetBar.LabelX();
            this.rangeEnable = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.xRangeLabel = new DevComponents.DotNetBar.LabelX();
            this.yRangeLabel = new DevComponents.DotNetBar.LabelX();
            this.leftBlankLabel = new DevComponents.DotNetBar.LabelX();
            this.portalImageBox = new HaCreator.CustomControls.ScrollablePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.xInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRangeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRangeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vImpactBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hImpactBox)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
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
            this.xInput.Location = new System.Drawing.Point(89, 12);
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
            this.labelX1.Location = new System.Drawing.Point(73, 15);
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
            this.labelX2.Location = new System.Drawing.Point(162, 15);
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
            this.yInput.Location = new System.Drawing.Point(178, 12);
            this.yInput.Name = "yInput";
            this.yInput.ShowUpDown = true;
            this.yInput.Size = new System.Drawing.Size(50, 20);
            this.yInput.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.okButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.okButton.Location = new System.Drawing.Point(110, 491);
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
            this.cancelButton.Location = new System.Drawing.Point(192, 491);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(73, 28);
            this.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ptComboBox
            // 
            this.ptComboBox.DisplayMember = "Text";
            this.ptComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ptComboBox.FormattingEnabled = true;
            this.ptComboBox.ItemHeight = 14;
            this.ptComboBox.Location = new System.Drawing.Point(89, 37);
            this.ptComboBox.Name = "ptComboBox";
            this.ptComboBox.Size = new System.Drawing.Size(139, 20);
            this.ptComboBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ptComboBox.TabIndex = 9;
            this.ptComboBox.SelectedIndexChanged += new System.EventHandler(this.ptComboBox_SelectedIndexChanged);
            // 
            // ptLabel
            // 
            this.ptLabel.AutoSize = true;
            // 
            // 
            // 
            this.ptLabel.BackgroundStyle.Class = "";
            this.ptLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ptLabel.Location = new System.Drawing.Point(20, 39);
            this.ptLabel.Name = "ptLabel";
            this.ptLabel.Size = new System.Drawing.Size(30, 15);
            this.ptLabel.TabIndex = 10;
            this.ptLabel.Text = "Type:";
            // 
            // pnLabel
            // 
            this.pnLabel.AutoSize = true;
            // 
            // 
            // 
            this.pnLabel.BackgroundStyle.Class = "";
            this.pnLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnLabel.Location = new System.Drawing.Point(20, 86);
            this.pnLabel.Name = "pnLabel";
            this.pnLabel.Size = new System.Drawing.Size(67, 15);
            this.pnLabel.TabIndex = 11;
            this.pnLabel.Text = "Portal Name:";
            // 
            // pnBox
            // 
            // 
            // 
            // 
            this.pnBox.Border.Class = "TextBoxBorder";
            this.pnBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnBox.Location = new System.Drawing.Point(89, 83);
            this.pnBox.Name = "pnBox";
            this.pnBox.Size = new System.Drawing.Size(139, 20);
            this.pnBox.TabIndex = 12;
            // 
            // tmBox
            // 
            this.tmBox.AllowEmptyState = false;
            // 
            // 
            // 
            this.tmBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.tmBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tmBox.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.tmBox.Location = new System.Drawing.Point(89, 109);
            this.tmBox.MinValue = 0;
            this.tmBox.Name = "tmBox";
            this.tmBox.Size = new System.Drawing.Size(139, 20);
            this.tmBox.TabIndex = 13;
            // 
            // tmLabel
            // 
            this.tmLabel.AutoSize = true;
            // 
            // 
            // 
            this.tmLabel.BackgroundStyle.Class = "";
            this.tmLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tmLabel.Location = new System.Drawing.Point(20, 111);
            this.tmLabel.Name = "tmLabel";
            this.tmLabel.Size = new System.Drawing.Size(41, 15);
            this.tmLabel.TabIndex = 14;
            this.tmLabel.Text = "Map ID:";
            // 
            // btnBrowseMap
            // 
            this.btnBrowseMap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrowseMap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBrowseMap.Location = new System.Drawing.Point(234, 109);
            this.btnBrowseMap.Name = "btnBrowseMap";
            this.btnBrowseMap.Size = new System.Drawing.Size(48, 20);
            this.btnBrowseMap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBrowseMap.TabIndex = 15;
            this.btnBrowseMap.Text = "Browse";
            this.btnBrowseMap.Click += new System.EventHandler(this.btnBrowseMap_Click);
            // 
            // thisMap
            // 
            this.thisMap.AutoSize = true;
            // 
            // 
            // 
            this.thisMap.BackgroundStyle.Class = "";
            this.thisMap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.thisMap.Location = new System.Drawing.Point(288, 111);
            this.thisMap.Name = "thisMap";
            this.thisMap.Size = new System.Drawing.Size(68, 15);
            this.thisMap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.thisMap.TabIndex = 16;
            this.thisMap.Text = "This Map";
            this.thisMap.CheckedChanged += new System.EventHandler(this.thisMap_CheckedChanged);
            // 
            // tnBox
            // 
            // 
            // 
            // 
            this.tnBox.Border.Class = "TextBoxBorder";
            this.tnBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tnBox.Location = new System.Drawing.Point(89, 135);
            this.tnBox.Name = "tnBox";
            this.tnBox.Size = new System.Drawing.Size(139, 20);
            this.tnBox.TabIndex = 18;
            // 
            // tnLabel
            // 
            this.tnLabel.AutoSize = true;
            // 
            // 
            // 
            this.tnLabel.BackgroundStyle.Class = "";
            this.tnLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tnLabel.Location = new System.Drawing.Point(20, 138);
            this.tnLabel.Name = "tnLabel";
            this.tnLabel.Size = new System.Drawing.Size(70, 15);
            this.tnLabel.TabIndex = 17;
            this.tnLabel.Text = "Target Name:";
            // 
            // btnBrowseTn
            // 
            this.btnBrowseTn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrowseTn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBrowseTn.Enabled = false;
            this.btnBrowseTn.Location = new System.Drawing.Point(234, 135);
            this.btnBrowseTn.Name = "btnBrowseTn";
            this.btnBrowseTn.Size = new System.Drawing.Size(48, 20);
            this.btnBrowseTn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBrowseTn.TabIndex = 19;
            this.btnBrowseTn.Text = "Browse";
            this.btnBrowseTn.Click += new System.EventHandler(this.btnBrowseTn_Click);
            // 
            // scriptBox
            // 
            // 
            // 
            // 
            this.scriptBox.Border.Class = "TextBoxBorder";
            this.scriptBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.scriptBox.Location = new System.Drawing.Point(89, 161);
            this.scriptBox.Name = "scriptBox";
            this.scriptBox.Size = new System.Drawing.Size(139, 20);
            this.scriptBox.TabIndex = 21;
            // 
            // delayBox
            // 
            this.delayBox.AllowEmptyState = false;
            // 
            // 
            // 
            this.delayBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.delayBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.delayBox.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.delayBox.Enabled = false;
            this.delayBox.Location = new System.Drawing.Point(89, 187);
            this.delayBox.Name = "delayBox";
            this.delayBox.ShowUpDown = true;
            this.delayBox.Size = new System.Drawing.Size(139, 20);
            this.delayBox.TabIndex = 22;
            // 
            // delayEnable
            // 
            this.delayEnable.AutoSize = true;
            // 
            // 
            // 
            this.delayEnable.BackgroundStyle.Class = "";
            this.delayEnable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.delayEnable.Location = new System.Drawing.Point(20, 189);
            this.delayEnable.Name = "delayEnable";
            this.delayEnable.Size = new System.Drawing.Size(54, 15);
            this.delayEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.delayEnable.TabIndex = 23;
            this.delayEnable.Text = "Delay:";
            this.delayEnable.CheckedChanged += new System.EventHandler(this.EnablingCheckBoxCheckChanged);
            // 
            // hRangeBox
            // 
            this.hRangeBox.AllowEmptyState = false;
            // 
            // 
            // 
            this.hRangeBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.hRangeBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hRangeBox.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.hRangeBox.Enabled = false;
            this.hRangeBox.Location = new System.Drawing.Point(110, 213);
            this.hRangeBox.Name = "hRangeBox";
            this.hRangeBox.ShowUpDown = true;
            this.hRangeBox.Size = new System.Drawing.Size(62, 20);
            this.hRangeBox.TabIndex = 24;
            // 
            // vRangeBox
            // 
            this.vRangeBox.AllowEmptyState = false;
            // 
            // 
            // 
            this.vRangeBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.vRangeBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.vRangeBox.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.vRangeBox.Enabled = false;
            this.vRangeBox.Location = new System.Drawing.Point(228, 213);
            this.vRangeBox.Name = "vRangeBox";
            this.vRangeBox.ShowUpDown = true;
            this.vRangeBox.Size = new System.Drawing.Size(62, 20);
            this.vRangeBox.TabIndex = 27;
            // 
            // vImpactEnable
            // 
            this.vImpactEnable.AutoSize = true;
            // 
            // 
            // 
            this.vImpactEnable.BackgroundStyle.Class = "";
            this.vImpactEnable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.vImpactEnable.Checked = true;
            this.vImpactEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vImpactEnable.CheckValue = "Y";
            this.vImpactEnable.Enabled = false;
            this.vImpactEnable.Location = new System.Drawing.Point(192, 241);
            this.vImpactEnable.Name = "vImpactEnable";
            this.vImpactEnable.Size = new System.Drawing.Size(30, 15);
            this.vImpactEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.vImpactEnable.TabIndex = 33;
            this.vImpactEnable.Text = "Y";
            // 
            // vImpactBox
            // 
            this.vImpactBox.AllowEmptyState = false;
            // 
            // 
            // 
            this.vImpactBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.vImpactBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.vImpactBox.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.vImpactBox.Enabled = false;
            this.vImpactBox.Location = new System.Drawing.Point(228, 239);
            this.vImpactBox.Name = "vImpactBox";
            this.vImpactBox.ShowUpDown = true;
            this.vImpactBox.Size = new System.Drawing.Size(62, 20);
            this.vImpactBox.TabIndex = 32;
            // 
            // impactLabel
            // 
            this.impactLabel.AutoSize = true;
            // 
            // 
            // 
            this.impactLabel.BackgroundStyle.Class = "";
            this.impactLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.impactLabel.Location = new System.Drawing.Point(20, 241);
            this.impactLabel.Name = "impactLabel";
            this.impactLabel.Size = new System.Drawing.Size(39, 15);
            this.impactLabel.TabIndex = 31;
            this.impactLabel.Text = "Impact:";
            // 
            // hImpactEnable
            // 
            this.hImpactEnable.AutoSize = true;
            // 
            // 
            // 
            this.hImpactEnable.BackgroundStyle.Class = "";
            this.hImpactEnable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hImpactEnable.Location = new System.Drawing.Point(74, 241);
            this.hImpactEnable.Name = "hImpactEnable";
            this.hImpactEnable.Size = new System.Drawing.Size(30, 15);
            this.hImpactEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.hImpactEnable.TabIndex = 30;
            this.hImpactEnable.Text = "X";
            this.hImpactEnable.CheckedChanged += new System.EventHandler(this.EnablingCheckBoxCheckChanged);
            // 
            // hImpactBox
            // 
            this.hImpactBox.AllowEmptyState = false;
            // 
            // 
            // 
            this.hImpactBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.hImpactBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hImpactBox.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.hImpactBox.Enabled = false;
            this.hImpactBox.Location = new System.Drawing.Point(110, 239);
            this.hImpactBox.Name = "hImpactBox";
            this.hImpactBox.ShowUpDown = true;
            this.hImpactBox.Size = new System.Drawing.Size(62, 20);
            this.hImpactBox.TabIndex = 29;
            // 
            // hideTooltip
            // 
            this.hideTooltip.AutoSize = true;
            // 
            // 
            // 
            this.hideTooltip.BackgroundStyle.Class = "";
            this.hideTooltip.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.hideTooltip.Location = new System.Drawing.Point(77, 265);
            this.hideTooltip.Name = "hideTooltip";
            this.hideTooltip.Size = new System.Drawing.Size(81, 15);
            this.hideTooltip.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.hideTooltip.TabIndex = 34;
            this.hideTooltip.Text = "Hide Tooltip";
            // 
            // onlyOnce
            // 
            this.onlyOnce.AutoSize = true;
            // 
            // 
            // 
            this.onlyOnce.BackgroundStyle.Class = "";
            this.onlyOnce.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.onlyOnce.Location = new System.Drawing.Point(183, 265);
            this.onlyOnce.Name = "onlyOnce";
            this.onlyOnce.Size = new System.Drawing.Size(74, 15);
            this.onlyOnce.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.onlyOnce.TabIndex = 35;
            this.onlyOnce.Text = "Only Once";
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            // 
            // 
            // 
            this.imageLabel.BackgroundStyle.Class = "";
            this.imageLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.imageLabel.Location = new System.Drawing.Point(20, 286);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(36, 15);
            this.imageLabel.TabIndex = 36;
            this.imageLabel.Text = "Image:";
            // 
            // portalImageList
            // 
            this.portalImageList.FormattingEnabled = true;
            this.portalImageList.Location = new System.Drawing.Point(77, 286);
            this.portalImageList.Name = "portalImageList";
            this.portalImageList.Size = new System.Drawing.Size(189, 69);
            this.portalImageList.TabIndex = 38;
            this.portalImageList.SelectedIndexChanged += new System.EventHandler(this.portalImageList_SelectedIndexChanged);
            // 
            // scriptLabel
            // 
            this.scriptLabel.AutoSize = true;
            // 
            // 
            // 
            this.scriptLabel.BackgroundStyle.Class = "";
            this.scriptLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.scriptLabel.Location = new System.Drawing.Point(20, 163);
            this.scriptLabel.Name = "scriptLabel";
            this.scriptLabel.Size = new System.Drawing.Size(34, 15);
            this.scriptLabel.TabIndex = 40;
            this.scriptLabel.Text = "Script:";
            // 
            // rangeEnable
            // 
            this.rangeEnable.AutoSize = true;
            // 
            // 
            // 
            this.rangeEnable.BackgroundStyle.Class = "";
            this.rangeEnable.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rangeEnable.Location = new System.Drawing.Point(20, 214);
            this.rangeEnable.Name = "rangeEnable";
            this.rangeEnable.Size = new System.Drawing.Size(58, 15);
            this.rangeEnable.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rangeEnable.TabIndex = 41;
            this.rangeEnable.Text = "Range:";
            this.rangeEnable.CheckedChanged += new System.EventHandler(this.rangeEnable_CheckedChanged);
            // 
            // xRangeLabel
            // 
            this.xRangeLabel.AutoSize = true;
            // 
            // 
            // 
            this.xRangeLabel.BackgroundStyle.Class = "";
            this.xRangeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.xRangeLabel.Location = new System.Drawing.Point(94, 215);
            this.xRangeLabel.Name = "xRangeLabel";
            this.xRangeLabel.Size = new System.Drawing.Size(10, 15);
            this.xRangeLabel.TabIndex = 42;
            this.xRangeLabel.Text = "X";
            // 
            // yRangeLabel
            // 
            this.yRangeLabel.AutoSize = true;
            // 
            // 
            // 
            this.yRangeLabel.BackgroundStyle.Class = "";
            this.yRangeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.yRangeLabel.Location = new System.Drawing.Point(212, 215);
            this.yRangeLabel.Name = "yRangeLabel";
            this.yRangeLabel.Size = new System.Drawing.Size(10, 15);
            this.yRangeLabel.TabIndex = 43;
            this.yRangeLabel.Text = "Y";
            // 
            // leftBlankLabel
            // 
            this.leftBlankLabel.AutoSize = true;
            // 
            // 
            // 
            this.leftBlankLabel.BackgroundStyle.Class = "";
            this.leftBlankLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.leftBlankLabel.Location = new System.Drawing.Point(288, 138);
            this.leftBlankLabel.Name = "leftBlankLabel";
            this.leftBlankLabel.Size = new System.Drawing.Size(85, 15);
            this.leftBlankLabel.TabIndex = 44;
            this.leftBlankLabel.Text = "Can be left blank";
            // 
            // portalImageBox
            // 
            this.portalImageBox.AutoScroll = true;
            this.portalImageBox.Image = null;
            this.portalImageBox.Location = new System.Drawing.Point(77, 361);
            this.portalImageBox.Name = "portalImageBox";
            this.portalImageBox.Size = new System.Drawing.Size(189, 124);
            this.portalImageBox.TabIndex = 39;
            // 
            // PortalInstanceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 528);
            this.Controls.Add(this.leftBlankLabel);
            this.Controls.Add(this.yRangeLabel);
            this.Controls.Add(this.xRangeLabel);
            this.Controls.Add(this.rangeEnable);
            this.Controls.Add(this.scriptLabel);
            this.Controls.Add(this.portalImageBox);
            this.Controls.Add(this.portalImageList);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.onlyOnce);
            this.Controls.Add(this.hideTooltip);
            this.Controls.Add(this.vImpactEnable);
            this.Controls.Add(this.vImpactBox);
            this.Controls.Add(this.impactLabel);
            this.Controls.Add(this.hImpactEnable);
            this.Controls.Add(this.hImpactBox);
            this.Controls.Add(this.vRangeBox);
            this.Controls.Add(this.hRangeBox);
            this.Controls.Add(this.delayEnable);
            this.Controls.Add(this.delayBox);
            this.Controls.Add(this.scriptBox);
            this.Controls.Add(this.btnBrowseTn);
            this.Controls.Add(this.tnBox);
            this.Controls.Add(this.tnLabel);
            this.Controls.Add(this.thisMap);
            this.Controls.Add(this.btnBrowseMap);
            this.Controls.Add(this.tmLabel);
            this.Controls.Add(this.tmBox);
            this.Controls.Add(this.pnBox);
            this.Controls.Add(this.pnLabel);
            this.Controls.Add(this.ptLabel);
            this.Controls.Add(this.ptComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.yInput);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.xInput);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PortalInstanceEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.xInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRangeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRangeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vImpactBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hImpactBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.IntegerInput xInput;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.IntegerInput yInput;
        private DevComponents.DotNetBar.ButtonX okButton;
        private DevComponents.DotNetBar.ButtonX cancelButton;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ptComboBox;
        private DevComponents.DotNetBar.LabelX ptLabel;
        private DevComponents.DotNetBar.LabelX pnLabel;
        private DevComponents.DotNetBar.Controls.TextBoxX pnBox;
        private DevComponents.Editors.IntegerInput tmBox;
        private DevComponents.DotNetBar.LabelX tmLabel;
        private DevComponents.DotNetBar.ButtonX btnBrowseMap;
        private DevComponents.DotNetBar.Controls.CheckBoxX thisMap;
        private DevComponents.DotNetBar.Controls.TextBoxX tnBox;
        private DevComponents.DotNetBar.LabelX tnLabel;
        private DevComponents.DotNetBar.ButtonX btnBrowseTn;
        private DevComponents.DotNetBar.Controls.TextBoxX scriptBox;
        private DevComponents.Editors.IntegerInput delayBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX delayEnable;
        private DevComponents.Editors.IntegerInput hRangeBox;
        private DevComponents.Editors.IntegerInput vRangeBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX vImpactEnable;
        private DevComponents.Editors.IntegerInput vImpactBox;
        private DevComponents.DotNetBar.LabelX impactLabel;
        private DevComponents.DotNetBar.Controls.CheckBoxX hImpactEnable;
        private DevComponents.Editors.IntegerInput hImpactBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX hideTooltip;
        private DevComponents.DotNetBar.Controls.CheckBoxX onlyOnce;
        private DevComponents.DotNetBar.LabelX imageLabel;
        private System.Windows.Forms.ListBox portalImageList;
        private CustomControls.ScrollablePictureBox portalImageBox;
        private DevComponents.DotNetBar.LabelX scriptLabel;
        private DevComponents.DotNetBar.Controls.CheckBoxX rangeEnable;
        private DevComponents.DotNetBar.LabelX xRangeLabel;
        private DevComponents.DotNetBar.LabelX yRangeLabel;
        private DevComponents.DotNetBar.LabelX leftBlankLabel;
    }
}