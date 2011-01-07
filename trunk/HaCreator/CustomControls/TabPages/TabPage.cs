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

using System.Windows.Forms;

namespace TabPages
{
    /// <summary>
    /// Encapsulates tab information for a specified control/page.
    /// </summary>
    public class TabPage
    {
        public event ParentChangedEventHandler ParentChanged;
        public delegate void ParentChangedEventHandler();

        public object Tag;

        internal TabPageControl TabPageCtl;

        private PageCollection myParent = null;
        /// <summary>
        /// Gets the tabpages control to which this page belongs.
        /// </summary>
        public PageCollection Parent
        {
            get { return myParent; }
        }

        /// <summary>
        /// Gets or sets the text to be displayed in the tab.
        /// </summary>
        public string Text
        {
            get { return TabPageCtl.Text; }
            set { TabPageCtl.Text = value; }
        }

        /// <summary>
        /// Gets or sets the text to be displayed as the tab's tool-tip (in addition to the tab's text).
        /// </summary>
        public string ToolTip
        {
            get { return TabPageCtl.ToolTip; }
            set { TabPageCtl.ToolTip = value; }
        }

        private Control myControl = null;
        /// <summary>
        /// Gets or sets the control to be displayed when this tab is selected.
        /// </summary>
        public Control Control
        {
            get { return myControl; }
            set { myControl = value; }
        }

        /// <summary>
        /// Gets or sets the context menu on right click
        /// </summary>
        public ContextMenuStrip Menu
        {
            get { return TabPageCtl.Menu; }
            set { TabPageCtl.Menu = value; }
        }

        /// <summary>
        /// Closes this tab (and raises the close event).
        /// </summary>
        public void Close()
        {
            this.TabPageCtl.Close();
        }

        public TabPage(string text, Control control, string toolTip /*default null*/, ContextMenuStrip menu)
        {
            this.TabPageCtl = new TabPageControl(this);
            this.Text = text;
            this.Control = control;
            this.ToolTip = toolTip;
            this.Menu = menu;
        }

        internal void SetParent(PageCollection parent)
        {
            this.myParent = parent;
            if (ParentChanged != null)
            {
                ParentChanged();
            }
        }
    }
}