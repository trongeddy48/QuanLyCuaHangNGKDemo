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
    public partial class frmPhieuHen : Form
    {
        public frmPhieuHen()
        {
            InitializeComponent();
        }

        PhieuHenCL phb = new PhieuHenCL();

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Setcontrol(bool stats)
        {
            cbomakh.Enabled = stats;
            //btncthd.Enabled = stats;
            btnluu.Enabled = stats;
            btnthem.Enabled = !stats;
            btnhuythem.Enabled = stats;
        }

        private void Resetcontrol()
        {
            txtmaph.Text = "";
            cbomakh.Text = "";
            Getkhachhang();
        }

        private void Getkhachhang()
        {
            cbomakh.DisplayMember = "MaKH";
            cbomakh.ValueMember = "MaKH";
            cbomakh.DataSource = phb.loadcbkh();
        }

        private void ResetGridview()
        {
            dgvHenNGK.DataSource = null;
            dgvHenNGK.DataSource = phb.loadgridview(frmDangnhap.tendangnhap);
        }

        private void Getdatetime()
        {
            txtngaylap.Text = DateTime.Now.ToShortDateString().ToString();
        }

        private void Getusername()
        {
            txtmanv.Text = frmDangnhap.tendangnhap.ToString();
        }

        private void PhieuHen_Form_Load(object sender, EventArgs e)
        {
            ResetGridview();
            Setcontrol(false);
            Getkhachhang();
            Getdatetime();
            Getusername();
        }

        private void btnhuythem_Click(object sender, EventArgs e)
        {
            Setcontrol(false);
            Resetcontrol();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Setcontrol(true);
            //txtmaph.Text = phb.getNextID();
            txtmaph.Text = "SHP0";
            cbomakh.Text = "";
            txtngaylap.Text = "";
            txtmanv.Text = "";
        }

        private void btnCTPH_Click(object sender, EventArgs e)
        {
            if (phb.them(txtmaph.Text, cbomakh.SelectedValue.ToString(), txtmanv.Text, txtngaylap.Text) == true)
            {
                MessageBox.Show("Lập Phiếu Hẹn Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Setcontrol(false);
                Resetcontrol();
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Lập Phiếu Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btncthd_Click(object sender, EventArgs e)
        {
            frmChiTietPhieuHen ctphf = new frmChiTietPhieuHen();
            ctphf.ShowDialog();
        }        
    }
}
