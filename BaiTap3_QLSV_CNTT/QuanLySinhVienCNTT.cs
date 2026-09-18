using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3_QLSV_CNTT
{
    public class QuanLySinhVienCNTT
    {
        public List<SinhVien> qlsv;
        public QuanLySinhVienCNTT()
        {
            qlsv = new List<SinhVien>();
        }

        public SinhVien this[int index]
        {
            get { return qlsv[index]; }
            set { qlsv[index] = value;}
        }
        public void ThemSinhVien(SinhVien sv)
        {
            qlsv.Add(sv);
        }

        public void XoaSinhVien(SinhVien sv)
        {
            qlsv.Remove(sv);
        }

        public void DocTuFile(string filename)
        {
            string t;
            string[] s;
            SinhVien sv;
            using(StreamReader sr = new StreamReader(filename))
            {
                while((t = sr.ReadLine()) != null)
                {
                    sv = new SinhVien();
                    s = t.Split('|');
                    sv.MSSV = s[0];
                    sv.Ten = s[1];
                    sv.Mail = s[2];
                    sv.DiaChi = s[3];
                    sv.NgaySinh = DateTime.ParseExact(s[4],"dd/MM/yyyy",CultureInfo.InvariantCulture);
                    sv.Sex = false;
                    if (s[5] == "1")
                        sv.Sex = true;
                    sv.Lop = s[6];
                    sv.SDT = s[7];
                    sv.Pic = s[8];

                    this.ThemSinhVien(sv);
                }
                sr.Close();
            }
        }

        public void GhiFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))    
            {
                foreach(SinhVien sv in qlsv)
                {
                    string gt = sv.Sex ? "1" : "0";
                    sw.WriteLine
                        (sv.MSSV + "|" +
                        sv.Ten + "|" +
                        sv.Mail + "|" +
                        sv.DiaChi + "|" +
                        sv.NgaySinh.ToString("dd/MM/yyyy") + "|" +
                        gt + "|" +
                        sv.Lop + "|" +
                        sv.SDT + "|" +
                        sv.Pic);
                }
                sw.Close();
            }
        }
    }
}
