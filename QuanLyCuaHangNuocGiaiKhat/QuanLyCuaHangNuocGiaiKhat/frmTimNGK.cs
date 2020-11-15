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
    public partial class frmTimNGK : Form
    {
        public frmTimNGK()
        {
            InitializeComponent();
        }

        TimNGKCL ssb = new TimNGKCL();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetGridview()
        {
            dgvTimNuoc.DataSource = null;
            dgvTimNuoc.DataSource = ssb.loadgridview();
        }        

        private void Getncu()
        {
            cbonhacu.DisplayMember = "TenNhaCungUng";
            cbonhacu.ValueMember = "MaNhaCungUng";
            cbonhacu.DataSource = ssb.loadcbNCU();
        }

        private void GetloaiNGK()
        {
            cboloaingk.DisplayMember = "TenLoaiNGK";
            cboloaingk.ValueMember = "MaLoaiNGK";
            cboloaingk.DataSource = ssb.loadcbLoaiNGK();
        }

        private void btntimtenNGK_Click(object sender, EventArgs e)
        {
            dgvTimNuoc.DataSource = ssb.timtenNGK(txttenngk.Text);
        }

        private void btntimloaingk_Click(object sender, EventArgs e)
        {
            dgvTimNuoc.DataSource = ssb.timtenloaiNGKTL(txttenngkln.Text, cboloaingk.SelectedValue.ToString());
        }        

        private void btntimnhacu_Click(object sender, EventArgs e)
        {
            dgvTimNuoc.DataSource = ssb.timtenNGKNCU(txttenngkncu.Text, cbonhacu.SelectedValue.ToString());
        }

        private void TimKiemSach_Form_Load(object sender, EventArgs e)
        {
            ResetGridview();            
            Getncu();
            GetloaiNGK ();
        }        
    }
}
