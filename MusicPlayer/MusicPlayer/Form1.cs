using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        //Global array to hold song titles and there paths

        String[] paths, files;


        private void SongList_SelectedIndexChanged(object sender, EventArgs e)
        {
            WindowsMediaPlayerMusic.URL = paths[SongList.SelectedIndex];
        }

        

        private void closeIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowsMediaPlayerMusic_Enter(object sender, EventArgs e)
        {

        }

        private void btnSelectSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for(int i = 0; i < files.Length; i++)
                {
                    SongList.Items.Add(files[i]);
                }

            }
        }

        private void MusicPlayerApp_Load(object sender, EventArgs e)
        {

        }
    }
}
