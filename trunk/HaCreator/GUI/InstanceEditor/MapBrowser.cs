using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MapleLib.WzLib.WzProperties;
using MapleLib.WzLib;
using System.Collections;

namespace HaCreator.GUI.InstanceEditor
{
    public partial class MapBrowser : DevComponents.DotNetBar.Office2007Form
    {
        public MapBrowser()
        {
            InitializeComponent();

            styleManager.ManagerStyle = UserSettings.applicationStyle;
        }

        public new static int? Show()
        {
            MapBrowser mb = new MapBrowser();
            mb.ShowDialog();
            return mb.result;
        }

        private int? result = null;

        private void mapNamesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mapNamesBox.SelectedItem == null)
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
            mapNamesBox.Items.Clear();
            foreach (string map in listBoxObjects)
                mapNamesBox.Items.Add(map);
        }

        private void MapBrowser_Load(object sender, EventArgs e)
        {
            List<string> listBoxObjects = new List<string>();
            foreach (DictionaryEntry map in Program.InfoManager.Maps)
                listBoxObjects.Add((string)map.Key + " - " + (string)map.Value);
            listBoxObjects.Sort();
            foreach (string map in listBoxObjects)
                mapNamesBox.Items.Add(map);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            result = int.Parse(((string)mapNamesBox.SelectedItem).Substring(0, 9));
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
