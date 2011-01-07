using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MapleLib.WzLib.WzStructure.Data;

namespace HaCreator.GUI.InstanceEditor
{
    public partial class ObjQuestInput : DevComponents.DotNetBar.Office2007Form
    {
        public MapEditor.ObjectInstanceQuest result;

        public ObjQuestInput()
        {
            InitializeComponent();
            styleManager.ManagerStyle = UserSettings.applicationStyle;
            DialogResult = System.Windows.Forms.DialogResult.No;
            stateInput.SelectedIndex = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            result = new MapEditor.ObjectInstanceQuest(idInput.Value, (QuestState)stateInput.SelectedIndex);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
