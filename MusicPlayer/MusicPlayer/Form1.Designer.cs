namespace MusicPlayer
{
    partial class MusicPlayerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.closeIcon = new System.Windows.Forms.PictureBox();
            this.lbllogo = new System.Windows.Forms.Label();
            this.SongList = new System.Windows.Forms.ListBox();
            this.lblfooter = new System.Windows.Forms.Label();
            this.WindowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnSelectSong = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayerMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.IndianRed;
            this.TopPanel.Controls.Add(this.closeIcon);
            this.TopPanel.Controls.Add(this.lbllogo);
            this.TopPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(600, 38);
            this.TopPanel.TabIndex = 0;
            // 
            // closeIcon
            // 
            this.closeIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeIcon.Image = ((System.Drawing.Image)(resources.GetObject("closeIcon.Image")));
            this.closeIcon.Location = new System.Drawing.Point(568, 2);
            this.closeIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeIcon.Name = "closeIcon";
            this.closeIcon.Size = new System.Drawing.Size(30, 30);
            this.closeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeIcon.TabIndex = 1;
            this.closeIcon.TabStop = false;
            this.closeIcon.Click += new System.EventHandler(this.closeIcon_Click);
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.Font = new System.Drawing.Font("Magneto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogo.Location = new System.Drawing.Point(10, 11);
            this.lbllogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(110, 18);
            this.lbllogo.TabIndex = 0;
            this.lbllogo.Text = "Music Player";
            // 
            // SongList
            // 
            this.SongList.Cursor = System.Windows.Forms.Cursors.Default;
            this.SongList.FormattingEnabled = true;
            this.SongList.Location = new System.Drawing.Point(9, 43);
            this.SongList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SongList.Name = "SongList";
            this.SongList.Size = new System.Drawing.Size(155, 251);
            this.SongList.TabIndex = 1;
            this.SongList.SelectedIndexChanged += new System.EventHandler(this.SongList_SelectedIndexChanged);
            // 
            // lblfooter
            // 
            this.lblfooter.AutoSize = true;
            this.lblfooter.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblfooter.Location = new System.Drawing.Point(10, 345);
            this.lblfooter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfooter.Name = "lblfooter";
            this.lblfooter.Size = new System.Drawing.Size(106, 13);
            this.lblfooter.TabIndex = 4;
            this.lblfooter.Text = "DevelopedByShivam";
            // 
            // WindowsMediaPlayerMusic
            // 
            this.WindowsMediaPlayerMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowsMediaPlayerMusic.Enabled = true;
            this.WindowsMediaPlayerMusic.Location = new System.Drawing.Point(168, 42);
            this.WindowsMediaPlayerMusic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WindowsMediaPlayerMusic.Name = "WindowsMediaPlayerMusic";
            this.WindowsMediaPlayerMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayerMusic.OcxState")));
            this.WindowsMediaPlayerMusic.Size = new System.Drawing.Size(421, 299);
            this.WindowsMediaPlayerMusic.TabIndex = 3;
            this.WindowsMediaPlayerMusic.Enter += new System.EventHandler(this.WindowsMediaPlayerMusic_Enter);
            // 
            // btnSelectSong
            // 
            this.btnSelectSong.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSelectSong.Location = new System.Drawing.Point(9, 298);
            this.btnSelectSong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectSong.Name = "btnSelectSong";
            this.btnSelectSong.Size = new System.Drawing.Size(154, 43);
            this.btnSelectSong.TabIndex = 5;
            this.btnSelectSong.Text = "Select Songs";
            this.btnSelectSong.UseVisualStyleBackColor = true;
            this.btnSelectSong.Click += new System.EventHandler(this.btnSelectSong_Click);
            // 
            // MusicPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnSelectSong);
            this.Controls.Add(this.lblfooter);
            this.Controls.Add(this.WindowsMediaPlayerMusic);
            this.Controls.Add(this.SongList);
            this.Controls.Add(this.TopPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MusicPlayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayerApp";
            this.Load += new System.EventHandler(this.MusicPlayerApp_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayerMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox closeIcon;
        private System.Windows.Forms.Label lbllogo;
        private System.Windows.Forms.ListBox SongList;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayerMusic;
        private System.Windows.Forms.Label lblfooter;
        private System.Windows.Forms.Button btnSelectSong;
    }
}

