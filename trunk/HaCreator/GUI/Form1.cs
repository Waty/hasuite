/*  HaCreator - MapleStory Map Editor
 * Copyright (C) 2009, 2010  haha01haha01
   
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XNA = Microsoft.Xna.Framework;
using HaCreator.MapEditor;
using MapleLib.WzLib.WzStructure;

namespace HaCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ObjectInfo info1 = new ObjectInfo(new Bitmap(@"D:\asdf.png"), new Point(10, 10), "test", "test", "test", "test", null);
            ObjectInfo info2 = new ObjectInfo(new Bitmap(@"D:\asdf2.png"), new Point(10, 10), "test", "test", "test", "test", null);
            ContextMenuStrip menuStrip = new ContextMenuStrip();
            menuStrip.Items.Add(new ToolStripMenuItem("Edit map info..."));
            CreateMap("Map1", "test", menuStrip, new XNA.Point(1500, 1500), new XNA.Point(101, 101), 8);
            CreateMap("Map2", "test", menuStrip, new XNA.Point(500, 500), new XNA.Point(101, 101), 8);
            multiBoard.Boards[0].MapInfo = MapInfo.Default;
            multiBoard.Boards[1].MapInfo = MapInfo.Default;
            multiBoard.Start();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
                multiBoard.Boards[0].BoardItems.TileObjs.Add(new ObjectInstance(((i % 2) == 0) ? info1 : info2, multiBoard.Boards[0].Layers[0], multiBoard.Boards[0], rand.Next(1500), rand.Next(1500), rand.Next(99), false, false, false, false, null, null, null, null, null, null, null, ((i % 3) == 0) ? true : false, false));
            for (int i = 0; i < 1; i++)
                multiBoard.Boards[1].BoardItems.TileObjs.Add(new ObjectInstance(((i % 2) == 0) ? info1 : info2, multiBoard.Boards[1].Layers[0], multiBoard.Boards[1], rand.Next(500), rand.Next(500), rand.Next(99), false, false, false, false, null, null, null, null, null, null, null, ((i % 3) == 0) ? true : false, false));
            multiBoard.Boards[0].BoardItems.ToolTips.Add(new HaCreator.MapEditor.ToolTip(multiBoard.Boards[0], new Microsoft.Xna.Framework.Rectangle(0, 0, 500, 500), "roflmao", "asdf"));
            multiBoard.Boards[0].BoardItems.CharacterToolTips.Add(new ToolTipChar(multiBoard.Boards[0], new Microsoft.Xna.Framework.Rectangle(0, 0, 500, 500), multiBoard.Boards[0].BoardItems.ToolTips[0]));
            multiBoard.Boards[0].BoardItems.Sort();
            multiBoard.Boards[1].BoardItems.Sort();
            InputHandler handler = new InputHandler(multiBoard);
        }

        private void CreateMap(string text, string tooltip, ContextMenuStrip menu, XNA.Point size, XNA.Point center, int layers)
        {
            Board newBoard = multiBoard.CreateBoard(size, center, layers);
            TabPages.TabPage page = new TabPages.TabPage(text, multiBoard, tooltip, menu);
            page.Tag = newBoard;
            Tabs.Add(page);
            Tabs.CurrentPage = page;
            multiBoard.SelectedBoard = newBoard;
        }

        private void FPSUpdater_Tick(object sender, EventArgs e)
        {
            Text = multiBoard.FPS.ToString();
        }

        private bool SelectColor(ref Color result)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return false;
            result = dialog.Color;
            return true;
        }

        private void Tabs_CurrentPageChanged(TabPages.TabPage currentPage, TabPages.TabPage previousPage)
        {
            multiBoard.SelectedBoard = (Board)currentPage.Tag;
            multiBoard.Focus();
        }
    }
}