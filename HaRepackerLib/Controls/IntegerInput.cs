using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HaRepackerLib.Controls
{
    public class IntegerInput : TextBox
    {
        public IntegerInput()
        {
            this.KeyPress += new KeyPressEventHandler(HandleKeyPress);
        }

        private void HandleKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == 770)
            {
                string cbdata = (string)Clipboard.GetDataObject().GetData(typeof(string));
                int foo = 0;
                if (!int.TryParse(cbdata, out foo))
                {
                    msg.Result = IntPtr.Zero;
                    return;
                }
            }
            base.WndProc(ref msg);
        }

        public int Value
        {
            get
            {
                return int.Parse(this.Text);
            }
        }
    } 
}
