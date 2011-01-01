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
    public partial class GeneralInstanceEditor : Office2007Form
    {
        public BoardItem item;

        public GeneralInstanceEditor(BoardItem item)
        {
            InitializeComponent();
            this.item = item;
            styleManager.ManagerStyle = UserSettings.applicationStyle;
            xInput.Value = item.X;
            yInput.Value = item.Y;
            if (item.Z == -1) zInput.Enabled = false;
            else zInput.Value = item.Z;
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
            if (zInput.Enabled && item.Z != zInput.Value)
            {
                actions.Add(UndoRedoManager.ItemZChanged(item, item.Z, zInput.Value));
                item.Z = zInput.Value;
                item.Board.BoardItems.Sort();
            }
            if (actions.Count > 0)
                item.Board.UndoRedoMan.AddUndoBatch(actions);
            Close();
        }
    }
}
