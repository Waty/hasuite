/*  TabPages - A tab control simlar to IE 7's. Created by christophilus,
    translated from VB to C# by haha01haha01.
 * Copyright (C) 2009, 2010  christophilus, haha01haha01
   
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

using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;
using System.Threading;

namespace TabPages
{
    /// <summary>
    /// This is the underlying control which eliminates flickering by disabling painting of all
    /// child and sub-controls.
    /// </summary>
    public abstract class FlickerFreeControl : Control
    {

        private const int WM_SETREDRAW = 0xb;
        [DllImport("User32", EntryPoint = "SendMessage", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        private static extern bool SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        /// <summary>
        /// This is your good old SendMessage function.  We'll be sending the magic WM_SETREDRAW message which suspends and resumes painting for this and all sub controls.  Sweeto.
        /// </summary>

        private int mySuspendPainting = 0;
        /// <summary>
        /// Stop painting while multiple changes are made to this and/or nested controls.
        /// </summary>
        /// <value>True to suspend painting.  False to resume painting.</value>
        /// <remarks>This actually increments a counter for each time it is set to true and decrements that 
        /// counter for each time it is set to false.  This is to prevent painting from resuming earlier than
        /// we might wish.</remarks>
        protected bool SuspendPainting
        {
            get { return mySuspendPainting > 0; }
            set
            {
                if ((!this.Visible || !this.IsHandleCreated)) return;

                if ((value))
                {
                    mySuspendPainting += 1;
                    if ((Interlocked.Increment(ref mySuspendPainting) == 1))
                    {
                        SendMessage(this.Handle, WM_SETREDRAW, 0, 0);
                    }
                }
                else
                {
                    if ((Interlocked.Decrement(ref mySuspendPainting) == 0))
                    {
                        SendMessage(this.Handle, WM_SETREDRAW, 1, 0);
                        this.Invalidate(true);
                    }
                }
            }
        }

        public FlickerFreeControl()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
    }
}