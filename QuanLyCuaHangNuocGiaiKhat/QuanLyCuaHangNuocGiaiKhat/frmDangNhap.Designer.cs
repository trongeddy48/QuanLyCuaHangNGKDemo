namespace QuanLyCuaHangNuocGiaiKhat
{
    partial class frmDangnhap
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
            this.lblTitledangnhap = new System.Windows.Forms.Label();
            this.lblTaikhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnThoatDN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTenmay = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitledangnhap
            // 
            this.lblTitledangnhap.AutoSize = true;
            this.lblTitledangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitledangnhap.Location = new System.Drawing.Point(12, 33);
            this.lblTitledangnhap.Name = "lblTitledangnhap";
            this.lblTitledangnhap.Size = new System.Drawing.Size(727, 26);
            this.lblTitledangnhap.TabIndex = 0;
            this.lblTitledangnhap.Text = "ĐĂNG NHẬP HỆ THỐNG QUẢN LÝ CỬA HÀNG NƯỚC GIẢI KHÁT";
            // 
            // lblTaikhoan
            // 
            this.lblTaikhoan.AutoSize = true;
            this.lblTaikhoan.Location = new System.Drawing.Point(152, 114);
            this.lblTaikhoan.Name = "lblTaikhoan";
            this.lblTaikhoan.Size = new System.Drawing.Size(81, 17);
            this.lblTaikhoan.TabIndex = 1;
            this.lblTaikhoan.Text = "Tài Khoản: ";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(157, 173);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(76, 17);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật Khẩu: ";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(239, 111);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(367, 22);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(239, 173);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(367, 22);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Location = new System.Drawing.Point(347, 29);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(128, 36);
            this.btnDangnhap.TabIndex = 5;
            this.btnDangnhap.Text = "Đăng Nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click_1);
            // 
            // btnThoatDN
            // 
            this.btnThoatDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatDN.Location = new System.Drawing.Point(376, 98);
            this.btnThoatDN.Name = "btnThoatDN";
            this.btnThoatDN.Size = new System.Drawing.Size(75, 28);
            this.btnThoatDN.TabIndex = 6;
            this.btnThoatDN.Text = "Thoát";
            this.btnThoatDN.UseVisualStyleBackColor = true;
            this.btnThoatDN.Click += new System.EventHandler(this.btnThoatDN_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDangnhap);
            this.panel1.Controls.Add(this.btnThoatDN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 130);
            this.panel1.TabIndex = 7;
            // 
            // txtTenmay
            // 
            this.txtTenmay.Location = new System.Drawing.Point(239, 233);
            this.txtTenmay.Name = "txtTenmay";
            this.txtTenmay.Size = new System.Drawing.Size(367, 22);
            this.txtTenmay.TabIndex = 7;
            this.txtTenmay.TextChanged += new System.EventHandler(this.txtTenmay_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Máy:";
            // 
            // frmDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenmay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTaikhoan);
            this.Controls.Add(this.lblTitledangnhap);
            this.Name = "frmDangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập Chương Trình QL Nước Giải Khát";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitledangnhap;
        private System.Windows.Forms.Label lblTaikhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnThoatDN;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTenmay;
        private System.Windows.Forms.Label label2;
    }
}

