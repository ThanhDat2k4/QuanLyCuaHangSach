using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangSach
{
     class DonHang
    {
        public string MaDonHang { get; set; }
        public string IDSach { get; set; }
        public string IDKhachHang { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SoLuongMua { get; set; }

        public DonHang() 
        {
            MaDonHang = IDSach = IDKhachHang = "";
            NgayNhap = DateTime.Now;
            SoLuongMua = 0;
        }

       
                


    }
}
