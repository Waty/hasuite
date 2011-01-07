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
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using MapleLib.WzLib;
using HaCreator.MapEditor;
using MapleLib.WzLib.Util;

namespace HaCreator.GUI
{
    public partial class Initialization : DevComponents.DotNetBar.Office2007Form
    {
        //public Hashtable WzFiles = new Hashtable();

        public Initialization()
        {
            InitializeComponent();
            styleManager.ManagerStyle = UserSettings.applicationStyle;
        }

        public static bool XNASelfCheck(ref string exceptionResult)
        {
            try
            {
                Microsoft.Xna.Framework.Point foo = new Microsoft.Xna.Framework.Point();
                foo.X = 1337; //to shut VS up;
                return true;
            }
            catch (Exception e)
            {
                exceptionResult = e.Message;
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplicationSettings.MapleVersionIndex = versionBox.SelectedIndex;
            ApplicationSettings.MapleFolderIndex = pathBox.SelectedIndex;
            string wzPath = (string)pathBox.SelectedItem;
            if (wzPath == "Select Maple Folder")
            {
                MessageBox.Show("Please select the maple folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ApplicationSettings.MapleFolder.Contains(wzPath))
                ApplicationSettings.MapleFolder = ApplicationSettings.MapleFolder + "," + wzPath;
            WzMapleVersion fileVersion;
            short version = -1;
            if (versionBox.SelectedIndex == 3)
                fileVersion = WzTool.DetectMapleVersion(Path.Combine(wzPath, "Item.wz"), out version);
            else
                fileVersion = (WzMapleVersion)versionBox.SelectedIndex;
            //TL; DR: Snow is a fucking genius
            //Below code (or more like, the fact it's not in use anymore) serves as proof
            /*textBox2.Text = "Checking System Requirements...";
            string exceptResult = "";
            if (!MapleLib.WzLib.Util.WzTool.AESSelfCheck(ref exceptResult))
            {
                if (exceptResult.Contains("System.Core"))
                {
                    switch (MessageBox.Show("HaCreator has detected that your computer is not running the latest .NET Framework.\r\n\r\nClick \"Yes\" to close the editor and go to the download page on Microsoft's site\r\nClick \"No\" to ignore the error and continue loading\r\nClick \"Cancel\" to close the editor and do nothing", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error))
                    {
                        case DialogResult.Yes:
                            System.Diagnostics.Process.Start(@"http://www.microsoft.com/downloads/details.aspx?FamilyID=a9ef9a95-58d2-4e51-a4b7-bea3cc6962cb&displaylang=en#filelist");
                            Application.Exit();
                            return;
                        case DialogResult.No:
                            break;
                        case DialogResult.Cancel:
                            Application.Exit();
                            return;
                    }
                }
                else
                {
                    MessageBox.Show("Unknown error occured during wzKey generation self check: " + exceptResult);
                    Application.Exit();
                }
            }
            if (!XNASelfCheck(ref exceptResult))
            {
                switch (MessageBox.Show("HaCreator has detected that your computer is not running the XNA Framework.\r\n\r\nClick \"Yes\" to close the editor and go to the download page on Microsoft's site\r\nClick \"No\" to ignore the error and continue loading\r\nClick \"Cancel\" to close the editor and do nothing", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error))
                {
                    case DialogResult.Yes:
                        System.Diagnostics.Process.Start(@"http://www.microsoft.com/downloads/details.aspx?FamilyID=53867a2a-e249-4560-8011-98eb3e799ef2&displaylang=en");
                        Application.Exit();
                        return;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        Application.Exit();
                        return;
                }
            }*/
            /*if (!WzTools.DataAssemblyExists(ref exceptResult))
            {
                if (exceptResult.Contains("Unable to load DLL 'ManagedZLib.dll': The specified module could not be found."))
                {
                    MessageBox.Show("Error at WzKey generation self test. Make sure ManagedZLib.dll is in the same folder with HaCreator and is valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    switch (MessageBox.Show("HaCreator has detected that your computer is not running the Visual C++ Runtime Libraries. This may cause problems.\r\n\r\nClick \"Yes\" to close the editor and go to the download page on Microsoft's site\r\nClick \"No\" to ignore the error and continue loading\r\nClick \"Cancel\" to close the editor and do nothing", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error))
                    {
                        case DialogResult.Yes:
                            System.Diagnostics.Process.Start(@"http://www.microsoft.com/downloads/details.aspx?familyid=32bc1bee-a3f9-4c13-9c99-220b62a191ee&displaylang=en");
                            Application.Exit();
                            return;
                        case DialogResult.No:
                            break;
                        case DialogResult.Cancel:
                            Application.Exit();
                            return;
                    }
                }
            }
            if (!CoreFunctions.MDXExists())
            {
                switch (MessageBox.Show("HaCreator has detected that your computer is not running the DirectX 9.0c End-User Runtime. This may cause problems.\r\n\r\nClick \"Yes\" to close the editor and go to the download page on Microsoft's site\r\nClick \"No\" to ignore the error and continue loading\r\nClick \"Cancel\" to close the editor and do nothing", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error))
                {
                    case DialogResult.Yes:
                        System.Diagnostics.Process.Start(@"http://www.microsoft.com/downloads/details.aspx?FamilyID=2DA43D38-DB71-4C1B-BC6A-9B6652CD92A3&displaylang=en");
                        Application.Exit();
                        return;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        Application.Exit();
                        return;
                }
            }
            if (!WzPngProperty.MSVCR80Exists())
            {
                switch (MessageBox.Show("HaCreator has detected that your computer is not running the Visual C++ Runtime Libraries. This may cause problems.\r\n\r\nClick \"Yes\" to close the editor and go to the download page on Microsoft's site\r\nClick \"No\" to ignore the error and continue loading\r\nClick \"Cancel\" to close the editor and do nothing", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error))
                {
                    case DialogResult.Yes:
                        System.Diagnostics.Process.Start(@"http://www.microsoft.com/downloads/details.aspx?familyid=32bc1bee-a3f9-4c13-9c99-220b62a191ee&displaylang=en");
                        Application.Exit();
                        return;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        Application.Exit();
                        return;
                }
            }*/
            Program.WzManager = new WzFileManager(wzPath, fileVersion);
            textBox2.Text = "Initializing String.wz...";
            Application.DoEvents();
            Program.WzManager.LoadWzFile("string");
            Program.WzManager.ExtractMaps();
            Program.WzManager.ExtractItems();
            textBox2.Text = "Initializing Mob.wz...";
            Application.DoEvents();
            Program.WzManager.LoadWzFile("mob");
            Program.WzManager.ExtractMobFile();
            textBox2.Text = "Initializing Npc.wz...";
            Application.DoEvents();
            Program.WzManager.LoadWzFile("npc");
            Program.WzManager.ExtractNpcFile();
            textBox2.Text = "Initializing Reactor.wz...";
            Application.DoEvents();
            Program.WzManager.LoadWzFile("reactor");
            Program.WzManager.ExtractReactorFile();
            textBox2.Text = "Initializing Sound.wz...";
            Application.DoEvents();
            Program.WzManager.LoadWzFile("sound");
            Program.WzManager.ExtractSoundFile();
            textBox2.Text = "Initializing Map.wz...";
            Application.DoEvents();
            Program.WzManager.LoadWzFile("map");
            Program.WzManager.ExtractMapMarks();
            Program.WzManager.ExtractPortals();
            Program.WzManager.ExtractTileSets();
            Program.WzManager.ExtractObjSets();
            Program.WzManager.ExtractBackgroundSets();
            textBox2.Text = "Initializing UI.wz...";
            Application.DoEvents();
            Program.WzManager.LoadWzFile("ui");
            //TL; DR: OOP is 1337
            //Below code (or more like, the fact it's not in use anymore) serves as proof
            /*try
            {
                WzImage mobStrings = Program.WzManager.GetWzFileByName("string").WzDirectory.GetImageByName("Mob.img");
                if (!mobStrings.Parsed)
                    mobStrings.ParseImage();
                toolStripProgressBar1.Maximum = mobStrings.WzProperties.Length;
                toolStripProgressBar1.Value = 0;
                foreach (IWzImageProperty mobString in mobStrings.WzProperties)
                {
                    toolStripProgressBar1.Value++;
                    Application.DoEvents();
                    if (!(mobString is WzExtendedProperty) || !(((WzExtendedProperty)mobString).ExtendedProperty is WzSubProperty))
                        continue;
                    string mobName = null;
                    try
                    {
                        mobName = ((WzStringProperty)((WzSubProperty)((WzExtendedProperty)mobString).ExtendedProperty)["name"]).Value;
                    }
                    catch
                    {
                        continue;
                    }
                    ProgramInitData.mobData.Add(mobName + "(ID:" + mobString.Name + ")", new MobInfo(CoreFunctions.AddLeadingZeros(mobString.Name, 7), null, new Point(), false));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing Mob.wz (" + ex.Message + ").\r\nCheck that the directory is valid and the file is not in use.");
                Application.Exit();
                return;
            }
            textBox2.Text = "Initializing Npc.wz...";
            try
            {
                WzFiles.Add("Npc.wz", new WzFile(Path.Combine(wzPath, "Npc.wz"), (WzMapleVersion)versionBox.SelectedIndex));
                ((WzFile)WzFiles["Npc.wz"]).ParseWzFile();
                WzImage npcStrings = (WzImage)((WzFile)WzFiles["String.wz"])["Npc.img"];
                if (!npcStrings.Parsed)
                    npcStrings.ParseImage();
                toolStripProgressBar1.Maximum = npcStrings.WzProperties.Length;
                toolStripProgressBar1.Value = 0;
                foreach (IWzImageProperty npcString in npcStrings.WzProperties)
                {
                    toolStripProgressBar1.Value++;
                    Application.DoEvents();
                    if (!(npcString is WzExtendedProperty) || !(((WzExtendedProperty)npcString).ExtendedProperty is WzSubProperty))
                        continue;
                    string npcName = null;
                    try
                    {
                        npcName = ((WzStringProperty)((WzSubProperty)((WzExtendedProperty)npcString).ExtendedProperty)["name"]).Value;
                    }
                    catch
                    {
                        continue;
                    }
                    ProgramInitData.npcData.Add(npcName + "(ID:" + npcString.Name + ")", new NpcInfo(CoreFunctions.AddLeadingZeros(npcString.Name, 7), null, new Point()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing Npc.wz (" + ex.Message + ").\r\nCheck that the directory is valid and the file is not in use.");
                Application.Exit();
                return;
            }
            textBox2.Text = "Initializing Map.wz...";
            try
            {
                WzFiles.Add("Map.wz", new WzFile(Path.Combine(wzPath, "Map.wz"), (WzMapleVersion)versionBox.SelectedIndex));
                ((WzFile)WzFiles["Map.wz"]).ParseWzFile();
                WzDirectory tileDirectory = (WzDirectory)((WzFile)WzFiles["Map.wz"])["Tile"];
                toolStripProgressBar1.Maximum = tileDirectory.WzImages.Length;
                toolStripProgressBar1.Value = 0;
                foreach (WzImage tileCategory in tileDirectory.WzImages)
                {
                    toolStripProgressBar1.Value++;
                    Application.DoEvents();
                    ProgramInitData.tileImages.Add(tileCategory.Name.Split(Convert.ToChar("."))[0]);
                }
                WzImage helper = (WzImage)((WzFile)WzFiles["Map.wz"])["MapHelper.img"];
                if (!helper.Parsed)
                    helper.ParseImage();
                foreach (WzExtendedProperty property in ((WzSubProperty)helper["mark"]).WzProperties)
                {
                    ProgramInitData.mapMarks.Add(property.Name, ((WzCanvasProperty)property.ExtendedProperty).PngProperty.PNG);
                }
                foreach (WzExtendedProperty property in ((WzSubProperty)((WzSubProperty)helper["portal"])["editor"]).WzProperties)
                {
                    WzVectorProperty origin = (WzVectorProperty)((WzCanvasProperty)property.ExtendedProperty)["origin"];
                    ProgramInitData.portalMarks.Add(property.Name, new OriginatedImage(new Point(origin.X.Value, origin.Y.Value), ((WzCanvasProperty)property.ExtendedProperty).PngProperty.PNG));
                }
                WzImage mapStringsParent = (WzImage)((WzFile)WzFiles["String.wz"])["Map.img"];
                if (!mapStringsParent.Parsed)
                    mapStringsParent.ParseImage();
                foreach (WzDirectory mapCategory in ((WzDirectory)((WzFile)WzFiles["Map.wz"])["Map"]).WzDirectories)
                {
                    foreach (WzImage mapImage in mapCategory.WzImages)
                    {
                        string mapID = mapImage.Name.Split(Convert.ToChar("."))[0];*/
/*                        string mapName = "";
                        try
                        {
                            WzSubProperty mapString = (WzSubProperty)mapStringsParent[CoreFunctions.RemoveLeadingZeros(mapID)];
                            mapName = ((WzStringProperty)mapString["mapName"]).Value;
                        }
                        catch
                        {
                        }*/
                        /*ProgramInitData.maps.Add(mapID + ".img");
                    }
                }
                WzDirectory objDirectory = (WzDirectory)((WzFile)WzFiles["Map.wz"])["Obj"];
                toolStripProgressBar1.Maximum = objDirectory.WzImages.Length;
                toolStripProgressBar1.Value = 0;
                foreach (WzImage objCategory in objDirectory.WzImages)
                {
                    toolStripProgressBar1.Value++;
                    Application.DoEvents();
                    ProgramInitData.objImages.Add(objCategory.Name.Split(Convert.ToChar("."))[0]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing Map.wz (" + ex.Message + ").\r\nCheck that the directory is valid and the file is not in use.");
                Application.Exit();
                return;
            }
            textBox2.Text = "Initializing Sound.wz...";
            try
            {
                WzFiles.Add("Sound.wz", new WzFile(Path.Combine(wzPath, "Sound.wz"), (WzMapleVersion)versionBox.SelectedIndex));
                ((WzFile)WzFiles["Sound.wz"]).ParseWzFile();
                toolStripProgressBar1.Maximum = ((WzFile)WzFiles["Sound.wz"]).WzDirectory.WzImages.Length;
                toolStripProgressBar1.Value = 0;
                foreach (WzImage soundImg in ((WzFile)WzFiles["Sound.wz"]).WzDirectory.WzImages)
                {
                    toolStripProgressBar1.Value++;
                    Application.DoEvents();
                    if (!soundImg.Name.Contains("Bgm"))
                        continue;
                    if (!soundImg.Parsed)
                    {
                        soundImg.silent = true;
                        soundImg.ParseImage();
                    }
                    foreach (IWzImageProperty sound in soundImg.WzProperties)
                    {
                        ProgramInitData.soundData.Add(soundImg.Name.Split(Convert.ToChar("."))[0] + "/" + sound.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing Sound.wz (" + ex.Message + ").\r\nCheck that the directory is valid and the file is not in use.");
                Application.Exit();
                return;
            }
            textBox2.Text = "Initializing Reactor.wz...";
            try
            {
                WzFiles.Add("Reactor.wz", new WzFile(Path.Combine(wzPath, "Reactor.wz"), (WzMapleVersion)versionBox.SelectedIndex));
                ((WzFile)WzFiles["Reactor.wz"]).ParseWzFile();
                toolStripProgressBar1.Maximum = ((WzFile)WzFiles["Reactor.wz"]).WzDirectory.WzImages.Length;
                toolStripProgressBar1.Value = 0;
                foreach (WzImage reactorImg in ((WzFile)WzFiles["Reactor.wz"]).WzDirectory.WzImages)
                {
                    toolStripProgressBar1.Value++;
                    Application.DoEvents();
                    ProgramInitData.reactorImages.Add(reactorImg.Name.Split(Convert.ToChar("."))[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing Reactor.wz (" + ex.Message + ").\r\nCheck that the directory is valid and the file is not in use.");
                Application.Exit();
                return;
            }
            textBox2.Text = "Initializing UI.wz...";
            WzFiles.Add("UI.wz", new WzFile(Path.Combine(wzPath, "UI.wz"), (WzMapleVersion)versionBox.SelectedIndex));
            ((WzFile)WzFiles["UI.wz"]).ParseWzFile();
            textBox2.Text = "OK";
            if (!Properties.Settings.Default.MapleFolder.Contains(wzPath))
            {
                Properties.Settings.Default.MapleFolder = Properties.Settings.Default.MapleFolder + "," + wzPath;
                Properties.Settings.Default.Save();
            }
            ProgramInitData.WzFiles = WzFiles;
            Hide();
            MainForm.Instance = new MainForm();
            new Load().ShowDialog();
            MainForm.Instance.ShowDialog();
            Application.Exit();*/
            Hide();
            Application.DoEvents();
            new Editor().ShowDialog();
            Application.Exit();
        }

        string[] commonMaplePaths = new string[] { @"C:\Nexon\MapleStory", @"C:\Program Files\WIZET\MapleStory", @"C:\MapleStory" };

        private void Initialization_Load(object sender, EventArgs e)
        {
            versionBox.SelectedIndex = 0;
            try
            {
                string[] paths = ApplicationSettings.MapleFolder.Split(',');
                foreach (string x in paths)
                    if (x != string.Empty)
                        pathBox.Items.Add(x);
                if (paths.Length == 1) foreach (string path in commonMaplePaths) 
                    if (Directory.Exists(path)) pathBox.Items.Add(path);
                if (pathBox.Items.Count == 0)
                    pathBox.Items.Add("Select Maple Folder");
            }
            catch
            {
            }
            versionBox.SelectedIndex = ApplicationSettings.MapleVersionIndex;
            if (pathBox.Items.Count < ApplicationSettings.MapleFolderIndex + 1)
                pathBox.SelectedIndex = pathBox.SelectedIndex = pathBox.Items.Count - 1;
            else pathBox.SelectedIndex = ApplicationSettings.MapleFolderIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog mapleSelect = new FolderBrowserDialog();
            if (mapleSelect.ShowDialog() != DialogResult.OK)
                return;
            pathBox.Items.Add(mapleSelect.SelectedPath);
            pathBox.SelectedIndex = pathBox.Items.Count - 1;
        }
    }
}