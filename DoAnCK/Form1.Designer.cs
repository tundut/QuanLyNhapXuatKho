﻿namespace DoAnCK
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
            this.hoadonnhap_btn = new Guna.UI2.WinForms.Guna2Button();
            this.hoadonxuat_btn = new Guna.UI2.WinForms.Guna2Button();
            this.sidebar = new System.Windows.Forms.Panel();
            this.hoadon_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.hoadon_btn = new Guna.UI2.WinForms.Guna2Button();
            this.nhaphang_btn = new Guna.UI2.WinForms.Guna2Button();
            this.ncc_btn = new Guna.UI2.WinForms.Guna2Button();
            this.trangchu_btn = new Guna.UI2.WinForms.Guna2Button();
            this.cuahang_btn = new Guna.UI2.WinForms.Guna2Button();
            this.menu_pnl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu_lbl = new System.Windows.Forms.Label();
            this.xuathang_btn = new Guna.UI2.WinForms.Guna2Button();
            this.hoadon_timer = new System.Windows.Forms.Timer(this.components);
            this.topbar = new System.Windows.Forms.Panel();
            this.ngay_lbl = new System.Windows.Forms.Label();
            this.nhanvien_lbl = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            this.hoadon_flp.SuspendLayout();
            this.menu_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // hoadonnhap_btn
            // 
            this.hoadonnhap_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.hoadonnhap_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.hoadonnhap_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hoadonnhap_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.hoadonnhap_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.hoadonnhap_btn.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.hoadonnhap_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.hoadonnhap_btn.Location = new System.Drawing.Point(0, 60);
            this.hoadonnhap_btn.Margin = new System.Windows.Forms.Padding(0);
            this.hoadonnhap_btn.Name = "hoadonnhap_btn";
            this.hoadonnhap_btn.Size = new System.Drawing.Size(200, 60);
            this.hoadonnhap_btn.TabIndex = 8;
            this.hoadonnhap_btn.Text = "Hoá đơn nhập";
            this.hoadonnhap_btn.MouseEnter += new System.EventHandler(this.hoadon_btn_MouseEnter);
            this.hoadonnhap_btn.MouseLeave += new System.EventHandler(this.hoadon_btn_MouseLeave);
            // 
            // hoadonxuat_btn
            // 
            this.hoadonxuat_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.hoadonxuat_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.hoadonxuat_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hoadonxuat_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.hoadonxuat_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.hoadonxuat_btn.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.hoadonxuat_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.hoadonxuat_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.hoadonxuat_btn.Location = new System.Drawing.Point(0, 120);
            this.hoadonxuat_btn.Margin = new System.Windows.Forms.Padding(0);
            this.hoadonxuat_btn.Name = "hoadonxuat_btn";
            this.hoadonxuat_btn.Size = new System.Drawing.Size(200, 60);
            this.hoadonxuat_btn.TabIndex = 7;
            this.hoadonxuat_btn.Text = "Hoá đơn xuất";
            this.hoadonxuat_btn.MouseEnter += new System.EventHandler(this.hoadon_btn_MouseEnter);
            this.hoadonxuat_btn.MouseLeave += new System.EventHandler(this.hoadon_btn_MouseLeave);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sidebar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sidebar.Controls.Add(this.hoadon_flp);
            this.sidebar.Controls.Add(this.nhaphang_btn);
            this.sidebar.Controls.Add(this.ncc_btn);
            this.sidebar.Controls.Add(this.trangchu_btn);
            this.sidebar.Controls.Add(this.cuahang_btn);
            this.sidebar.Controls.Add(this.menu_pnl);
            this.sidebar.Controls.Add(this.xuathang_btn);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 611);
            this.sidebar.MinimumSize = new System.Drawing.Size(44, 611);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 611);
            this.sidebar.TabIndex = 2;
            // 
            // hoadon_flp
            // 
            this.hoadon_flp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.hoadon_flp.Controls.Add(this.hoadon_btn);
            this.hoadon_flp.Controls.Add(this.hoadonnhap_btn);
            this.hoadon_flp.Controls.Add(this.hoadonxuat_btn);
            this.hoadon_flp.Location = new System.Drawing.Point(0, 400);
            this.hoadon_flp.Name = "hoadon_flp";
            this.hoadon_flp.Size = new System.Drawing.Size(200, 60);
            this.hoadon_flp.TabIndex = 6;
            // 
            // hoadon_btn
            // 
            this.hoadon_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.hoadon_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.hoadon_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hoadon_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.hoadon_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.hoadon_btn.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.hoadon_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.hoadon_btn.Image = ((System.Drawing.Image)(resources.GetObject("hoadon_btn.Image")));
            this.hoadon_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.hoadon_btn.Location = new System.Drawing.Point(0, 0);
            this.hoadon_btn.Margin = new System.Windows.Forms.Padding(0);
            this.hoadon_btn.Name = "hoadon_btn";
            this.hoadon_btn.Size = new System.Drawing.Size(200, 60);
            this.hoadon_btn.TabIndex = 5;
            this.hoadon_btn.Text = "   Hoá đơn";
            this.hoadon_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.hoadon_btn.MouseEnter += new System.EventHandler(this.hoadon_btn_MouseEnter);
            this.hoadon_btn.MouseLeave += new System.EventHandler(this.hoadon_btn_MouseLeave);
            // 
            // nhaphang_btn
            // 
            this.nhaphang_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nhaphang_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nhaphang_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nhaphang_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nhaphang_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nhaphang_btn.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.nhaphang_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.nhaphang_btn.Image = ((System.Drawing.Image)(resources.GetObject("nhaphang_btn.Image")));
            this.nhaphang_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nhaphang_btn.Location = new System.Drawing.Point(0, 160);
            this.nhaphang_btn.Name = "nhaphang_btn";
            this.nhaphang_btn.Size = new System.Drawing.Size(200, 60);
            this.nhaphang_btn.TabIndex = 2;
            this.nhaphang_btn.Text = "   Nhập hàng";
            this.nhaphang_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ncc_btn
            // 
            this.ncc_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ncc_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ncc_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ncc_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ncc_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ncc_btn.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.ncc_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ncc_btn.Image = ((System.Drawing.Image)(resources.GetObject("ncc_btn.Image")));
            this.ncc_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ncc_btn.Location = new System.Drawing.Point(0, 340);
            this.ncc_btn.Name = "ncc_btn";
            this.ncc_btn.Size = new System.Drawing.Size(200, 60);
            this.ncc_btn.TabIndex = 4;
            this.ncc_btn.Text = "   Nhà cung cấp";
            this.ncc_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // trangchu_btn
            // 
            this.trangchu_btn.Checked = true;
            this.trangchu_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.trangchu_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.trangchu_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.trangchu_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.trangchu_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.trangchu_btn.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.trangchu_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.trangchu_btn.Image = ((System.Drawing.Image)(resources.GetObject("trangchu_btn.Image")));
            this.trangchu_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.trangchu_btn.Location = new System.Drawing.Point(0, 100);
            this.trangchu_btn.Name = "trangchu_btn";
            this.trangchu_btn.Size = new System.Drawing.Size(200, 60);
            this.trangchu_btn.TabIndex = 0;
            this.trangchu_btn.Text = "   Trang chủ";
            this.trangchu_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cuahang_btn
            // 
            this.cuahang_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cuahang_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cuahang_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cuahang_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cuahang_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cuahang_btn.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.cuahang_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cuahang_btn.Image = ((System.Drawing.Image)(resources.GetObject("cuahang_btn.Image")));
            this.cuahang_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cuahang_btn.Location = new System.Drawing.Point(0, 280);
            this.cuahang_btn.Name = "cuahang_btn";
            this.cuahang_btn.Size = new System.Drawing.Size(200, 60);
            this.cuahang_btn.TabIndex = 3;
            this.cuahang_btn.Text = "   Cửa hàng";
            this.cuahang_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // menu_pnl
            // 
            this.menu_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu_pnl.Controls.Add(this.pictureBox1);
            this.menu_pnl.Controls.Add(this.menu_lbl);
            this.menu_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_pnl.Location = new System.Drawing.Point(0, 0);
            this.menu_pnl.Name = "menu_pnl";
            this.menu_pnl.Size = new System.Drawing.Size(196, 100);
            this.menu_pnl.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menu_lbl
            // 
            this.menu_lbl.AutoSize = true;
            this.menu_lbl.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.menu_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.menu_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_lbl.Location = new System.Drawing.Point(63, 41);
            this.menu_lbl.Name = "menu_lbl";
            this.menu_lbl.Size = new System.Drawing.Size(58, 21);
            this.menu_lbl.TabIndex = 1;
            this.menu_lbl.Text = "Menu";
            this.menu_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xuathang_btn
            // 
            this.xuathang_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.xuathang_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.xuathang_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.xuathang_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.xuathang_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.xuathang_btn.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.xuathang_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.xuathang_btn.Image = ((System.Drawing.Image)(resources.GetObject("xuathang_btn.Image")));
            this.xuathang_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.xuathang_btn.Location = new System.Drawing.Point(0, 220);
            this.xuathang_btn.Name = "xuathang_btn";
            this.xuathang_btn.Size = new System.Drawing.Size(200, 60);
            this.xuathang_btn.TabIndex = 1;
            this.xuathang_btn.Text = "   Xuất hàng";
            this.xuathang_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // hoadon_timer
            // 
            this.hoadon_timer.Interval = 10;
            this.hoadon_timer.Tick += new System.EventHandler(this.hoadon_timer_Tick);
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.topbar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topbar.Controls.Add(this.pictureBox2);
            this.topbar.Controls.Add(this.ngay_lbl);
            this.topbar.Controls.Add(this.nhanvien_lbl);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(200, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(684, 100);
            this.topbar.TabIndex = 3;
            // 
            // ngay_lbl
            // 
            this.ngay_lbl.AutoSize = true;
            this.ngay_lbl.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.ngay_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ngay_lbl.Location = new System.Drawing.Point(20, 50);
            this.ngay_lbl.Name = "ngay_lbl";
            this.ngay_lbl.Size = new System.Drawing.Size(55, 21);
            this.ngay_lbl.TabIndex = 3;
            this.ngay_lbl.Text = "Ngày";
            // 
            // nhanvien_lbl
            // 
            this.nhanvien_lbl.AutoSize = true;
            this.nhanvien_lbl.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.nhanvien_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.nhanvien_lbl.Location = new System.Drawing.Point(20, 15);
            this.nhanvien_lbl.Name = "nhanvien_lbl";
            this.nhanvien_lbl.Size = new System.Drawing.Size(104, 21);
            this.nhanvien_lbl.TabIndex = 2;
            this.nhanvien_lbl.Text = "Nhân viên:";
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBody.Location = new System.Drawing.Point(200, 100);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(684, 550);
            this.panelBody.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(470, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Quan Ly Kho";
            this.sidebar.ResumeLayout(false);
            this.hoadon_flp.ResumeLayout(false);
            this.menu_pnl.ResumeLayout(false);
            this.menu_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topbar.ResumeLayout(false);
            this.topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel menu_pnl;
        private Guna.UI2.WinForms.Guna2Button trangchu_btn;
        private Guna.UI2.WinForms.Guna2Button hoadon_btn;
        private Guna.UI2.WinForms.Guna2Button ncc_btn;
        private Guna.UI2.WinForms.Guna2Button cuahang_btn;
        private Guna.UI2.WinForms.Guna2Button nhaphang_btn;
        private Guna.UI2.WinForms.Guna2Button xuathang_btn;
        private System.Windows.Forms.Timer hoadon_timer;
        private System.Windows.Forms.FlowLayoutPanel hoadon_flp;
        private Guna.UI2.WinForms.Guna2Button hoadonnhap_btn;
        private Guna.UI2.WinForms.Guna2Button hoadonxuat_btn;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Label ngay_lbl;
        private System.Windows.Forms.Label nhanvien_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label menu_lbl;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

