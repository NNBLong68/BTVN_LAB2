namespace QuanLyThongTinSinhVien
{
    partial class frmSinhVien
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbTTSV = new System.Windows.Forms.GroupBox();
            this.grbDSSV = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grbTTSV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grbDSSV);
            this.splitContainer1.Size = new System.Drawing.Size(652, 412);
            this.splitContainer1.SplitterDistance = 321;
            this.splitContainer1.TabIndex = 0;
            // 
            // grbTTSV
            // 
            this.grbTTSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTTSV.Location = new System.Drawing.Point(0, 0);
            this.grbTTSV.Name = "grbTTSV";
            this.grbTTSV.Size = new System.Drawing.Size(321, 412);
            this.grbTTSV.TabIndex = 0;
            this.grbTTSV.TabStop = false;
            this.grbTTSV.Text = "Thông tin sinh viên";
            // 
            // grbDSSV
            // 
            this.grbDSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDSSV.Location = new System.Drawing.Point(0, 0);
            this.grbDSSV.Name = "grbDSSV";
            this.grbDSSV.Size = new System.Drawing.Size(327, 412);
            this.grbDSSV.TabIndex = 0;
            this.grbDSSV.TabStop = false;
            this.grbDSSV.Text = "Danh sách sinh viên";
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 412);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmSinhVien";
            this.Text = "Sinh viên";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grbTTSV;
        private System.Windows.Forms.GroupBox grbDSSV;
    }
}

