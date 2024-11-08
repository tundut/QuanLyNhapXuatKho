using System;
using System.Drawing;
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
            dongia_lbl.Text = "Đơn giá: " + String.Format("{0:N0}", hh.don_gia);
            soluong_lbl.Text = "SL: " + hh.so_luong.ToString();
            if (hh.img != null)
            {
                hanghoa_ptb.ImageLocation = hh.img;
            }
        }

        #region Event
        private void Mouse_Enter(object sender, EventArgs e)
        {
            guna2Panel1.FillColor = ColorTranslator.FromHtml("#888888");
            id_lbl.BackColor = ColorTranslator.FromHtml("#888888");
            hanghoa_ptb.BackColor = ColorTranslator.FromHtml("#888888");
            ten_lbl.BackColor = ColorTranslator.FromHtml("#888888");
            dongia_lbl.BackColor = ColorTranslator.FromHtml("#888888");
            soluong_lbl.BackColor = ColorTranslator.FromHtml("#888888");
        }
        private void Mouse_Leave(object sender, EventArgs e)
        {
            guna2Panel1.FillColor = ColorTranslator.FromHtml("#bbbbbb");
            id_lbl.BackColor = ColorTranslator.FromHtml("#bbbbbb");
            hanghoa_ptb.BackColor = ColorTranslator.FromHtml("#bbbbbb");
            ten_lbl.BackColor = ColorTranslator.FromHtml("#bbbbbb");
            dongia_lbl.BackColor = ColorTranslator.FromHtml("#bbbbbb");
            soluong_lbl.BackColor = ColorTranslator.FromHtml("#bbbbbb");
        }

        private void Mouse_Click(object sender, EventArgs e)
        {
            FormHangHoa formHangHoa = new FormHangHoa(hh, TrangChu);

            formHangHoa.Show();
        }
        #endregion
    }
}
