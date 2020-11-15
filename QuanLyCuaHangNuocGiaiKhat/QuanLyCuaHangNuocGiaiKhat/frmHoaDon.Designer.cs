namespace QuanLyCuaHangNuocGiaiKhat
{
    partial class frmHoaDon
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtNgaylapHD = new System.Windows.Forms.TextBox();
            this.txtmapm = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.GridViewPM = new System.Windows.Forms.DataGridView();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaylapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnhanvien = new System.Windows.Forms.TextBox();
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(871, 485);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(113, 43);
            this.btnthoat.TabIndex = 12;
            this.btnthoat.Text = "Đóng";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
            // 
            // txtNgaylapHD
            // 
            this.txtNgaylapHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgaylapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaylapHD.Location = new System.Drawing.Point(640, 45);
            this.txtNgaylapHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgaylapHD.Name = "txtNgaylapHD";
            this.txtNgaylapHD.Size = new System.Drawing.Size(250, 30);
            this.txtNgaylapHD.TabIndex = 3;
            // 
            // txtmapm
            // 
            this.txtmapm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmapm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmapm.Location = new System.Drawing.Point(176, 46);
            this.txtmapm.Margin = new System.Windows.Forms.Padding(4);
            this.txtmapm.Name = "txtmapm";
            this.txtmapm.Size = new System.Drawing.Size(211, 30);
            this.txtmapm.TabIndex = 3;
            this.txtmapm.TabStop = false;
            // 
            // btnthem
            // 
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(750, 485);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(113, 43);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // GridViewPM
            // 
            this.GridViewPM.AllowUserToAddRows = false;
            this.GridViewPM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewPM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridViewPM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHD,
            this.MaKH,
            this.MaNV,
            this.NgaylapHD});
            this.GridViewPM.Location = new System.Drawing.Point(86, 276);
            this.GridViewPM.Margin = new System.Windows.Forms.Padding(4);
            this.GridViewPM.Name = "GridViewPM";
            this.GridViewPM.ReadOnly = true;
            this.GridViewPM.Size = new System.Drawing.Size(898, 201);
            this.GridViewPM.TabIndex = 14;
            this.GridViewPM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewPM_CellContentClick);
            // 
            // SoHD
            // 
            this.SoHD.FillWeight = 300F;
            this.SoHD.HeaderText = "Số Phiếu Gọi";
            this.SoHD.Name = "SoHD";
            this.SoHD.ReadOnly = true;
            // 
            // MaKH
            // 
            this.MaKH.FillWeight = 300F;
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.FillWeight = 300F;
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // NgaylapHD
            // 
            this.NgaylapHD.FillWeight = 300F;
            this.NgaylapHD.HeaderText = "Ngày Lập";
            this.NgaylapHD.Name = "NgaylapHD";
            this.NgaylapHD.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày Lập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Khách Hàng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnhanvien);
            this.groupBox1.Controls.Add(this.txtNgaylapHD);
            this.groupBox1.Controls.Add(this.txtMakh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtmapm);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(86, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(898, 188);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Gọi";
            // 
            // txtnhanvien
            // 
            this.txtnhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhanvien.Location = new System.Drawing.Point(640, 123);
            this.txtnhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.txtnhanvien.Name = "txtnhanvien";
            this.txtnhanvien.Size = new System.Drawing.Size(250, 30);
            this.txtnhanvien.TabIndex = 3;
            // 
            // txtMakh
            // 
            this.txtMakh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakh.Location = new System.Drawing.Point(176, 123);
            this.txtMakh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Size = new System.Drawing.Size(211, 30);
            this.txtMakh.TabIndex = 3;
            this.txtMakh.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Nhân VIên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số Phiếu Gọi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lập Phiếu Gọi";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 549);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.GridViewPM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Gọi";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtNgaylapHD;
        private System.Windows.Forms.TextBox txtmapm;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView GridViewPM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaylapHD;
        private System.Windows.Forms.TextBox txtnhanvien;
        private System.Windows.Forms.Label label4;
    }
}