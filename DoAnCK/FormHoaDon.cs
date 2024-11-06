﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK
{
    public partial class FormHoaDon : System.Windows.Forms.Form
    {
        KhoHang kho = new KhoHang();
        private bool isnhap;

        private int index;

        public FormHoaDon(bool isnhap)
        {
            InitializeComponent();
            kho.LoadData();
            this.isnhap = isnhap;

        }

        private void HoaDon_load(object sender, EventArgs e)
        {
            if (isnhap) 
            {
                label1.Text = "Danh sách hoá đơn nhập";
                dataHD.Columns["ncc_ch"].HeaderText = "ID nhà cung cấp";
                foreach (HoaDonNhap hdn in kho.ds_hoa_don_nhap)
                {
                    dataHD.Rows.Add(hdn.id_hoa_don, hdn.ngay_tao_don, hdn.nv_lap.id_nv, hdn.nha_cung_cap.id_ncc, hdn.tong_tien);
                }
                dataHD.Enabled = dataHD.Rows.Count > 0;
            }
            else
            {
                label1.Text = "Danh sách hoá đơn xuất";
                dataHD.Columns["ncc_ch"].HeaderText = "ID cửa hàng";
                foreach (HoaDonXuat hdx in kho.ds_hoa_don_xuat)
                {
                    dataHD.Rows.Add(hdx.id_hoa_don, hdx.ngay_tao_don, hdx.nv_lap.id_nv, hdx.cua_hang.id_ch, hdx.tong_tien);
                }
                dataHD.Enabled = dataHD.Rows.Count > 0;
            }
        }

        private void dataHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataHD.CurrentCell.RowIndex;
            if (isnhap)
            {               
                HoaDonNhap hdn = kho.ds_hoa_don_nhap[index];
                FormPhieuHoaDon formHoaDon = new FormPhieuHoaDon();
                formHoaDon.hd_lbl.Text = "Hoá Đơn Nhập";
                formHoaDon.ngaylap_lbl.Text = "Ngày lập: " + DateTime.Now.ToString();
                formHoaDon.idnv_lbl.Text = "ID nhân viên lập: " + hdn.nv_lap.id_nv;
                formHoaDon.idhd_lbl.Text = "ID hoá đơn: " + hdn.id_hoa_don;
                formHoaDon.idncc_ch_lbl.Text = "ID nhà cung cấp: " + hdn.nha_cung_cap.id_ncc;
                formHoaDon.them_dshd(hdn.qlnx.ds_hang_hoa);
                formHoaDon.Show();
            }
            else
            {
                HoaDonXuat hdx = kho.ds_hoa_don_xuat[index];
                FormPhieuHoaDon formHoaDon = new FormPhieuHoaDon();
                formHoaDon.hd_lbl.Text = "Hoá Đơn Nhập";
                formHoaDon.ngaylap_lbl.Text = "Ngày lập: " + DateTime.Now.ToString();
                formHoaDon.idnv_lbl.Text = "ID nhân viên lập: " + hdx.nv_lap.id_nv;
                formHoaDon.idhd_lbl.Text = "ID hoá đơn: " + hdx.id_hoa_don;
                formHoaDon.idncc_ch_lbl.Text = "ID nhà cung cấp: " + hdx.cua_hang.id_ch;
                formHoaDon.them_dshd(hdx.qlnx.ds_hang_hoa);
                formHoaDon.Show();
            }    
        }
    }
}