using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCuaHangNuocGiaiKhat.Class;
using QuanLyCuaHangNuocGiaiKhat.Data;
using QuanLyCuaHangNuocGiaiKhat.ThucThe;

namespace QuanLyCuaHangNuocGiaiKhat
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        public static string tenmay;
        public static int quyen;
        public static string tendangnhap;

        private void btnDangnhap_Click_1(object sender, EventArgs e)
        {
            tenmay = txtTenmay.Text.Trim().ToString();
            DangNhapCl dnb = new DangNhapCl();
            if (KetNoi.connectstat == true)
            {
                if (dnb.checklogin(txtTaiKhoan.Text, txtMatKhau.Text) == true)
                {
                    quyen = dnb.getquyen(txtTaiKhoan.Text, txtMatKhau.Text);
                    tendangnhap = dnb.gettendangnhap(txtTaiKhoan.Text, txtMatKhau.Text);
                    frmMain fm = new frmMain();
                    fm.Show();
                    //MessageBox.Show("FormLogin: " + quyen.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

                KetNoi.connectstat = true;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenmay.Text = System.Environment.MachineName;
            txtTaiKhoan.Focus();
            /*this.reportViewer1.RefreshReport();*/
        }

        private void btnThoatDN_Click(object sender, EventArgs e)
        {
            if (KetNoi.connectstat == true)
            {
                DangNhapCl dnb = new DangNhapCl();
                dnb.ngatkn();
            }
            Application.Exit();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //dnb.ngatkn();
            Application.Exit();
        }

        private void txtTenmay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
