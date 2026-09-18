using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLyThongTinSinhVien
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        QuanLySinhVien qlsv;
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Lop);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            string cn = "";
            foreach(string s in sv.ChuyenNganh)
            {
                cn += s + ", ";
            }
            cn = cn.Substring(0, cn.Length - 1);
            lvitem.SubItems.Add(cn);
            lvitem.SubItems.Add(sv.Hinh);
            this.lvSinhVien.Items.Add(lvitem);
        }
        public void LoadListView(QuanLySinhVien ql)
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in ql.dsSinhVien)
                ThemSV(sv);
        }

        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.MaSo = this.maskTbMSSV.Text;
            sv.HoTen = this.txtHoTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.cbLop.Text;
            sv.Hinh = this.txtHinh.Text;
            if(rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            for(int i = 0;i<this.clbChuyenNganh.Items.Count;i++)
                if(clbChuyenNganh.GetItemChecked(i))
                    cn.Add(clbChuyenNganh.Items[i].ToString());
            sv.ChuyenNganh = cn;
            return sv;
        }

        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[5].Text == "Nam")
                sv.GioiTinh = true;
            List<string> cn = new List<string>();
            string[] s = lvitem.SubItems[6].Text.Split(',');
            foreach (string t in s)
                cn.Add(t);
            sv.ChuyenNganh = cn;
            sv.Hinh = lvitem.SubItems[7].Text;
            return sv;
        }

        private void ThietLapThongTin(SinhVien sv)
        {
            this.maskTbMSSV.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cbLop.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;
            //this.pbHinh.ImageLocation = sv.Hinh; //-- nếu hình nằm trong debug

            //sửa code do hình trong \Debug\Images
            //string duongDan = Path.Combine(Application.StartupPath,sv.Hinh);
            //this.pbHinh.Image = Image.FromFile(duongDan);
            string duongDan = "";

            // Trường hợp sv.Hinh là đường dẫn đầy đủ
            if (Path.IsPathRooted(sv.Hinh) && File.Exists(sv.Hinh))
            {
                duongDan = sv.Hinh;
                //IsPathRooted: kiểm tra đường dẫn đã đầy đủ chưa
            }
            else
            {
                // 1. Tìm trực tiếp trong Debug
                string duongDanDebug = Path.Combine(Application.StartupPath,sv.Hinh);

                //Application.StartupPath: lấy đường dẫn đến thư mục mà chương trình đang chạy
                //Path Combine: ghép 2 đường dẫn lại với nhau

                // 2. Tìm trong Debug\Images
                string duongDanImages = Path.Combine(Application.StartupPath,"Images",sv.Hinh);

                if (File.Exists(duongDanDebug))
                {
                    duongDan = duongDanDebug;
                }
                else if (File.Exists(duongDanImages))
                {
                    duongDan = duongDanImages;
                }
            }

            if (duongDan != "")
            {
                this.pbHinh.Image = Image.FromFile(duongDan);
            }
            else
            {
                this.pbHinh.Image = null;
            }


            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
            for(int i = 0; i<this.clbChuyenNganh.Items.Count;i++)
                this.clbChuyenNganh.SetItemChecked(i, false);
            foreach (string s in sv.ChuyenNganh)
                for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                    if (s.CompareTo(this.clbChuyenNganh.Items[i]) == 0)
                        this.clbChuyenNganh.SetItemChecked(i, true);
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile("DanhSachSV.txt");
            LoadListView(qlsv);
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if(count > 0)
            {
                ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.maskTbMSSV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";
            this.cbLop.Text = this.cbLop.Items[0].ToString();
            this.txtHinh.Text = "";
            this.pbHinh.ImageLocation = "";
            this.rdNam.Checked = true;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count - 1; i++)
                this.clbChuyenNganh.SetItemChecked(i, false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private int SoSanhTheoMa(object sv1, object sv2)
        {
            SinhVien sv = sv2 as SinhVien;
            return sv.MaSo.CompareTo(sv1);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvSinhVien.Items.Count - 1;
            for(i = count; i >=0; i--)
            {
                lvitem = this.lvSinhVien.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView(qlsv);
            this.btnMacDinh.PerformClick();

            qlsv.GhiFile("DanhSachSV.txt");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            Console.WriteLine(sv.MaSo);
            bool kq;
            kq = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
            if (kq)
            {
                this.LoadListView(qlsv);
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            else
                MessageBox.Show("Sửa thất bại");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog(); //hộp thoại chọn file
            open.Filter = "Image File (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png|All File (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string thuMucImages = Path.Combine(Application.StartupPath, "Images");

                // Nếu chưa có thư mục Images thì tạo
                if (!Directory.Exists(thuMucImages))
                    Directory.CreateDirectory(thuMucImages);

                // Lấy tên file ảnh
                string tenFile = Path.GetFileName(open.FileName);

                // Đường dẫn đích: Debug\Images\tênảnh
                string duongDanDich = Path.Combine(thuMucImages, tenFile);

                // Copy ảnh vào Debug\Images
                File.Copy(open.FileName, duongDanDich, true);

                // Hiển thị ảnh
                pbHinh.Image = Image.FromFile(duongDanDich);

                // Chỉ lưu tên ảnh
                txtHinh.Text = tenFile;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            qlsv.Them(sv);
            qlsv.GhiFile("DanhSachSV.txt");

            LoadListView(qlsv);
            MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mởFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBrowse.PerformClick();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThoat.PerformClick();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThem_Click(sender, e);
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoa_Click(sender, e);
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSua_Click(sender, e);
        }

        private void sắpXếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frnTuyChinh form = new frnTuyChinh(this, qlsv);
            form.ShowDialog();
        }

        public void SapXepTheoMa()
        {
            qlsv.dsSinhVien = qlsv.dsSinhVien.OrderBy(sv => sv.MaSo).ToList();
        }

        public void SapXepTheoTen()
        {
            qlsv.dsSinhVien = qlsv.dsSinhVien.OrderBy(sv => sv.HoTen).ToList();
        }

        public void SapXepTheoNgaySinh()
        {
            qlsv.dsSinhVien = qlsv.dsSinhVien.OrderBy(sv => sv.NgaySinh).ToList();
        }

        private void đỏToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvSinhVien.ForeColor = Color.Red;
        }

        private void xanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvSinhVien.ForeColor = Color.Blue;
        }

        private void mặcĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvSinhVien.ForeColor = Color.Black;
        }

        private void mặcĐịnhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lvSinhVien.Font = new Font("Times New Roman", 12, FontStyle.Regular);
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvSinhVien.Font = new Font("Arial", 12, FontStyle.Regular);
        }


        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frnTuyChinh form = new frnTuyChinh(this, qlsv);
            form.ShowDialog();
        }
    }
}
