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
    public partial class frmTimPhieuHen : Form
    {
        public frmTimPhieuHen()
        {
            InitializeComponent();
        }

        TimPhieuHenCL sphb = new TimPhieuHenCL();

        private void ResetGridview()
        {
            dgvTimPH.DataSource = null;
            dgvTimPH.DataSource = sphb.loadgridview(frmDangnhap.tendangnhap);
        }

        private void GetcbKhachhang()
        {
            cbmakh.DisplayMember = "MaKH";
            cbmakh.ValueMember = "MaKH";
            cbmakh.DataSource = sphb.loadcbkhachhang(frmDangnhap.tendangnhap);
        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            dgvTimPH.DataSource = sphb.SearchlikeDate(frmDangnhap.tendangnhap, dateTimePicker1.Value.ToShortDateString().ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvTimPH.DataSource = sphb.SearchlikeIDKh(frmDangnhap.tendangnhap, cbmakh.SelectedValue.ToString());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ResetGridview();
        }

        private void TimKiemPhieuMuon_Form_Load(object sender, EventArgs e)
        {
            ResetGridview();
            GetcbKhachhang();
            txtmanv.Text = frmDangnhap.tendangnhap.ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}