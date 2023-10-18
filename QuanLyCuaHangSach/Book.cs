using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCuaHangSach
{
     class Book
    {
        public string MaSach {  get; set; }
        public string TenSach { get; set; }
        public string TheLoai { get; set; }
        public string TacGia { get; set; }
        public string NhaXuatBan {  get; set; }
        public double GiaTien {  get; set; }
        public int SoLuongTonKho {  get; set; }

        public Book()
        {
            MaSach = TenSach = TheLoai = TacGia = NhaXuatBan = "";
            GiaTien = 0;
            SoLuongTonKho = 0;
        }
        public Book(string maSach, string tenSach, string theLoai, string tacGia, string nhaXuatBan, double giaTien, int soLuongTonKho)
        {
            MaSach = maSach;
            TenSach = tenSach;
            TheLoai = theLoai;
            TacGia = tacGia;
            NhaXuatBan = nhaXuatBan;
            GiaTien = giaTien;
            SoLuongTonKho = soLuongTonKho;
        }

        public Book this[List<Book> Booklist, int index]
        {
            get
            {
                if(0 > index || index >= Booklist.Count) 
                {
                    throw new IndexOutOfRangeException("Index not valid!");

                }
                else
                {
                    return Booklist[index];
                }
            }
            set
            {
                if(index > 0 || index >= Booklist.Count)
                {
                    throw new IndexOutOfRangeException("Index not valid!");

                }
                else
                {
                    Booklist[index] = value;
                }
            }
        }
        public Book (string csvline)
        {
            string[] giatri = csvline.Split(',');
            this.MaSach = giatri[0];
            this.TenSach = giatri[1];
            this.TheLoai = giatri[2];
            this.TacGia = giatri[3];
            this.NhaXuatBan = giatri[4];
            this.GiaTien = Convert.ToDouble(giatri[5]);
            this.SoLuongTonKho = Convert.ToInt32(giatri[6]);
        }

        public static int  SaveToFile(List<Book> Booklist, string filename , bool insert = false)
        {
            try
            {
                StreamWriter sw = new(filename, append: insert);
                string temp = "MaSach, TenSach, TheLoai, TacGia, NhaXuatBan, GiaTien, SoLuong";
                sw.Write(temp);
                sw.Write(sw.NewLine);

                foreach(var books in Booklist)
                {
                    string line = "";
                    line += "," + books.MaSach;
                    line += "," + books.TenSach;
                    line += "," + books.TheLoai;
                    line += "," + books.TacGia;
                    line += "," + books.NhaXuatBan;
                    line += "," + books.GiaTien;
                    line += "," + books.SoLuongTonKho;
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
        public static List<Book> LoadFromFile(string filename)
        {
            List<Book> list = new List<Book>();
            string line = "";
            using(StreamReader reader = new StreamReader(filename)) 
            { 
                if(!reader.EndOfStream)
                {
                   reader.ReadLine();
                }
                while(!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    Book b = new Book();
                    
                    list.Add(b); // thêm book vào list
                }
            }
            return list;
        }

        public static DataTable LoadDataTable(List<Book> Booklist) 
        { 
            DataTable dtBook = new DataTable();
            string[] temp = { "MaSach", "TenSach", "TheLoai", "TacGia", "NhaXuatBan", "GiaTien", "SoLuong" };
            for(int i = 0; i < temp.Length; i++)
            {
                dtBook.Columns.Add(temp[i]);
            }
            foreach (var item in Booklist) 
            {
                DataRow row;
                row = dtBook.NewRow();
                row[0] = item.MaSach;
                row[1] = item.TenSach;
                row[2] = item.TheLoai;
                row[3] = item.TacGia;
                row[4] = item.NhaXuatBan;
                row[5] = item.GiaTien;
                row[6] = item.SoLuongTonKho;         
                dtBook.Rows.Add(row);
            }
            return dtBook;
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
