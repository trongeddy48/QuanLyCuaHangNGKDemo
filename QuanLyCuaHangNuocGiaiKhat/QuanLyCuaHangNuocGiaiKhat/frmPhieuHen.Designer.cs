namespace QuanLyCuaHangNuocGiaiKhat
{
    partial class frmPhieuHen
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
            this.dgvHenNGK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbomakh = new System.Windows.Forms.ComboBox();
            this.txtngaylap = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtmaph = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnhuythem = new System.Windows.Forms.Button();
            this.btnctph = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHenNGK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(789, 488);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(113, 43);
            this.btnthoat.TabIndex = 16;
            this.btnthoat.Text = "Đóng";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dgvHenNGK
            // 
            this.dgvHenNGK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHenNGK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHenNGK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHenNGK.Location = new System.Drawing.Point(41, 279);
            this.dgvHenNGK.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHenNGK.Name = "dgvHenNGK";
            this.dgvHenNGK.ReadOnly = true;
            this.dgvHenNGK.Size = new System.Drawing.Size(861, 201);
            this.dgvHenNGK.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "Phiếu Hẹn NGK";
            // 
            // btnluu
            // 
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(647, 488);
            this.btnluu.Margin = new System.Windows.Forms.Padding(4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(113, 43);
            this.btnluu.TabIndex = 17;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnCTPH_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbomakh);
            this.groupBox1.Controls.Add(this.txtngaylap);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.txtmaph);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(861, 188);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // cbomakh
            // 
            this.cbomakh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbomakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomakh.FormattingEnabled = true;
            this.cbomakh.Location = new System.Drawing.Point(606, 31);
            this.cbomakh.Margin = new System.Windows.Forms.Padding(4);
            this.cbomakh.Name = "cbomakh";
            this.cbomakh.Size = new System.Drawing.Size(235, 33);
            this.cbomakh.TabIndex = 4;
            // 
            // txtngaylap
            // 
            this.txtngaylap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtngaylap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaylap.Location = new System.Drawing.Point(176, 131);
            this.txtngaylap.Margin = new System.Windows.Forms.Padding(4);
            this.txtngaylap.Name = "txtngaylap";
            this.txtngaylap.Size = new System.Drawing.Size(211, 30);
            this.txtngaylap.TabIndex = 9;
            // 
            // txtmanv
            // 
            this.txtmanv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.Location = new System.Drawing.Point(606, 133);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(235, 30);
            this.txtmanv.TabIndex = 10;
            // 
            // txtmaph
            // 
            this.txtmaph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmaph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaph.Location = new System.Drawing.Point(176, 32);
            this.txtmaph.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaph.Name = "txtmaph";
            this.txtmaph.Size = new System.Drawing.Size(211, 30);
            this.txtmaph.TabIndex = 11;
            this.txtmaph.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày Lập PH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Nhân Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã Khách Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số Phiếu Hẹn:";
            // 
            // btnhuythem
            // 
            this.btnhuythem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhuythem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuythem.Location = new System.Drawing.Point(359, 488);
            this.btnhuythem.Margin = new System.Windows.Forms.Padding(4);
            this.btnhuythem.Name = "btnhuythem";
            this.btnhuythem.Size = new System.Drawing.Size(113, 43);
            this.btnhuythem.TabIndex = 19;
            this.btnhuythem.Text = "Hủy Thêm";
            this.btnhuythem.UseVisualStyleBackColor = true;
            this.btnhuythem.Click += new System.EventHandler(this.btnhuythem_Click);
            // 
            // btnctph
            // 
            this.btnctph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnctph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnctph.Location = new System.Drawing.Point(139, 488);
            this.btnctph.Margin = new System.Windows.Forms.Padding(4);
            this.btnctph.Name = "btnctph";
            this.btnctph.Size = new System.Drawing.Size(181, 43);
            this.btnctph.TabIndex = 21;
            this.btnctph.Text = "Chi Tiết Phiếu Hẹn";
            this.btnctph.UseVisualStyleBackColor = true;
            this.btnctph.Click += new System.EventHandler(this.btncthd_Click);
            // 
            // btnthem
            // 
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(502, 488);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(113, 43);
            this.btnthem.TabIndex = 20;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // frmPhieuHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 556);
            this.Controls.Add(this.btnhuythem);
            this.Controls.Add(this.btnctph);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dgvHenNGK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnluu);
            this.Name = "frmPhieuHen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Hẹn";
            this.Load += new System.EventHandler(this.PhieuHen_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHenNGK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView dgvHenNGK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbomakh;
        private System.Windows.Forms.TextBox txtngaylap;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txtmaph;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhuythem;
        private System.Windows.Forms.Button btnctph;
        private System.Windows.Forms.Button btnthem;
    }
}