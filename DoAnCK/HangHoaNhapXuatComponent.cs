using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnCK
{
    public partial class HangHoaNhapXuatComponent : UserControl
    {
        public HangHoaNhapXuatComponent(FormNhapXuat NhapHang)
        {
            InitializeComponent();
            this.NhapHang = NhapHang;
        }
        private FormNhapXuat NhapHang;
        public HangHoa hh;
        public void SetProductInfo(HangHoa hh)
        {
            ten_lbl.Text = hh.ten_hang;
            dongia_lbl.Text = "Đơn giá: " + String.Format("{0:N0}", hh.don_gia);
            soluong_lbl.Text = "SL: " + hh.so_luong.ToString();
            if (hh.img != null)
            {
                hanghoa_ptb.ImageLocation = hh.img;
            }
            else
            {
                hanghoa_ptb.ImageLocation = "Resources/default.jpg";
            }
        }

        #region Event
        private void Mouse_Enter(object sender, EventArgs e)
        {
            guna2Panel1.FillColor = ColorTranslator.FromHtml("#888888");
            hanghoa_ptb.BackColor = ColorTranslator.FromHtml("#888888");
            ten_lbl.BackColor = ColorTranslator.FromHtml("#888888");
            dongia_lbl.BackColor = ColorTranslator.FromHtml("#888888");
            soluong_lbl.BackColor = ColorTranslator.FromHtml("#888888");
        }
        private void Mouse_Leave(object sender, EventArgs e)
        {
            guna2Panel1.FillColor = ColorTranslator.FromHtml("#bbbbbb");
            hanghoa_ptb.BackColor = ColorTranslator.FromHtml("#bbbbbb");
            ten_lbl.BackColor = ColorTranslator.FromHtml("#bbbbbb");
            dongia_lbl.BackColor = ColorTranslator.FromHtml("#bbbbbb");
            soluong_lbl.BackColor = ColorTranslator.FromHtml("#bbbbbb");
        }

        private void Mouse_Click(object sender, EventArgs e)
        {
            NhapHang.them_hh_lo(hh);
        }
        #endregion
    }
}
