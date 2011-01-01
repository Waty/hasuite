using System;
using System.Drawing;
using System.Windows.Forms;

namespace HaRepackerLib
{
    public partial class ChangableTextbox : UserControl
    {
        public ChangableTextbox()
        {
            InitializeComponent();
        }

        public new string Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            if (this.Size.Height != textBox.Size.Height)
                this.Size = new Size(this.Size.Width, textBox.Size.Height);
            textBox.Location = new Point(0, 0);
            textBox.Size = new Size(this.Size.Width - applyButton.Width - applyButton.Margin.Left, textBox.Size.Height);
            applyButton.Location = new Point(textBox.Size.Width + textBox.Margin.Right, 0);
            base.OnSizeChanged(e);
        }

        public event EventHandler ButtonClicked;

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (ButtonClicked != null) ButtonClicked.Invoke(sender, e);
            applyButton.Enabled = false;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            applyButton.Enabled = true;
        }

        public bool ButtonEnabled
        {
            get { return applyButton.Enabled; }
            set { applyButton.Enabled = value; }
        }
    }
}
