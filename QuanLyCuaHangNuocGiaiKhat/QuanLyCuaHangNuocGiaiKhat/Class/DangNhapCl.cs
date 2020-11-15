using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyCuaHangNuocGiaiKhat.Data;

namespace QuanLyCuaHangNuocGiaiKhat.Class
{
    class DangNhapCl
    {
        DangNhapDL dnd = new DangNhapDL();

        public bool checklogin(string id, string pass)
        {
            if (dnd.ktdangnhap(id.Trim().ToString(), pass.Trim().ToString()) == true)
            {
                return true;
            }
            else
                return false;
        }

        public int getquyen(string user, string pass)
        {
            return dnd.quyennow(user, pass);
        }

        public string gettendangnhap(string user, string pass)
        {
            return dnd.tendangnhapnow(user, pass);
        }

        public void ngatkn()
        {
            dnd.ngatkn();
        }
    }
}