using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using HaCreator.MapEditor;
using MapleLib.WzLib.WzStructure;

namespace HaCreator.GUI.InstanceEditor
{
    public partial class ObjectInstanceEditor : Office2007Form
    {
        public ObjectInstance item;

        public ObjectInstanceEditor(ObjectInstance item)
        {
            InitializeComponent();
            cxBox.Tag = cxInt;
            cyBox.Tag = cyInt;
            rxBox.Tag = rxInt;
            ryBox.Tag = ryInt;
            nameEnable.Tag = nameBox;
            questEnable.Tag = new Control[] { questAdd, questRemove, questList };
            tagsEnable.Tag = tagsBox;

            this.item = item;
            styleManager.ManagerStyle = UserSettings.applicationStyle;
            xInput.Value = item.X;
            yInput.Value = item.Y;
            zInput.Value = item.Z;
            rBox.Checked = item.r;
            pathLabel.Text = Editor.CreateItemDescription(item, "\r\n");
            if (item.Name != null)
            {
                nameEnable.Checked = true;
                nameBox.Text = item.Name;
            }
            rBox.Checked = item.r;
            flowBox.Checked = item.flow;
            SetOptionalInt(rxInt, rxBox, item.rx);
            SetOptionalInt(ryInt, ryBox, item.ry);
            SetOptionalInt(cxInt, cxBox, item.cx);
            SetOptionalInt(cyInt, cyBox, item.cy);
            if (item.tags == null) tagsEnable.Checked = false;
            else { tagsEnable.Checked = true; tagsBox.Text = item.tags; }
            if (item.QuestInfo != null)
            {
                questEnable.Checked = true;
                foreach (ObjectInstanceQuest info in item.QuestInfo)
                    questList.Items.Add(info);
            }
        }

        private void SetOptionalInt(DevComponents.Editors.IntegerInput intinput, DevComponents.DotNetBar.Controls.CheckBoxX checkbox, int? num)
        {
            if (num != null) { checkbox.Checked = true; intinput.Value = (int)num; }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            List<UndoRedoAction> actions = new List<UndoRedoAction>();
            if (xInput.Value != item.X || yInput.Value != item.Y)
            {
                actions.Add(UndoRedoManager.ItemMoved(item, new Microsoft.Xna.Framework.Point(item.X, item.Y), new Microsoft.Xna.Framework.Point(xInput.Value, yInput.Value)));
                item.Move(xInput.Value, yInput.Value);
            }
            if (zInput.Enabled && item.Z != zInput.Value)
            {
                actions.Add(UndoRedoManager.ItemZChanged(item, item.Z, zInput.Value));
                item.Z = zInput.Value;
                item.Board.BoardItems.Sort();
            }
            if (actions.Count > 0)
                item.Board.UndoRedoMan.AddUndoBatch(actions);
            item.Name = nameEnable.Checked ? nameBox.Text : null;
            item.flow = flowBox.Checked;
            item.reactor = reactorBox.Checked;
            item.r = rBox.Checked;
            item.hide = hideBox.Checked;
            item.rx = GetOptionalInt(rxInt, rxBox);
            item.ry = GetOptionalInt(ryInt, ryBox);
            item.cx = GetOptionalInt(cxInt, cxBox);
            item.cy = GetOptionalInt(cyInt, cyBox);
            item.tags = tagsEnable.Checked ? tagsBox.Text : null;
            if (questEnable.Checked)
            {
                List<ObjectInstanceQuest> questInfo = new List<ObjectInstanceQuest>();
                foreach (ObjectInstanceQuest info in questList.Items) questInfo.Add(info);
                item.QuestInfo = questInfo;
            }
            else item.QuestInfo = null;
            Close();
        }

        private int? GetOptionalInt(DevComponents.Editors.IntegerInput intinput, DevComponents.DotNetBar.Controls.CheckBoxX checkbox)
        {
            return checkbox.Checked ? (int?)intinput.Value : null;
        }

        private void enablingCheckBox_CheckChanged(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.Controls.CheckBoxX cbx = (DevComponents.DotNetBar.Controls.CheckBoxX)sender;
            bool featureActivated = cbx.Checked && cbx.Enabled;
            if (cbx.Tag is Control) ((Control)cbx.Tag).Enabled = featureActivated;
            else
            {
                foreach (Control control in (Control[])cbx.Tag) control.Enabled = featureActivated;
                foreach (Control control in (Control[])cbx.Tag) if (control is DevComponents.DotNetBar.Controls.CheckBoxX) enablingCheckBox_CheckChanged(control, e);
            }
        }

        private void questRemove_Click(object sender, EventArgs e)
        {
            if (questList.SelectedIndex != -1) questList.Items.RemoveAt(questList.SelectedIndex);
        }

        private void questAdd_Click(object sender, EventArgs e)
        {
            ObjQuestInput input = new ObjQuestInput();
            if (input.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                questList.Items.Add(input.result);
        }
    }
}
