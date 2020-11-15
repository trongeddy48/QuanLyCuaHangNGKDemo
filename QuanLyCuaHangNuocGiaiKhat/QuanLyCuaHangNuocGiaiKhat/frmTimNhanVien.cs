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
    public partial class frmTimNhanVien : Form
    {
        public frmTimNhanVien()
        {
            InitializeComponent();
        }

        TimNhanVienCL snvb = new TimNhanVienCL();

        private void ResetGridview()
        {
            dgvTimNV.DataSource = null;
            dgvTimNV.DataSource = snvb.loadgridview();
        }

        private void btnTimNV_Click(object sender, EventArgs e)
        {
            dgvTimNV.DataSource = snvb.timtennv(txtTenNV.Text);
        }

        private void TimKiemNhanVien_Form_Load(object sender, EventArgs e)
        {
            ResetGridview();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDanhsachnv_Click_1(object sender, EventArgs e)
        {
            ResetGridview();
        }        
    }
}
