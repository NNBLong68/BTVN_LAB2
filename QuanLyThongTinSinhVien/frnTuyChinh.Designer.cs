namespace QuanLyThongTinSinhVien
{
    partial class frnTuyChinh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdNgaySinh = new System.Windows.Forms.RadioButton();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.rdMa = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtChuoiTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdNgaySinh);
            this.panel1.Controls.Add(this.rdTen);
            this.panel1.Controls.Add(this.rdMa);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 72);
            this.panel1.TabIndex = 1;
            // 
            // rdNgaySinh
            // 
            this.rdNgaySinh.AutoSize = true;
            this.rdNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNgaySinh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rdNgaySinh.Location = new System.Drawing.Point(314, 22);
            this.rdNgaySinh.Name = "rdNgaySinh";
            this.rdNgaySinh.Size = new System.Drawing.Size(116, 27);
            this.rdNgaySinh.TabIndex = 0;
            this.rdNgaySinh.Text = "Ngày Sinh";
            this.rdNgaySinh.UseVisualStyleBackColor = true;
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rdTen.Location = new System.Drawing.Point(163, 22);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(93, 27);
            this.rdTen.TabIndex = 0;
            this.rdTen.Text = "Họ Tên";
            this.rdTen.UseVisualStyleBackColor = true;
            // 
            // rdMa
            // 
            this.rdMa.AutoSize = true;
            this.rdMa.Checked = true;
            this.rdMa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rdMa.Location = new System.Drawing.Point(25, 22);
            this.rdMa.Name = "rdMa";
            this.rdMa.Size = new System.Drawing.Size(89, 27);
            this.rdMa.TabIndex = 0;
            this.rdMa.TabStop = true;
            this.rdMa.Text = "Mã SV";
            this.rdMa.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtChuoiTim);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Location = new System.Drawing.Point(12, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 71);
            this.panel2.TabIndex = 2;
            // 
            // txtChuoiTim
            // 
            this.txtChuoiTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuoiTim.Location = new System.Drawing.Point(163, 21);
            this.txtChuoiTim.Name = "txtChuoiTim";
            this.txtChuoiTim.Size = new System.Drawing.Size(202, 30);
            this.txtChuoiTim.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập thông tin:";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnTim.Location = new System.Drawing.Point(371, 21);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 30);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnSapXep.Location = new System.Drawing.Point(71, 195);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(117, 33);
            this.btnSapXep.TabIndex = 3;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnThoat.Location = new System.Drawing.Point(302, 195);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 33);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // frnTuyChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 240);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frnTuyChinh";
            this.Text = "frnTuyChinh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdNgaySinh;
        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.RadioButton rdMa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtChuoiTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnThoat;
    }
}