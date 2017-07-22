namespace SoundCload_Downloader
{
    partial class Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.header = new System.Windows.Forms.Panel();
            this.iconApp = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ms_box = new System.Windows.Forms.RichTextBox();
            this.drag_header = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bt_ok = new Bunifu.Framework.UI.BunifuThinButton2();
            this.im_icon = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            titleApp = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.im_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
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
            // header
            // 
            this.header.AllowDrop = true;
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Controls.Add(titleApp);
            this.header.Controls.Add(this.iconApp);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(395, 35);
            this.header.TabIndex = 1;
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ms_box
            // 
            this.ms_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ms_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ms_box.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ms_box.DetectUrls = false;
            this.ms_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_box.ForeColor = System.Drawing.Color.Black;
            this.ms_box.HideSelection = false;
            this.ms_box.Location = new System.Drawing.Point(161, 55);
            this.ms_box.Name = "ms_box";
            this.ms_box.ReadOnly = true;
            this.ms_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ms_box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ms_box.ShortcutsEnabled = false;
            this.ms_box.Size = new System.Drawing.Size(221, 117);
            this.ms_box.TabIndex = 5;
            this.ms_box.Text = "Chương trình đã bị lỗi";
            // 
            // drag_header
            // 
            this.drag_header.Fixed = true;
            this.drag_header.Horizontal = true;
            this.drag_header.TargetControl = this.header;
            this.drag_header.Vertical = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = titleApp;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bt_ok
            // 
            this.bt_ok.ActiveBorderThickness = 1;
            this.bt_ok.ActiveCornerRadius = 20;
            this.bt_ok.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_ok.ActiveForecolor = System.Drawing.Color.White;
            this.bt_ok.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_ok.BackColor = System.Drawing.SystemColors.Control;
            this.bt_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_ok.BackgroundImage")));
            this.bt_ok.ButtonText = "Ok";
            this.bt_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ok.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_ok.IdleBorderThickness = 1;
            this.bt_ok.IdleCornerRadius = 20;
            this.bt_ok.IdleFillColor = System.Drawing.Color.White;
            this.bt_ok.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_ok.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_ok.Location = new System.Drawing.Point(185, 173);
            this.bt_ok.Margin = new System.Windows.Forms.Padding(5);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(181, 41);
            this.bt_ok.TabIndex = 6;
            this.bt_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_ok.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // im_icon
            // 
            this.im_icon.Image = global::SounDownloader.Properties.Resources.bug;
            this.im_icon.InitialImage = global::SounDownloader.Properties.Resources.bug;
            this.im_icon.Location = new System.Drawing.Point(12, 55);
            this.im_icon.Name = "im_icon";
            this.im_icon.Size = new System.Drawing.Size(133, 159);
            this.im_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.im_icon.TabIndex = 2;
            this.im_icon.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.ErrorImage = global::SounDownloader.Properties.Resources.cancel;
            this.bunifuImageButton1.Image = global::SounDownloader.Properties.Resources.cancel;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = global::SounDownloader.Properties.Resources.cancel;
            this.bunifuImageButton1.Location = new System.Drawing.Point(365, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(395, 236);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.ms_box);
            this.Controls.Add(this.im_icon);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBox";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.im_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox iconApp;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox im_icon;
        private Bunifu.Framework.UI.BunifuDragControl drag_header;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.RichTextBox ms_box;
        private Bunifu.Framework.UI.BunifuThinButton2 bt_ok;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}