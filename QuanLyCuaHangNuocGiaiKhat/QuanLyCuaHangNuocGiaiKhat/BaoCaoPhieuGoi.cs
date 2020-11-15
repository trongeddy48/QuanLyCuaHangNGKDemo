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
    public partial class BaoCaoPhieuGoi : Form
    {
        public BaoCaoPhieuGoi()
        {
            InitializeComponent();
        }

        private void BaoCaoPhieuGoi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            KetNoi kn = new KetNoi(frmDangnhap.tenmay);
            dt = kn.laybangHoaDonchodgv("select * from HoaDon");
            rptPhieuGoi rpt = new rptPhieuGoi();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
