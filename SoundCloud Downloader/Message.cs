using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundCload_Downloader
{
    public partial class Message : Form
    {
        public Message(string str, int k)
        {
            InitializeComponent();
            ms_box.Text = str;
            if (k == 0)
                im_icon.Image = SounDownloader.Properties.Resources.smile;
            else if(k == 1)
                im_icon.Image = SounDownloader.Properties.Resources.bug;
        }
        public Message(string str)
        {
            InitializeComponent();
            ms_box.Text = str;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
