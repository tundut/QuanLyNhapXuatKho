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
    public partial class HangHoaComponent : UserControl
    {
        public HangHoaComponent(FormTrangChu HomeDisplay)
        {
            InitializeComponent();
            this.HomeDisplay = HomeDisplay;
        }
        private FormTrangChu HomeDisplay;
        public HangHoa hh;
        public void SetProductInfo(HangHoa hh)
        {
            ten_lbl.Text = hh.ten_hang;
            label2.Text = "Don gia: " + hh.don_gia.ToString();
            soluong_lbl.Text = "SL: " + hh.so_luong.ToString();
            hanghoa_ptb.ImageLocation = "Resources/default.jpg";
        }
    }
}
