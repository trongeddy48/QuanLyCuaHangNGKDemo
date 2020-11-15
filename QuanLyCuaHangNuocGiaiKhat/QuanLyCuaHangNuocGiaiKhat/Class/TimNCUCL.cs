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
    class TimNCUCL
    {
        TimNCUDL search = new TimNCUDL();
               
        public DataTable timloaiNGK(string keyword)
        {
            DataTable dt = new DataTable();
            dt = search.SearchtenLoaiNGKProtocol(keyword.Trim().ToString());
            return dt;
        }

        public DataTable timncu(string keyword)
        {
            DataTable dt = new DataTable();
            dt = search.SearchtenNCUProtocol(keyword.Trim().ToString());
            return dt;
        }
    }
}
