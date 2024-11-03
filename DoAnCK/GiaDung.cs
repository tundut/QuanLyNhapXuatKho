using DoAnCK;
using System;
using System.Runtime.Serialization;

[Serializable]
public class GiaDung : HangHoa
{
    public GiaDung()
    {

    }
    public GiaDung(string id, string ten_hang, uint so_luong, ulong don_gia) : base(id, ten_hang, so_luong, don_gia)
    {

    }

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
    }

    public GiaDung(SerializationInfo info, StreamingContext context) : base(info, context)
    {

    }
}