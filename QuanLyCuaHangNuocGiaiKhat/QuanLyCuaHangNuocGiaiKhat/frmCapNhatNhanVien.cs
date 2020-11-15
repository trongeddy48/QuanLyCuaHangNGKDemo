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
    public partial class frmCapNhatNhanVien : Form
    {
        public frmCapNhatNhanVien()
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
            dgvCapnhatNV.DataSource = null;
            dgvCapnhatNV.DataSource = nvb.loadgridview();
        }

        private void CapNhatNhanVien_Form_Load(object sender, EventArgs e)
        {
            ResetGridview();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (nvb.sua(txtManv.Text, txttennv.Text, txtdiachi.Text, txtsdt.Text) == true)
            {
                MessageBox.Show("Cập Nhật Nhân Viên Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Cập Nhật Nhân Viên Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridviewaddnv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtManv.Text = dgvCapnhatNV.Rows[row].Cells[0].Value.ToString();
                txttennv.Text = dgvCapnhatNV.Rows[row].Cells[1].Value.ToString();
                txtdiachi.Text = dgvCapnhatNV.Rows[row].Cells[2].Value.ToString();
                txtsdt.Text = dgvCapnhatNV.Rows[row].Cells[3].Value.ToString();                
            }
            catch
            {

            }
        }        
    }
}
