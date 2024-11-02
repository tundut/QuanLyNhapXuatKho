using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCK
{
    public partial class HangHoaTrangChuComponent : UserControl
    {
        public HangHoaTrangChuComponent(FormTrangChu TrangChu)
        {
            InitializeComponent();
            this.TrangChu = TrangChu;
        }
        private FormTrangChu TrangChu;
        public HangHoa hh;
        public void SetProductInfo(HangHoa hh)
        {
            id_lbl.Text = "ID: " + hh.id;
            ten_lbl.Text = hh.ten_hang;
            dongia_lbl.Text = "Đơn giá: " + hh.don_gia.ToString();
            soluong_lbl.Text = "SL: " + hh.so_luong.ToString();
            hanghoa_ptb.ImageLocation = "Resources/default.jpg";
        }
    }
}
