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
    class NhaCungUngCL
    {
        NhaCungUngDL ncud = new NhaCungUngDL();

        public bool them(string MaNhaCungUng, string TenNhaCungUng, string DiaChiNhaCungUng, string SdtNhaCungUng)
        {
            try
            {
                ncud.insert(MaNhaCungUng.Trim().ToString(), TenNhaCungUng.Trim().ToString(), DiaChiNhaCungUng.Trim().ToString(), SdtNhaCungUng.Trim().ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool sua(string MaNhaCungUng, string TenNhaCungUng, string DiaChiNhaCungUng, string SdtNhaCungUng)
        {
            try
            {
                ncud.update(MaNhaCungUng.Trim().ToString(), TenNhaCungUng.Trim().ToString(), DiaChiNhaCungUng.Trim().ToString(), SdtNhaCungUng.Trim().ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoa(string MaNhaCungUng)
        {
            try
            {
                ncud.delete(MaNhaCungUng.Trim().ToString());
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
            dt = ncud.gridviewcome();
            return dt;
        }

        public void ngatkn()
        {
            ncud.ngatkn();
        }

        public string getNextID()
        {
            string MaNhaCungUng = ncud.nextID();
            if (MaNhaCungUng == "") return "NCU001";
            int so = int.Parse(MaNhaCungUng.Substring(3)) + 1;
            string ma = "NCU00";
            if (so < 10)
                ma = "NCU00";
            else
            {
                if (so < 100)
                    ma = "NCU0";
                else
                {
                    if (so < 1000)
                        ma = "NCU";
                }
            }
            return ma + so.ToString();

        }
    }
}