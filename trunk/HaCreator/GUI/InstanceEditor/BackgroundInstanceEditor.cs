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
using MapleLib.WzLib.WzStructure.Data;

namespace HaCreator.GUI.InstanceEditor
{
    public partial class BackgroundInstanceEditor : Office2007Form
    {
        public BackgroundInstance item;

        public BackgroundInstanceEditor(BackgroundInstance item)
        {
            InitializeComponent();
            this.item = item;
            styleManager.ManagerStyle = UserSettings.applicationStyle;
            xInput.Value = item.X;
            yInput.Value = item.Y;
            if (item.Z == -1) zInput.Enabled = false;
            else zInput.Value = item.Z;
            pathLabel.Text = Editor.CreateItemDescription(item, "\r\n");
            typeBox.Items.AddRange((object[])Tables.BackgroundTypeNames.Cast<object>());
            typeBox.SelectedIndex = (int)item.type;
            alphaBox.Value = item.a;
            front.Checked = item.front;
            rxBox.Value = item.rx;
            ryBox.Value = item.ry;
            cxBox.Value = item.cx;
            cyBox.Value = item.cy;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            List<UndoRedoAction> actions = new List<UndoRedoAction>();
            bool sort = false;
            if (xInput.Value != item.X || yInput.Value != item.Y)
            {
                actions.Add(UndoRedoManager.ItemMoved(item, new Microsoft.Xna.Framework.Point(item.X, item.Y), new Microsoft.Xna.Framework.Point(xInput.Value, yInput.Value)));
                item.Move(xInput.Value, yInput.Value);
            }
            if (zInput.Enabled && item.Z != zInput.Value)
            {
                actions.Add(UndoRedoManager.ItemZChanged(item, item.Z, zInput.Value));
                item.Z = zInput.Value;
                sort = true;
            }
            if (front.Checked != item.front)
            {
                (item.front ? item.Board.BoardItems.FrontBackgrounds : item.Board.BoardItems.BackBackgrounds).Remove(item);
                (item.front ? item.Board.BoardItems.BackBackgrounds : item.Board.BoardItems.FrontBackgrounds).Add(item);
                item.front = front.Checked;
                sort = true;
            }
            if (sort) item.Board.BoardItems.Sort();
            if (actions.Count > 0)
                item.Board.UndoRedoMan.AddUndoBatch(actions);

            item.type = (BackgroundType)typeBox.SelectedIndex;
            item.a = alphaBox.Value;
            item.rx = rxBox.Value;
            item.ry = ryBox.Value;
            item.cx = cxBox.Value;
            item.cy = cyBox.Value;
            Close();
        }
    }
}
