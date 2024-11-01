﻿using System.Text;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using DoAnCK;
using System;

[XmlInclude(typeof(HoaDonNhap))]
[XmlInclude(typeof(HoaDonXuat))]
[Serializable]
public abstract class HoaDon : ISerializable
{
    public string ma_don_hang;
    public DateTime ngay_tao_don;
    public QuanLyNhapXuat ds_san_pham;
    public NhanVien nv_lap;
    public ulong tong_tien;

    public HoaDon()
    {

    }
    public HoaDon(string ma_don_hang, QuanLyNhapXuat ds_san_pham, NhanVien nv_lap)
    {
        this.ma_don_hang = ma_don_hang;
        this.ngay_tao_don = DateTime.Now;
        this.ds_san_pham = ds_san_pham;
        this.nv_lap = nv_lap;
    }

    public abstract StringBuilder ToString();

    public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("ma_don_hang", ma_don_hang);
        info.AddValue("ngay_tao_don", ngay_tao_don);
        info.AddValue("ds_san_pham", ds_san_pham);
        info.AddValue("nv_lap", nv_lap);
        info.AddValue("tong_tien", tong_tien);
    }

    public HoaDon(SerializationInfo info, StreamingContext context)
    {
        ma_don_hang = info.GetString("ma_don_hang");
        ngay_tao_don = (DateTime)info.GetValue("ngay_tao_don", typeof(DateTime));
        ds_san_pham = (QuanLyNhapXuat)info.GetValue("ds_san_pham", typeof(QuanLyNhapXuat));
        nv_lap = (NhanVien)info.GetValue("nv_lap", typeof(NhanVien));
        tong_tien = info.GetUInt64("tong_tien");
    }
}