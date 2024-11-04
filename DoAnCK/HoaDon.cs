using System.Text;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using DoAnCK;
using System;

[XmlInclude(typeof(HoaDonNhap))]
[XmlInclude(typeof(HoaDonXuat))]
[Serializable]
public abstract class HoaDon : ISerializable
{
    public string id_hoa_don;
    public DateTime ngay_tao_don;
    public QuanLyNhapXuat qlnx;
    public NhanVien nv_lap;
    public ulong tong_tien;

    public HoaDon()
    {

    }
    public HoaDon(QuanLyNhapXuat qlnx, NhanVien nv_lap, ulong tong_tien)
    {
        this.ngay_tao_don = DateTime.Now;
        this.qlnx = qlnx;
        this.nv_lap = nv_lap;
        this.tong_tien = tong_tien;
    }

    public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("id_hoa_don", id_hoa_don);
        info.AddValue("ngay_tao_don", ngay_tao_don);
        info.AddValue("qlnx", qlnx);
        info.AddValue("nv_lap", nv_lap);
        info.AddValue("tong_tien", tong_tien);
    }

    public HoaDon(SerializationInfo info, StreamingContext context)
    {
        id_hoa_don = info.GetString("id_hoa_don");
        ngay_tao_don = (DateTime)info.GetValue("ngay_tao_don", typeof(DateTime));
        qlnx = (QuanLyNhapXuat)info.GetValue("qlnx", typeof(QuanLyNhapXuat));
        nv_lap = (NhanVien)info.GetValue("nv_lap", typeof(NhanVien));
        tong_tien = info.GetUInt64("tong_tien");
    }
}