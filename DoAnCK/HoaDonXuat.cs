using System.Text;
using System.Runtime.Serialization;
using DoAnCK;
using System;

[Serializable]
public class HoaDonXuat : HoaDon
{
    public CuaHang cua_hang;
    public HoaDonXuat()
    {

    }
    public HoaDonXuat(QuanLyNhapXuat qlnx, NhanVien nv_lap, CuaHang cua_hang, ulong tong_tien) : base(qlnx, nv_lap, tong_tien)
    {
        ngay_tao_don = DateTime.Now;
        this.cua_hang = cua_hang;
    }


    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
        info.AddValue("cua_hang", cua_hang);
    }

    public HoaDonXuat(SerializationInfo info, StreamingContext context) : base(info, context)
    {
        cua_hang = (CuaHang)info.GetValue("cua_hang", typeof(CuaHang));
    }

}