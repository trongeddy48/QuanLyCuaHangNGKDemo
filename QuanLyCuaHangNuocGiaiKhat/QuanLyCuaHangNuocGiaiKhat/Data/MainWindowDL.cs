using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyCuaHangNuocGiaiKhat.ThucThe;

namespace QuanLyCuaHangNuocGiaiKhat.Data
{
    class MainWindowDL
    {
        KetNoi kn = new KetNoi(frmDangnhap.tenmay);

        public void ngatkn()
        {
            kn.disconnect();
        }
    }
}
