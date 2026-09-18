using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThongTinSinhVien
{
    public partial class frnTuyChinh : Form
    {
        QuanLySinhVien ql;
        frmSinhVien formSinhVien;
        public frnTuyChinh(frmSinhVien frm, QuanLySinhVien qlsv)
        {
            InitializeComponent();
            this.formSinhVien = frm;
            this.ql = qlsv;
        }

        private TuyChon kieu = TuyChon.MaSV;

        private void ChonKieu(object sender, EventArgs e)
        {
            RadioButton rd = sender as RadioButton;
            if (rd == null || !rd.Checked)
                return;

            if (rdMa.Checked)
                kieu = TuyChon.MaSV;
            else if (rdTen.Checked)
                kieu = TuyChon.HoTen;
            else if (rdNgaySinh.Checked)
                kieu = TuyChon.NgaySinh;
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            switch(kieu)
            {
                case TuyChon.MaSV:
                    formSinhVien.SapXepTheoMa();
                    break;

                case TuyChon.HoTen:
                    formSinhVien.SapXepTheoTen();
                    break;

                case TuyChon.NgaySinh:
                    formSinhVien.SapXepTheoNgaySinh();
                    break;
            }
            formSinhVien.LoadListView(ql);
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string chuoiTim = txtChuoiTim.Text;
            foreach (SinhVien sv in ql.dsSinhVien)
            {
                switch(kieu)
                {
                    case TuyChon.MaSV:
                        formSinhVien.LoadListView(TimTheoMSSV(chuoiTim));
                        break;

                    case TuyChon.HoTen:
                        formSinhVien.LoadListView(TimTheoTen(chuoiTim));
                        break;

                    case TuyChon.NgaySinh:
                        formSinhVien.LoadListView(TimTheoNgaySinh(chuoiTim));
                        break;

                    default:
                        formSinhVien.LoadListView(ql);
                        break;

                }

            }    
        }
        private QuanLySinhVien TimTheoMSSV(string chuoi)
        {
            QuanLySinhVien kq = new QuanLySinhVien();
            foreach (SinhVien sv in ql.dsSinhVien)
                if (sv.MaSo.Contains(chuoi))
                    kq.Them(sv);
            return kq;
        }

        private QuanLySinhVien TimTheoTen(string chuoi)
        {
            QuanLySinhVien kq = new QuanLySinhVien();
            foreach (SinhVien sv in ql.dsSinhVien)
                if (sv.HoTen.Contains(chuoi))
                    kq.Them(sv);
            return kq;
        }

        private QuanLySinhVien TimTheoNgaySinh(string chuoi)
        {
            QuanLySinhVien kq = new QuanLySinhVien();
            foreach (SinhVien sv in ql.dsSinhVien)
                if (sv.NgaySinh.ToString().Contains(chuoi))
                    kq.Them(sv);
            return kq;
        }
    }

    public enum TuyChon
    {
        MaSV,
        HoTen,
        NgaySinh
    }
}
