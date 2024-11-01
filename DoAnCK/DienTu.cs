﻿using DoAnCK;
using System;
using System.Runtime.Serialization;

[Serializable]
public class DienTu : HangHoa
{
    public DienTu()
    {

    }

    public DienTu(string id, string ten_hang, uint so_luong, long don_gia) : base(id, ten_hang, so_luong, don_gia)
    {

    }
    public override string ToString()
    {
        return $"{id,-5} | {ten_hang,-20} | {so_luong,-10} | {don_gia,-15}";
    }

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
    }

    public DienTu(SerializationInfo info, StreamingContext context) : base(info, context)
    {

    }
}