namespace QuanLyCuaHangNuocGiaiKhat
{
    partial class frmInCacPhieu
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
            this.btnBaoCaoPhieuGoi = new System.Windows.Forms.Button();
            this.btnBaoCaoPhieuHen = new System.Windows.Forms.Button();
            this.btnBaoCaoKhachHang = new System.Windows.Forms.Button();
            this.btnBaoCaoNhanVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBaoCaoPhieuGoi
            // 
            this.btnBaoCaoPhieuGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoPhieuGoi.Location = new System.Drawing.Point(119, 26);
            this.btnBaoCaoPhieuGoi.Name = "btnBaoCaoPhieuGoi";
            this.btnBaoCaoPhieuGoi.Size = new System.Drawing.Size(301, 48);
            this.btnBaoCaoPhieuGoi.TabIndex = 0;
            this.btnBaoCaoPhieuGoi.Text = "Báo Cáo Phiếu Gọi";
            this.btnBaoCaoPhieuGoi.UseVisualStyleBackColor = true;
            this.btnBaoCaoPhieuGoi.Click += new System.EventHandler(this.btnBaoCaoPhieuGoi_Click);
            // 
            // btnBaoCaoPhieuHen
            // 
            this.btnBaoCaoPhieuHen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoPhieuHen.Location = new System.Drawing.Point(119, 104);
            this.btnBaoCaoPhieuHen.Name = "btnBaoCaoPhieuHen";
            this.btnBaoCaoPhieuHen.Size = new System.Drawing.Size(301, 48);
            this.btnBaoCaoPhieuHen.TabIndex = 1;
            this.btnBaoCaoPhieuHen.Text = "Báo Cáo Phiếu Hẹn";
            this.btnBaoCaoPhieuHen.UseVisualStyleBackColor = true;
            this.btnBaoCaoPhieuHen.Click += new System.EventHandler(this.btnBaoCaoPhieuHen_Click);
            // 
            // btnBaoCaoKhachHang
            // 
            this.btnBaoCaoKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoKhachHang.Location = new System.Drawing.Point(119, 183);
            this.btnBaoCaoKhachHang.Name = "btnBaoCaoKhachHang";
            this.btnBaoCaoKhachHang.Size = new System.Drawing.Size(301, 48);
            this.btnBaoCaoKhachHang.TabIndex = 4;
            this.btnBaoCaoKhachHang.Text = "Báo Cáo Khách Hàng";
            this.btnBaoCaoKhachHang.UseVisualStyleBackColor = true;
            this.btnBaoCaoKhachHang.Click += new System.EventHandler(this.btnBaoCaoKhachHang_Click);
            // 
            // btnBaoCaoNhanVien
            // 
            this.btnBaoCaoNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoNhanVien.Location = new System.Drawing.Point(119, 257);
            this.btnBaoCaoNhanVien.Name = "btnBaoCaoNhanVien";
            this.btnBaoCaoNhanVien.Size = new System.Drawing.Size(301, 50);
            this.btnBaoCaoNhanVien.TabIndex = 5;
            this.btnBaoCaoNhanVien.Text = "Báo Cáo Nhân Viên";
            this.btnBaoCaoNhanVien.UseVisualStyleBackColor = true;
            this.btnBaoCaoNhanVien.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmInCacPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 342);
            this.Controls.Add(this.btnBaoCaoNhanVien);
            this.Controls.Add(this.btnBaoCaoKhachHang);
            this.Controls.Add(this.btnBaoCaoPhieuHen);
            this.Controls.Add(this.btnBaoCaoPhieuGoi);
            this.Name = "frmInCacPhieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Báo Cáo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaoCaoPhieuGoi;
        private System.Windows.Forms.Button btnBaoCaoPhieuHen;
        private System.Windows.Forms.Button btnBaoCaoKhachHang;
        private System.Windows.Forms.Button btnBaoCaoNhanVien;
    }
}