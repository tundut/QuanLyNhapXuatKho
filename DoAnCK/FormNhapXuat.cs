using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using System.Windows.Forms;

namespace DoAnCK
{
    public partial class FormNhapXuat : System.Windows.Forms.Form
    {

        public KhoHang _kho { get; set; }
        public QuanLyNhapXuat quanlynhapxuat = new QuanLyNhapXuat();
        public FormNhapXuat(KhoHang kho)
        {
            InitializeComponent();
            _kho = kho;

            foreach (HangHoa hh in _kho.ds_hang_hoa)
            {
                HangHoaNhapXuatComponent hh_component = new HangHoaNhapXuatComponent(this);
                hh_component.hh = hh;
                hh_component.SetProductInfo(hh);
                dshh_flp.Controls.Add(hh_component);
            }

            foreach (NhaCungCap ncc in _kho.ds_ncc)
            {
                ncc_cbb.Items.Add(ncc.ten_ncc);
            }
        }

        public void them_hh_lo(HangHoa hh)
        {
            if (quanlynhapxuat.ton_tai(hh) == false)
            {
                HangHoaLoComponent hh_lo = new HangHoaLoComponent(this);
                hh_lo.hh = (HangHoa)hh.Clone();
                hh_lo.hh.so_luong = 1;
                hh_lo.SetProductInfo();
                ctlh_flp.Controls.Add(hh_lo);
                quanlynhapxuat.them_hh(hh_lo.hh);
                tinh_tong_tien();
            }
        }
        public void xoa_hh_lo(HangHoaLoComponent hh_lo)
        {
            ctlh_flp.Controls.Remove(hh_lo);
            quanlynhapxuat.xoa_hh(hh_lo.hh);
            tinh_tong_tien();
        }

        public void tang_sl(HangHoaLoComponent hh_lo)
        {
            quanlynhapxuat.tang_sl(hh_lo.hh);
            tinh_tong_tien();
        }

        public void giam_sl(HangHoaLoComponent hh_lo)
        {
            quanlynhapxuat.giam_sl(hh_lo.hh);
            tinh_tong_tien();
        }
        public void nhap_sl(HangHoaLoComponent hh_lo)
        {
            quanlynhapxuat.cap_nhat_sl(hh_lo.hh, hh_lo.hh.so_luong);
            tinh_tong_tien();
        }

        public void tinh_tong_tien()
        {
            ulong tong_tien = quanlynhapxuat.tinh_tong_tien();
            tongtien_lbl.Text = "Tổng tiền: " + String.Format("{0:N0}", tong_tien) + " VNĐ";
        }

        private void ncc_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            NhaCungCap ncc = _kho.ds_ncc.Find(x => x.ten_ncc == ncc_cbb.Text);
            idncc_lbl.Text = "ID: " + ncc.id_ncc;
            diachincc_lbl.Text = "Địa chỉ: " + ncc.dia_chi_ncc;
        }

        private void apdung_btn_Click(object sender, EventArgs e)
        {
            dshh_flp.Controls.Clear();
            if (search_txb.Text == "Search")
            {
                search_txb.Text = "";
            }    

            if (loaihh_cbb.Text == "Điện tử")
            {
                foreach (HangHoa hh in _kho.ds_hang_hoa)
                {
                    if (hh is DienTu && hh.ten_hang.ToLower().Contains(search_txb.Text))
                    {
                        HangHoaNhapXuatComponent hh_component = new HangHoaNhapXuatComponent(this);
                        hh_component.hh = hh;
                        hh_component.SetProductInfo(hh);
                        dshh_flp.Controls.Add(hh_component);
                    }
                }
            }
            else if (loaihh_cbb.Text == "Gia dụng")
            {
                foreach (HangHoa hh in _kho.ds_hang_hoa)
                {
                    if (hh is GiaDung && hh.ten_hang.ToLower().Contains(search_txb.Text))
                    {
                        HangHoaNhapXuatComponent hh_component = new HangHoaNhapXuatComponent(this);
                        hh_component.hh = hh;
                        hh_component.SetProductInfo(hh);
                        dshh_flp.Controls.Add(hh_component);
                    }
                }
            }
            else if (loaihh_cbb.Text == "Thực phẩm")
            {
                foreach (HangHoa hh in _kho.ds_hang_hoa)
                {
                    if (hh is ThucPham && hh.ten_hang.ToLower().Contains(search_txb.Text))
                    {
                        HangHoaNhapXuatComponent hh_component = new HangHoaNhapXuatComponent(this);
                        hh_component.hh = hh;
                        hh_component.SetProductInfo(hh);
                        dshh_flp.Controls.Add(hh_component);
                    }
                }
            }
            else
            {
                foreach (HangHoa hh in _kho.ds_hang_hoa)
                {
                    if (hh.ten_hang.ToLower().Contains(search_txb.Text))
                    {
                        HangHoaNhapXuatComponent hh_component = new HangHoaNhapXuatComponent(this);
                        hh_component.hh = hh;
                        hh_component.SetProductInfo(hh);
                        dshh_flp.Controls.Add(hh_component);
                    }
                }
            }
        }

        private void search_tb_Click(object sender, EventArgs e)
        {
            search_txb.Text = "";
        }


    }
}
