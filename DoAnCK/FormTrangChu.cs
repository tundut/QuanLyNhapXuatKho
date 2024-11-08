using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace DoAnCK
{
    public partial class FormTrangChu : System.Windows.Forms.Form
    {
        private KhoHang kho = new KhoHang();
        public FormTrangChu()
        {
            InitializeComponent();
            kho.LoadData();
        }

        public void Reload_flp()
        {
            dshh_flp.Controls.Clear();
            kho.LoadData();

            if (dientu_btn.Checked)
            {
                foreach (HangHoa hh in kho.ds_hang_hoa)
                {
                    if (hh is DienTu && (hh.ten_hang.ToLower().Contains(search_tb.Text) || search_tb.Text == "Search"))
                    {
                        HangHoaTrangChuComponent hh_component = new HangHoaTrangChuComponent(this);
                        hh_component.hh = hh;
                        hh_component.SetProductInfo(hh);
                        dshh_flp.Controls.Add(hh_component);
                    }
                }
            }
            else if (giadung_btn.Checked)
            {
                foreach (HangHoa hh in kho.ds_hang_hoa)
                {
                    if (hh is GiaDung && (hh.ten_hang.ToLower().Contains(search_tb.Text) || search_tb.Text == "Search"))
                    {
                        HangHoaTrangChuComponent hh_component = new HangHoaTrangChuComponent(this);
                        hh_component.hh = hh;
                        hh_component.SetProductInfo(hh);
                        dshh_flp.Controls.Add(hh_component);
                    }
                }
            }
            else if (thucpham_btn.Checked)
            {
                foreach (HangHoa hh in kho.ds_hang_hoa)
                {
                    if (hh is ThucPham && (hh.ten_hang.ToLower().Contains(search_tb.Text) || search_tb.Text == "Search"))
                    {
                        HangHoaTrangChuComponent hh_component = new HangHoaTrangChuComponent(this);
                        hh_component.hh = hh;
                        hh_component.SetProductInfo(hh);
                        dshh_flp.Controls.Add(hh_component);
                    }
                }
            }
            else if (tatca_btn.Checked)
            {
                foreach (HangHoa hh in kho.ds_hang_hoa)
                {
                    if (hh.ten_hang.ToLower().Contains(search_tb.Text) || search_tb.Text == "Search")
                    {
                        HangHoaTrangChuComponent hh_component = new HangHoaTrangChuComponent(this);
                        hh_component.hh = hh;
                        hh_component.SetProductInfo(hh);
                        dshh_flp.Controls.Add(hh_component);
                    }
                }
            }
        }

        #region Event
        private void tatca_btn_Click(object sender, EventArgs e)
        {
            tatca_btn.Checked = true;
            giadung_btn.Checked = false;
            dientu_btn.Checked = false;
            thucpham_btn.Checked = false;

            dshh_flp.Controls.Clear();
            Reload_flp();
        }

        private void giadung_btn_Click(object sender, EventArgs e)
        {
            tatca_btn.Checked = false;
            giadung_btn.Checked = true;
            dientu_btn.Checked = false;
            thucpham_btn.Checked = false;

            dshh_flp.Controls.Clear();
            Reload_flp();
        }

        private void dientu_btn_Click(object sender, EventArgs e)
        {
            tatca_btn.Checked = false;
            giadung_btn.Checked = false;
            dientu_btn.Checked = true;
            thucpham_btn.Checked = false;

            dshh_flp.Controls.Clear();
            Reload_flp();
        }

        private void thucpham_btn_Click(object sender, EventArgs e)
        {
            tatca_btn.Checked = false;
            giadung_btn.Checked = false;
            dientu_btn.Checked = false;
            thucpham_btn.Checked = true;

            dshh_flp.Controls.Clear();
            Reload_flp();
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        { 
            dshh_flp.Controls.Clear();
            string searchText = search_tb.Text;
            Reload_flp();
        }

        private void search_tb_MouseClick(object sender, MouseEventArgs e)
        {
            search_tb.Text = "";
        }

        private void them_btn_Click(object sender, EventArgs e)
        {
            FormHangHoa formthem = new FormHangHoa(null, this);
            formthem.Show();
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            string filePath_hh = "Resources/hang_hoa.dat";
            using (StreamReader reader = new StreamReader(filePath_hh))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<HangHoa>));
                kho.ds_hang_hoa = (List<HangHoa>)serializer.Deserialize(reader);
            }

            foreach (HangHoa hh in kho.ds_hang_hoa)
            {
                HangHoaTrangChuComponent hh_component = new HangHoaTrangChuComponent(this);
                hh_component.hh = hh;
                hh_component.SetProductInfo(hh);
                dshh_flp.Controls.Add(hh_component);
            }
        }
        #endregion
    }
}
