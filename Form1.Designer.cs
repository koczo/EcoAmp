namespace EcoAmp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PlayList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.openSongs = new System.Windows.Forms.OpenFileDialog();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.hScrollBarTrack = new System.Windows.Forms.HScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSong = new System.Windows.Forms.Label();
            this.panelMarqque = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxPlaylist = new System.Windows.Forms.CheckBox();
            this.buttonFullVol = new System.Windows.Forms.Button();
            this.buttonMute = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.panelMarqque.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PlayList
            // 
            this.PlayList.BackColor = System.Drawing.SystemColors.Window;
            this.PlayList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.PlayList.GridLines = true;
            this.PlayList.HideSelection = false;
            this.PlayList.LabelWrap = false;
            this.PlayList.Location = new System.Drawing.Point(190, 30);
            this.PlayList.MultiSelect = false;
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(411, 316);
            this.PlayList.TabIndex = 2;
            this.PlayList.UseCompatibleStateImageBehavior = false;
            this.PlayList.View = System.Windows.Forms.View.Details;
            this.PlayList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PlayList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Playlist";
            this.columnHeader1.Width = 400;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(190, 352);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add File(s)";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // openSongs
            // 
            this.openSongs.DefaultExt = "mp3";
            this.openSongs.Filter = "MP3 Files |*.mp3";
            this.openSongs.Multiselect = true;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(35, 175);
            this.trackBarVolume.Maximum = 1000;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(96, 45);
            this.trackBarVolume.SmallChange = 100;
            this.trackBarVolume.TabIndex = 9;
            this.trackBarVolume.TickFrequency = 100;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // hScrollBarTrack
            // 
            this.hScrollBarTrack.Location = new System.Drawing.Point(-5, 152);
            this.hScrollBarTrack.Name = "hScrollBarTrack";
            this.hScrollBarTrack.Size = new System.Drawing.Size(186, 12);
            this.hScrollBarTrack.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-12, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 29);
            this.panel1.TabIndex = 11;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Enabled = false;
            this.textBoxTime.Font = new System.Drawing.Font("Lithos Pro Regular", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTime.Location = new System.Drawing.Point(12, 76);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(151, 31);
            this.textBoxTime.TabIndex = 12;
            this.textBoxTime.Text = "00:00 / 00:00";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(164, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 18);
            this.panel2.TabIndex = 13;
            // 
            // menuStrip
            // 
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(179, 24);
            this.menuStrip.TabIndex = 15;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addFilesToolStripMenuItem
            // 
            this.addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
            this.addFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.addFilesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addFilesToolStripMenuItem.Text = "Add &File(s)";
            this.addFilesToolStripMenuItem.Click += new System.EventHandler(this.addFilesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelSong
            // 
            this.labelSong.AutoSize = true;
            this.labelSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSong.Location = new System.Drawing.Point(5, 3);
            this.labelSong.Name = "labelSong";
            this.labelSong.Size = new System.Drawing.Size(0, 26);
            this.labelSong.TabIndex = 16;
            // 
            // panelMarqque
            // 
            this.panelMarqque.Controls.Add(this.label1);
            this.panelMarqque.Controls.Add(this.labelSong);
            this.panelMarqque.Location = new System.Drawing.Point(12, 31);
            this.panelMarqque.Name = "panelMarqque";
            this.panelMarqque.Size = new System.Drawing.Size(151, 39);
            this.panelMarqque.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 16;
            // 
            // checkBoxPlaylist
            // 
            this.checkBoxPlaylist.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxPlaylist.AutoSize = true;
            this.checkBoxPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxPlaylist.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxPlaylist.Location = new System.Drawing.Point(114, 352);
            this.checkBoxPlaylist.Name = "checkBoxPlaylist";
            this.checkBoxPlaylist.Size = new System.Drawing.Size(49, 23);
            this.checkBoxPlaylist.TabIndex = 14;
            this.checkBoxPlaylist.Text = "Playlist";
            this.checkBoxPlaylist.UseVisualStyleBackColor = true;
            this.checkBoxPlaylist.CheckedChanged += new System.EventHandler(this.checkBoxPlaylist_CheckedChanged);
            // 
            // buttonFullVol
            // 
            this.buttonFullVol.BackgroundImage = global::EcoAmp.Properties.Resources.volume_up;
            this.buttonFullVol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFullVol.Location = new System.Drawing.Point(131, 175);
            this.buttonFullVol.Name = "buttonFullVol";
            this.buttonFullVol.Size = new System.Drawing.Size(26, 26);
            this.buttonFullVol.TabIndex = 8;
            this.buttonFullVol.UseVisualStyleBackColor = true;
            this.buttonFullVol.Click += new System.EventHandler(this.buttonFullVol_Click);
            // 
            // buttonMute
            // 
            this.buttonMute.BackgroundImage = global::EcoAmp.Properties.Resources.mute;
            this.buttonMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMute.Location = new System.Drawing.Point(6, 175);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(26, 26);
            this.buttonMute.TabIndex = 7;
            this.buttonMute.UseVisualStyleBackColor = true;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackgroundImage = global::EcoAmp.Properties.Resources.skip_to_start;
            this.buttonPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrevious.Location = new System.Drawing.Point(105, 123);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(26, 26);
            this.buttonPrevious.TabIndex = 6;
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackgroundImage = global::EcoAmp.Properties.Resources.end;
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNext.Location = new System.Drawing.Point(137, 123);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(26, 26);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackgroundImage = global::EcoAmp.Properties.Resources.stop;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStop.Location = new System.Drawing.Point(73, 123);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(26, 26);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackgroundImage = global::EcoAmp.Properties.Resources.pause;
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPause.Location = new System.Drawing.Point(41, 123);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(26, 26);
            this.buttonPause.TabIndex = 1;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImage = global::EcoAmp.Properties.Resources.play;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.Location = new System.Drawing.Point(12, 123);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(26, 26);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 387);
            this.Controls.Add(this.panelMarqque);
            this.Controls.Add(this.PlayList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkBoxPlaylist);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hScrollBarTrack);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.buttonFullVol);
            this.Controls.Add(this.buttonMute);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(629, 426);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(195, 426);
            this.Name = "Form1";
            this.Text = "EcoAmp";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelMarqque.ResumeLayout(false);
            this.panelMarqque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.ListView PlayList;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.OpenFileDialog openSongs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonMute;
        private System.Windows.Forms.Button buttonFullVol;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.HScrollBar hScrollBarTrack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxPlaylist;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelSong;
        private System.Windows.Forms.Panel panelMarqque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem addFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

