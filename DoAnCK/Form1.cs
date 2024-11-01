using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace DoAnCK
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            ngay_lbl.Text = "Ngày " + DateTime.Now.ToString("dd/MM/yyyy");
            OpenChildForm(new FormTrangChu());
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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

        
    }
}
