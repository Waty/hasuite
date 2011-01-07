/*  KoolkTextBox - Numbers-only TextBox
 * Copyright (C) 2009, 2010 Koolk, haha01haha01
   
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

namespace HaCreator
{
    using System;
    using System.Windows.Forms;

    public class KoolkTextBox : TextBox
    {
        private int Field_00 = 0x100;
        private int Field_01 = 770;

        protected override void WndProc(ref Message A_0)
        {
            if (A_0.Msg == this.Field_01)
            {
                string data = (string) Clipboard.GetDataObject().GetData(typeof(string));
                string str2 = data;
                int num = 0;
                do
                {
                    char c = str2[num];
                    if (!char.IsDigit(c))
                    {
                        A_0.Result = IntPtr.Zero;
                        return;
                    }
                    num++;
                }
                while (num < str2.Length);
            }
            base.WndProc(ref A_0);
        }

        public int GetValue(int defaultValue)
        {
            if (Text == "") return defaultValue;
            else return int.Parse(Text);
        }

        public override bool PreProcessMessage(ref Message msg)
        {
            // This item is obfuscated and can not be translated.
            bool flag = true, flag2 = true, flag3 = true, flag4 = true, flag5 = true, flag6 = true;
            if (msg.Msg != this.Field_00)
            {
                return base.PreProcessMessage(ref msg);
            }
            Keys keys = (Keys) msg.WParam.ToInt32();
            if (((keys < Keys.D0) || (keys > Keys.D9)) && ((keys < Keys.NumPad0) || (keys > Keys.NumPad9)))
            {
                flag = false;
            }
            flag2 = keys == Keys.Control;
            if (keys != Keys.Z)
            {
                flag3 = false;
            }
            if (keys != Keys.X)
            {
                flag4 = false;
            }
            if (keys != Keys.C)
            {
                flag5 = false;
            }
            if (keys != Keys.V)
            {
                flag6 = false;
            }
            bool flag7 = keys == Keys.Delete;
            bool flag8 = keys == Keys.Back;
            bool flag9 = (((keys == Keys.Up) | (keys == Keys.Down)) | (keys == Keys.Left)) | (keys == Keys.Right);
            if (!(((((((flag | flag2) | flag7) | flag8) | flag9) | flag5) | flag4) | flag3))
            {
                if (!flag6)
                {
                    return true;
                }
                string data = (string) Clipboard.GetDataObject().GetData(typeof(string));
                string str2 = data;
                int num = 0;
                do
                {
                    char c = str2[num];
                    if (!char.IsDigit(c))
                    {
                        return true;
                    }
                    num++;
                }
                while (num < str2.Length);
            }
            return false;
        }
    }
}

