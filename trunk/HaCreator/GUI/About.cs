using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace HaCreator.GUI
{
    public partial class About : Office2007Form
    {
        public About()
        {
            InitializeComponent();
            styleManager.ManagerStyle = UserSettings.applicationStyle;
        }
    }
}
