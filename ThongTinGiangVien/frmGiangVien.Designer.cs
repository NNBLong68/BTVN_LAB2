namespace ThongTinGiangVien
{
    partial class frmGiangVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiangVien));
            this.lblThongBao = new System.Windows.Forms.Label();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblNgoaiNgu = new System.Windows.Forms.Label();
            this.cboMaSo = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
            this.chklbNgoaiNgu = new System.Windows.Forms.CheckedListBox();
            this.lbDanhSachHP = new System.Windows.Forms.ListBox();
            this.lblDSMon = new System.Windows.Forms.Label();
            this.lbHocPhanDay = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnThongBao = new System.Windows.Forms.Button();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.linklblLienHe = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblThongBao.Location = new System.Drawing.Point(109, 27);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(513, 31);
            this.lblThongBao.TabIndex = 0;
            this.lblThongBao.Text = "THÔNG TIN GIẢNG VIÊN KHOA CNTT";
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSo.Location = new System.Drawing.Point(15, 105);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(61, 19);
            this.lblMaSo.TabIndex = 0;
            this.lblMaSo.Text = "Mã Số:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(15, 142);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(68, 19);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ Tên:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 185);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(89, 19);
            this.lblNgaySinh.TabIndex = 0;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblNgoaiNgu
            // 
            this.lblNgoaiNgu.AutoSize = true;
            this.lblNgoaiNgu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgoaiNgu.Location = new System.Drawing.Point(15, 226);
            this.lblNgoaiNgu.Name = "lblNgoaiNgu";
            this.lblNgoaiNgu.Size = new System.Drawing.Size(91, 19);
            this.lblNgoaiNgu.TabIndex = 0;
            this.lblNgoaiNgu.Text = "Ngoại ngữ:";
            // 
            // cboMaSo
            // 
            this.cboMaSo.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaSo.FormattingEnabled = true;
            this.cboMaSo.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004"});
            this.cboMaSo.Location = new System.Drawing.Point(115, 102);
            this.cboMaSo.Name = "cboMaSo";
            this.cboMaSo.Size = new System.Drawing.Size(121, 27);
            this.cboMaSo.TabIndex = 0;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(115, 139);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(211, 27);
            this.txtHoTen.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(115, 179);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(211, 27);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDT.Location = new System.Drawing.Point(381, 142);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(58, 19);
            this.lblSoDT.TabIndex = 0;
            this.lblSoDT.Text = "Số ĐT:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(381, 185);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(108, 19);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Địa chỉ Mail:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(381, 105);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(88, 19);
            this.lblGioiTinh.TabIndex = 0;
            this.lblGioiTinh.Text = "Giới Tính:";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.Location = new System.Drawing.Point(569, 101);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(48, 23);
            this.rdNu.TabIndex = 4;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.Location = new System.Drawing.Point(500, 101);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(59, 23);
            this.rdNam.TabIndex = 3;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(500, 182);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(180, 27);
            this.txtMail.TabIndex = 6;
            // 
            // mtxtSoDT
            // 
            this.mtxtSoDT.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtSoDT.Location = new System.Drawing.Point(500, 139);
            this.mtxtSoDT.Mask = "(\\0633).000.000";
            this.mtxtSoDT.Name = "mtxtSoDT";
            this.mtxtSoDT.Size = new System.Drawing.Size(180, 27);
            this.mtxtSoDT.TabIndex = 5;
            // 
            // chklbNgoaiNgu
            // 
            this.chklbNgoaiNgu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklbNgoaiNgu.FormattingEnabled = true;
            this.chklbNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật",
            "Tiếng Nga"});
            this.chklbNgoaiNgu.Location = new System.Drawing.Point(115, 226);
            this.chklbNgoaiNgu.Name = "chklbNgoaiNgu";
            this.chklbNgoaiNgu.Size = new System.Drawing.Size(211, 92);
            this.chklbNgoaiNgu.TabIndex = 7;
            // 
            // lbDanhSachHP
            // 
            this.lbDanhSachHP.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachHP.FormattingEnabled = true;
            this.lbDanhSachHP.ItemHeight = 19;
            this.lbDanhSachHP.Items.AddRange(new object[] {
            "Tin học cơ sở",
            "Lập trình cấu trúc C/C++",
            "Cơ sở dữ liệu",
            "Tiếng Anh B1",
            "Tiếng Anh B2",
            "Lập trình hướng đối tượng",
            "Mạng máy tính",
            "Công nghệ phần mềm",
            "Phân tích TKHDT"});
            this.lbDanhSachHP.Location = new System.Drawing.Point(115, 356);
            this.lbDanhSachHP.Name = "lbDanhSachHP";
            this.lbDanhSachHP.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhSachHP.Size = new System.Drawing.Size(211, 175);
            this.lbDanhSachHP.TabIndex = 8;
            // 
            // lblDSMon
            // 
            this.lblDSMon.AutoSize = true;
            this.lblDSMon.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSMon.Location = new System.Drawing.Point(111, 334);
            this.lblDSMon.Name = "lblDSMon";
            this.lblDSMon.Size = new System.Drawing.Size(155, 19);
            this.lblDSMon.TabIndex = 0;
            this.lblDSMon.Text = "Danh sách môn học:";
            // 
            // lbHocPhanDay
            // 
            this.lbHocPhanDay.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHocPhanDay.FormattingEnabled = true;
            this.lbHocPhanDay.ItemHeight = 19;
            this.lbHocPhanDay.Location = new System.Drawing.Point(427, 356);
            this.lbHocPhanDay.Name = "lbHocPhanDay";
            this.lbHocPhanDay.Size = new System.Drawing.Size(180, 175);
            this.lbHocPhanDay.TabIndex = 9;
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(346, 399);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(61, 23);
            this.btnChon.TabIndex = 9;
            this.btnChon.Text = ">>";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(346, 457);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "<<";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(328, 568);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 33);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExit.Location = new System.Drawing.Point(504, 568);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThongBao
            // 
            this.btnThongBao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongBao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongBao.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThongBao.Location = new System.Drawing.Point(140, 568);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(113, 33);
            this.btnThongBao.TabIndex = 10;
            this.btnThongBao.Text = "Thông Báo";
            this.btnThongBao.UseVisualStyleBackColor = true;
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebsite.Location = new System.Drawing.Point(580, 629);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(55, 15);
            this.lblWebsite.TabIndex = 16;
            this.lblWebsite.Text = "Website:";
            // 
            // linklblLienHe
            // 
            this.linklblLienHe.AutoSize = true;
            this.linklblLienHe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblLienHe.Location = new System.Drawing.Point(641, 629);
            this.linklblLienHe.Name = "linklblLienHe";
            this.linklblLienHe.Size = new System.Drawing.Size(46, 15);
            this.linklblLienHe.TabIndex = 17;
            this.linklblLienHe.TabStop = true;
            this.linklblLienHe.Text = "Liên hệ";
            this.linklblLienHe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLienHe_LinkClicked);
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 653);
            this.Controls.Add(this.linklblLienHe);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThongBao);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lbHocPhanDay);
            this.Controls.Add(this.lbDanhSachHP);
            this.Controls.Add(this.chklbNgoaiNgu);
            this.Controls.Add(this.mtxtSoDT);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.cboMaSo);
            this.Controls.Add(this.lblDSMon);
            this.Controls.Add(this.lblNgoaiNgu);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblSoDT);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaSo);
            this.Controls.Add(this.lblThongBao);
            this.Name = "frmGiangVien";
            this.Text = "Thông tin giảng viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblNgoaiNgu;
        private System.Windows.Forms.ComboBox cboMaSo;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox mtxtSoDT;
        private System.Windows.Forms.CheckedListBox chklbNgoaiNgu;
        private System.Windows.Forms.ListBox lbDanhSachHP;
        private System.Windows.Forms.Label lblDSMon;
        private System.Windows.Forms.ListBox lbHocPhanDay;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.LinkLabel linklblLienHe;
    }
}

