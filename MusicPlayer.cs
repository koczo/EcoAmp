using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows;
using System.ComponentModel;

namespace EcoAmp
{

    /// <summary>
    /// musicplayer
    /// </summary>
    class MusicPlayer
    {

        /// <summary>
        /// The command
        /// </summary>
        private string command;
        /// <summary>
        /// The error
        /// </summary>
        private int error;
        /// <summary>
        /// The mci return data
        /// </summary>
        private StringBuilder mciReturnData;
        /// <summary>
        /// The play list
        /// </summary>
        private List<string> playList = new List<string>();
        /// <summary>
        /// Gets or sets the now playing.
        /// </summary>
        /// <value>
        /// The now playing.
        /// </value>
        public int NowPlaying { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="MusicPlayer"/> is paused.
        /// </summary>
        /// <value>
        ///   <c>true</c> if paused; otherwise, <c>false</c>.
        /// </value>
        public bool Paused { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicPlayer"/> class.
        /// </summary>
        /// <param name="songs">The songs.</param>
        public MusicPlayer(List<string> songs)
        {
            playList = songs;
            NowPlaying = 0;
            Paused = false;
            mciReturnData = new StringBuilder(128);
        }




        /// <summary>
        /// Mci send string.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="returnInfo">The return info.</param>
        /// <param name="returnLenght">The return lenght.</param>
        /// <param name="winHand">The win hand.</param>
        /// <returns> Sends a command string to an MCI device</returns>
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string command, StringBuilder returnInfo, int returnLenght, IntPtr winHand);


        /// <summary>
        /// Closes this instance.
        /// </summary>
        private void Close()
        {
            command = "Close MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);


        }


        /// <summary>
        /// Opens the specified path.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>
        /// <c>true</c> if this instance is open; otherwise, <c>false</c>.</returns>
        public bool Open(string path)
        {
            //path.Replace('\\', #92);
            Close();
            command = "Open \"" + path + "\" type MPEGVideo alias MediaFile";
            //MessageBoxResult results = MessageBox.Show(command);  
            error = mciSendString(command, null, 0, IntPtr.Zero);
            //MessageBoxResult result = MessageBox.Show(error.ToString());  
            if (error == 0)
            {
                return true;
            }
            else return false;


        }


        /// <summary>
        /// Plays the specified track.
        /// </summary>
        /// <param name="track">The track.</param>
        /// <returns>
        /// <c>true</c> if this instance is play; otherwise, <c>false</c>.
        /// </returns>
        public bool Play(int track)
        {
            if (Open(playList[track]))
            {
                command = "Play MediaFile";
                //MessageBoxResult results = MessageBox.Show(command);  
                error = mciSendString(command, null, 0, IntPtr.Zero);
                if (error == 0)
                {
                    NowPlaying = track;
                    return true;
                }
                else
                {
                    Close();
                    return false;
                }



            }
            else return false;
        }


        /// <summary>
        /// Pauses this instance.
        /// </summary>
        public void Pause()
        {
            if (Paused)
            {
                Resume();
                Paused = false;
            }
            else
            {
                command = "pause MediaFile";
                mciSendString(command, null, 0, IntPtr.Zero);
                Paused = true;
            }
        }

        /// <summary>
        /// Stops this instance.
        /// </summary>
        public void Stop()
        {
            command = "stop MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
            Paused = false;
            Close();
        }


        /// <summary>
        /// Resumes this instance.
        /// </summary>
        public void Resume()
        {
            command = "resume MediaFile";
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        /// <summary>
        /// Sets the volume.
        /// </summary>
        /// <param name="volume">The volume.</param>
        /// <returns>
        /// <c>true</c> if this volume is between 0 and 1000; otherwise, <c>false</c>.
        /// </returns>
        public bool SetVolume(int volume)
        {
            if (volume>=0 && volume<=1000)
            {
                command = "setaudio MediaFile volume to " + volume.ToString();
                mciSendString(command, null, 0, IntPtr.Zero);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Determines whether this instance is playing.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is playing; otherwise, <c>false</c>.
        /// </returns>
        public bool IsPlaying()
        {
            command = "status MediaFile mode";
            error = mciSendString(command, mciReturnData, 128, IntPtr.Zero);
            if (mciReturnData.Length == 7 &&
                      mciReturnData.ToString().Substring(0, 7) == "playing")
                return true;
            else
                return false;
        }

        /// <summary>
        /// Determines whether this instance is paused.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is paused; otherwise, <c>false</c>.
        /// </returns>
        public bool IsPaused()
        {
            command = "status MediaFile mode";
            error = mciSendString(command, mciReturnData, 128, IntPtr.Zero);
            if (mciReturnData.Length == 6 && mciReturnData.ToString().Substring(0, 6) == "paused")
                return true;
            else
                return false;
        }

        /// <summary>
        /// Determines whether this instance is stopped.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is stopped; otherwise, <c>false</c>.
        /// </returns>
        public bool IsStopped()
        {
            command = "status MediaFile mode";
            error = mciSendString(command, mciReturnData, 128, IntPtr.Zero);
            if (mciReturnData.Length == 7 && mciReturnData.ToString().Substring(0, 7) == "stopped")
                return true;
            else
                return false;
        }


        /// <summary>
        /// Gets the current position.
        /// </summary>
        /// <returns>
        /// Current position of song.
        /// </returns>
        public int GetCurrentPosition()
        {
            command = "status MediaFile position";
            error = mciSendString(command, mciReturnData, mciReturnData.Capacity, IntPtr.Zero);
            return int.Parse(mciReturnData.ToString());

        }

        /// <summary>
        /// Sets the position.
        /// </summary>
        /// <param name="milisec">The milisec.</param>
        public void SetPosition(int milisec)
        {
            //TO-DO : 
        }


        /// <summary>
        /// Get current song lenght
        /// </summary>
        /// <returns>
        ///  If song is playing song lenght in milicesondes.
        /// </returns>
        public int GetSongLenght()
        {
            if (IsPlaying())
            {
                command = "status MediaFile length";
                mciSendString(command, mciReturnData, mciReturnData.Capacity, IntPtr.Zero);
                return int.Parse(mciReturnData.ToString());
            }
            
            else return 0;
        }

        /// <summary>
        /// Convert time from milisecond to minutes and secondes
        /// </summary>
        /// <param name="milisec">Time in milisecondes</param>
        /// <returns>Formated minutes and seconds </returns>
        public string GetTime(int milisec)
        {
            int sec = milisec / 1000;
            int min = sec / 60;



            return String.Format("{0:00}:{1:00}", (float)min, (float)(sec % 60));
        }
    }
}
