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
    class TimNGKCL
    {
        TimNGKDL tnd = new TimNGKDL();

        public DataTable loadgridview()
        {
            DataTable dt = new DataTable();
            dt = tnd.gridviewcome();
            return dt;
        }

        public DataTable timtenNGK(string keyword)
        {
            DataTable dt = new DataTable();
            dt = tnd.SearchtenNGKProtocol(keyword.Trim().ToString());
            return dt;
        }

        public DataTable timtenloaiNGKTL(string keyword, string MaLoaiNGK)
        {
            DataTable dt = new DataTable();
            dt = tnd.SearchtenLNGKProtocol(keyword.Trim().ToString(), MaLoaiNGK.Trim().ToString());
            return dt;
        }

        internal object timtenloaiNGKTL(string text)
        {
            throw new NotImplementedException();
        }

        internal object timtenNGKNCU(string text)
        {
            throw new NotImplementedException();
        }

        public DataTable timtenNGKNCU(string keyword, string MaNhaCungUng)
        {
            DataTable dt = new DataTable();
            dt = tnd.SearchtenNCUProtocol(keyword.Trim().ToString(), MaNhaCungUng.Trim().ToString());
            return dt;
        }
                
        public DataTable loadcbNCU()
        {
            DataTable dt = new DataTable();
            dt = tnd.ncucome();
            return dt;
        }

        public DataTable loadcbLoaiNGK()
        {
            DataTable dt = new DataTable();
            dt = tnd.loaiNGKcome();
            return dt;
        }
    }
}