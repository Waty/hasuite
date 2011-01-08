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
    partial class HaRepackerMainPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HaRepackerMainPanel));
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.DataTree = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector2 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle2 = new DevComponents.DotNetBar.ElementStyle();
            this.saveSoundButton = new System.Windows.Forms.Button();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.changeSoundButton = new System.Windows.Forms.Button();
            this.changeImageButton = new System.Windows.Forms.Button();
            this.applyChangesButton = new System.Windows.Forms.Button();
            this.nameBox = new HaRepackerLib.ChangableTextbox();
            this.vectorPanel = new HaRepackerLib.XYPanel();
            this.mp3Player = new HaRepackerLib.SoundPlayer();
            this.textPropBox = new System.Windows.Forms.TextBox();
            this.pictureBoxPanel = new System.Windows.Forms.Panel();
            this.canvasPropBox = new System.Windows.Forms.PictureBox();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.selectionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.secondaryProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.node1 = new DevComponents.AdvTree.Node();
            this.findStrip = new System.Windows.Forms.ToolStrip();
            this.btnFindAll = new System.Windows.Forms.ToolStripButton();
            this.btnFindNext = new System.Windows.Forms.ToolStripButton();
            this.findBox = new System.Windows.Forms.ToolStripTextBox();
            this.btnRestart = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnOptions = new System.Windows.Forms.ToolStripButton();
            this.dotNetBarManager = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.dockSite4 = new DevComponents.DotNetBar.DockSite();
            this.searchResults = new DevComponents.DotNetBar.Bar();
            this.panelDockContainer1 = new DevComponents.DotNetBar.PanelDockContainer();
            this.searchResultsBox = new System.Windows.Forms.ListBox();
            this.searchResultsContainer = new DevComponents.DotNetBar.DockContainerItem();
            this.dockSite1 = new DevComponents.DotNetBar.DockSite();
            this.dockSite2 = new DevComponents.DotNetBar.DockSite();
            this.dockSite8 = new DevComponents.DotNetBar.DockSite();
            this.dockSite5 = new DevComponents.DotNetBar.DockSite();
            this.dockSite6 = new DevComponents.DotNetBar.DockSite();
            this.dockSite7 = new DevComponents.DotNetBar.DockSite();
            this.dockSite3 = new DevComponents.DotNetBar.DockSite();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTree)).BeginInit();
            this.pictureBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPropBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.findStrip.SuspendLayout();
            this.dockSite4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResults)).BeginInit();
            this.searchResults.SuspendLayout();
            this.panelDockContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.DataTree);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.saveSoundButton);
            this.MainSplitContainer.Panel2.Controls.Add(this.saveImageButton);
            this.MainSplitContainer.Panel2.Controls.Add(this.changeSoundButton);
            this.MainSplitContainer.Panel2.Controls.Add(this.changeImageButton);
            this.MainSplitContainer.Panel2.Controls.Add(this.applyChangesButton);
            this.MainSplitContainer.Panel2.Controls.Add(this.nameBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.vectorPanel);
            this.MainSplitContainer.Panel2.Controls.Add(this.mp3Player);
            this.MainSplitContainer.Panel2.Controls.Add(this.textPropBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.pictureBoxPanel);
            this.MainSplitContainer.Size = new System.Drawing.Size(657, 330);
            this.MainSplitContainer.SplitterDistance = 218;
            this.MainSplitContainer.TabIndex = 0;
            this.MainSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.MainSplitContainer_SplitterMoved);
            // 
            // DataTree
            // 
            this.DataTree.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.DataTree.AllowDrop = true;
            this.DataTree.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.DataTree.BackgroundStyle.Class = "TreeBorderKey";
            this.DataTree.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DataTree.DragDropEnabled = false;
            this.DataTree.DragDropNodeCopyEnabled = false;
            this.DataTree.Location = new System.Drawing.Point(36, 56);
            this.DataTree.MultiSelect = true;
            this.DataTree.Name = "DataTree";
            this.DataTree.NodesConnector = this.nodeConnector2;
            this.DataTree.NodeStyle = this.elementStyle2;
            this.DataTree.PathSeparator = ";";
            this.DataTree.Size = new System.Drawing.Size(147, 196);
            this.DataTree.Styles.Add(this.elementStyle2);
            this.DataTree.TabIndex = 0;
            this.DataTree.Text = "DataTree";
            this.DataTree.AfterNodeSelect += new DevComponents.AdvTree.AdvTreeNodeEventHandler(this.DataTree_AfterSelect);
            this.DataTree.NodeDoubleClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.DataTree_DoubleClick);
            this.DataTree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataTree_KeyDown);
            // 
            // nodeConnector2
            // 
            this.nodeConnector2.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle2
            // 
            this.elementStyle2.Class = "";
            this.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle2.Name = "elementStyle2";
            this.elementStyle2.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // saveSoundButton
            // 
            this.saveSoundButton.Location = new System.Drawing.Point(45, 178);
            this.saveSoundButton.Name = "saveSoundButton";
            this.saveSoundButton.Size = new System.Drawing.Size(118, 34);
            this.saveSoundButton.TabIndex = 12;
            this.saveSoundButton.Text = "Save Sound...";
            this.saveSoundButton.UseVisualStyleBackColor = true;
            this.saveSoundButton.Visible = false;
            this.saveSoundButton.Click += new System.EventHandler(this.saveSoundButton_Click);
            // 
            // saveImageButton
            // 
            this.saveImageButton.Location = new System.Drawing.Point(17, 218);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(118, 34);
            this.saveImageButton.TabIndex = 11;
            this.saveImageButton.Text = "Save Image...";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Visible = false;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // changeSoundButton
            // 
            this.changeSoundButton.Location = new System.Drawing.Point(71, 240);
            this.changeSoundButton.Name = "changeSoundButton";
            this.changeSoundButton.Size = new System.Drawing.Size(118, 34);
            this.changeSoundButton.TabIndex = 10;
            this.changeSoundButton.Text = "Change Sound...";
            this.changeSoundButton.UseVisualStyleBackColor = true;
            this.changeSoundButton.Visible = false;
            this.changeSoundButton.Click += new System.EventHandler(this.changeSoundButton_Click);
            // 
            // changeImageButton
            // 
            this.changeImageButton.Location = new System.Drawing.Point(71, 138);
            this.changeImageButton.Name = "changeImageButton";
            this.changeImageButton.Size = new System.Drawing.Size(118, 34);
            this.changeImageButton.TabIndex = 9;
            this.changeImageButton.Text = "Change Image...";
            this.changeImageButton.UseVisualStyleBackColor = true;
            this.changeImageButton.Visible = false;
            this.changeImageButton.Click += new System.EventHandler(this.changeImageButton_Click);
            // 
            // applyChangesButton
            // 
            this.applyChangesButton.Location = new System.Drawing.Point(3, 269);
            this.applyChangesButton.Name = "applyChangesButton";
            this.applyChangesButton.Size = new System.Drawing.Size(118, 34);
            this.applyChangesButton.TabIndex = 8;
            this.applyChangesButton.Text = "Apply Changed Value";
            this.applyChangesButton.UseVisualStyleBackColor = true;
            this.applyChangesButton.Visible = false;
            this.applyChangesButton.Click += new System.EventHandler(this.applyChangesButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.ButtonEnabled = false;
            this.nameBox.Location = new System.Drawing.Point(3, 83);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(306, 20);
            this.nameBox.TabIndex = 7;
            this.nameBox.ButtonClicked += new System.EventHandler(this.nameBox_ButtonClicked);
            // 
            // vectorPanel
            // 
            this.vectorPanel.Location = new System.Drawing.Point(71, 91);
            this.vectorPanel.MaximumSize = new System.Drawing.Size(90, 53);
            this.vectorPanel.MinimumSize = new System.Drawing.Size(90, 53);
            this.vectorPanel.Name = "vectorPanel";
            this.vectorPanel.Size = new System.Drawing.Size(90, 53);
            this.vectorPanel.TabIndex = 6;
            this.vectorPanel.Visible = false;
            this.vectorPanel.X = 0;
            this.vectorPanel.Y = 0;
            // 
            // mp3Player
            // 
            this.mp3Player.Location = new System.Drawing.Point(45, 16);
            this.mp3Player.MaximumSize = new System.Drawing.Size(310, 86);
            this.mp3Player.MinimumSize = new System.Drawing.Size(310, 86);
            this.mp3Player.Name = "mp3Player";
            this.mp3Player.Size = new System.Drawing.Size(310, 86);
            this.mp3Player.SoundProperty = null;
            this.mp3Player.TabIndex = 3;
            this.mp3Player.Visible = false;
            // 
            // textPropBox
            // 
            this.textPropBox.Location = new System.Drawing.Point(45, 150);
            this.textPropBox.Multiline = true;
            this.textPropBox.Name = "textPropBox";
            this.textPropBox.Size = new System.Drawing.Size(144, 124);
            this.textPropBox.TabIndex = 2;
            this.textPropBox.Visible = false;
            // 
            // pictureBoxPanel
            // 
            this.pictureBoxPanel.AutoScroll = true;
            this.pictureBoxPanel.Controls.Add(this.canvasPropBox);
            this.pictureBoxPanel.Location = new System.Drawing.Point(195, 108);
            this.pictureBoxPanel.Name = "pictureBoxPanel";
            this.pictureBoxPanel.Size = new System.Drawing.Size(199, 176);
            this.pictureBoxPanel.TabIndex = 1;
            this.pictureBoxPanel.Visible = false;
            // 
            // canvasPropBox
            // 
            this.canvasPropBox.Location = new System.Drawing.Point(7, 26);
            this.canvasPropBox.Name = "canvasPropBox";
            this.canvasPropBox.Size = new System.Drawing.Size(189, 118);
            this.canvasPropBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.canvasPropBox.TabIndex = 0;
            this.canvasPropBox.TabStop = false;
            this.canvasPropBox.Visible = false;
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.Class = "";
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectionLabel,
            this.mainProgressBar,
            this.secondaryProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 376);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(663, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // selectionLabel
            // 
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(119, 17);
            this.selectionLabel.Text = "Selection Type: None";
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // secondaryProgressBar
            // 
            this.secondaryProgressBar.Name = "secondaryProgressBar";
            this.secondaryProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // node1
            // 
            this.node1.Name = "node1";
            this.node1.Text = "asdfsfd";
            // 
            // findStrip
            // 
            this.findStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.findStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFindAll,
            this.btnFindNext,
            this.findBox,
            this.btnRestart,
            this.btnClose,
            this.btnOptions});
            this.findStrip.Location = new System.Drawing.Point(0, 311);
            this.findStrip.Name = "findStrip";
            this.findStrip.Size = new System.Drawing.Size(663, 25);
            this.findStrip.TabIndex = 2;
            this.findStrip.Text = "toolStrip1";
            this.findStrip.Visible = false;
            this.findStrip.VisibleChanged += new System.EventHandler(this.findStrip_VisibleChanged);
            // 
            // btnFindAll
            // 
            this.btnFindAll.Image = global::HaRepackerLib.Properties.Resources.find;
            this.btnFindAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(41, 22);
            this.btnFindAll.Text = "All";
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // btnFindNext
            // 
            this.btnFindNext.Image = global::HaRepackerLib.Properties.Resources.arrow_right;
            this.btnFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(51, 22);
            this.btnFindNext.Text = "Next";
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // findBox
            // 
            this.findBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.findBox.Name = "findBox";
            this.findBox.Size = new System.Drawing.Size(100, 25);
            this.findBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.findBox_KeyDown);
            this.findBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.findBox_KeyPress);
            this.findBox.TextChanged += new System.EventHandler(this.findBox_TextChanged);
            // 
            // btnRestart
            // 
            this.btnRestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRestart.Image = global::HaRepackerLib.Properties.Resources.undo;
            this.btnRestart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(23, 22);
            this.btnRestart.Text = "Restart";
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnClose
            // 
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClose.Image = global::HaRepackerLib.Properties.Resources.red_x1;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 22);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(53, 22);
            this.btnOptions.Text = "Options";
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // dotNetBarManager
            // 
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.dotNetBarManager.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.dotNetBarManager.BottomDockSite = this.dockSite4;
            this.dotNetBarManager.EnableFullSizeDock = false;
            this.dotNetBarManager.LeftDockSite = this.dockSite1;
            this.dotNetBarManager.ParentForm = null;
            this.dotNetBarManager.ParentUserControl = this;
            this.dotNetBarManager.RightDockSite = this.dockSite2;
            this.dotNetBarManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.dotNetBarManager.ToolbarBottomDockSite = this.dockSite8;
            this.dotNetBarManager.ToolbarLeftDockSite = this.dockSite5;
            this.dotNetBarManager.ToolbarRightDockSite = this.dockSite6;
            this.dotNetBarManager.ToolbarTopDockSite = this.dockSite7;
            this.dotNetBarManager.TopDockSite = this.dockSite3;
            // 
            // dockSite4
            // 
            this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite4.Controls.Add(this.searchResults);
            this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite4.Location = new System.Drawing.Point(0, 398);
            this.dockSite4.Name = "dockSite4";
            this.dockSite4.Size = new System.Drawing.Size(663, 58);
            this.dockSite4.TabIndex = 6;
            this.dockSite4.TabStop = false;
            // 
            // searchResults
            // 
            this.searchResults.AccessibleDescription = "DotNetBar Bar (searchResults)";
            this.searchResults.AccessibleName = "DotNetBar Bar";
            this.searchResults.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.searchResults.AutoSyncBarCaption = true;
            this.searchResults.CanHide = true;
            this.searchResults.CloseSingleTab = true;
            this.searchResults.Controls.Add(this.panelDockContainer1);
            this.searchResults.DockSide = DevComponents.DotNetBar.eDockSide.Bottom;
            this.searchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchResults.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.searchResults.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.searchResultsContainer});
            this.searchResults.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.searchResults.Location = new System.Drawing.Point(0, 0);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(663, 58);
            this.searchResults.Stretch = true;
            this.searchResults.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.searchResults.TabIndex = 0;
            this.searchResults.TabStop = false;
            this.searchResults.Text = "Search Results";
            this.searchResults.Visible = false;
            this.searchResults.VisibleChanged += new System.EventHandler(this.searchResults_VisibleChanged);
            // 
            // panelDockContainer1
            // 
            this.panelDockContainer1.Controls.Add(this.searchResultsBox);
            this.panelDockContainer1.Location = new System.Drawing.Point(3, 23);
            this.panelDockContainer1.Name = "panelDockContainer1";
            this.panelDockContainer1.Size = new System.Drawing.Size(657, 32);
            this.panelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelDockContainer1.Style.GradientAngle = 90;
            this.panelDockContainer1.TabIndex = 0;
            // 
            // searchResultsBox
            // 
            this.searchResultsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResultsBox.FormattingEnabled = true;
            this.searchResultsBox.Location = new System.Drawing.Point(0, 0);
            this.searchResultsBox.Name = "searchResultsBox";
            this.searchResultsBox.Size = new System.Drawing.Size(657, 32);
            this.searchResultsBox.TabIndex = 0;
            this.searchResultsBox.SelectedIndexChanged += new System.EventHandler(this.searchResultsBox_SelectedIndexChanged);
            // 
            // searchResultsContainer
            // 
            this.searchResultsContainer.Control = this.panelDockContainer1;
            this.searchResultsContainer.Name = "searchResultsContainer";
            this.searchResultsContainer.Text = "Search Results";
            this.searchResultsContainer.VisibleChanged += new System.EventHandler(this.searchResultsContainer_VisibleChanged);
            // 
            // dockSite1
            // 
            this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite1.Location = new System.Drawing.Point(0, 0);
            this.dockSite1.Name = "dockSite1";
            this.dockSite1.Size = new System.Drawing.Size(0, 376);
            this.dockSite1.TabIndex = 3;
            this.dockSite1.TabStop = false;
            // 
            // dockSite2
            // 
            this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite2.Location = new System.Drawing.Point(663, 0);
            this.dockSite2.Name = "dockSite2";
            this.dockSite2.Size = new System.Drawing.Size(0, 376);
            this.dockSite2.TabIndex = 4;
            this.dockSite2.TabStop = false;
            // 
            // dockSite8
            // 
            this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dockSite8.Location = new System.Drawing.Point(0, 456);
            this.dockSite8.Name = "dockSite8";
            this.dockSite8.Size = new System.Drawing.Size(663, 0);
            this.dockSite8.TabIndex = 10;
            this.dockSite8.TabStop = false;
            // 
            // dockSite5
            // 
            this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockSite5.Location = new System.Drawing.Point(0, 0);
            this.dockSite5.Name = "dockSite5";
            this.dockSite5.Size = new System.Drawing.Size(0, 456);
            this.dockSite5.TabIndex = 7;
            this.dockSite5.TabStop = false;
            // 
            // dockSite6
            // 
            this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockSite6.Location = new System.Drawing.Point(663, 0);
            this.dockSite6.Name = "dockSite6";
            this.dockSite6.Size = new System.Drawing.Size(0, 456);
            this.dockSite6.TabIndex = 8;
            this.dockSite6.TabStop = false;
            // 
            // dockSite7
            // 
            this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite7.Location = new System.Drawing.Point(0, 0);
            this.dockSite7.Name = "dockSite7";
            this.dockSite7.Size = new System.Drawing.Size(663, 0);
            this.dockSite7.TabIndex = 9;
            this.dockSite7.TabStop = false;
            // 
            // dockSite3
            // 
            this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockSite3.Location = new System.Drawing.Point(0, 0);
            this.dockSite3.Name = "dockSite3";
            this.dockSite3.Size = new System.Drawing.Size(663, 0);
            this.dockSite3.TabIndex = 5;
            this.dockSite3.TabStop = false;
            // 
            // HaRepackerMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dockSite2);
            this.Controls.Add(this.dockSite1);
            this.Controls.Add(this.findStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dockSite3);
            this.Controls.Add(this.dockSite4);
            this.Controls.Add(this.dockSite5);
            this.Controls.Add(this.dockSite6);
            this.Controls.Add(this.dockSite7);
            this.Controls.Add(this.dockSite8);
            this.Controls.Add(this.MainSplitContainer);
            this.Name = "HaRepackerMainPanel";
            this.Size = new System.Drawing.Size(663, 456);
            this.SizeChanged += new System.EventHandler(this.HaRepackerMainPanel_SizeChanged);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            this.MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTree)).EndInit();
            this.pictureBoxPanel.ResumeLayout(false);
            this.pictureBoxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPropBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.findStrip.ResumeLayout(false);
            this.findStrip.PerformLayout();
            this.dockSite4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResults)).EndInit();
            this.searchResults.ResumeLayout(false);
            this.panelDockContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.PictureBox canvasPropBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel selectionLabel;
        private System.Windows.Forms.Panel pictureBoxPanel;
        private System.Windows.Forms.TextBox textPropBox;
        private SoundPlayer mp3Player;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.AdvTree.NodeConnector nodeConnector2;
        private DevComponents.DotNetBar.ElementStyle elementStyle2;
        public DevComponents.AdvTree.AdvTree DataTree;
        public System.Windows.Forms.ToolStripProgressBar secondaryProgressBar;
        public System.Windows.Forms.ToolStripProgressBar mainProgressBar;
        private ChangableTextbox nameBox;
        private XYPanel vectorPanel;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.Button changeSoundButton;
        private System.Windows.Forms.Button changeImageButton;
        private System.Windows.Forms.Button applyChangesButton;
        private System.Windows.Forms.Button saveSoundButton;
        private System.Windows.Forms.ToolStripButton btnFindNext;
        private System.Windows.Forms.ToolStripTextBox findBox;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnRestart;
        private System.Windows.Forms.ToolStripButton btnFindAll;
        private DevComponents.DotNetBar.DotNetBarManager dotNetBarManager;
        private DevComponents.DotNetBar.DockSite dockSite4;
        private DevComponents.DotNetBar.Bar searchResults;
        private DevComponents.DotNetBar.PanelDockContainer panelDockContainer1;
        private DevComponents.DotNetBar.DockContainerItem searchResultsContainer;
        private DevComponents.DotNetBar.DockSite dockSite1;
        private DevComponents.DotNetBar.DockSite dockSite2;
        private DevComponents.DotNetBar.DockSite dockSite3;
        private DevComponents.DotNetBar.DockSite dockSite5;
        private DevComponents.DotNetBar.DockSite dockSite6;
        private DevComponents.DotNetBar.DockSite dockSite7;
        private DevComponents.DotNetBar.DockSite dockSite8;
        private System.Windows.Forms.ToolStripButton btnOptions;
        private System.Windows.Forms.ListBox searchResultsBox;
        public System.Windows.Forms.ToolStrip findStrip;
    }
}
