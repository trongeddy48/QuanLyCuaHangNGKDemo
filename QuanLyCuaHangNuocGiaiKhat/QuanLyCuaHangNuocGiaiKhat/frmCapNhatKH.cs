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
    public partial class frmCapNhatKH : Form
    {
        public frmCapNhatKH()
        {
            InitializeComponent();
        }

        KhachHangCL svb = new KhachHangCL();

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetGridview()
        {
            gridviewupdateKH.DataSource = null;
            gridviewupdateKH.DataSource = svb.loadgridview();
        }

        private void CapNhatKhachHang_Form_Load(object sender, EventArgs e)
        {
            ResetGridview();
        }

        private void gridviewupdatesv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtmaKH.Text = gridviewupdateKH.Rows[row].Cells[0].Value.ToString();
                txttenKH.Text = gridviewupdateKH.Rows[row].Cells[1].Value.ToString();
                txtDiaChi.Text = gridviewupdateKH.Rows[row].Cells[2].Value.ToString();
                txtSdt.Text = gridviewupdateKH.Rows[row].Cells[3].Value.ToString();                
            }
            catch
            {

            }
        }        

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            if (svb.sua(txtmaKH.Text, txttenKH.Text, txtDiaChi.Text, txtSdt.Text) == true)
            {
                MessageBox.Show("Cập Nhật Khách Hàng Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Cập Nhật Khách Hàng Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
