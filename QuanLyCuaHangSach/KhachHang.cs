using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace QuanLyCuaHangSach
{
     class KhachHang
    {
        public string MaKhachHang {  get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DiaChi { get; set; }
        

        public KhachHang()
        {
            MaKhachHang = Ho = Ten = GioiTinh = Email = Phone = DiaChi = "";

        }
        public KhachHang(string maKH, string HoKH, string TenKH, string gioitinh, string email, string diaChi, string sDT)
        {
            MaKhachHang = maKH;
            Ho = HoKH;
            Ten = TenKH;
            GioiTinh = gioitinh;
            Email = email;
            Phone = sDT;
            DiaChi = diaChi;
        }

        public KhachHang this[List<KhachHang> KHlist, int index]
        {
            get
            {
                if (0 > index || index >= KHlist.Count)
                {
                    throw new IndexOutOfRangeException("Index not valid!!!");
                }
                else return KHlist[index];
            }
            set
            {
                if (index > 0 || index >= KHlist.Count)
                {
                    throw new IndexOutOfRangeException("Index not valid!!!");
                }     
                else
                {
                    KHlist[index] = value;
                }    
                    
            }
        }

        public KhachHang(string csvline)
        {
            string[] values = csvline.Split(',');
            this.MaKhachHang = values[0];
            this.Ho = values[1];
            this.Ten = values[2];
            this.GioiTinh = values[3];
            this.Email = values[4];
            this.Phone = values[5];
            this.DiaChi = values[6];
        }

        public static int SaveToFile(List<KhachHang> KHlist, string filename, bool insert = false)
        {
            try
            {
                StreamWriter sw = new(filename, append: insert);
                string temp = "MaKhachhang, Ho, Ten, GioiTinh, Email, Phone, DiaChi";
                sw.Write(temp);
                sw.Write(sw.NewLine);

                foreach (var KH in KHlist)
                {
                    string line = "";
                    line += "," + KH.MaKhachHang;
                    line += "," + KH.Ho;
                    line += "," + KH.Ten;
                    line += "," + KH.GioiTinh;
                    line += "," + KH.Email;
                    line += "," + KH.Phone;
                    line += "," + KH.DiaChi;
                    line = line.Remove(0, 1);
                    sw.Write(line);
                    sw.Write(sw.NewLine);
                }
                sw.Close(); ;
                return 1;
            }
            catch 
            {
                return 0;
            }
        }
        public static List<KhachHang> LoadFromFile(string filename)
        {
            List<KhachHang> list = new List<KhachHang>();
            string line = "";
            using (StreamReader reader = new StreamReader(filename))
            {
                if (!reader.EndOfStream)
                {
                    reader.ReadLine();
                }
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    KhachHang b = new KhachHang();

                    list.Add(b); // thêm KhachHang vào list
                }
            }
            return list;
        }

        public static DataTable LoadDataTable(List<Book> Booklist)
        {
            DataTable dtKH = new DataTable();
            string[] temp = { "MaKhachhang", "Ho", "Ten", "GioiTinh", "Email", "Phone", "DiaChi" };
            for (int i = 0; i < temp.Length; i++)
            {
                dtKH.Columns.Add(temp[i]);
            }
            foreach (var item in Booklist)
            {
                DataRow row;
                row = dtKH.NewRow();
                row[0] = item.MaSach;
                row[1] = item.TenSach;
                row[2] = item.TheLoai;
                row[3] = item.TacGia;
                row[4] = item.NhaXuatBan;
                row[5] = item.GiaTien;
                row[6] = item.SoLuongTonKho;
                dtKH.Rows.Add(row);
            }
            return dtKH;
        }

        public static List<T> Sort<T>(List<T> input, string property, SortOrder sortOrder)
        {
            if (sortOrder == SortOrder.Descending)
            {
                return input.OrderByDescending(p => p.GetType().GetProperty(property).GetValue(p, null)).ToList();
            }
            else
            {
                return input.OrderBy(p => p.GetType().GetProperty(property).GetValue(p, null)).ToList();
            }
        }


    }
}
