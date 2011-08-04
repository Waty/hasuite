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
using System.Windows.Forms;
using HaRepackerLib;
using HaRepacker.GUI;
using Microsoft.Win32;
using System.Threading;
using AppModule.InterProcessComm;
using MapleLib.WzLib;

namespace HaRepacker
{
    public static class Program
    {
        public static WzFileManager WzMan = new HaRepackerLib.WzFileManager();
        public static WzSettingsManager SettingsManager;
        public static IChannelManager PipeManager;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string wzToLoad = null;
            if (args.Length > 0)
                wzToLoad = args[0];

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PrepareApplication();
            Application.Run(new MainForm(wzToLoad, true));
            EndApplication(true);
        }

        public static void PrepareApplication()
        {
            SettingsManager = new WzSettingsManager(System.IO.Path.Combine(Application.StartupPath, "HRSettings.wz"), typeof(UserSettings), typeof(ApplicationSettings));
            int tryCount = 0;
        tryagain:
            try
            {
                SettingsManager.Load();
            }
            catch
            {
                tryCount++;
                if (tryCount < 5)
                {
                    Thread.Sleep(1000);
                    goto tryagain;
                }
                else
                {
                    Warning.Error("Could not load settings file, make sure it is not in use. If it is not, delete it and try again.");
                    return;
                }
            }
            if (ApplicationSettings.FirstRun)
            {
                new FirstRunForm().ShowDialog();
                ApplicationSettings.FirstRun = false;
                SettingsManager.Save();
            }
            if (UserSettings.AutoAssociate)
            {
                string path = Application.ExecutablePath;
                Registry.ClassesRoot.CreateSubKey(".wz").SetValue("", "WzFile");
                RegistryKey wzKey = Registry.ClassesRoot.CreateSubKey("WzFile");
                wzKey.SetValue("", "Wz File");
                wzKey.CreateSubKey("DefaultIcon").SetValue("", path + ",1");
                wzKey.CreateSubKey("shell\\open\\command").SetValue("", "\"" + path + "\" \"%1\"");
            }
        }

        public static void EndApplication(bool usingPipes)
        {
            if (PipeManager != null && usingPipes) PipeManager.Stop();
            if (MainForm.updater != null) MainForm.updater.Abort();
            WzMan.Terminate();
            SettingsManager.Save();
        }
    }
}
