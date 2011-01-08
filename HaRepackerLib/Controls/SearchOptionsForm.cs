using System;
using System.Windows.Forms;

namespace HaRepackerLib
{
    public partial class SearchOptionsForm : Form
    {
        public SearchOptionsForm()
        {
            InitializeComponent();

            parseImages.Checked = UserSettings.ParseImagesInSearch;
            searchValues.Checked = UserSettings.SearchStringValues;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserSettings.ParseImagesInSearch = parseImages.Checked;
            UserSettings.SearchStringValues = searchValues.Checked;
            Close();
        }
    }
}
