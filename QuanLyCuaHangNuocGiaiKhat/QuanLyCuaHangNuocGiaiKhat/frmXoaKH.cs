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
    public partial class frmXoaKH : Form
    {
        public frmXoaKH()
        {
            InitializeComponent();
        }

        KhachHangCL khb = new KhachHangCL();

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetGridview()
        {
            GridViewdelkh.DataSource = null;
            GridViewdelkh.DataSource = khb.loadgridviewdel();
        }

        private void XoaKhachHang_Form_Load(object sender, EventArgs e)
        {
            ResetGridview();
        }

        private void GridViewdelkh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtmakh.Text = GridViewdelkh.Rows[row].Cells[0].Value.ToString();
                txttenkh.Text = GridViewdelkh.Rows[row].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void btndel_Click_1(object sender, EventArgs e)
        {
            if (khb.xoa(txtmakh.Text) == true)
            {
                MessageBox.Show("Xóa Sinh Viên Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Xóa Sinh Viên Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
