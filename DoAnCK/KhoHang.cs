using DoAnCK;
using System.Collections.Generic;

public class KhoHang
{
    string ten_kho;
    public List<HangHoa> ds_hang_hoa = new List<HangHoa>();
    public List<NhanVien> ds_nhan_vien = new List<NhanVien>();
    public List<CuaHang> ds_cua_hang = new List<CuaHang>();
    public List<NhaCungCap> ds_ncc = new List<NhaCungCap>();
    public List<HoaDonNhap> ds_hoa_don_nhap = new List<HoaDonNhap>();
    public List<HoaDonXuat> ds_hoa_don_xuat = new List<HoaDonXuat>();

    public bool kha_dung(List<HangHoa> ds_hh)
    {
        foreach (HangHoa hh in ds_hh)
        {
            HangHoa hh_kho = ds_hang_hoa.Find(x => x.id == hh.id);
            if (hh.so_luong > hh_kho.so_luong)
            {
                return false;
            }
        }
        return true;
    }

    public void capnhatkho(List<HangHoa> ds_hh, bool isnhap)
    {
        if (isnhap)
        {
            foreach (HangHoa hanghoa in ds_hh)
            {
                HangHoa hh_kho = ds_hang_hoa.Find(x => x.id == hanghoa.id);
                hh_kho.so_luong += hanghoa.so_luong;
            }
        }
        else
        {
            foreach (HangHoa hanghoa in ds_hh)
            {
                HangHoa hh_kho = ds_hang_hoa.Find(x => x.id == hanghoa.id);
                hh_kho.so_luong -= hanghoa.so_luong;
            }
        }
    }

    public void them_hoa_don_nhap(HoaDonNhap hd_nhap)
    {
        ds_hoa_don_nhap.Add(hd_nhap);
    }

    public void them_hoa_don_xuat(HoaDonXuat hd_xuat)
    {
        ds_hoa_don_xuat.Add(hd_xuat);
    }

    public NhanVien dang_nhap(string username, string password)
    {
        NhanVien nv = new NhanVien();
        nv = ds_nhan_vien.Find(user => user.username == username && user.password == password);
        return nv;
    }
}