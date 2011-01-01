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
using System.IO;
using System.Windows.Forms;
using MapleLib.WzLib.WzProperties;
using Microsoft.DirectX.AudioVideoPlayback;

namespace HaRepackerLib
{
    public partial class SoundPlayer : UserControl
    {
        private Audio currAudio;
        private string currSoundFile = "";
        private WzSoundProperty soundProp;

        public SoundPlayer()
        {
            InitializeComponent();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            AudioTimer.Enabled = false;
            currAudio.Pause();
            PauseButton.Visible = false;
            PlayButton.Visible = true;
        }

        private void TimeBar_Scroll(object sender, EventArgs e)
        {
            if (currAudio != null)
                currAudio.CurrentPosition = ((TrackBar)sender).Value;
        }

        private void AudioTimer_Tick(object sender, EventArgs e)
        {
            if (currAudio == null) return;
            if (currAudio.CurrentPosition == currAudio.Duration)
                if (LoopBox.Checked)
                    currAudio.CurrentPosition = 0;
                else
                {
                    currAudio.Stop();
                    PlayButton.Visible = true;
                    PauseButton.Visible = false;
                    TimeBar.Value = 0;
                }
            TimeBar.Value = (int)currAudio.CurrentPosition;
            TimeSpan time = TimeSpan.FromSeconds(currAudio.CurrentPosition);
            CurrentPositionLabel.Text = Convert.ToString(time.Minutes).PadLeft(2, '0') + ":" + Convert.ToString(time.Seconds).PadLeft(2, '0') + " /";
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (currSoundFile == "")
            {
                currSoundFile = Path.GetTempFileName();
                soundProp.SaveToFile(currSoundFile);
                currAudio = new Audio(currSoundFile, true);
                TimeBar.Maximum = (int)currAudio.Duration;
                TimeBar.Minimum = 0;
            }
            else
            {
                currAudio.Play();
            }
            AudioTimer.Enabled = true;
            PlayButton.Visible = false;
            PauseButton.Visible = true;
        }

        public WzSoundProperty SoundProperty
        {
            get { return soundProp; }
            set 
            {
                if (PauseButton.Visible == true) PauseButton_Click(null, null);
                soundProp = value;
                currSoundFile = "";
                if (currAudio != null && !currAudio.Disposed)
                    currAudio.Dispose();
                currAudio = null;
                if (soundProp != null)
                {
                    TimeSpan time = TimeSpan.FromMilliseconds(soundProp.Length);
                    LengthLabel.Text = Convert.ToString(time.Minutes).PadLeft(2, '0') + ":" + Convert.ToString(time.Seconds).PadLeft(2, '0');
                }
                CurrentPositionLabel.Text = "00:00 /";
                TimeBar.Value = 0;
            }
        }
    }
}
