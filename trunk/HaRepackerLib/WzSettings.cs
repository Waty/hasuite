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
using MapleLib;
using MapleLib.WzLib;
using MapleLib.WzLib.Util;
using MapleLib.WzLib.WzProperties;
using System.IO;
using System.Reflection;
using MapleLib.WzLib.WzStructure.Data;
using MapleLib.WzLib.WzStructure;
using System.Drawing;
using MapleLib.WzLib.Serialization;

namespace HaRepackerLib
{
    public static class UserSettings
    {
        public static int Indentation = 0;
        public static LineBreak LineBreakType = LineBreak.None;
        public static string DefaultXmlFolder = "";
        public static bool UseApngIncompatibilityFrame = true;
        public static bool AutoAssociate = true;
        public static bool AutoUpdate = true;
        public static bool Sort = true;
        public static bool SuppressWarnings = false;
        public static bool ParseImagesInSearch = false;
        public static bool SearchStringValues = true;
    }

    public static class ApplicationSettings
    {
        public static bool Maximized = false;
        public static Size WindowSize = new Size(800, 600);
        public static int FileVersion = 94;
        public static bool FirstRun = true;
        public static string LastBrowserPath = "";
        public static WzMapleVersion MapleVersion = WzMapleVersion.GMS;
    }

    public static class Constants
    {
        public const int Version = 422;
    }
}
