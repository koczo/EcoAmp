using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace EcoAmp
{
    /// <summary>
    /// Main window
    /// </summary>
    public partial class Form1 : Form
    {
        private const int STEP = 2; // Speed of label animation
        MusicPlayer player; // 
        private bool buttonClicked = false; // Flag for deactivate form
        private int xPos = 0, yPos = 0; // Position of Marque Lable
        List<string> paths = new List<string>(); // List for paths of added files

        /// <summary>
        /// Initian Main window
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            player = new MusicPlayer(paths);
            timer.Enabled = false;
            trackBarVolume.Value = 750;

        }

        /// <summary>
        /// Set Marque Lable on start
        /// </summary>
        public void ResetMarquePosition()
        {
            labelSong.Location = new Point(0, 0);

        }

        /// <summary>
        /// Play song and set all
        /// </summary>
        /// <param name="track">Number of track</param>
        /// <returns>
        /// True if track is play
        /// </returns>
        private bool play(int track)
        {
            ResetMarquePosition();
            player.Stop();
            player.Paused = false;
            if (player.Play(track))
            {

                player.SetVolume(trackBarVolume.Value);
                labelSong.Text = PlayList.Items[player.NowPlaying].Text;
                xPos = labelSong.Location.X;
                yPos = labelSong.Location.Y;
                timer.Enabled = true;
                PlayList.Items[player.NowPlaying].Selected = true;
                //PlayList.Items[player.NowPlaying].BackColor = Color.LightSteelBlue;
                hScrollBarTrack.Maximum = player.GetSongLenght();
                return true;
            }
            else
            {

                return false;
            }
        }

        /// <summary>
        /// Button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            buttonClicked = true;
            if (openSongs.ShowDialog() == DialogResult.OK)
            {

                foreach (var file in openSongs.FileNames)
                {
                    paths.Add(file);
                }

                foreach (var name in openSongs.SafeFileNames)
                {
                    PlayList.Items.Add(name);
                }
            }

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {

            if (player.Paused)
            {
                player.Pause();

            }
            else
            {
                for (int i = 0; i < PlayList.Items.Count; i++)
                {
                    if (PlayList.Items[i].Selected == true)
                    {
                        play(i);
                        break;
                    }
                }
                if (PlayList.Items.Count != 0 && !player.IsPlaying())
                {
                    play(0);
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (xPos <= -(labelSong.Text.Length * (labelSong.Font.Size - STEP)))
            {
                labelSong.Location = new Point(panelMarqque.Width, yPos);
                xPos = panelMarqque.Width;

            }
            else
            {
                labelSong.Location = new Point(xPos, yPos);
                xPos -= STEP;
            }


            if (!player.IsStopped() && player.IsPlaying())
            {
                if (player.IsPlaying() || player.Paused)
                {

                    hScrollBarTrack.Value = player.GetCurrentPosition();
                    textBoxTime.Text = player.GetTime(player.GetCurrentPosition()) + " / " + player.GetTime(player.GetSongLenght());
                }
                else if (!player.Paused)
                {
                    hScrollBarTrack.Value = 0;
                }
            }
            else if (!player.Paused)
                buttonNext_Click(sender, e);


        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (player.NowPlaying != PlayList.Items.Count - 1)
            {
                player.NowPlaying++;
                play(player.NowPlaying);
            }
            else
            {
                player.NowPlaying = 0;
                play(player.NowPlaying);
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            player.Pause();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            ResetMarquePosition();
            player.Stop();
            timer.Enabled = false;
        }

        /// <summary>
        /// Handles the Click event of the buttonPrevious control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (player.NowPlaying != 0)
            {
                player.NowPlaying--;
                play(player.NowPlaying);
            }
            else
            {
                player.NowPlaying = PlayList.Items.Count - 1;
                play(player.NowPlaying);
            }
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            player.SetVolume(trackBarVolume.Value);
        }

        private void buttonMute_Click(object sender, EventArgs e)
        {
            trackBarVolume.Value = 0;
            player.SetVolume(trackBarVolume.Value);
        }

        private void buttonFullVol_Click(object sender, EventArgs e)
        {
            trackBarVolume.Value = 1000;
            player.SetVolume(trackBarVolume.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PlayList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < PlayList.Items.Count; i++)
            {
                if (PlayList.Items[i].Selected == true)
                {
                    play(i);
                    break;
                }
            }
        }

        private void checkBoxPlaylist_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlaylist.Checked)
            {
                Size = MaximumSize;
            }
            else
                Size = MinimumSize;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {

            if (!buttonClicked)
            {
                WindowState = FormWindowState.Minimized;
            }
            buttonClicked = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonClicked = true;
            AboutBox1 about = new AboutBox1();
            about.Show();

            buttonClicked = false;
        }

        private void addFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAdd_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
