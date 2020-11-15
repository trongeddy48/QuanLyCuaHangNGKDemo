using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyCuaHangNuocGiaiKhat.Data;

namespace QuanLyCuaHangNuocGiaiKhat.Class
{
    class TimNhanVienCL
    {
        TimNhanVienDL snvd = new TimNhanVienDL();

        public DataTable loadgridview()
        {
            DataTable dt = new DataTable();
            dt = snvd.gridviewcome();
            return dt;
        }

        public DataTable timtennv(string keyword)
        {
            DataTable dt = new DataTable();
            dt = snvd.SearchTennvProtocol(keyword.Trim().ToString());
            return dt;
        }
    }
}
