using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangNuocGiaiKhat.ThucThe;

namespace QuanLyCuaHangNuocGiaiKhat
{
    public partial class BaoCaoKhachHang : Form
    {
        public BaoCaoKhachHang()
        {
            InitializeComponent();
        }

        private void BaoCaoKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            KetNoi kn = new KetNoi(frmDangnhap.tenmay);
            dt = kn.bangKhachHangchorpt("select * from KhachHang");
            rptKhachHang rpt = new rptKhachHang();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
