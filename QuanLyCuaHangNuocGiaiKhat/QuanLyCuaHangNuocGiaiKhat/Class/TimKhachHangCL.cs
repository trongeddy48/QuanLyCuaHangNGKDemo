using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangNuocGiaiKhat.Data;

namespace QuanLyCuaHangNuocGiaiKhat.Class
{
    class TimKhachHangCL
    {
            TimKhachHangDL tkh = new TimKhachHangDL();

            public DataTable loadgridview()
            {
                DataTable dt = new DataTable();
                dt = tkh.gridviewcome();
                return dt;
            }

            public DataTable timtenKH(string keyword)
            {
                DataTable dt = new DataTable();
                dt = tkh.SearchtenKHProtocol(keyword.Trim().ToString());
                return dt;
            }
        }
}
