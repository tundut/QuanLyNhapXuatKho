namespace DoAnCK
{
    partial class FormTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            this.search_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.dssp_pnl = new System.Windows.Forms.Panel();
            this.dssp_lbl = new System.Windows.Forms.Label();
            this.thucpham_btn = new Guna.UI2.WinForms.Guna2Button();
            this.dientu_btn = new Guna.UI2.WinForms.Guna2Button();
            this.giadung_btn = new Guna.UI2.WinForms.Guna2Button();
            this.tatca_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hanghoa_flp = new System.Windows.Forms.FlowLayoutPanel();
            this.dssp_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_tb
            // 
            this.search_tb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.search_tb.BorderRadius = 13;
            this.search_tb.BorderThickness = 3;
            this.search_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_tb.DefaultText = "Search";
            this.search_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.search_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_tb.IconLeft = ((System.Drawing.Image)(resources.GetObject("search_tb.IconLeft")));
            this.search_tb.IconLeftOffset = new System.Drawing.Point(-3, -1);
            this.search_tb.IconLeftSize = new System.Drawing.Size(25, 25);
            this.search_tb.Location = new System.Drawing.Point(12, 12);
            this.search_tb.Name = "search_tb";
            this.search_tb.PasswordChar = '\0';
            this.search_tb.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.search_tb.PlaceholderText = "";
            this.search_tb.SelectedText = "";
            this.search_tb.Size = new System.Drawing.Size(200, 30);
            this.search_tb.TabIndex = 5;
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            this.search_tb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.search_tb_MouseClick);
            // 
            // dssp_pnl
            // 
            this.dssp_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dssp_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dssp_pnl.Controls.Add(this.dssp_lbl);
            this.dssp_pnl.Location = new System.Drawing.Point(4, 48);
            this.dssp_pnl.Name = "dssp_pnl";
            this.dssp_pnl.Size = new System.Drawing.Size(684, 50);
            this.dssp_pnl.TabIndex = 6;
            // 
            // dssp_lbl
            // 
            this.dssp_lbl.AutoSize = true;
            this.dssp_lbl.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.dssp_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dssp_lbl.Location = new System.Drawing.Point(248, 11);
            this.dssp_lbl.Name = "dssp_lbl";
            this.dssp_lbl.Size = new System.Drawing.Size(208, 24);
            this.dssp_lbl.TabIndex = 4;
            this.dssp_lbl.Text = "Danh sách sản phẩm";
            // 
            // thucpham_btn
            // 
            this.thucpham_btn.BorderRadius = 15;
            this.thucpham_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.thucpham_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.thucpham_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.thucpham_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.thucpham_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.thucpham_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.thucpham_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.thucpham_btn.Location = new System.Drawing.Point(544, 104);
            this.thucpham_btn.Name = "thucpham_btn";
            this.thucpham_btn.Size = new System.Drawing.Size(120, 30);
            this.thucpham_btn.TabIndex = 13;
            this.thucpham_btn.Text = "Thực phẩm";
            this.thucpham_btn.Click += new System.EventHandler(this.thucpham_btn_Click);
            // 
            // dientu_btn
            // 
            this.dientu_btn.BorderRadius = 15;
            this.dientu_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dientu_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dientu_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dientu_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dientu_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dientu_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.dientu_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dientu_btn.Location = new System.Drawing.Point(364, 104);
            this.dientu_btn.Name = "dientu_btn";
            this.dientu_btn.Size = new System.Drawing.Size(120, 30);
            this.dientu_btn.TabIndex = 12;
            this.dientu_btn.Text = "Điện tử";
            this.dientu_btn.Click += new System.EventHandler(this.dientu_btn_Click);
            // 
            // giadung_btn
            // 
            this.giadung_btn.BorderRadius = 15;
            this.giadung_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.giadung_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.giadung_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.giadung_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.giadung_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.giadung_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.giadung_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.giadung_btn.Location = new System.Drawing.Point(194, 104);
            this.giadung_btn.Name = "giadung_btn";
            this.giadung_btn.Size = new System.Drawing.Size(120, 30);
            this.giadung_btn.TabIndex = 11;
            this.giadung_btn.Text = "Gia dụng";
            this.giadung_btn.Click += new System.EventHandler(this.giadung_btn_Click);
            // 
            // tatca_btn
            // 
            this.tatca_btn.BorderRadius = 15;
            this.tatca_btn.Checked = true;
            this.tatca_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tatca_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tatca_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tatca_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tatca_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tatca_btn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tatca_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tatca_btn.Location = new System.Drawing.Point(24, 104);
            this.tatca_btn.Name = "tatca_btn";
            this.tatca_btn.Size = new System.Drawing.Size(120, 30);
            this.tatca_btn.TabIndex = 10;
            this.tatca_btn.Text = "Tất cả";
            this.tatca_btn.Click += new System.EventHandler(this.tatca_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(4, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 5);
            this.panel2.TabIndex = 15;
            // 
            // hanghoa_flp
            // 
            this.hanghoa_flp.AutoScroll = true;
            this.hanghoa_flp.Location = new System.Drawing.Point(15, 150);
            this.hanghoa_flp.Name = "hanghoa_flp";
            this.hanghoa_flp.Size = new System.Drawing.Size(650, 350);
            this.hanghoa_flp.TabIndex = 14;
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.hanghoa_flp);
            this.Controls.Add(this.thucpham_btn);
            this.Controls.Add(this.dientu_btn);
            this.Controls.Add(this.giadung_btn);
            this.Controls.Add(this.tatca_btn);
            this.Controls.Add(this.dssp_pnl);
            this.Controls.Add(this.search_tb);
            this.Name = "FormTrangChu";
            this.Text = "FormTrangChu";
            this.dssp_pnl.ResumeLayout(false);
            this.dssp_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox search_tb;
        private System.Windows.Forms.Panel dssp_pnl;
        private System.Windows.Forms.Label dssp_lbl;
        private Guna.UI2.WinForms.Guna2Button thucpham_btn;
        private Guna.UI2.WinForms.Guna2Button dientu_btn;
        private Guna.UI2.WinForms.Guna2Button giadung_btn;
        private Guna.UI2.WinForms.Guna2Button tatca_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel hanghoa_flp;
    }
}