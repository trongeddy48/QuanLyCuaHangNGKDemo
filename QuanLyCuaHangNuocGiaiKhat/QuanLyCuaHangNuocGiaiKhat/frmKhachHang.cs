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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        KhachHangCL khb = new KhachHangCL();

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Setcontrol(bool stats)
        {
            txtmaKH.Enabled = stats;
            txttenKH.Enabled = stats;
            txtDiachi.Enabled = stats;
            txtsdt.Enabled = stats;            
            btnsave.Enabled = stats;
            btnthem.Enabled = !stats;
            btnhuythem.Enabled = stats;
        }

        private void Resetcontrol()
        {
            txtmaKH.Text = "";
            txttenKH.Text = "";
            txtDiachi.Text = "";
            txtsdt.Text = "";            
        }

        private void ResetGridview()
        {
            gridviewaddkh.DataSource = null;
            gridviewaddkh.DataSource = khb.loadgridview();
        }

        private void ThemKhachHang_Form_Load(object sender, EventArgs e)
        {
            ResetGridview();
            Setcontrol(false);
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            Setcontrol(true);
            txtmaKH.Text = khb.getNextID();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            if (khb.them(txtmaKH.Text, txttenKH.Text, txtDiachi.Text, txtsdt.Text) == true)
            {
                MessageBox.Show("Thêm Khách Hàng Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Setcontrol(false);
                Resetcontrol();
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Thêm Khách Hàng Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnhuythem_Click_1(object sender, EventArgs e)
        {
            Setcontrol(false);
            Resetcontrol();
        }
    }
}
