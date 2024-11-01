using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace DoAnCK
{
    public partial class FormTrangChu : Form
    {
        KhoHang kho = new KhoHang();
        public FormTrangChu()
        {
            InitializeComponent();

            
            string filePath = "Resources/hang_hoa.dat";

            using (StreamReader reader = new StreamReader(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<HangHoa>));
                kho.ds_san_pham = (List<HangHoa>)serializer.Deserialize(reader);
            }

            foreach (HangHoa hh in kho.ds_san_pham)
            {
                HangHoaComponent hh_component = new HangHoaComponent(this);
                hh_component.hh = hh;
                hh_component.SetProductInfo(hh);
                hanghoa_flp.Controls.Add(hh_component);
            }

            ngay_lbl.Text = "Ngày " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        bool sidebarExpand = true;
        bool hoadonExpand = false;


        private void hoadon_timer_Tick(object sender, EventArgs e)
        {
            if (hoadonExpand == false && hoadon_flp.Height < 180)
            {
                hoadon_flp.Height += 10;
                if (hoadon_flp.Height >= 180)
                {
                    hoadon_timer.Stop();

                }
            }
            else if (hoadonExpand == true && hoadon_flp.Height > 60)
            {
                hoadon_flp.Height -= 10;
                if (hoadon_flp.Height <= 60)
                {
                    hoadon_timer.Stop();

                }
            }
        }
        private void hoadon_btn_MouseEnter(object sender, EventArgs e)
        {
            hoadon_timer.Stop();
            hoadonExpand = false;
            hoadon_timer.Start();
        }

        private void hoadon_btn_MouseLeave(object sender, EventArgs e)
        {
            hoadon_timer.Stop();
            hoadonExpand = true;
            hoadon_timer.Start();
        }

        private void tatca_btn_Click(object sender, EventArgs e)
        {
            tatca_btn.Checked = true;
            giadung_btn.Checked = false;
            dientu_btn.Checked = false;
            thucpham_btn.Checked = false;

            hanghoa_flp.Controls.Clear();
            foreach (HangHoa hh in kho.ds_san_pham)
            {
                HangHoaComponent hh_component = new HangHoaComponent(this);
                hh_component.hh = hh;
                hh_component.SetProductInfo(hh);
                hanghoa_flp.Controls.Add(hh_component);
            }
        }



        

        private void giadung_btn_Click(object sender, EventArgs e)
        {
            tatca_btn.Checked = false;
            giadung_btn.Checked = true;
            dientu_btn.Checked = false;
            thucpham_btn.Checked = false;

            hanghoa_flp.Controls.Clear();
            foreach (HangHoa hh in kho.ds_san_pham)
            {
                if (hh is GiaDung)
                {
                    HangHoaComponent hh_component = new HangHoaComponent(this);
                    hh_component.hh = hh;
                    hh_component.SetProductInfo(hh);
                    hanghoa_flp.Controls.Add(hh_component);
                }
            }
        }

        private void dientu_btn_Click(object sender, EventArgs e)
        {
            tatca_btn.Checked = false;
            giadung_btn.Checked = false;
            dientu_btn.Checked = true;
            thucpham_btn.Checked = false;

            hanghoa_flp.Controls.Clear();
            foreach (HangHoa hh in kho.ds_san_pham)
            {
                if (hh is DienTu)
                {
                    HangHoaComponent hh_component = new HangHoaComponent(this);
                    hh_component.hh = hh;
                    hh_component.SetProductInfo(hh);
                    hanghoa_flp.Controls.Add(hh_component);
                }
            }
        }

        private void thucpham_btn_Click(object sender, EventArgs e)
        {
            tatca_btn.Checked = false;
            giadung_btn.Checked = false;
            dientu_btn.Checked = false;
            thucpham_btn.Checked = true;

            hanghoa_flp.Controls.Clear();
            foreach (HangHoa hh in kho.ds_san_pham)
            {
                if (hh is ThucPham)
                {
                    HangHoaComponent hh_component = new HangHoaComponent(this);
                    hh_component.hh = hh;
                    hh_component.SetProductInfo(hh);
                    hanghoa_flp.Controls.Add(hh_component);
                }
            }
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            hanghoa_flp.Controls.Clear();
            string searchText = search_tb.Text;
            foreach (HangHoa hh in kho.ds_san_pham)
            {
                if (hh.ten_hang.ToLower().Contains(searchText.ToLower()))
                {
                    HangHoaComponent hh_component = new HangHoaComponent(this);
                    hh_component.hh = hh;
                    hh_component.SetProductInfo(hh);
                    hanghoa_flp.Controls.Add(hh_component);
                }
            }
        }

        private void search_tb_MouseClick(object sender, MouseEventArgs e)
        {
            search_tb.Text = "";
        }
    }
}
