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
    class LoaiNGKCL
    {
        LoaiNGKDL lnd = new LoaiNGKDL();

        public bool them(string MaLoaiNGK, string TenLoaiNGK)
        {
            try
            {
                lnd.insert(MaLoaiNGK.Trim().ToString(), TenLoaiNGK.Trim().ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool sua(string MaLoaiNGK, string TenLoaiNGK)
        {
            try
            {
                lnd.update(MaLoaiNGK.Trim().ToString(), TenLoaiNGK.Trim().ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoa(string MaLoaiNGK)
        {
            try
            {
                lnd.delete(MaLoaiNGK.Trim().ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable loadgridview()
        {
            DataTable dt = new DataTable();
            dt = lnd.gridviewcome();
            return dt;
        }

        public void ngatkn()
        {
            lnd.ngatkn();
        }

        public string getNextID()
        {
            string MaLoaiNGK = lnd.nextID();
            if (MaLoaiNGK == "") return "LNN001";
            int so = int.Parse(MaLoaiNGK.Substring(3)) + 1;
            string ma = "LNN00";
            if (so < 10)
                ma = "LNN00";
            else
            {
                if (so < 100)
                    ma = "LNN0";
                else
                {
                    if (so < 1000)
                        ma = "LNN";
                }
            }
            return ma + so.ToString();

        }
    }
}
