namespace QuanLyCuaHangNuocGiaiKhat
{
    partial class frmLoaiNGK
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaoma = new System.Windows.Forms.Button();
            this.txtTenLoaiNGK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaloaiNGK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvLoaiNGK = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNGK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTaoma);
            this.groupBox1.Controls.Add(this.txtTenLoaiNGK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaloaiNGK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(70, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(615, 137);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm, Xóa, Sửa Loại Nước Giải Khát";
            // 
            // btnTaoma
            // 
            this.btnTaoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoma.Location = new System.Drawing.Point(442, 46);
            this.btnTaoma.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoma.Name = "btnTaoma";
            this.btnTaoma.Size = new System.Drawing.Size(137, 32);
            this.btnTaoma.TabIndex = 8;
            this.btnTaoma.Text = "Tạo Mã";
            this.btnTaoma.UseVisualStyleBackColor = true;
            this.btnTaoma.Click += new System.EventHandler(this.btnTaoma_Click_1);
            // 
            // txtTenLoaiNGK
            // 
            this.txtTenLoaiNGK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenLoaiNGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiNGK.Location = new System.Drawing.Point(184, 85);
            this.txtTenLoaiNGK.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLoaiNGK.Name = "txtTenLoaiNGK";
            this.txtTenLoaiNGK.Size = new System.Drawing.Size(250, 30);
            this.txtTenLoaiNGK.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Loại NGK:";
            // 
            // txtMaloaiNGK
            // 
            this.txtMaloaiNGK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaloaiNGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaloaiNGK.Location = new System.Drawing.Point(184, 46);
            this.txtMaloaiNGK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaloaiNGK.Name = "txtMaloaiNGK";
            this.txtMaloaiNGK.ReadOnly = true;
            this.txtMaloaiNGK.Size = new System.Drawing.Size(250, 30);
            this.txtMaloaiNGK.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Loại NGK:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản Lý Loại Nước Giải Khát";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Location = new System.Drawing.Point(448, 398);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(113, 43);
            this.btnCapnhat.TabIndex = 10;
            this.btnCapnhat.Text = "Cập Nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(324, 398);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 43);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(196, 398);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(113, 43);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Thêm";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(572, 398);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 43);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // dgvLoaiNGK
            // 
            this.dgvLoaiNGK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiNGK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoaiNGK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiNGK.Location = new System.Drawing.Point(70, 251);
            this.dgvLoaiNGK.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLoaiNGK.Name = "dgvLoaiNGK";
            this.dgvLoaiNGK.ReadOnly = true;
            this.dgvLoaiNGK.Size = new System.Drawing.Size(615, 139);
            this.dgvLoaiNGK.TabIndex = 8;
            this.dgvLoaiNGK.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewLoaiNGK_RowEnter);
            // 
            // frmLoaiNGK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvLoaiNGK);
            this.Name = "frmLoaiNGK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Nước Giải Khát";
            this.Load += new System.EventHandler(this.LoaiNGK_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNGK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaoma;
        private System.Windows.Forms.TextBox txtTenLoaiNGK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaloaiNGK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvLoaiNGK;
    }
}