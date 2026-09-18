using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3_QLSV_CNTT
{
    public partial class MainForm : Form
    {
        private int index;
        QuanLySinhVienCNTT dssv;
        public MainForm()
        {
            InitializeComponent();

            dssv = new QuanLySinhVienCNTT();
            dssv.DocTuFile("DSSV.txt");

            LoadlistView(dssv);
        }

        public SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = false;

            sv.MSSV = mtbMSSV.Text;
            sv.Ten = txtTen.Text;
            sv.Mail = txtEmail.Text;
            sv.DiaChi = txtDiaChi.Text;
            sv.NgaySinh = dtpNgaySinh.Value;
            if (rdNam.Checked)
                gt = true;
            sv.Sex = gt;
            sv.Lop = cbLop.Text;
            sv.SDT = mtbsdt.Text;
            sv.Pic = txtHinh.Text;

            return sv;
        }

        public void ThemSinhVien(SinhVien sv)
        {
            string gt = "Nữ";

            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            lvitem.SubItems.Add(sv.Ten);
            if (sv.Sex)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.SDT);
            lvitem.SubItems.Add(sv.Mail);
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Pic);

            lvDS.Items.Add(lvitem);
        }

        public void LoadlistView(QuanLySinhVienCNTT qlsv)
        {
            this.lvDS.Items.Clear();
            foreach (SinhVien sv in qlsv.qlsv)
                this.ThemSinhVien(sv);

        }

        public void HienThiThongTin(SinhVien sv)
        {
            this.mtbMSSV.Text = sv.MSSV;
            this.txtTen.Text = sv.Ten;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.cbLop.Text = sv.Lop;
            this.txtEmail.Text = sv.Mail;
            this.mtbsdt.Text = sv.SDT;
            this.txtDiaChi.Text = sv.DiaChi;

            rdNam.Checked = sv.Sex;
            rdNu.Checked = !sv.Sex;

            txtHinh.Text = sv.Pic;
        }

        private void lvDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lvDS.SelectedItems[0].Index;

            SinhVien sv = dssv[index];
            HienThiThongTin(sv);
        }
    }
}