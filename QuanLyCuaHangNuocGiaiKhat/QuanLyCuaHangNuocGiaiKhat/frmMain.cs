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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        MainWimdowBL mwb = new MainWimdowBL();

        private void btnDangxuatvathoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn đăng xuất và thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

        private void Setcontrol(int stats)
        {
            if (stats == 1)
            {
                grpNV.Enabled = true;
                grpKH.Enabled = true;
            }
            else
            {
                grpNV.Enabled = false;
                grpKH.Enabled = false;
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            Setcontrol(frmDangnhap.quyen);
            //MessageBox.Show("FormMain: " + frmDangNhap.quyen.ToString(), "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDangnhap frmlogin = new frmDangnhap();
            frmlogin.Show();
            frmDangnhap.quyen = 0;
        }

        #region GroupNGK

        private void btnThemNGK_Click(object sender, EventArgs e)
        {
            frmThemNGK themnuoc = new frmThemNGK();
            themnuoc.Show();
        }

        private void btnSuaNGK_Click(object sender, EventArgs e)
        {
            frmSuaNGK suanuoc = new frmSuaNGK();
            suanuoc.Show();
        }

        private void btnXoaNGK_Click(object sender, EventArgs e)
        {
           frmXoaNGK xoanuoc = new frmXoaNGK();
            xoanuoc.Show();
        }

        private void btnTimNGK_Click(object sender, EventArgs e)
        {
            frmTimNGK timNGK = new frmTimNGK();
            timNGK.Show();
        }
        #endregion

        #region Group LoaiNGK, NhaCU

        private void btnThemLoaiNGK_Click(object sender, EventArgs e)
        {
            frmLoaiNGK ln = new frmLoaiNGK();
            ln.Show();
        }
             

        private void btnNhaCU_Click(object sender, EventArgs e)
        {
            frmNhaCU ncu = new frmNhaCU();
            ncu.Show();
        }

        private void btnTimNGKvaNCC_Click(object sender, EventArgs e)
        {
            frmTimNCU tk = new frmTimNCU();
            tk.Show();
        }
                
        private void btnPhieuhen_Click(object sender, EventArgs e)
        {
            frmPhieuHen phieuhen = new frmPhieuHen();
            phieuhen.Show();
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            hd.Show();
        }

        private void btnTimdon_Click(object sender, EventArgs e)
        {
            frmTimPhieuHen thd = new frmTimPhieuHen();
            thd.Show();
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            frmInCacPhieu inphieu = new frmInCacPhieu();
            inphieu.Show();
        }
        #endregion

        #region Group KhachHang
        private void btnaddstu_Click(object sender, EventArgs e)
        {
            frmKhachHang themkh = new frmKhachHang();
            themkh.Show();
        }

        private void btndelstu_Click(object sender, EventArgs e)
        {
            frmXoaKH xoakh = new frmXoaKH();
            xoakh.Show();
        }

        private void btnupdatestu_Click(object sender, EventArgs e)
        {
            frmCapNhatKH cnkh = new frmCapNhatKH();
            cnkh.Show();
        }

        

        private void btnsearchstu_Click(object sender, EventArgs e)
        {
            frmTimKiemKH timkh = new frmTimKiemKH();
            timkh.Show();
        }
        #endregion

        #region Group NhanVien
        private void btnaddstaff_Click(object sender, EventArgs e)
        {
            frmThemNhanVien addstaffform = new frmThemNhanVien();
            addstaffform.Show();
        }

        private void btnupdatestaff_Click_1(object sender, EventArgs e)
        {
            frmCapNhatNhanVien updatestaff = new frmCapNhatNhanVien();
            updatestaff.Show();
        }

        private void btnsearchstaff_Click_1(object sender, EventArgs e)
        {
            frmTimNhanVien tknv = new frmTimNhanVien();
            tknv.Show();
        }
        #endregion

        private void btndelstaff_Click(object sender, EventArgs e)
        {
            frmXoaNhanVien delnv = new frmXoaNhanVien();
            delnv.Show();
        }
    }
}