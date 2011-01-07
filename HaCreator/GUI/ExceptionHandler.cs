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
using System.IO;

namespace HaCreator
{
    public partial class ExceptionHandler : Form
    {
        public static bool InitializationFinished = false;

        public string GetExceptionInfo(Exception e)
        {
            string result = e.Message + "\r\n\r\n" + e.Source + "\r\n\r\n" + e.StackTrace;
            if (e.InnerException != null)
                result += "\r\n\r\n" + GetExceptionInfo(e.InnerException);
            return result;
        }

        public ExceptionHandler(Exception e)
        {
            InitializeComponent();
            string logPath = Path.Combine(Application.StartupPath, "crashdump.log");
            File.WriteAllText(logPath, GetExceptionInfo(e));
            if (!InitializationFinished)
            {
                crashMessageLabel.Text = "Whoops! It looks like HaCreator crashed. The good news are, it crashed before you started working on your map so you didn't lose anything (woohoo!).\r\nAdditionaly, an error log was saved to " + logPath + ". If you want the bug to be solved ASAP, send me this error log on KryptoDEV or through my email (haha01haha01@gmail.com), preferably with some details about the problem (e.g. are your files edited or clean).";
                restartButton.Text = "Restart HaCreator";
                restartButton.Click += new EventHandler(Restart);
            }
            else
            {
                crashMessageLabel.Text = "Whoops! It looks like HaCreator crashed. The good news are, because I am such a 1337 programmer a backup file containing the map you were working on will be dumped once you click on the button below (and it's going to be extremely funny if it crashes again while trying to back up the data, in which case you are screwed), and it will be loaded next time you open HaCreator after the initialization screen.\r\nAdditionaly, an error log was saved to " + logPath + ". If you want the bug to be solved ASAP, send me this error log on KryptoDEV or through my email (haha01haha01@gmail.com), preferably with some details about what were you doing and maybe a copy of the map you were trying to make.";
                restartButton.Text = "Dump map backup and restart HaCreator";
                restartButton.Click += new EventHandler(Backup);
            }
        }

        private void Restart(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Backup(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
