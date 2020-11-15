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
    public partial class frmTimKiemKH : Form
    {
        public frmTimKiemKH()
        {
            InitializeComponent();
        }

        TimKhachHangCL ssvb = new TimKhachHangCL();

        private void ResetGridview()
        {
            GridViewSearch.DataSource = null;
            GridViewSearch.DataSource = ssvb.loadgridview();
        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            GridViewSearch.DataSource = ssvb.timtenKH(txttenkh.Text);
        }

        private void TimKiemKhachHang_Form_Load(object sender, EventArgs e)
        {
            ResetGridview();
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndanhsachsv_Click_1(object sender, EventArgs e)
        {
            ResetGridview();
        }
    }
}
