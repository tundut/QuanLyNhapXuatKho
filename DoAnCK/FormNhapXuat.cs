using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DoAnCK
{
    public partial class FormNhapXuat : System.Windows.Forms.Form
    {
        private bool isnhap;

        private KhoHang kho = new KhoHang();
        private QuanLyNhapXuat quanlynhapxuat = new QuanLyNhapXuat();

        private NhanVien current_nv = new NhanVien();

        public FormNhapXuat(NhanVien current_nv, bool isnhap)
        {
            InitializeComponent();

            kho.LoadData();

            this.isnhap = isnhap;
            this.current_nv = current_nv;
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

        private void ncc_ch_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isnhap)
            {
                NhaCungCap ncc = kho.ds_ncc.Find(x => x.ten_ncc == ncc_ch_cbb.Text);
                id_lbl.Text = "ID: " + ncc.id_ncc;
                diachi_lbl.Text = "Địa chỉ: " + ncc.dia_chi_ncc;
            }
            else
            {
                CuaHang ncc = kho.ds_cua_hang.Find(x => x.ten_ch == ncc_ch_cbb.Text);
                id_lbl.Text = "ID: " + ncc.id_ch;
                diachi_lbl.Text = "Địa chỉ: " + ncc.dia_chi_ch;
            }
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
                foreach (HangHoa hh in kho.ds_hang_hoa)
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
                foreach (HangHoa hh in kho.ds_hang_hoa)
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
                foreach (HangHoa hh in kho.ds_hang_hoa)
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
                foreach (HangHoa hh in kho.ds_hang_hoa)
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

        private void huy_btn_Click(object sender, EventArgs e)
        {
            quanlynhapxuat = new QuanLyNhapXuat();
            ctlh_flp.Controls.Clear();
            tinh_tong_tien();
        }

        private void xuathoadon_btn_Click(object sender, EventArgs e)
        {
            if (isnhap)
            {
                NhaCungCap current_ncc = kho.ds_ncc.Find(x => x.ten_ncc == ncc_ch_cbb.Text);
                if (current_ncc != null)
                {
                    kho.capnhatkho(quanlynhapxuat.ds_hang_hoa, true);
                    string id_hoa_don = "HDN" + (kho.ds_hoa_don_nhap.Count + 1);

                    FormPhieuHoaDon formHoaDon = new FormPhieuHoaDon();
                    formHoaDon.hd_lbl.Text = "Hoá Đơn Nhập";
                    formHoaDon.ngaylap_lbl.Text = DateTime.Now.ToString();
                    formHoaDon.idnv_lbl.Text = "ID nhân viên lập: " + current_nv.id_nv;
                    formHoaDon.idhd_lbl.Text = "ID hoá đơn: " + id_hoa_don;
                    formHoaDon.idncc_ch_lbl.Text = "ID nhà cung cấp: " + current_ncc.id_ncc;
                    formHoaDon.them_dshd(quanlynhapxuat.ds_hang_hoa);
                    formHoaDon.Show();

                    HoaDonNhap hoaDonNhap = new HoaDonNhap(quanlynhapxuat, id_hoa_don, current_nv, current_ncc, quanlynhapxuat.tinh_tong_tien());
                    kho.ThemHoaDonNhap(hoaDonNhap);

                    dshh_flp.Controls.Clear();
                    kho.LoadData();
                    foreach (HangHoa hh in kho.ds_hang_hoa)
                    {
                        HangHoaNhapXuatComponent hh_component = new HangHoaNhapXuatComponent(this);
                        hh_component.hh = hh;
                        hh_component.SetProductInfo(hh);
                        dshh_flp.Controls.Add(hh_component);
                    }

                    ctlh_flp.Controls.Clear();
                    quanlynhapxuat = new QuanLyNhapXuat();
                    tinh_tong_tien();
                }
                else
                {
                    MessageBox.Show("Hãy chọn nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                CuaHang current_ch = kho.ds_cua_hang.Find(x => x.ten_ch == ncc_ch_cbb.Text);
                if (current_ch != null)
                {
                    if (kho.kha_dung(quanlynhapxuat.ds_hang_hoa))
                    {
                        kho.capnhatkho(quanlynhapxuat.ds_hang_hoa, false);
                        string id_hoa_don = "HDX" + (kho.ds_hoa_don_xuat.Count + 1);

                        FormPhieuHoaDon formHoaDon = new FormPhieuHoaDon();
                        formHoaDon.hd_lbl.Text = "Hoá Đơn Xuất";
                        formHoaDon.ngaylap_lbl.Text = DateTime.Now.ToString();
                        formHoaDon.idnv_lbl.Text = "ID nhân viên lập: " + current_nv.id_nv;
                        formHoaDon.idhd_lbl.Text = "ID hoá đơn: " + id_hoa_don;
                        formHoaDon.idncc_ch_lbl.Text = "ID cửa hàng: " + current_ch.id_ch;
                        formHoaDon.them_dshd(quanlynhapxuat.ds_hang_hoa);
                        formHoaDon.Show();

                        HoaDonXuat hoaDonXuat = new HoaDonXuat(quanlynhapxuat, id_hoa_don, current_nv, current_ch, quanlynhapxuat.tinh_tong_tien());
                        kho.ThemHoaDonXuat(hoaDonXuat);


                        dshh_flp.Controls.Clear();
                        kho.LoadData();
                        foreach (HangHoa hh in kho.ds_hang_hoa)
                        {
                            HangHoaNhapXuatComponent hh_component = new HangHoaNhapXuatComponent(this);
                            hh_component.hh = hh;
                            hh_component.SetProductInfo(hh);
                            dshh_flp.Controls.Add(hh_component);
                        }

                        ctlh_flp.Controls.Clear();
                        quanlynhapxuat = new QuanLyNhapXuat();
                        tinh_tong_tien();
                    }
                    else
                    {
                        MessageBox.Show("Số lượng tồn kho không đủ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn cửa hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  
        }

        private void FormNhapXuat_Load(object sender, EventArgs e)
        {
            foreach (HangHoa hh in kho.ds_hang_hoa)
            {
                HangHoaNhapXuatComponent hh_component = new HangHoaNhapXuatComponent(this);
                hh_component.hh = hh;
                hh_component.SetProductInfo(hh);
                dshh_flp.Controls.Add(hh_component);
            }

            if (isnhap)
            {
                ncc_ch_lbl.Text = "Nhà cung cấp";
                foreach (NhaCungCap ncc in kho.ds_ncc)
                {
                    ncc_ch_cbb.Items.Add(ncc.ten_ncc);
                }
            }
            else
            {
                ncc_ch_lbl.Text = "Cửa hàng";
                foreach (CuaHang ch in kho.ds_cua_hang)
                {
                    ncc_ch_cbb.Items.Add(ch.ten_ch);
                }
            }
        }
    }
}
