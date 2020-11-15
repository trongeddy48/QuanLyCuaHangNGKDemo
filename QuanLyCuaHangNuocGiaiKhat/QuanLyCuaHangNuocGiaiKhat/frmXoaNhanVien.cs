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
    public partial class frmXoaNhanVien : Form
    {
        public frmXoaNhanVien()
        {
            InitializeComponent();
        }

        NhanVienCL nvb = new NhanVienCL();

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetGridview()
        {
            dgvXoaNV.DataSource = null;
            dgvXoaNV.DataSource = nvb.loadgridviewdel();
        }

        private void XoaNhanVien_Form_Load(object sender, EventArgs e)
        {
            ResetGridview();
        }

        private void GridViewdelnv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtManv.Text = dgvXoaNV.Rows[row].Cells[0].Value.ToString();
                txtTennv.Text = dgvXoaNV.Rows[row].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (nvb.xoa(txtManv.Text) == true)
            {
                MessageBox.Show("Xóa Nhân Viên Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Xóa Nhân Viên Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}