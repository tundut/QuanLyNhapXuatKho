﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DoAnCK
{

    public partial class FormDangNhap : System.Windows.Forms.Form
    {
        public KhoHang kho = new KhoHang();

        public NhanVien current_nv;

        public FormDangNhap()
        {
            InitializeComponent();

            string filePath_nv = "Resources/nhan_vien.dat";
            using (StreamReader reader = new StreamReader(filePath_nv))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<NhanVien>));
                kho.ds_nhan_vien = (List<NhanVien>)serializer.Deserialize(reader);
            }
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;

            current_nv = kho.dang_nhap(username, password);

            if (current_nv != null)
            {
                this.DialogResult = DialogResult.OK; // Nếu đăng nhập thành công
                this.Close(); // Đóng form đăng nhập
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng thử lại.");
            }
        }
    }
}