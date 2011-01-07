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

namespace HaCreator.GUI.InstanceEditor
{
    public partial class ReactorInstanceEditor : Office2007Form
    {
        public ReactorInstance item;

        public ReactorInstanceEditor(ReactorInstance item)
        {
            InitializeComponent();
            this.item = item;
            styleManager.ManagerStyle = UserSettings.applicationStyle;
            xInput.Value = item.X;
            yInput.Value = item.Y;
            pathLabel.Text = Editor.CreateItemDescription(item, "\r\n");
            if (item.Name == null) useName.Checked = false;
            else nameBox.Text = item.Name;
            timeBox.Value = item.ReactorTime;
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
            item.Name = useName.Checked ? nameBox.Text : null;
            item.ReactorTime = timeBox.Value;
            Close();
        }

        private void useName_CheckedChanged(object sender, EventArgs e)
        {
            nameBox.Enabled = useName.Checked;
        }
    }
}
