using System.Windows.Forms;

namespace HaRepackerLib
{
    public partial class XYPanel : UserControl
    {
        public XYPanel()
        {
            InitializeComponent();
        }

        public int X
        {
            get { return xBox.Value; }
            set { xBox.Value = value; }
        }

        public int Y
        {
            get { return yBox.Value; }
            set { yBox.Value = value; }
        }
    }
}
