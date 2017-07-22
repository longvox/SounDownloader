namespace SoundCload_Downloader
{
    partial class frm_main
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
            System.Windows.Forms.Label titleApp;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.buni_elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.iconApp = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dragControl_header = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tb_save = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lb_save = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_textTitle = new System.Windows.Forms.Label();
            this.dlg_FolderBrowser = new Ookii.Dialogs.VistaFolderBrowserDialog();
            this.tmr_pgb = new System.Windows.Forms.Timer(this.components);
            this.tb_address = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.DragControl_titleApp = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lb_download = new System.Windows.Forms.Label();
            this.lb_dload = new System.Windows.Forms.Label();
            this.tmr_pgb_show = new System.Windows.Forms.Timer(this.components);
            this.pnl_label = new System.Windows.Forms.Panel();
            this.bt_mail = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_openBlog = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_download = new Bunifu.Framework.UI.BunifuImageButton();
            this.bt_dlgFolder = new Bunifu.Framework.UI.BunifuImageButton();
            this.pgb_download = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lb_about = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bt_close = new Bunifu.Framework.UI.BunifuImageButton();
            titleApp = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconApp)).BeginInit();
            this.pnl_label.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_mail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_openBlog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_download)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_dlgFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_close)).BeginInit();
            this.SuspendLayout();
            // 
            // titleApp
            // 
            titleApp.AutoSize = true;
            titleApp.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleApp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            titleApp.Location = new System.Drawing.Point(66, 7);
            titleApp.Name = "titleApp";
            titleApp.Size = new System.Drawing.Size(144, 20);
            titleApp.TabIndex = 2;
            titleApp.Text = "SounDownloader";
            // 
            // buni_elipse
            // 
            this.buni_elipse.ElipseRadius = 5;
            this.buni_elipse.TargetControl = this;
            // 
            // header
            // 
            this.header.AllowDrop = true;
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.header.Controls.Add(this.bt_close);
            this.header.Controls.Add(titleApp);
            this.header.Controls.Add(this.iconApp);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(464, 35);
            this.header.TabIndex = 0;
            // 
            // iconApp
            // 
            this.iconApp.Image = global::SounDownloader.Properties.Resources.icon_soundcloud;
            this.iconApp.InitialImage = ((System.Drawing.Image)(resources.GetObject("iconApp.InitialImage")));
            this.iconApp.Location = new System.Drawing.Point(12, 5);
            this.iconApp.Name = "iconApp";
            this.iconApp.Size = new System.Drawing.Size(48, 22);
            this.iconApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconApp.TabIndex = 1;
            this.iconApp.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 0);
            this.panel2.TabIndex = 1;
            // 
            // dragControl_header
            // 
            this.dragControl_header.Fixed = true;
            this.dragControl_header.Horizontal = true;
            this.dragControl_header.TargetControl = this.header;
            this.dragControl_header.Vertical = true;
            // 
            // tb_save
            // 
            this.tb_save.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_save.BorderColorIdle = System.Drawing.Color.Silver;
            this.tb_save.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.tb_save.BorderThickness = 3;
            this.tb_save.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_save.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_save.isPassword = false;
            this.tb_save.Location = new System.Drawing.Point(89, 137);
            this.tb_save.Margin = new System.Windows.Forms.Padding(4);
            this.tb_save.Name = "tb_save";
            this.tb_save.Size = new System.Drawing.Size(281, 30);
            this.tb_save.TabIndex = 5;
            this.tb_save.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lb_save
            // 
            this.lb_save.AutoSize = true;
            this.lb_save.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_save.Location = new System.Drawing.Point(30, 140);
            this.lb_save.Name = "lb_save";
            this.lb_save.Size = new System.Drawing.Size(55, 20);
            this.lb_save.TabIndex = 11;
            this.lb_save.Text = "Save :";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.lb_title.Location = new System.Drawing.Point(3, 10);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(55, 20);
            this.lb_title.TabIndex = 14;
            this.lb_title.Text = "Title :";
            // 
            // lb_textTitle
            // 
            this.lb_textTitle.AutoSize = true;
            this.lb_textTitle.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_textTitle.Location = new System.Drawing.Point(64, 14);
            this.lb_textTitle.Name = "lb_textTitle";
            this.lb_textTitle.Size = new System.Drawing.Size(0, 16);
            this.lb_textTitle.TabIndex = 15;
            // 
            // dlg_FolderBrowser
            // 
            this.dlg_FolderBrowser.UseDescriptionForTitle = true;
            // 
            // tmr_pgb
            // 
            this.tmr_pgb.Interval = 10;
            this.tmr_pgb.Tick += new System.EventHandler(this.t_process_Tick);
            // 
            // tb_address
            // 
            this.tb_address.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_address.BorderColorIdle = System.Drawing.Color.Silver;
            this.tb_address.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.tb_address.BorderThickness = 3;
            this.tb_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_address.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_address.isPassword = false;
            this.tb_address.Location = new System.Drawing.Point(31, 76);
            this.tb_address.Margin = new System.Windows.Forms.Padding(4);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(401, 36);
            this.tb_address.TabIndex = 19;
            this.tb_address.Text = "link track, playlist or user on SoundCloud";
            this.tb_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_address_KeyDown);
            // 
            // DragControl_titleApp
            // 
            this.DragControl_titleApp.Fixed = true;
            this.DragControl_titleApp.Horizontal = true;
            this.DragControl_titleApp.TargetControl = titleApp;
            this.DragControl_titleApp.Vertical = true;
            // 
            // lb_download
            // 
            this.lb_download.AccessibleName = "lb_download";
            this.lb_download.AutoSize = true;
            this.lb_download.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_download.Location = new System.Drawing.Point(122, 50);
            this.lb_download.Name = "lb_download";
            this.lb_download.Size = new System.Drawing.Size(0, 16);
            this.lb_download.TabIndex = 23;
            // 
            // lb_dload
            // 
            this.lb_dload.AccessibleName = "";
            this.lb_dload.AutoSize = true;
            this.lb_dload.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.lb_dload.Location = new System.Drawing.Point(3, 46);
            this.lb_dload.Name = "lb_dload";
            this.lb_dload.Size = new System.Drawing.Size(115, 20);
            this.lb_dload.TabIndex = 22;
            this.lb_dload.Text = "Downloader :";
            // 
            // tmr_pgb_show
            // 
            this.tmr_pgb_show.Interval = 10;
            this.tmr_pgb_show.Tick += new System.EventHandler(this.tmr_pgb_show_Tick);
            // 
            // pnl_label
            // 
            this.pnl_label.BackColor = System.Drawing.Color.Transparent;
            this.pnl_label.Controls.Add(this.lb_title);
            this.pnl_label.Controls.Add(this.lb_download);
            this.pnl_label.Controls.Add(this.lb_textTitle);
            this.pnl_label.Controls.Add(this.lb_dload);
            this.pnl_label.Location = new System.Drawing.Point(31, 194);
            this.pnl_label.Name = "pnl_label";
            this.pnl_label.Size = new System.Drawing.Size(401, 82);
            this.pnl_label.TabIndex = 24;
            this.pnl_label.Visible = false;
            // 
            // bt_mail
            // 
            this.bt_mail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_mail.BackColor = System.Drawing.Color.Transparent;
            this.bt_mail.Image = global::SounDownloader.Properties.Resources.envelope;
            this.bt_mail.ImageActive = null;
            this.bt_mail.Location = new System.Drawing.Point(54, 341);
            this.bt_mail.Name = "bt_mail";
            this.bt_mail.Size = new System.Drawing.Size(41, 30);
            this.bt_mail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_mail.TabIndex = 26;
            this.bt_mail.TabStop = false;
            this.bt_mail.Zoom = 10;
            this.bt_mail.Click += new System.EventHandler(this.bt_mail_Click);
            // 
            // bt_openBlog
            // 
            this.bt_openBlog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_openBlog.BackColor = System.Drawing.Color.Transparent;
            this.bt_openBlog.Image = global::SounDownloader.Properties.Resources.earth_globe;
            this.bt_openBlog.ImageActive = null;
            this.bt_openBlog.Location = new System.Drawing.Point(12, 341);
            this.bt_openBlog.Name = "bt_openBlog";
            this.bt_openBlog.Size = new System.Drawing.Size(41, 30);
            this.bt_openBlog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_openBlog.TabIndex = 25;
            this.bt_openBlog.TabStop = false;
            this.bt_openBlog.Zoom = 10;
            this.bt_openBlog.Click += new System.EventHandler(this.bt_openBlog_Click);
            // 
            // bt_download
            // 
            this.bt_download.BackColor = System.Drawing.SystemColors.Control;
            this.bt_download.Image = global::SounDownloader.Properties.Resources.arrow_down_on_black_circular_background;
            this.bt_download.ImageActive = null;
            this.bt_download.Location = new System.Drawing.Point(196, 232);
            this.bt_download.Name = "bt_download";
            this.bt_download.Size = new System.Drawing.Size(91, 86);
            this.bt_download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_download.TabIndex = 18;
            this.bt_download.TabStop = false;
            this.bt_download.Zoom = 10;
            this.bt_download.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bt_dlgFolder
            // 
            this.bt_dlgFolder.BackColor = System.Drawing.Color.Transparent;
            this.bt_dlgFolder.Image = global::SounDownloader.Properties.Resources.folder_closed_black_shape;
            this.bt_dlgFolder.ImageActive = null;
            this.bt_dlgFolder.Location = new System.Drawing.Point(391, 137);
            this.bt_dlgFolder.Name = "bt_dlgFolder";
            this.bt_dlgFolder.Size = new System.Drawing.Size(41, 30);
            this.bt_dlgFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_dlgFolder.TabIndex = 6;
            this.bt_dlgFolder.TabStop = false;
            this.bt_dlgFolder.Zoom = 10;
            this.bt_dlgFolder.Click += new System.EventHandler(this.bt_dlgFolder_Click);
            // 
            // pgb_download
            // 
            this.pgb_download.animated = true;
            this.pgb_download.animationIterval = 1;
            this.pgb_download.animationSpeed = 5;
            this.pgb_download.BackColor = System.Drawing.Color.Transparent;
            this.pgb_download.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pgb_download.BackgroundImage")));
            this.pgb_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.pgb_download.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pgb_download.LabelVisible = false;
            this.pgb_download.LineProgressThickness = 8;
            this.pgb_download.LineThickness = 5;
            this.pgb_download.Location = new System.Drawing.Point(155, 190);
            this.pgb_download.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pgb_download.MaxValue = 100;
            this.pgb_download.Name = "pgb_download";
            this.pgb_download.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.pgb_download.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pgb_download.Size = new System.Drawing.Size(171, 171);
            this.pgb_download.TabIndex = 3;
            this.pgb_download.Value = 10;
            // 
            // lb_about
            // 
            this.lb_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_about.AutoSize = true;
            this.lb_about.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_about.Location = new System.Drawing.Point(358, 354);
            this.lb_about.Name = "lb_about";
            this.lb_about.Size = new System.Drawing.Size(94, 17);
            this.lb_about.TabIndex = 27;
            this.lb_about.Text = "by Long Vox";
            this.lb_about.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_close
            // 
            this.bt_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_close.BackColor = System.Drawing.Color.Transparent;
            this.bt_close.ErrorImage = global::SounDownloader.Properties.Resources.cancel;
            this.bt_close.Image = global::SounDownloader.Properties.Resources.cancel;
            this.bt_close.ImageActive = null;
            this.bt_close.Location = new System.Drawing.Point(435, 5);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(25, 25);
            this.bt_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_close.TabIndex = 3;
            this.bt_close.TabStop = false;
            this.bt_close.Zoom = 10;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 383);
            this.Controls.Add(this.lb_about);
            this.Controls.Add(this.bt_mail);
            this.Controls.Add(this.bt_openBlog);
            this.Controls.Add(this.pnl_label);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.bt_download);
            this.Controls.Add(this.lb_save);
            this.Controls.Add(this.bt_dlgFolder);
            this.Controls.Add(this.tb_save);
            this.Controls.Add(this.pgb_download);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SounDownloader";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconApp)).EndInit();
            this.pnl_label.ResumeLayout(false);
            this.pnl_label.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_mail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_openBlog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_download)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_dlgFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse buni_elipse;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox iconApp;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl dragControl_header;
        private Bunifu.Framework.UI.BunifuImageButton bt_dlgFolder;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_save;
        private System.Windows.Forms.Label lb_save;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_textTitle;
        private Ookii.Dialogs.VistaFolderBrowserDialog dlg_FolderBrowser;
        private System.Windows.Forms.Timer tmr_pgb;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_address;
        private Bunifu.Framework.UI.BunifuDragControl DragControl_titleApp;
        private System.Windows.Forms.Label lb_download;
        private System.Windows.Forms.Label lb_dload;
        private System.Windows.Forms.Timer tmr_pgb_show;
        private System.Windows.Forms.Panel pnl_label;
        public Bunifu.Framework.UI.BunifuCircleProgressbar pgb_download;
        public Bunifu.Framework.UI.BunifuImageButton bt_download;
        private Bunifu.Framework.UI.BunifuImageButton bt_mail;
        private Bunifu.Framework.UI.BunifuImageButton bt_openBlog;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_about;
        private Bunifu.Framework.UI.BunifuImageButton bt_close;

    }
}

