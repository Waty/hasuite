using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TreeViewTest
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbSelectionMode;
        private System.Windows.Forms.Button btnSelectNodes;

        private ArrayList arrTreeNodesToBeSelected = new ArrayList();
        private ArrayList arrTreeNodesToBeSelected2 = new ArrayList();
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSelectionColor;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Label label4;
        private CodersLab.Windows.Controls.TreeView treeView1;
        private System.Windows.Forms.CheckBox cbxLogBeforeSelectEvents;
        private System.Windows.Forms.CheckBox cbxLogAfterSelectEvent;
        private System.Windows.Forms.CheckBox cbxLabelEdit;
        private System.Windows.Forms.Button btnExpandAll;
        private System.Windows.Forms.Button btnCollapseAll;
        private System.Windows.Forms.Button btnAddNodesToSelection;
        private System.Windows.Forms.CheckBox cbxLogOnAfterDeselect;
        private System.Windows.Forms.CheckBox cbxLogOnBeforeDeselect;
        private Button button3;
        private CheckBox cbxLogOnSelectionsChanged;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;




        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                TreeNode tn = new TreeNode("Node " + i.ToString());
                treeView1.Nodes.Add(tn);

                if (i % 2 == 1)
                {
                    arrTreeNodesToBeSelected.Add(tn);
                }

                if (i % 2 == 0)
                {
                    arrTreeNodesToBeSelected2.Add(tn);
                }

                for (int j = 0; j < 10; j++)
                {
                    TreeNode tnSub = new TreeNode("Node " + i.ToString() + " - " + j.ToString());
                    tn.Nodes.Add(tnSub);

                    for (int k = 0; k < 10; k++)
                    {
                        TreeNode tnSubSub = new TreeNode("Node " + i.ToString() + " - " + j.ToString() + " - " + k.ToString());
                        tnSub.Nodes.Add(tnSubSub);
                    }
                }
            }



            cmbSelectionMode.SelectedIndex = 0;
            cbxLabelEdit.Checked = true;

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbSelectionMode = new System.Windows.Forms.ComboBox();
            this.btnSelectNodes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.treeView1 = new CodersLab.Windows.Controls.TreeView();
            this.btnSelectionColor = new System.Windows.Forms.Button();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxLogBeforeSelectEvents = new System.Windows.Forms.CheckBox();
            this.cbxLogAfterSelectEvent = new System.Windows.Forms.CheckBox();
            this.cbxLabelEdit = new System.Windows.Forms.CheckBox();
            this.btnExpandAll = new System.Windows.Forms.Button();
            this.btnCollapseAll = new System.Windows.Forms.Button();
            this.btnAddNodesToSelection = new System.Windows.Forms.Button();
            this.cbxLogOnAfterDeselect = new System.Windows.Forms.CheckBox();
            this.cbxLogOnBeforeDeselect = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cbxLogOnSelectionsChanged = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "contextmenu a";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "bbbcontextmenu b";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show selected nodes";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbSelectionMode
            // 
            this.cmbSelectionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectionMode.Items.AddRange(new object[] {
            "SingleSelection",
            "MultiSelection",
            "MultiSelectSameRootBranch",
            "MultiSelectSameLevel",
            "MultiSelectSameLevelAndRootBranch",
            "MultiSelectSameParent"});
            this.cmbSelectionMode.Location = new System.Drawing.Point(16, 41);
            this.cmbSelectionMode.Name = "cmbSelectionMode";
            this.cmbSelectionMode.Size = new System.Drawing.Size(197, 21);
            this.cmbSelectionMode.TabIndex = 3;
            this.cmbSelectionMode.SelectedIndexChanged += new System.EventHandler(this.cmbSelectionMode_SelectedIndexChanged);
            // 
            // btnSelectNodes
            // 
            this.btnSelectNodes.Location = new System.Drawing.Point(16, 91);
            this.btnSelectNodes.Name = "btnSelectNodes";
            this.btnSelectNodes.Size = new System.Drawing.Size(197, 23);
            this.btnSelectNodes.TabIndex = 4;
            this.btnSelectNodes.Text = "Select some nodes";
            this.btnSelectNodes.Click += new System.EventHandler(this.btnSelectNodes_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Start edit on a node";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SelectionMode:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 107);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(260, 364);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // treeView1
            // 
            this.treeView1.ContextMenu = this.contextMenu1;
            this.treeView1.Location = new System.Drawing.Point(6, 20);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.SelectionMode = CodersLab.Windows.Controls.TreeViewSelectionMode.SingleSelect;
            this.treeView1.Size = new System.Drawing.Size(226, 422);
            this.treeView1.TabIndex = 9;
            this.treeView1.AfterDeselect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterDeselect);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.BeforeDeselect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_BeforeDeselect);
            this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
            this.treeView1.SelectionsChanged += new System.EventHandler(this.treeView1_SelectionsChanged);
            // 
            // btnSelectionColor
            // 
            this.btnSelectionColor.Location = new System.Drawing.Point(16, 164);
            this.btnSelectionColor.Name = "btnSelectionColor";
            this.btnSelectionColor.Size = new System.Drawing.Size(197, 23);
            this.btnSelectionColor.TabIndex = 13;
            this.btnSelectionColor.Text = "Selection backcolor";
            this.btnSelectionColor.Click += new System.EventHandler(this.btnSelectionColor_Click);
            // 
            // btnForeColor
            // 
            this.btnForeColor.Location = new System.Drawing.Point(16, 188);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(197, 23);
            this.btnForeColor.TabIndex = 14;
            this.btnForeColor.Text = "Forecolor";
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(16, 212);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(197, 23);
            this.btnBackColor.TabIndex = 15;
            this.btnBackColor.Text = "Backcolor";
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Note: for Node1: in BeforeSelect, e.Cancel is set to true, so it cannot be select" +
                "ed";
            // 
            // cbxLogBeforeSelectEvents
            // 
            this.cbxLogBeforeSelectEvents.Location = new System.Drawing.Point(6, 20);
            this.cbxLogBeforeSelectEvents.Name = "cbxLogBeforeSelectEvents";
            this.cbxLogBeforeSelectEvents.Size = new System.Drawing.Size(112, 24);
            this.cbxLogBeforeSelectEvents.TabIndex = 18;
            this.cbxLogBeforeSelectEvents.Text = "Log BeforeSelect";
            // 
            // cbxLogAfterSelectEvent
            // 
            this.cbxLogAfterSelectEvent.Location = new System.Drawing.Point(124, 19);
            this.cbxLogAfterSelectEvent.Name = "cbxLogAfterSelectEvent";
            this.cbxLogAfterSelectEvent.Size = new System.Drawing.Size(112, 24);
            this.cbxLogAfterSelectEvent.TabIndex = 19;
            this.cbxLogAfterSelectEvent.Text = "Log AfterSelect";
            // 
            // cbxLabelEdit
            // 
            this.cbxLabelEdit.Location = new System.Drawing.Point(18, 315);
            this.cbxLabelEdit.Name = "cbxLabelEdit";
            this.cbxLabelEdit.Size = new System.Drawing.Size(112, 24);
            this.cbxLabelEdit.TabIndex = 20;
            this.cbxLabelEdit.Text = "LabelEdit";
            this.cbxLabelEdit.CheckedChanged += new System.EventHandler(this.cbxLabelEdit_CheckedChanged);
            // 
            // btnExpandAll
            // 
            this.btnExpandAll.Location = new System.Drawing.Point(17, 261);
            this.btnExpandAll.Name = "btnExpandAll";
            this.btnExpandAll.Size = new System.Drawing.Size(196, 23);
            this.btnExpandAll.TabIndex = 21;
            this.btnExpandAll.Text = "Expand all";
            this.btnExpandAll.Click += new System.EventHandler(this.btnExpandAll_Click);
            // 
            // btnCollapseAll
            // 
            this.btnCollapseAll.Location = new System.Drawing.Point(17, 286);
            this.btnCollapseAll.Name = "btnCollapseAll";
            this.btnCollapseAll.Size = new System.Drawing.Size(197, 23);
            this.btnCollapseAll.TabIndex = 22;
            this.btnCollapseAll.Text = "Collapse all";
            this.btnCollapseAll.Click += new System.EventHandler(this.btnCollapseAll_Click);
            // 
            // btnAddNodesToSelection
            // 
            this.btnAddNodesToSelection.Location = new System.Drawing.Point(16, 115);
            this.btnAddNodesToSelection.Name = "btnAddNodesToSelection";
            this.btnAddNodesToSelection.Size = new System.Drawing.Size(197, 23);
            this.btnAddNodesToSelection.TabIndex = 23;
            this.btnAddNodesToSelection.Text = "Add nodes to selection";
            this.btnAddNodesToSelection.Click += new System.EventHandler(this.btnAddNodesToSelection_Click);
            // 
            // cbxLogOnAfterDeselect
            // 
            this.cbxLogOnAfterDeselect.Location = new System.Drawing.Point(124, 49);
            this.cbxLogOnAfterDeselect.Name = "cbxLogOnAfterDeselect";
            this.cbxLogOnAfterDeselect.Size = new System.Drawing.Size(128, 24);
            this.cbxLogOnAfterDeselect.TabIndex = 25;
            this.cbxLogOnAfterDeselect.Text = "Log AfterDeselect";
            // 
            // cbxLogOnBeforeDeselect
            // 
            this.cbxLogOnBeforeDeselect.Location = new System.Drawing.Point(6, 49);
            this.cbxLogOnBeforeDeselect.Name = "cbxLogOnBeforeDeselect";
            this.cbxLogOnBeforeDeselect.Size = new System.Drawing.Size(128, 24);
            this.cbxLogOnBeforeDeselect.TabIndex = 24;
            this.cbxLogOnBeforeDeselect.Text = "Log BeforeDeselect";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Clear selection";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbxLogOnSelectionsChanged
            // 
            this.cbxLogOnSelectionsChanged.AutoSize = true;
            this.cbxLogOnSelectionsChanged.Location = new System.Drawing.Point(6, 79);
            this.cbxLogOnSelectionsChanged.Name = "cbxLogOnSelectionsChanged";
            this.cbxLogOnSelectionsChanged.Size = new System.Drawing.Size(153, 17);
            this.cbxLogOnSelectionsChanged.TabIndex = 27;
            this.cbxLogOnSelectionsChanged.Text = "Log OnSelectionsChanged";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.cbxLogOnSelectionsChanged);
            this.groupBox1.Controls.Add(this.cbxLogAfterSelectEvent);
            this.groupBox1.Controls.Add(this.cbxLogBeforeSelectEvents);
            this.groupBox1.Controls.Add(this.cbxLogOnAfterDeselect);
            this.groupBox1.Controls.Add(this.cbxLogOnBeforeDeselect);
            this.groupBox1.Location = new System.Drawing.Point(492, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 480);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logging";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelectionColor);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cbxLabelEdit);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.cmbSelectionMode);
            this.groupBox2.Controls.Add(this.btnSelectNodes);
            this.groupBox2.Controls.Add(this.btnAddNodesToSelection);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnCollapseAll);
            this.groupBox2.Controls.Add(this.btnForeColor);
            this.groupBox2.Controls.Add(this.btnExpandAll);
            this.groupBox2.Controls.Add(this.btnBackColor);
            this.groupBox2.Location = new System.Drawing.Point(255, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 480);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.treeView1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(11, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 480);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Coders Lab Multi-Select TreeView";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(770, 499);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void button1_Click(object sender, System.EventArgs e)
        {
            ShowSelectedNodes();
        }

        private void ShowSelectedNodes()
        {

            MessageBox.Show(GetNodesAsString(treeView1.SelectedNodes));
        }

        private string GetNodesAsString(CodersLab.Windows.Controls.NodesCollection arrtn)
        {
            System.Text.StringBuilder strb = new System.Text.StringBuilder();
            strb.Append("Selected nodes: ");
            strb.Append("\r\n");
            foreach (TreeNode tn in arrtn)
            {
                strb.Append("     " + tn.Text);
                strb.Append("\r\n");
            }
            return strb.ToString();
        }

        private void cmbSelectionMode_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (cmbSelectionMode.SelectedIndex)
            {
                case 0:
                    treeView1.SelectionMode = CodersLab.Windows.Controls.TreeViewSelectionMode.SingleSelect;
                    break;
                case 1:
                    treeView1.SelectionMode = CodersLab.Windows.Controls.TreeViewSelectionMode.MultiSelect;
                    break;
                case 2:
                    treeView1.SelectionMode = CodersLab.Windows.Controls.TreeViewSelectionMode.MultiSelectSameRootBranch;
                    break;
                case 3:
                    treeView1.SelectionMode = CodersLab.Windows.Controls.TreeViewSelectionMode.MultiSelectSameLevel;
                    break;
                case 4:
                    treeView1.SelectionMode = CodersLab.Windows.Controls.TreeViewSelectionMode.MultiSelectSameLevelAndRootBranch;
                    break;
                case 5:
                    treeView1.SelectionMode = CodersLab.Windows.Controls.TreeViewSelectionMode.MultiSelectSameParent;
                    break;
            }
        }

        private void btnSelectNodes_Click(object sender, System.EventArgs e)
        {
            treeView1.SelectedNodes.Clear();
            foreach (TreeNode tn in arrTreeNodesToBeSelected)
            {
                treeView1.SelectedNodes.Add(tn);
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            TreeNode[] arrTn = (TreeNode[])arrTreeNodesToBeSelected.ToArray(typeof(TreeNode));
            arrTn[2].BeginEdit();

        }

        private void treeView1_DoubleClick(object sender, System.EventArgs e)
        {
            Point ptCursor = Cursor.Position;
            Point pt = treeView1.PointToClient(ptCursor);
            TreeNode tn = treeView1.GetNodeAt(pt);
            if (tn != null)
            {
                richTextBox1.Text += "Double click: " + tn + "\n";
            }
        }

        private void treeView1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point pt = treeView1.PointToClient(new Point(e.X, e.Y));
            TreeNode tn = treeView1.GetNodeAt(e.X, e.Y);
            if (e.Button == MouseButtons.Right)
            {
                if (!tn.IsSelected)
                {
                    TreeNode[] arrtn = new TreeNode[1];
                    arrtn[0] = tn;
                }
            }

        }

        private void treeView1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //			if (e.Button == MouseButtons.Left)
            //			{
            //				Point pt = treeView1.PointToClient(new Point(e.X, e.Y));
            //				TreeNode tn = treeView1.GetNodeAt(e.X, e.Y);
            //
            //				Point ptCursor = this.PointToClient(Cursor.Position);
            //
            //				if (tn != null)
            //				{
            //					//if (!treeView1.RubberBandSelectionOnGoing)
            //					//{
            //						treeView1.DoDragDrop(treeView1.SelectedNodes, DragDropEffects.Move);					
            //					//}
            //				}
            //			}
        }

        private void treeView1_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void treeView1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            Point pt = ((CodersLab.Windows.Controls.TreeView)sender).PointToClient(new Point(e.X, e.Y));
            TreeNode DestinationNode = ((CodersLab.Windows.Controls.TreeView)sender).GetNodeAt(pt);

            if (e.Data.GetDataPresent(typeof(CodersLab.Windows.Controls.NodesCollection)))
            {
                CodersLab.Windows.Controls.NodesCollection si = (CodersLab.Windows.Controls.NodesCollection)e.Data.GetData(typeof(CodersLab.Windows.Controls.NodesCollection));
                richTextBox1.Text += "Dropping " + GetNodesAsString(si) + " to " + DestinationNode + "\n";
            }

        }

        private void treeView1_DoubleClick_1(object sender, System.EventArgs e)
        {
            ShowSelectedNodes();
        }

        private void treeView1_BeforeSelect(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
        {
            if (e.Node.Text == "Node 1")
            {
                e.Cancel = true;
            }

            if (cbxLogBeforeSelectEvents.Checked)
            {
                if (e.Node.Text == "Node 1")
                {

                    richTextBox1.Text += "Before select: " + e.Node + " and cancelling selection" + "\n";
                }
                else
                {
                    richTextBox1.Text += "Before select: " + e.Node + "\n";
                }
            }


        }

        private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            if (cbxLogAfterSelectEvent.Checked)
            {
                richTextBox1.Text += "After select" + e.Node + "\n";
            }
        }




        private void btnSelectionColor_Click(object sender, System.EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = treeView1.SelectionBackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.SelectionBackColor = colorDialog.Color;
            }
        }

        private void btnForeColor_Click(object sender, System.EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = treeView1.ForeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.ForeColor = colorDialog.Color;
            }
        }

        private void btnBackColor_Click(object sender, System.EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = treeView1.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.BackColor = colorDialog.Color;
            }
        }

        private void cbxLabelEdit_CheckedChanged(object sender, System.EventArgs e)
        {
            treeView1.LabelEdit = cbxLabelEdit.Checked;
        }


        private void treeView1_ItemDrag(object sender, System.Windows.Forms.ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void treeView1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void btnExpandAll_Click(object sender, System.EventArgs e)
        {
            treeView1.SuspendLayout();
            treeView1.ExpandAll();
            treeView1.ResumeLayout();
        }

        private void btnCollapseAll_Click(object sender, System.EventArgs e)
        {
            treeView1.SuspendLayout();
            treeView1.CollapseAll();
            treeView1.ResumeLayout();
        }

        private void btnAddNodesToSelection_Click(object sender, System.EventArgs e)
        {
            foreach (TreeNode tn in arrTreeNodesToBeSelected2)
            {
                treeView1.SelectedNodes.Add(tn);
            }
        }

        private void treeView1_BeforeDeselect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            if (cbxLogOnBeforeDeselect.Checked)
            {
                richTextBox1.Text += "Before deselect" + e.Node + "\n";
            }
        }

        private void treeView1_AfterDeselect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            if (cbxLogOnAfterDeselect.Checked)
            {
                richTextBox1.Text += "After deselect" + e.Node + "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNodes.Clear();
        }

        private void treeView1_SelectionsChanged(object sender, EventArgs e)
        {
            if (cbxLogOnSelectionsChanged.Checked)
            {
                richTextBox1.Text += "Selections changed" + "\n";
            }
        }






    }
}
