using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using QuanLyCuaHangNuocGiaiKhat.ThucThe;

namespace QuanLyCuaHangNuocGiaiKhat.Data
{
    class DangNhapDL
    {
        KetNoi kn = new KetNoi(frmDangnhap.tenmay);
        public static int q;
        public static string tendangnhap;

        public bool ktdangnhap(string user, string pass)
        {

            string sql = "select * from account where username='" + user + "' and pass='" + pass + "'";
            DataTable dt = new DataTable();
            dt = kn.gettable(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;

        }

        public int quyennow(string user, string pass)
        {
            string sql = "select * from account where username='" + user + "' and pass='" + pass + "'";
            DataTable dt = new DataTable();
            dt = kn.gettable(sql);
            q = Int32.Parse(dt.Rows[0][2].ToString());
            return q;
        }

        public string tendangnhapnow(string user, string pass)
        {
            string sql = "select * from account where username='" + user + "' and pass='" + pass + "'";
            DataTable dt = new DataTable();
            dt = kn.gettable(sql);
            tendangnhap = dt.Rows[0][0].ToString();
            return tendangnhap;
        }

        public void ngatkn()
        {
            kn.disconnect();
        }
    }
}
