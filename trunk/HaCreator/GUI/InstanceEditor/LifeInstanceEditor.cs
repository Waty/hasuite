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
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;

namespace HaCreator.GUI.InstanceEditor
{
    public partial class LifeInstanceEditor : Office2007Form
    {
        public LifeInstance item;

        public LifeInstanceEditor(LifeInstance item)
        {
            InitializeComponent();
            this.item = item;
            styleManager.ManagerStyle = UserSettings.applicationStyle;
            infoEnable.Tag = infoBox;
            limitedNameEnable.Tag = limitedNameBox;
            mobTimeEnable.Tag = mobTimeBox;
            teamEnable.Tag = teamBox;
            typeEnable.Tag = typeBox;

            xInput.Value = item.X;
            yInput.Value = item.Y;
            rx0Box.Value = item.rx0;
            rx1Box.Value = item.rx1;
            LoadOptionalInt(item.Info, infoEnable, infoBox);
            LoadOptionalInt(item.Team, teamEnable, teamBox);
            LoadOptionalInt(item.MobTime, mobTimeEnable, mobTimeBox);
            LoadOptionalStr(item.TypeStr, typeEnable, typeBox);
            LoadOptionalStr(item.LimitedName, limitedNameEnable, limitedNameBox);
            hideBox.Checked = item.Hide;

            pathLabel.Text = Editor.CreateItemDescription(item, "\r\n");
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
            if (actions.Count > 0)
                item.Board.UndoRedoMan.AddUndoBatch(actions);
            item.rx0 = rx0Box.Value;
            item.rx1 = rx1Box.Value;
            item.MobTime = GetOptionalInt(mobTimeEnable, mobTimeBox);
            item.Info = GetOptionalInt(infoEnable, infoBox);
            item.Team = GetOptionalInt(teamEnable, teamBox);
            item.TypeStr = GetOptionalStr(typeEnable, typeBox);
            item.LimitedName = GetOptionalStr(limitedNameEnable, limitedNameBox);
            item.Hide = hideBox.Checked;
            Close();
        }

        private void enablingCheckBoxCheckChanged(object sender, EventArgs e)
        {
            CheckBoxX cbx = (CheckBoxX)sender;
//            if (cbx.Tag is Control)
                ((Control)cbx.Tag).Enabled = cbx.Checked;
//            else foreach (Control ctrl in (Control[])cbx.Tag)
//                    ctrl.Enabled = cbx.Checked;
        }

        private void LoadOptionalInt(int? value, CheckBoxX cbx, IntegerInput box)
        {
            if (value == null) cbx.Checked = false;
            else cbx.Checked = true; box.Value = (int)value;
        }

        private void LoadOptionalStr(string value, CheckBoxX cbx, TextBoxX box)
        {
            if (value == null) cbx.Checked = false;
            else cbx.Checked = true; box.Text = value;
        }

        private int? GetOptionalInt(CheckBoxX cbx, IntegerInput box)
        {
            if (cbx.Checked) return box.Value;
            else return null;
        }

        private string GetOptionalStr(CheckBoxX cbx, TextBoxX box)
        {
            if (cbx.Checked) return box.Text;
            else return null;
        }
    }
}
