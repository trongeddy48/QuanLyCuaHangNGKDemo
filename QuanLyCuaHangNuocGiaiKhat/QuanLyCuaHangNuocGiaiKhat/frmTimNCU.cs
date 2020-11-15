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
    public partial class frmTimNCU : Form
    {
        public frmTimNCU()
        {
            InitializeComponent();
        }

        TimNCUCL search = new TimNCUCL();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntimloaingk_Click(object sender, EventArgs e)
        {
            dgvTimNCU.DataSource = search.timloaiNGK(txttenloaingk.Text);
        }

        private void btnTimtenNCU_Click(object sender, EventArgs e)
        {
            dgvTimNCU.DataSource = search.timncu(txtTenNCU.Text);
        }        
    }
}
