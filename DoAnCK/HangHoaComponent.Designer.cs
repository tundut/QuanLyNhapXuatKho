namespace DoAnCK
{
    partial class HangHoaComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.soluong_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ten_lbl = new System.Windows.Forms.Label();
            this.hanghoa_ptb = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoa_ptb)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.guna2Panel1.Controls.Add(this.soluong_lbl);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.ten_lbl);
            this.guna2Panel1.Controls.Add(this.hanghoa_ptb);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(144, 204);
            this.guna2Panel1.TabIndex = 0;
            // 
            // soluong_lbl
            // 
            this.soluong_lbl.AutoSize = true;
            this.soluong_lbl.Font = new System.Drawing.Font("Arial", 8F);
            this.soluong_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.soluong_lbl.Location = new System.Drawing.Point(100, 185);
            this.soluong_lbl.Name = "soluong_lbl";
            this.soluong_lbl.Size = new System.Drawing.Size(26, 14);
            this.soluong_lbl.TabIndex = 3;
            this.soluong_lbl.Text = "SL: ";
            this.soluong_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(5, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Don gia: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ten_lbl
            // 
            this.ten_lbl.AutoSize = true;
            this.ten_lbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.ten_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ten_lbl.Location = new System.Drawing.Point(5, 145);
            this.ten_lbl.Name = "ten_lbl";
            this.ten_lbl.Size = new System.Drawing.Size(40, 16);
            this.ten_lbl.TabIndex = 1;
            this.ten_lbl.Text = "Ten: ";
            this.ten_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hanghoa_ptb
            // 
            this.hanghoa_ptb.Location = new System.Drawing.Point(3, 3);
            this.hanghoa_ptb.Name = "hanghoa_ptb";
            this.hanghoa_ptb.Size = new System.Drawing.Size(138, 136);
            this.hanghoa_ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hanghoa_ptb.TabIndex = 0;
            this.hanghoa_ptb.TabStop = false;
            // 
            // HangHoaComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "HangHoaComponent";
            this.Size = new System.Drawing.Size(150, 210);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hanghoa_ptb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox hanghoa_ptb;
        private System.Windows.Forms.Label soluong_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ten_lbl;
    }
}
