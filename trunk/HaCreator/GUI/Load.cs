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

//uncomment the line below to create a space-time tradeoff (saving RAM by wasting more CPU cycles)
#define SPACETIME

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Xml;
using System.Linq;
using System.IO;
using MapleLib.WzLib;
using MapleLib.WzLib.WzProperties;
using HaCreator.MapEditor;
using XNA = Microsoft.Xna.Framework;
using TabPages;
using MapleLib.WzLib.WzStructure.Data;
using MapleLib.WzLib.WzStructure;
using MapleLib.Helpers;
using HaCreator.WzStructure;
using MapleLib.WzLib.Serialization;
using HaRepackerLib;

namespace HaCreator
{
    public partial class Load : DevComponents.DotNetBar.Office2007Form
    {
        public bool usebasepng = false;
        public int bufferzone = 100;
        private MultiBoard multiBoard;
        private TabPages.PageCollection Tabs;
        private EventHandler rightClickHandler;

        public Load(MultiBoard board, TabPages.PageCollection Tabs, EventHandler rightClickHandler)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            styleManager.ManagerStyle = UserSettings.applicationStyle;
            this.multiBoard = board;
            this.Tabs = Tabs;
            this.rightClickHandler = rightClickHandler;
        }

        private void Load_Load(object sender, EventArgs e)
        {
            newWidth.Text = ApplicationSettings.LastMapSize.Width.ToString();
            newHeight.Text = ApplicationSettings.LastMapSize.Height.ToString();
            if (multiBoard.Boards.Count == 0)
            {
                newTab.Checked = true;
                newTab.Enabled = false;
            }
            else
                newTab.Checked = ApplicationSettings.newTab;
            List<string> listBoxObjects = new List<string>();
            foreach (DictionaryEntry map in Program.InfoManager.Maps)
                listBoxObjects.Add((string)map.Key + " - " + (string)map.Value);
            listBoxObjects.Sort();
            listBoxObjects.Insert(0, "CashShopPreview");
            listBoxObjects.Insert(0, "MapLogin");
            listBoxObjects.Insert(0, "MapLogin1");
            foreach (string map in listBoxObjects)
                mapNamesBox.Items.Add(map);
            switch (ApplicationSettings.lastRadioIndex)
            {
                case 0:
                    NewSelect.Checked = true;
                    break;
                case 1:
                    XMLSelect.Checked = true;
                    break;
                case 2:
                    WZSelect.Checked = true;
                    break;
            }
        }

