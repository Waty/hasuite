/*  HaRepacker - WZ extractor and repacker
 * Copyright (C) 2009, 2010 haha01haha01
   
 * This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

 * This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

 * You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.*/

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
                double result = 0;
                if (double.TryParse(this.Text, out result)) return result;
                else return 0;
            }
            set
            {
                this.Text = value.ToString();
            }
        }
    } 
}
