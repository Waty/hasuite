using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HaCreator.MapEditor;

namespace HaCreator.GUI.InstanceEditor
{
    public partial class TnSelector : DevComponents.DotNetBar.Office2007Form
    {
        public static string Show(Board board)
        {
            TnSelector ps = new TnSelector(board);
            ps.ShowDialog();
            return ps.result;
        }

        private string result = null;

        public TnSelector(Board board)
        {
            InitializeComponent();

            styleManager.ManagerStyle = UserSettings.applicationStyle;

            foreach (PortalInstance pi in board.BoardItems.Portals)
            {
                if (pi.pn != null && pi.pn != "" && pi.pn != "sp" && pi.pn != "pt")
                    pnList.Items.Add(pi.pn);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            result = (string)pnList.SelectedItem;
            Close();
        }
    }
}