        private void XMLBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select the XML File";
            dialog.Filter = "XML|*.xml";
            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            XMLBox.Text = dialog.FileName;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string tosearch = searchBox.Text.ToLower();
            List<string> listBoxObjects = new List<string>();
            if (searchBox.Text == "")
                foreach (DictionaryEntry map in Program.InfoManager.Maps)
                    listBoxObjects.Add((string)map.Key + " - " + (string)map.Value);
            else foreach (DictionaryEntry map in Program.InfoManager.Maps)
            {
                string idName = (string)map.Key + " - " + (string)map.Value;
                if (idName.ToLower().Contains(tosearch))
                    listBoxObjects.Add(idName);
            }
            listBoxObjects.Sort();
            if (searchBox.Text == "")
            {
                listBoxObjects.Insert(0, "CashShopPreview");
                listBoxObjects.Insert(0, "MapLogin");
                listBoxObjects.Insert(0, "MapLogin1");
            }
            else if ("CashShopPreview".ToLower().Contains(tosearch))
                listBoxObjects.Add("CashShopPreview");
            else if ("MapLogin".ToLower().Contains(tosearch))
                listBoxObjects.Add("MapLogin");
            else if ("MapLogin1".ToLower().Contains(tosearch))
                listBoxObjects.Add("MapLogin1");
            mapNamesBox.Items.Clear();
            foreach (string map in listBoxObjects)
                mapNamesBox.Items.Add(map);
        }

        private void selectionChanged(object sender, EventArgs e)
        {
            if (NewSelect.Checked)
            {
                newWidth.Enabled = true;
                newHeight.Enabled = true;
                XMLBox.Enabled = false;
                searchBox.Enabled = false;
                mapNamesBox.Enabled = false;
                minimapBox.Visible = false;
            }
            else if (XMLSelect.Checked)
            {
                newWidth.Enabled = false;
                newHeight.Enabled = false;
                XMLBox.Enabled = true;
                searchBox.Enabled = false;
                mapNamesBox.Enabled = false;
                minimapBox.Visible = false;
            }
            else if (WZSelect.Checked)
            {
                newWidth.Enabled = false;
                newHeight.Enabled = false;
                XMLBox.Enabled = false;
                searchBox.Enabled = true;
                mapNamesBox.Enabled = true;
                minimapBox.Visible = true;
            }
        }

        private void mapNamesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)mapNamesBox.SelectedItem == "MapLogin" || 
                (string)mapNamesBox.SelectedItem == "MapLogin1" || 
                (string)mapNamesBox.SelectedItem == "CashShopPreview" || 
                mapNamesBox.SelectedItem == null)
            {
                linkLabel.Visible = false;
                mapNotExist.Visible = false;
                minimapBox.Image = (Image)new Bitmap(1, 1);
                loadButton.Enabled = true;
                return;
            }
            string mapid = ((string)mapNamesBox.SelectedItem).Substring(0, 9);
            string mapcat = "Map" + mapid.Substring(0, 1);
            WzImage mapImage = (WzImage)Program.WzManager["map"].GetObjectFromPath("Map.wz/Map/" + mapcat + "/" + mapid + ".img");
            if (mapImage == null)
            {
                linkLabel.Visible = false;
                mapNotExist.Visible = true;
                minimapBox.Image = (Image)new Bitmap(1, 1);
                loadButton.Enabled = false;
                return;
            }
            if (!mapImage.Parsed) mapImage.ParseImage();
            if (mapImage["info"]["link"] != null)
            {
                linkLabel.Visible = true;
                mapNotExist.Visible = false;
                minimapBox.Image = (Image)new Bitmap(1, 1);
                loadButton.Enabled = false;
            }
            else
            {
                linkLabel.Visible = false;
                mapNotExist.Visible = false;
                loadButton.Enabled = true;
                WzCanvasProperty minimap = (WzCanvasProperty)mapImage.GetFromPath("miniMap/canvas");
                if (minimap != null) minimapBox.Image = (Image)minimap.PngProperty.GetPNG(false);
                else minimapBox.Image = (Image)new Bitmap(1, 1);
            }
            mapImage.UnparseImage();
            GC.Collect();
        }

        private void browseXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select XML to load...";
            dialog.Filter = "eXtensible Markup Language file (*.xml)|*.xml";
            if (dialog.ShowDialog() != DialogResult.OK) return;
            XMLBox.Text = dialog.FileName;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (newTab.Checked && multiBoard.Boards.Count != 0)
                ApplicationSettings.newTab = true;
            else if (!newTab.Checked)
            {
                ApplicationSettings.newTab = false;
                Board toRemove = (Board)Tabs.CurrentPage.Tag;
                Tabs.Remove(Tabs.CurrentPage);
                toRemove.Dispose();
            }
            WzImage mapImage = null;
            string mapName = null, streetName = null;
            if (NewSelect.Checked)
            {
                ApplicationSettings.lastRadioIndex = 0;
                MapLoader.CreateMap("<Untitled>", "<Untitled>", MapLoader.CreateStandardMapMenu(rightClickHandler), new XNA.Point(int.Parse(newWidth.Text), int.Parse(newHeight.Text)), new XNA.Point(int.Parse(newWidth.Text) / 2, int.Parse(newHeight.Text) / 2), 8, Tabs, multiBoard);
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            else if (XMLSelect.Checked)
            {
                ApplicationSettings.lastRadioIndex = 1;
                try
                {
                    mapImage = (WzImage)new WzXmlDeserializer(false, null).ParseXML(XMLBox.Text)[0];
                }
                catch
                {
                    Warning.Error("Error while loading XML. Aborted.");
                    return;
                }
                //mapImage = WZXML.LoadMap(XMLBox.Text, ref mapName, ref streetName);
            }
            else if (WZSelect.Checked)
            {
                ApplicationSettings.lastRadioIndex = 2;
                if ((string)mapNamesBox.SelectedItem == "MapLogin")
                {
                    mapImage = (WzImage)Program.WzManager["ui"]["MapLogin.img"];
                    mapName = "MapLogin";
                    streetName = "";
                }
                else if ((string)mapNamesBox.SelectedItem == "MapLogin1")
                {
                    mapImage = (WzImage)Program.WzManager["ui"]["MapLogin1.img"];
                    mapName = "MapLogin1";
                    streetName = "";
                }
                else if ((string)mapNamesBox.SelectedItem == "CashShopPreview")
                {
                    mapImage = (WzImage)Program.WzManager["ui"]["CashShopPreview.img"];
                    mapName = "CashShopPreview";
                    streetName = "";
                }
                else
                {
                    string mapid = ((string)mapNamesBox.SelectedItem).Substring(0, 9);
                    string mapcat = "Map" + mapid.Substring(0, 1);
                    mapImage = (WzImage)Program.WzManager["map"].GetObjectFromPath("Map.wz/Map/" + mapcat + "/" + mapid + ".img");
                    mapName = WzInfoTools.GetMapNameById(mapid);
                    streetName = WzInfoTools.GetStreetNameById(mapid);
                }
            }
            MapLoader.CreateMapFromImage(mapImage, mapName, streetName, Tabs, multiBoard, rightClickHandler);
            DialogResult = DialogResult.OK;
            Close();
        }


    }
}
