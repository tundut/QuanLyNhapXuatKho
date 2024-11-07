﻿using System;
using System.Collections.Generic;

namespace DoAnCK
{
    public partial class FormPhieuHoaDon : System.Windows.Forms.Form
    {
        public FormPhieuHoaDon()
        {
            InitializeComponent();
        }

        public void them_dshd(List<HangHoa> dshh)
        {
            foreach (HangHoa hh in dshh)
            {
                HangHoaBillComponent billComponent = new HangHoaBillComponent(this);
                billComponent.hh = hh;
                billComponent.SetProductInfo(hh);
                dshd_flp.Controls.Add(billComponent);

            }

            ulong tong_tien = 0;
            ulong so_luong = 0;
            foreach (HangHoa hh in dshh)
            {
                tong_tien += hh.don_gia * hh.so_luong;
                so_luong += hh.so_luong;
            }


            BillTailComponent billTailComponent = new BillTailComponent();

            billTailComponent.soluong_endbill.Text = "Số Lượng:   " + so_luong;
            billTailComponent.thanhtien_endbill.Text = "Thành Tiền:   " + String.Format("{0:N0}", tong_tien) + " VNĐ";
            dshd_flp.Controls.Add(billTailComponent);
        }
    }
}
