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
    class NGKCL
    {
        NGKDL ndl = new NGKDL();

        public bool them(string MaNGK, string TenNGK, string MaNhaCungUng, string SoLuong, string MaLoaiNGK)
        {
            try
            {
                ndl.insert(MaNGK.Trim().ToString(), TenNGK.Trim().ToString(), MaNhaCungUng.Trim().ToString(), Int32.Parse(SoLuong.Trim().ToString()), MaLoaiNGK.Trim().ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool sua(string MaNGK, string TenNGK, string MaNhaCungUng, string SoLuong, string MaLoaiNGK)
        {
            try
            {
                ndl.update(MaNGK.Trim().ToString(), TenNGK.Trim().ToString(), MaNhaCungUng.Trim().ToString(), Int32.Parse(SoLuong.Trim().ToString()), MaLoaiNGK.Trim().ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoa(string MaNGK)
        {
            try
            {
                ndl.delete(MaNGK.Trim().ToString());
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
            dt = ndl.gridviewcome();
            return dt;
        }

        public DataTable loadgridviewdel()
        {
            DataTable dt = new DataTable();
            dt = ndl.gridviewcomedelNGK();
            return dt;
        }        

        public DataTable loadcbncu()
        {
            DataTable dt = new DataTable();
            dt = ndl.ncucome();
            return dt;
        }

        public DataTable loadcbloaingk()
        {
            DataTable dt = new DataTable();
            dt = ndl.loaingkcome();
            return dt;
        }

        public void ngatkn()
        {
            ndl.ngatkn();
        }

       // public string getNextID()
       // {
        //    //string MaNGK = ndl.nextID();
        //    //if (MaNGK == "") return "NGK001";
           
        //    //int so = int.Parse(MaNGK.Substring(4)+1);
        //    //string ma = "NGK00";
        //    //if (so < 10)
        //    //    ma = "NGK00";
        //    //else
        //    //{
        //    //    if (so < 100)
        //    //        ma = "NGK0";
        //    //    else
        //    //    {
        //    //        if (so < 1000)
        //    //            ma = "NGK";
        //    //    }
        //    //}
        //    //return ma + so.ToString();

       // }
    }
}
