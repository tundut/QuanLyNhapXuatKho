using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DoAnCK
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            KhoHang kho = new KhoHang();
            string filePath_hh = "Resources/hang_hoa.dat";
            using (StreamReader reader = new StreamReader(filePath_hh))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<HangHoa>));
                kho.ds_hang_hoa = (List<HangHoa>)serializer.Deserialize(reader);
            }

            string filePath_ncc = "Resources/nha_cung_cap.dat";
            using (StreamReader reader = new StreamReader(filePath_ncc))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<NhaCungCap>));
                kho.ds_ncc = (List<NhaCungCap>)serializer.Deserialize(reader);
            }

            string filePath_nv = "Resources/nhan_vien.dat";
            using (StreamReader reader = new StreamReader(filePath_nv))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<NhanVien>));
                kho.ds_nhan_vien = (List<NhanVien>)serializer.Deserialize(reader);
            }

            string filePath_ch = "Resources/cua_hang.dat";
            using (StreamReader reader = new StreamReader(filePath_ch))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<CuaHang>));
                kho.ds_cua_hang = (List<CuaHang>)serializer.Deserialize(reader);
            }
            try
            {
                Application.Run(new Form(kho));
            }
            catch (ObjectDisposedException ex)
            {
                return;
            }

        }
    }
}