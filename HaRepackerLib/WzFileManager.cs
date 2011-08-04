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
using System.Collections;
using MapleLib.WzLib;
using MapleLib.WzLib.WzProperties;
using System.Windows.Forms;
using System.IO;
using MapleLib.WzLib.Util;
using HaRepackerLib.Controls;

namespace HaRepackerLib
{
    public class WzFileManager
    {
        private List<WzFile> wzFiles = new List<WzFile>();

        public WzFileManager()
        {
        }

        private bool OpenWzFile(string path, WzMapleVersion encVersion, short version, out WzFile file)
        {
            try
            {
                WzFile f = new WzFile(path, version, encVersion);
                wzFiles.Add(f);
                f.ParseWzFile();
                file = f;
                return true;
            }
            catch (Exception e)
            {
                Warning.Error("Error initializing " + Path.GetFileName(path) + " (" + e.Message + ").\r\nCheck that the directory is valid and the file is not in use.");
                file = null;
                return false;
            }
        }

        public void UnloadWzFile(WzFile file)
        {
            ((WzNode)file.HRTag).Delete();
            wzFiles.Remove(file);
        }

        public void ReloadWzFile(WzFile file, HaRepackerMainPanel panel)
        {
            WzMapleVersion encVersion = file.MapleVersion;
            string path = file.FilePath;
            short version = ((WzFile)file).Version;
            ((WzNode)file.HRTag).Delete();
            wzFiles.Remove(file);
            LoadWzFile(path, encVersion, (short)-1, panel);
        }

        public void LoadWzFile(string path, HaRepackerMainPanel panel)
        {
            short fileVersion = -1;
            bool isList = WzTool.IsListFile(path);
            LoadWzFile(path, WzTool.DetectMapleVersion(path, out fileVersion), fileVersion, panel);
        }

        public void LoadWzFile(string path, WzMapleVersion encVersion, HaRepackerMainPanel panel)
        {
            LoadWzFile(path, encVersion, (short)-1, panel);
        }

        private void LoadWzFile(string path, WzMapleVersion encVersion, short version, HaRepackerMainPanel panel)
        {
            WzFile newFile;
            if (!OpenWzFile(path, encVersion, version, out newFile)) return;
            WzNode node = new WzNode(newFile);
            panel.DataTree.Nodes.Add(node);
            SortNodesRecursively(node);
        }

        public void InsertWzFileUnsafe(WzFile f, HaRepackerMainPanel panel)
        {
            wzFiles.Add(f);
            WzNode node = new WzNode(f);
            panel.DataTree.Nodes.Add(node);
            SortNodesRecursively(node);
        }

        private void SortNodesRecursively(WzNode parent)
        {
            parent.TreeView.Sort();
        }

        public void ReloadAll(HaRepackerMainPanel panel)
        {
            for (int i = 0; i < wzFiles.Count; i++) ReloadWzFile(wzFiles[i], panel);
        }

        public void UnloadAll()
        {
            while (wzFiles.Count > 0) UnloadWzFile(wzFiles[0]);
        }

        public void Terminate()
        {
            foreach (WzFile f in wzFiles)
            {
                f.Dispose();
            }
        }
    }
}
