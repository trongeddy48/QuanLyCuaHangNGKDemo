namespace QuanLyCuaHangNuocGiaiKhat
{
    partial class frmKhachHang
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
            this.btnhuythem = new System.Windows.Forms.Button();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txttenKH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtmaKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.gridviewaddkh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewaddkh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhuythem
            // 
            this.btnhuythem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhuythem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuythem.Location = new System.Drawing.Point(287, 487);
            this.btnhuythem.Margin = new System.Windows.Forms.Padding(4);
            this.btnhuythem.Name = "btnhuythem";
            this.btnhuythem.Size = new System.Drawing.Size(113, 43);
            this.btnhuythem.TabIndex = 12;
            this.btnhuythem.Text = "Hủy Thêm";
            this.btnhuythem.UseVisualStyleBackColor = true;
            this.btnhuythem.Click += new System.EventHandler(this.btnhuythem_Click_1);
            // 
            // txtDiachi
            // 
            this.txtDiachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(201, 126);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(600, 30);
            this.txtDiachi.TabIndex = 1;
            // 
            // txttenKH
            // 
            this.txttenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenKH.Location = new System.Drawing.Point(202, 85);
            this.txttenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txttenKH.Name = "txttenKH";
            this.txttenKH.Size = new System.Drawing.Size(211, 30);
            this.txttenKH.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txttenKH);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txtmaKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(809, 188);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách Hàng Mới";
            // 
            // txtsdt
            // 
            this.txtsdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Location = new System.Drawing.Point(551, 46);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(250, 30);
            this.txtsdt.TabIndex = 2;
            // 
            // txtmaKH
            // 
            this.txtmaKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaKH.Location = new System.Drawing.Point(202, 45);
            this.txtmaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaKH.Name = "txtmaKH";
            this.txtmaKH.ReadOnly = true;
            this.txtmaKH.Size = new System.Drawing.Size(211, 30);
            this.txtmaKH.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(458, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số ĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Khách Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Khách Hàng:";
            // 
            // btnthem
            // 
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(439, 487);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(113, 43);
            this.btnthem.TabIndex = 13;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // btnsave
            // 
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(588, 487);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(113, 43);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "Lưu";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // btnthoat
            // 
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(735, 487);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(113, 43);
            this.btnthoat.TabIndex = 14;
            this.btnthoat.Text = "Đóng";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
            // 
            // gridviewaddkh
            // 
            this.gridviewaddkh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewaddkh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridviewaddkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewaddkh.Location = new System.Drawing.Point(39, 278);
            this.gridviewaddkh.Margin = new System.Windows.Forms.Padding(4);
            this.gridviewaddkh.Name = "gridviewaddkh";
            this.gridviewaddkh.ReadOnly = true;
            this.gridviewaddkh.Size = new System.Drawing.Size(809, 201);
            this.gridviewaddkh.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 42);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thêm Khách Hàng";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 561);
            this.Controls.Add(this.btnhuythem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.gridviewaddkh);
            this.Controls.Add(this.label1);
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.ThemKhachHang_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewaddkh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhuythem;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txttenKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtmaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView gridviewaddkh;
        private System.Windows.Forms.Label label1;
    }
}