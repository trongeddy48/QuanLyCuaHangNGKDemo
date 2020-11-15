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
    public partial class frmThemNhanVien : Form
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        NhanVienCL nvb = new NhanVienCL();

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Setcontrol(bool stats)
        {
            txtManv.Enabled = stats;
            txtTennv.Enabled = stats;
            txtDiachi.Enabled = stats;            
            txtsdt.Enabled = stats;
            btnLuu.Enabled = stats;
            btnThem.Enabled = !stats;
            btnHuythem.Enabled = stats;
        }

        private void Resetcontrol()
        {
            txtManv.Text = "";
            txtTennv.Text = "";
            txtDiachi.Text = "";            
            txtsdt.Text = "";
        }

        private void ResetGridview()
        {
            dgvThemnv.DataSource = null;
            dgvThemnv.DataSource = nvb.loadgridview();
        }

        private void ThemNhanVien_Form_Load(object sender, EventArgs e)
        {
            ResetGridview();
            Setcontrol(false);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Setcontrol(true);
            //txtManv.Text = nvb.getNextID();
            txtManv.Text = "";
            txtTennv.Text = "";
            txtDiachi.Text = "";
            txtsdt.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (nvb.them(txtManv.Text, txtTennv.Text, txtDiachi.Text, txtsdt.Text) == true)
            {
                MessageBox.Show("Thêm Nhân Viên Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Setcontrol(false);
                Resetcontrol();
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Thêm Nhân Viên Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuythem_Click_1(object sender, EventArgs e)
        {
            Setcontrol(false);
            Resetcontrol();
        }
    }
}
