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
            string filePath1 = "Resources/hang_hoa.dat";
            using (StreamReader reader = new StreamReader(filePath1))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<HangHoa>));
                kho.ds_hang_hoa = (List<HangHoa>)serializer.Deserialize(reader);
            }

            string filePath2 = "Resources/nha_cung_cap.dat";
            using (StreamReader reader = new StreamReader(filePath2))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<NhaCungCap>));
                kho.ds_ncc = (List<NhaCungCap>)serializer.Deserialize(reader);
            }


            Application.Run(new Form(kho));
        }
    }
}
