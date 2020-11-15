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
    public partial class frmNhaCU : Form
    {
        public frmNhaCU()
        {
            InitializeComponent();
        }

        NhaCungUngCL ncub = new NhaCungUngCL();

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridViewNCU_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtMaNCU.Text = dgvNhaCU.Rows[row].Cells[0].Value.ToString();
                txtTenNCU.Text = dgvNhaCU.Rows[row].Cells[1].Value.ToString();
                txtdiachi.Text = dgvNhaCU.Rows[row].Cells[2].Value.ToString();
                txtsdt.Text = dgvNhaCU.Rows[row].Cells[3].Value.ToString();
            }
            catch
            {
                ResetControl();
                txtMaNCU.Text = "";
            }
        }

        private void ResetGridview()
        {
            dgvNhaCU.DataSource = null;
            dgvNhaCU.DataSource = ncub.loadgridview();
        }

        private void ResetControl()
        {
            txtTenNCU.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
        }

        private void NhaCU_Form_Load(object sender, EventArgs e)
        {
            ResetGridview();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ncub.them(txtMaNCU.Text, txtTenNCU.Text, txtdiachi.Text, txtsdt.Text) == true)
            {
                MessageBox.Show("Thêm Nhà Cung Ứng NGK Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Thêm Nhà Cung Ứng NGK Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (ncub.xoa(txtMaNCU.Text) == true)
            {
                MessageBox.Show("Xóa Nhà Cung Ứng NGK Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Xóa Nhà Cung Ứng NGK Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapnhat_Click_1(object sender, EventArgs e)
        {
            if (ncub.sua(txtMaNCU.Text, txtTenNCU.Text, txtdiachi.Text, txtsdt.Text) == true)
            {
                MessageBox.Show("Cập Nhật Nhà Cung Ứng NGK Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Cập Nhật Nhà Cung Ứng NGK Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTaoma_Click_1(object sender, EventArgs e)
        {
            txtMaNCU.Text = ncub.getNextID();
            ResetControl();
            txtTenNCU.Focus();
        }              
    }
}
