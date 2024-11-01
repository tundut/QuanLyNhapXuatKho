using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCK
{
    public class QuanLyNhapXuat
    {
        public List<HangHoa> ds_san_pham = new List<HangHoa>();

        public void them_sp(HangHoa sp)
        {
            ds_san_pham.Add(sp);
        }

        public void xoa_sp(HangHoa sp)
        {
            ds_san_pham.Remove(sp);
        }

        public void capnhat_sp(HangHoa sp, uint so_luong_moi)
        {
            sp.so_luong = so_luong_moi;
        }
    }
}
