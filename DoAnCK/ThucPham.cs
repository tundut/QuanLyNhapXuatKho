﻿using System;
using System.Runtime.Serialization;

[Serializable]
public class ThucPham : HangHoa
{
    public ThucPham()
    {

    }
    public ThucPham(string id, string ten_hang, uint so_luong, ulong don_gia) : base(id, ten_hang, so_luong, don_gia)
    {

    }

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
    }

    public ThucPham(SerializationInfo info, StreamingContext context) : base(info, context)
    {

    }
}