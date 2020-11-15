using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangNuocGiaiKhat.Class;

namespace QuanLyCuaHangNuocGiaiKhat
{
    public partial class frmLoaiNGK : Form
    {
        public frmLoaiNGK()
        {
            InitializeComponent();
        }

        LoaiNGKCL lnb = new LoaiNGKCL();

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridViewLoaiNGK_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtMaloaiNGK.Text = dgvLoaiNGK.Rows[row].Cells[0].Value.ToString();
                txtTenLoaiNGK.Text = dgvLoaiNGK.Rows[row].Cells[1].Value.ToString();
            }
            catch
            {
                ResetControl();
                txtMaloaiNGK.Text = "";
            }
        }

        private void ResetGridview()
        {
            dgvLoaiNGK.DataSource = null;
            dgvLoaiNGK.DataSource = lnb.loadgridview();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (lnb.them(txtMaloaiNGK.Text, txtTenLoaiNGK.Text) == true)
            {
                MessageBox.Show("Thêm Loại NGK Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Thêm Loại NGK Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (lnb.xoa(txtMaloaiNGK.Text) == true)
            {
                MessageBox.Show("Xóa Loại NGK Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Xóa Loại NGK Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapnhat_Click_1(object sender, EventArgs e)
        {
            if (lnb.sua(txtMaloaiNGK.Text, txtTenLoaiNGK.Text) == true)
            {
                MessageBox.Show("Cập Nhật Loại NGK Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Cập Nhật Loại NGK Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ResetControl()
        {
            txtTenLoaiNGK.Text = "";
        }

        private void LoaiNGK_Form_Load(object sender, EventArgs e)
        {
            ResetGridview();
        }

        private void btnTaoma_Click_1(object sender, EventArgs e)
        {
            txtMaloaiNGK.Text = lnb.getNextID();
            ResetControl();
            txtTenLoaiNGK.Focus();
        }                    
    }
}
