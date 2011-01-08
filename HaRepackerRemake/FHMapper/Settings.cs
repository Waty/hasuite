/*  HaRepacker Foothold Mapper - MapleStory Map + Foothold Renderer and Editor
 * Copyright (C) 2009, 2010  haha01haha01 and Odecey
   
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
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HaRepacker.GUI;

namespace HaRepacker
{
    public partial class Settings : Form
    {
        public List<Object> settings;
        public MainForm main;
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            PrevTBox.Text = settings.ToArray()[0].ToString();
            PrevCBox.Checked = (bool)settings.ToArray()[1];
            NextTBox.Text = settings.ToArray()[2].ToString();
            NextCBox.Checked = (bool)settings.ToArray()[3];
            ForceTBox.Text = settings.ToArray()[4].ToString();
            ForceCBox.Checked = (bool)settings.ToArray()[5];
            XTBox.Text = settings.ToArray()[6].ToString();
            XCBox.Checked = (bool)settings.ToArray()[7];
            YTBox.Text = settings.ToArray()[8].ToString();
            YCBox.Checked = (bool)settings.ToArray()[9];
            TypeTBox.Text = settings.ToArray()[10].ToString();
            TypeCBox.Checked = (bool)settings.ToArray()[11];
            FilepathTBox.Text = settings.ToArray()[12].ToString();
            FilepathCBox.Checked = (bool)settings.ToArray()[13];
            SizeTBox.Text = settings.ToArray()[14].ToString();
            SizeCBox.Checked = (bool)settings.ToArray()[15];
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        { this.Close(); }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            bool doOverwrite = true;
            string errorTBox = "";
            try {
                //Can this be done better?
                errorTBox = "prev value";
                int.Parse(PrevTBox.Text);
                errorTBox = "next value";
                int.Parse(NextTBox.Text);
                errorTBox = "force value";
                int.Parse(ForceTBox.Text);
                errorTBox = "X value";
                int.Parse(XTBox.Text);
                errorTBox = "Y value";
                int.Parse(YTBox.Text);
                errorTBox = "portal type value";
                int.Parse(TypeTBox.Text);
                double.Parse(SizeTBox.Text);
                }
            catch { doOverwrite = false; MessageBox.Show("                      The " + errorTBox + " was invalid.\r\nPlease make sure all values are valid before confirming.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            if (doOverwrite)
            {
                string theSettings;
                using (TextReader settingsFile = new StreamReader(Application.StartupPath + @"\Settings.ini"))
                    theSettings = settingsFile.ReadToEnd();

                // The below should be shorted down using Regex.Replace *Done*
                theSettings= Regex.Replace(theSettings, @"(?<=!DPt:)-?\d*(?=!)", PrevTBox.Text);
                /*theSettings = theSettings.Remove(Regex.Match(theSettings, @"(?<=!DPt:)-?\d*(?=!)").Index, Regex.Match(theSettings, @"(?<=!DPt:)-?\d*(?=!)").Length);// Regex: One or zero -, Any number of digits with the prefix !DPt: and suffix !
                theSettings = theSettings.Insert(Regex.Match(theSettings, @"(?<=!DPt:)!").Index, PrevTBox.Text);*/
                theSettings = Regex.Replace(theSettings, @"(?<=!DPc:)\w+(?=!)", PrevCBox.Checked.ToString());
              /*  theSettings = theSettings.Remove(Regex.Match(theSettings, @"(?<=!DPc:)\w+(?=!)").Index, Regex.Match(theSettings, @"(?<=!DPc:)\w+(?=!)").Length);// Regex: One or more number of alphanumeric chars with the prefix !DPc: and suffix !
                theSettings = theSettings.Insert(Regex.Match(theSettings, @"(?<=!DPc:)!").Index, PrevCBox.Checked.ToString());*/
                theSettings = Regex.Replace(theSettings, @"(?<=!DNt:)-?\d*(?=!)", NextTBox.Text);
                /*theSettings = theSettings.Remove(Regex.Match(theSettings, @"(?<=!DNt:)-?\d*(?=!)").Index, Regex.Match(theSettings, @"(?<=!DNt:)-?\d*(?=!)").Length);
                theSettings = theSettings.Insert(Regex.Match(theSettings, @"(?<=!DNt:)!").Index, NextTBox.Text);*/
                theSettings = Regex.Replace(theSettings, @"(?<=!DNc:)\w+(?=!)", NextCBox.Checked.ToString());
                /*theSettings = theSettings.Remove(Regex.Match(theSettings, @"(?<=!DNc:)\w+(?=!)").Index, Regex.Match(theSettings, @"(?<=!DNc:)\w+(?=!)").Length);
                theSettings = theSettings.Insert(Regex.Match(theSettings, @"(?<=!DNc:)!").Index, NextCBox.Checked.ToString());*/
                theSettings = Regex.Replace(theSettings, @"(?<=!DFt:)-?\d*(?=!)",ForceTBox.Text);
                /*theSettings = theSettings.Remove(Regex.Match(theSettings, @"(?<=!DFt:)-?\d*(?=!)").Index, Regex.Match(theSettings, @"(?<=!DFt:)-?\d*(?=!)").Length);
                theSettings = theSettings.Insert(Regex.Match(theSettings, @"(?<=!DFt:)!").Index, ForceTBox.Text);*/
                theSettings = Regex.Replace(theSettings, @"(?<=!DFc:)\w+(?=!)", ForceCBox.Checked.ToString());
               /* theSettings = theSettings.Remove(Regex.Match(theSettings, @"(?<=!DFc:)\w+(?=!)").Index, Regex.Match(theSettings, @"(?<=!DFc:)\w+(?=!)").Length);
                theSettings = theSettings.Insert(Regex.Match(theSettings, @"(?<=!DFc:)!").Index, ForceCBox.Checked.ToString());*/
                theSettings = Regex.Replace(theSettings, @"(?<=!DXt:)-?\d*(?=!)", XTBox.Text);
                /*theSettings = theSettings.Remove(Regex.Match(theSettings, @"(?<=!DXt:)-?\d*(?=!)").Index, Regex.Match(theSettings, @"(?<=!DXt:)-?\d*(?=!)").Length);
                theSettings = theSettings.Insert(Regex.Match(theSettings, @"(?<=!DXt:)!").Index, XTBox.Text);*/
                theSettings = Regex.Replace(theSettings, @"(?<=!DXc:)\w+(?=!)", XCBox.Checked.ToString());
                /*theSettings = theSettings.Remove(Regex.Match(theSettings, @"(?<=!DXc:)\w+(?=!)").Index, Regex.Match(theSettings, @"(?<=!DXc:)\w+(?=!)").Length);
                theSettings = theSettings.Insert(Regex.Match(theSettings, @"(?<=!DXc:)!").Index, XCBox.Checked.ToString());*/
                theSettings = Regex.Replace(theSettings, @"(?<=!DYt:)-?\d*(?=!)", YTBox.Text);
                /*theSettings = theSettings.Remove(Regex.Match(theSettings, @"(?<=!DYt:)-?\d*(?=!)").Index, Regex.Match(theSettings, @"(?<=!DYt:)-?\d*(?=!)").Length);
                theSettings = theSettings.Insert(Regex.Match(theSettings, @"(?<=!DYt:)!").Index, YTBox.Text);*/
                theSettings = Regex.Replace(theSettings, @"(?<=!DYc:)\w+(?=!)", YCBox.Checked.ToString());
               /* theSettings = theSettings.Remove(Regex.Match(theSettings, @"(?<=!DYc:)\w+(?=!)").Index, Regex.Match(theSettings, @"(?<=!DYc:)\w+(?=!)").Length);
                theSettings = theSettings.Insert(Regex.Match(theSettings, @"(?<=!DYc:)!").Index, YCBox.Checked.ToString());*/
                theSettings = Regex.Replace(theSettings, @"(?<=!DTt:)-?\d*(?=!)", TypeTBox.Text);
                /*theSettings = theSettings.Remove(Regex.Match(theSettings, @"(?<=!DTt:)\d*(?=!)").Index, Regex.Match(theSettings, @"(?<=!DTt:)\d*(?=!)").Length);
                theSettings = theSettings.Insert(Regex.Match(theSettings, @"(?<=!DTt:)!").Index, TypeTBox.Text);*/
                theSettings = Regex.Replace(theSettings, @"(?<=!DTc:)\w+(?=!)", TypeCBox.Checked.ToString());
               /* theSettings = theSettings.Remove(Regex.Match(theSettings, @"(?<=!DTc:)\w+(?=!)").Index, Regex.Match(theSettings, @"(?<=!DTc:)\w+(?=!)").Length);
                theSettings = theSettings.Insert(Regex.Match(theSettings, @"(?<=!DTc:)!").Index, TypeCBox.Checked.ToString());*/
                theSettings = Regex.Replace(theSettings, @"(?<=!DFPt:)C:(%\w+)+.wz(?=!)", FilepathTBox.Text.Replace('/','%'));
                /*theSettings = theSettings.Remove(Regex.Match(theSettings, @"(?<=!DFPt:)C:(%\w+)+.wz(?=!)").Index, Regex.Match(theSettings, @"(?<=!DFPt:)C:(%\w+)+.wz(?=!)").Length);
                theSettings = theSettings.Insert(Regex.Match(theSettings, @"(?<=!DFPt:)!").Index, FilepathTBox.Text.Replace('/', '%'));*/
                theSettings = Regex.Replace(theSettings, @"(?<=!DFPc:)\w+(?=!)", FilepathCBox.Checked.ToString());
               /* theSettings = theSettings.Remove(Regex.Match(theSettings, @"(?<=!DFPc:)\w+(?=!)").Index, Regex.Match(theSettings, @"(?<=!DFPc:)\w+(?=!)").Length);
                theSettings = theSettings.Insert(Regex.Match(theSettings, @"(?<=!DFPc:)!").Index, FilepathCBox.Checked.ToString());*/
                theSettings = Regex.Replace(theSettings, @"(?<=!DSt:)\d*,?\d*(?=!)", SizeTBox.Text);
                /*theSettings = theSettings.Remove(Regex.Match(theSettings, @"(?<=!DSt:)\d*,?\d*(?=!)").Index, Regex.Match(theSettings, @"(?<=!DSt:)\d*,?\d*(?=!)").Length);
                theSettings = theSettings.Insert(Regex.Match(theSettings, @"(?<=!DSt:)!").Index, SizeTBox.Text);*/
                theSettings = Regex.Replace(theSettings, @"(?<=!DSc:)\w+(?=!)", SizeCBox.Checked.ToString());
                /*theSettings = theSettings.Remove(Regex.Match(theSettings, @"(?<=!DSc:)\w+(?=!)").Index, Regex.Match(theSettings, @"(?<=!DSc:)\w+(?=!)").Length);
                theSettings = theSettings.Insert(Regex.Match(theSettings, @"(?<=!DSc:)!").Index, SizeCBox.Checked.ToString());*/

                using (TextWriter settingsWriter = new StreamWriter(Application.StartupPath + @"\Settings.ini"))
                    settingsWriter.Write(theSettings);
                

                main.ParseSettings();
                this.Close();
            }
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All wz files | *.wz";
            openFile.ShowDialog();
            string buf = openFile.FileName;
            buf= buf.Replace('\\','/');
            FilepathTBox.Text = buf;
        }

       
        private void PrevTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Space)
                e.Handled = true;
        }

        private void NextTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void ForceTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void XTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void YTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void TypeTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void SizeTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }
    }
}