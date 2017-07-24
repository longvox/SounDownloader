using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;

namespace SoundCload_Downloader
{
    public partial class frm_main : Form
    {
        int countTrack = 0;
        int count = 0;
        List<TrackID> t = new List<TrackID>();
        string url;
        string fileName;
        string path;
        public frm_main()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            count--;
            if (count == 0)
            {
                
                Invoke(new MethodInvoker(delegate()
                {
                    pgb_download.Value = 10;
                    pgb_download.animated = true;
                    pgb_download.LabelVisible = false;

                    tmr_pgb_show.Enabled = true;

                    tb_save.Enabled = true;
                    tb_address.Enabled = true;

                    msgBox("Đã tải xong!", 0);

                }));
            }
            else
                DownLoadFile();
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate()
            {
                pgb_download.Value = 0;
                double recent = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                lb_download.Text = string.Format("({0:0.00} MB/{1:0.00} MB)", recent / 1024 / 1024, total / 1024 / 1024);
                pgb_download.Value = (int)(recent / total * 100);
            }));
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_dlgFolder_Click(object sender, EventArgs e)
        {
            dlg_FolderBrowser.ShowDialog();
            tb_save.Text = dlg_FolderBrowser.SelectedPath;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (tb_save.Text == "")
                msgBox("Vui lòng chọn nơi để lưu trữ");
            else
            {
                url = tb_address.Text;
                int check = SoundCloud.checkUrl(url);
                if (check < 0 || check > 2)
                    msgBox("Không thể tải nhạc từ link này");

                else
                {
                    path = tb_save.Text;
                    tb_save.Enabled = false;
                    tb_address.Enabled = false;

                    bt_download.Hide();
                    tmr_pgb.Enabled = true;

                    t = new List<TrackID>();

                    Thread thr = new Thread(() =>
                    {
                        Invoke(new MethodInvoker(delegate()
                        {
                            lb_textTitle.Text = "";
                            lb_download.Text = "";
                        }));
                        if (check == 0)
                            t = SoundCloud.resolveListTrackIDs(url);
                        else if (check == 1)
                            t.Add(SoundCloud.resolveTrackID(url));
                        else if (check == 2)
                            t = SoundCloud.resolveUserTrackID(url);

                        countTrack = count = t.Count;

                        Invoke(new MethodInvoker(delegate()
                        {
                            pgb_download.Value = 0;
                            pgb_download.animated = false;
                            pgb_download.LabelVisible = true;

                            DownLoadFile();

                        }));
                    });
                    thr.Start();
                }
            }
        }

        private void DownLoadFile()
        {
            WebClient client = new WebClient();

            int i = t.Count - count;
            lb_textTitle.Text = "(" + (i + 1).ToString() + "/" + t.Count + ") " + Regex.Unescape(t[i].title) + ".mp3";

            client = new WebClient();
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);

            fileName = path;
            if (fileName[fileName.Length - 1] != '\\')
                fileName += @"\";

            fileName += Regex.Unescape(t[i].title) + ".mp3";
            client.DownloadFileAsync(new Uri(t[i].urlMp3), fileName);

        }

        private void tb_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (tb_address.Text == "link track, playlist or user on SoundCloud")
                tb_address.Text = "";
        }

        private void msgBox(string str)
        {
            Invoke(new MethodInvoker(delegate()
            {
                Message msg = new Message(str);
                msg.Show();

            }));
        }

        private void msgBox(string str, int k)
        {
            Invoke(new MethodInvoker(delegate()
            {
                Message msg = new Message(str, k);
                msg.Show();

            }));
        }

        private void tmr_pgb_show_Tick(object sender, EventArgs e)
        {
            pgb_download.Location = new Point(pgb_download.Location.X, pgb_download.Location.Y - 2);
            this.Size = new Size(this.Size.Width, this.Size.Height - 2);

            if (this.Location.Y > 0)
                this.Location = new Point(this.Location.X, this.Location.Y + 1);

            if (pgb_download.Location.Y < 190)
            {
                bt_download.Show();
                tmr_pgb_show.Enabled = false;
                pnl_label.Visible = false;
            }
        }

        private void t_process_Tick(object sender, EventArgs e)
        {
            pgb_download.Location = new Point(pgb_download.Location.X, pgb_download.Location.Y + 2);
            this.Size = new Size(this.Size.Width, this.Size.Height + 2);

            if (this.Location.Y > 0)
                this.Location = new Point(this.Location.X, this.Location.Y - 1);

            if (pgb_download.Location.Y > 290)
            {
                tmr_pgb.Enabled = false;
                pnl_label.Visible = true;
                
            }
        }

        private void bt_openBlog_Click(object sender, EventArgs e)
        {
            Process.Start("https://longvox.blogspot.com/"); 
        }

        private void bt_mail_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:longvox98@gmail.com?subject=Feedback&body=Messag");
        }
    }
}
