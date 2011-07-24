using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HaRepackerLib.Controls
{
    public class DoubleInput : TextBox
    {
        public DoubleInput()
        {
            this.KeyPress += new KeyPressEventHandler(HandleKeyPress);
        }

        private void HandleKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == "."[0] && !this.Text.Contains("."))))
                e.Handled = true;
        }

        private int PASTE = 770;

        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == 770)
            {
                string cbdata = (string)Clipboard.GetDataObject().GetData(typeof(string));
                double foo = 0;
                if (!double.TryParse(cbdata, out foo))
                {
                    msg.Result = IntPtr.Zero;
                    return;
                }
            }
            base.WndProc(ref msg);
        }

        public double Value
        {
            get
            {
                return double.Parse(this.Text);
            }
        }
    } 
}
