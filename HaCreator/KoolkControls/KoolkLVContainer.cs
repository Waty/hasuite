/*  KoolkListView - Improved ListView
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
    using System.Drawing;
    using System.Windows.Forms;

    public class KoolkLVContainer : FlowLayoutPanel
    {
        public KoolkLVItem createItem(Bitmap image, string name, bool viewName)
        {
            // This item is obfuscated and can not be translated.
            KoolkLVItem item = new KoolkLVItem {
                Dock = DockStyle.Bottom
            };
            if (image.Width > 100 || image.Height > 100) 
                image = (Bitmap)KoolkLVItem.ResizeImage(image, 100, 100);
            item.Image = image;
            item.viewName = viewName;
            item.Width = image.Width + 8;
            if (viewName)
                item.Height = image.Height + 20;
            else
                item.Height = image.Height + 8;
            item.Name = name;
            item.Field02 = false;
            base.Controls.Add(item);
            return item;
        }

        protected override Point ScrollToControl(Control activeControl)
        {
            return base.AutoScrollPosition;
        }

        public void ClearSelectedItems()
        {
            foreach (KoolkLVItem item in Controls)
                if (item.Selected) item.Selected = false;
        }
    }
}

