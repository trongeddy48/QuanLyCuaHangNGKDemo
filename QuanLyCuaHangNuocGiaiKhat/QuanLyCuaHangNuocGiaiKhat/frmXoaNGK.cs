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
    public partial class frmXoaNGK : Form
    {
        public frmXoaNGK()
        {
            InitializeComponent();
        }

        NGKCL nbl = new NGKCL();

        private void ResetGridview()
        {
            dgvXoaNGK.DataSource = null;
            dgvXoaNGK.DataSource = nbl.loadgridviewdel();
        }

        private void XoaNGK_Form_Load(object sender, EventArgs e)
        {
            ResetGridview();
        }

        private void GridViewDelNGK_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtMaNGK.Text = dgvXoaNGK.Rows[row].Cells[0].Value.ToString();
                txtTenNGK.Text = dgvXoaNGK.Rows[row].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (nbl.xoa(txtMaNGK.Text) == true)
            {
                MessageBox.Show("Xóa NGK Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Xóa NGK Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
