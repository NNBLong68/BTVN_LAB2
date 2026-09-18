using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3_QLSV_CNTT
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string Ten { get; set; }
        public string Mail { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool Sex { get; set; }
        public string Lop { get; set; }
        public string SDT { get; set; }
        public string Pic { get; set; }
        public SinhVien() { }
        public SinhVien(string mssv, string ten, string mail, string dc, DateTime ns, bool sex, string lop, string sdt, string pic)
        {
            this.MSSV = mssv;
            this.Ten = ten;
            this.Mail = mail;
            this.DiaChi = dc;
            this.NgaySinh = ns;
            this.Sex = sex;
            this.Lop = lop;
            this.SDT = sdt;
            this.Pic = pic;
        }
    }
}
