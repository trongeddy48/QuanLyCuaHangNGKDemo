namespace QuanLyCuaHangNuocGiaiKhat
{
    partial class frmSuaNGK
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
            this.lblTitleSuaNGK = new System.Windows.Forms.Label();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.txtTenNGK = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtMaNGK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbThemnuoc = new System.Windows.Forms.GroupBox();
            this.btnaddLoaiNGK = new System.Windows.Forms.Button();
            this.cboLoaiNGK = new System.Windows.Forms.ComboBox();
            this.cboNCU = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvSuaNGK = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grbThemnuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuaNGK)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleSuaNGK
            // 
            this.lblTitleSuaNGK.AutoSize = true;
            this.lblTitleSuaNGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSuaNGK.Location = new System.Drawing.Point(57, 18);
            this.lblTitleSuaNGK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleSuaNGK.Name = "lblTitleSuaNGK";
            this.lblTitleSuaNGK.Size = new System.Drawing.Size(531, 42);
            this.lblTitleSuaNGK.TabIndex = 27;
            this.lblTitleSuaNGK.Text = "Sửa Nước Giải Khát Trong Kho";
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNCC.Location = new System.Drawing.Point(316, 126);
            this.btnThemNCC.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(83, 34);
            this.btnThemNCC.TabIndex = 5;
            this.btnThemNCC.Text = "Add";
            this.btnThemNCC.UseVisualStyleBackColor = true;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // txtTenNGK
            // 
            this.txtTenNGK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNGK.Location = new System.Drawing.Point(117, 85);
            this.txtTenNGK.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNGK.Name = "txtTenNGK";
            this.txtTenNGK.Size = new System.Drawing.Size(282, 30);
            this.txtTenNGK.TabIndex = 3;
            // 
            // txtSoluong
            // 
            this.txtSoluong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(620, 126);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(250, 30);
            this.txtSoluong.TabIndex = 3;
            // 
            // txtMaNGK
            // 
            this.txtMaNGK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNGK.Location = new System.Drawing.Point(117, 46);
            this.txtMaNGK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNGK.Name = "txtMaNGK";
            this.txtMaNGK.ReadOnly = true;
            this.txtMaNGK.Size = new System.Drawing.Size(282, 30);
            this.txtMaNGK.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(478, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã Loại NGK:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(509, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số Lượng:";
            // 
            // grbThemnuoc
            // 
            this.grbThemnuoc.Controls.Add(this.btnaddLoaiNGK);
            this.grbThemnuoc.Controls.Add(this.cboLoaiNGK);
            this.grbThemnuoc.Controls.Add(this.cboNCU);
            this.grbThemnuoc.Controls.Add(this.btnThemNCC);
            this.grbThemnuoc.Controls.Add(this.txtTenNGK);
            this.grbThemnuoc.Controls.Add(this.txtSoluong);
            this.grbThemnuoc.Controls.Add(this.txtMaNGK);
            this.grbThemnuoc.Controls.Add(this.label7);
            this.grbThemnuoc.Controls.Add(this.label6);
            this.grbThemnuoc.Controls.Add(this.label4);
            this.grbThemnuoc.Controls.Add(this.label3);
            this.grbThemnuoc.Controls.Add(this.label2);
            this.grbThemnuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThemnuoc.Location = new System.Drawing.Point(13, 78);
            this.grbThemnuoc.Margin = new System.Windows.Forms.Padding(4);
            this.grbThemnuoc.Name = "grbThemnuoc";
            this.grbThemnuoc.Padding = new System.Windows.Forms.Padding(4);
            this.grbThemnuoc.Size = new System.Drawing.Size(890, 188);
            this.grbThemnuoc.TabIndex = 28;
            this.grbThemnuoc.TabStop = false;
            this.grbThemnuoc.Text = "Nước Giải Khát Mới";
            // 
            // btnaddLoaiNGK
            // 
            this.btnaddLoaiNGK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddLoaiNGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddLoaiNGK.Location = new System.Drawing.Point(775, 48);
            this.btnaddLoaiNGK.Margin = new System.Windows.Forms.Padding(4);
            this.btnaddLoaiNGK.Name = "btnaddLoaiNGK";
            this.btnaddLoaiNGK.Size = new System.Drawing.Size(95, 34);
            this.btnaddLoaiNGK.TabIndex = 15;
            this.btnaddLoaiNGK.Text = "Add";
            this.btnaddLoaiNGK.UseVisualStyleBackColor = true;
            this.btnaddLoaiNGK.Click += new System.EventHandler(this.btnaddLoaiNGK_Click);
            // 
            // cboLoaiNGK
            // 
            this.cboLoaiNGK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLoaiNGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiNGK.FormattingEnabled = true;
            this.cboLoaiNGK.Location = new System.Drawing.Point(622, 51);
            this.cboLoaiNGK.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiNGK.Name = "cboLoaiNGK";
            this.cboLoaiNGK.Size = new System.Drawing.Size(145, 33);
            this.cboLoaiNGK.TabIndex = 14;
            // 
            // cboNCU
            // 
            this.cboNCU.FormattingEnabled = true;
            this.cboNCU.Location = new System.Drawing.Point(167, 122);
            this.cboNCU.Name = "cboNCU";
            this.cboNCU.Size = new System.Drawing.Size(142, 38);
            this.cboNCU.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhà Cung Ứng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên NGK:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã NGK:";
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(770, 494);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 43);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvSuaNGK
            // 
            this.dgvSuaNGK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuaNGK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuaNGK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuaNGK.Location = new System.Drawing.Point(65, 286);
            this.dgvSuaNGK.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSuaNGK.Name = "dgvSuaNGK";
            this.dgvSuaNGK.ReadOnly = true;
            this.dgvSuaNGK.Size = new System.Drawing.Size(818, 201);
            this.dgvSuaNGK.TabIndex = 29;
            this.dgvSuaNGK.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridviewupdate_RowEnter);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(649, 494);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(113, 43);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Cập Nhật";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmSuaNGK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 550);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblTitleSuaNGK);
            this.Controls.Add(this.grbThemnuoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvSuaNGK);
            this.Name = "frmSuaNGK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Nước Giải Khát";
            this.Load += new System.EventHandler(this.ChinhSuaNGK_Form_Load);
            this.grbThemnuoc.ResumeLayout(false);
            this.grbThemnuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuaNGK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleSuaNGK;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.TextBox txtTenNGK;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtMaNGK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbThemnuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvSuaNGK;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cboNCU;
        private System.Windows.Forms.Button btnaddLoaiNGK;
        private System.Windows.Forms.ComboBox cboLoaiNGK;
    }
}