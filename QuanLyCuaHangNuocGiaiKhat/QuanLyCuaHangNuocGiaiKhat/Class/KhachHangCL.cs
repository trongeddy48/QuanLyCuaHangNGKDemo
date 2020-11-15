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
    class KhachHangCL
    {
        KhachHangDL khd = new KhachHangDL();

        public bool them(string MaKH, string TenKH, string DiaChiKH, string SdtKH)
        {
            try
            {
                khd.insert(MaKH.Trim().ToString(), TenKH.Trim().ToString(), DiaChiKH.Trim().ToString(), SdtKH.Trim().ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool sua(string MaKH, string TenKH, string DiaChiKH, string SdtKH)
        {
            try
            {
                khd.update(MaKH.Trim().ToString(), TenKH.Trim().ToString(), DiaChiKH.Trim().ToString(), SdtKH.Trim().ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoa(string MaKH)
        {
            try
            {
                khd.delete(MaKH.Trim().ToString());
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
            dt = khd.gridviewcome();
            return dt;
        }

        public DataTable loadgridviewdel()
        {
            DataTable dt = new DataTable();
            dt = khd.gridviewcomedelkhachhang();
            return dt;
        }

        public void ngatkn()
        {
            khd.ngatkn();
        }

        public string getNextID()
        {
            string MaKH = khd.nextID();
            if (MaKH == "") return "1210KH0001";
            int so = int.Parse(MaKH.Substring(8)) + 1;
            string ma = "1210KH000";
            if (so < 10)
                ma = "1210KH000";
            else
            {
                if (so < 100)
                    ma = "1210KH00";
                else
                {
                    if (so < 1000)
                        ma = "1210KH0";
                }
            }
            return ma + so.ToString();

        }
    }
}