namespace ThongTinGiangVien
{
    partial class frmTimGV
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
            this.gbTim = new System.Windows.Forms.GroupBox();
            this.rdSoDT = new System.Windows.Forms.RadioButton();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.rdMaSo = new System.Windows.Forms.RadioButton();
            this.txtTimGV = new System.Windows.Forms.TextBox();
            this.btnTimGV = new System.Windows.Forms.Button();
            this.lblMa = new System.Windows.Forms.Label();
            this.gbTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTim
            // 
            this.gbTim.Controls.Add(this.rdSoDT);
            this.gbTim.Controls.Add(this.rdTen);
            this.gbTim.Controls.Add(this.rdMaSo);
            this.gbTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTim.Location = new System.Drawing.Point(12, 12);
            this.gbTim.Name = "gbTim";
            this.gbTim.Size = new System.Drawing.Size(490, 84);
            this.gbTim.TabIndex = 0;
            this.gbTim.TabStop = false;
            this.gbTim.Text = "Tìm theo";
            // 
            // rdSoDT
            // 
            this.rdSoDT.AutoSize = true;
            this.rdSoDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSoDT.Location = new System.Drawing.Point(314, 41);
            this.rdSoDT.Name = "rdSoDT";
            this.rdSoDT.Size = new System.Drawing.Size(135, 26);
            this.rdSoDT.TabIndex = 1;
            this.rdSoDT.TabStop = true;
            this.rdSoDT.Text = "Số điện thoại";
            this.rdSoDT.UseVisualStyleBackColor = true;
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTen.Location = new System.Drawing.Point(181, 41);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(83, 26);
            this.rdTen.TabIndex = 1;
            this.rdTen.TabStop = true;
            this.rdTen.Text = "Họ tên";
            this.rdTen.UseVisualStyleBackColor = true;
            // 
            // rdMaSo
            // 
            this.rdMaSo.AutoSize = true;
            this.rdMaSo.Checked = true;
            this.rdMaSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMaSo.Location = new System.Drawing.Point(43, 41);
            this.rdMaSo.Name = "rdMaSo";
            this.rdMaSo.Size = new System.Drawing.Size(89, 26);
            this.rdMaSo.TabIndex = 0;
            this.rdMaSo.TabStop = true;
            this.rdMaSo.Text = "Mã GV";
            this.rdMaSo.UseVisualStyleBackColor = true;
            // 
            // txtTimGV
            // 
            this.txtTimGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimGV.Location = new System.Drawing.Point(148, 101);
            this.txtTimGV.Name = "txtTimGV";
            this.txtTimGV.Size = new System.Drawing.Size(249, 30);
            this.txtTimGV.TabIndex = 2;
            // 
            // btnTimGV
            // 
            this.btnTimGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimGV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTimGV.Location = new System.Drawing.Point(403, 101);
            this.btnTimGV.Name = "btnTimGV";
            this.btnTimGV.Size = new System.Drawing.Size(99, 30);
            this.btnTimGV.TabIndex = 3;
            this.btnTimGV.Text = "Tìm";
            this.btnTimGV.UseVisualStyleBackColor = true;
            this.btnTimGV.Click += new System.EventHandler(this.btnTimGV_Click);
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(12, 109);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(130, 22);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Nhập thông tin:";
            // 
            // frmTimGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 145);
            this.Controls.Add(this.btnTimGV);
            this.Controls.Add(this.txtTimGV);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.gbTim);
            this.Name = "frmTimGV";
            this.Text = "TimGV";
            this.gbTim.ResumeLayout(false);
            this.gbTim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTim;
        private System.Windows.Forms.RadioButton rdMaSo;
        private System.Windows.Forms.RadioButton rdSoDT;
        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.TextBox txtTimGV;
        private System.Windows.Forms.Button btnTimGV;
        private System.Windows.Forms.Label lblMa;
    }
}