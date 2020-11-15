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
    public partial class BaoCaoNhanVien : Form
    {
        public BaoCaoNhanVien()
        {
            InitializeComponent();
        }

        private void BaoCaoNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            KetNoi kn = new KetNoi(frmDangnhap.tenmay);
            dt = kn.bangNhanVienchorpt("select * from nhanvien");
            rptNhanVien rpt = new rptNhanVien();
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
