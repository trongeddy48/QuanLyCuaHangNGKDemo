using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangNuocGiaiKhat
{
    public partial class frmInCacPhieu : Form
    {
        public frmInCacPhieu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BaoCaoNhanVien bcnv = new BaoCaoNhanVien();
            bcnv.Show();
        }

        private void btnBaoCaoPhieuGoi_Click(object sender, EventArgs e)
        {
            BaoCaoPhieuGoi bcpg = new BaoCaoPhieuGoi();
            bcpg.Show();
        }

        private void btnBaoCaoPhieuHen_Click(object sender, EventArgs e)
        {
            BaoCaoPhieuHen bcph = new BaoCaoPhieuHen();
            bcph.Show();
        }

        private void btnBaoCaoKhachHang_Click(object sender, EventArgs e)
        {
            BaoCaoKhachHang bckh = new BaoCaoKhachHang();
            bckh.Show();
        }
    }
}
