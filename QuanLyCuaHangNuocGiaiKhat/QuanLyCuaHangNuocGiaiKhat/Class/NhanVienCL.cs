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
    class NhanVienCL
    {
        NhanVienDL nvd = new NhanVienDL();

        public bool them(string MaNV, string TenNV, string DiaChi, string SdtNV)
        {
            try
            {
                nvd.insert(MaNV.Trim().ToString(), TenNV.Trim().ToString(), DiaChi.Trim().ToString(), SdtNV.Trim().ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool sua(string MaNV, string TenNV, string DiaChi, string SdtNV)
        {
            try
            {
                nvd.update(MaNV.Trim().ToString(), TenNV.Trim().ToString(), DiaChi.Trim().ToString(), SdtNV.Trim().ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoa(string MaNV)
        {
            try
            {
                nvd.delete(MaNV.Trim().ToString());
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
            dt = nvd.gridviewcome();
            return dt;
        }

        public DataTable loadgridviewdel()
        {
            DataTable dt = new DataTable();
            dt = nvd.gridviewcomedelnhanvien();
            return dt;
        }

        public void ngatkn()
        {
            nvd.ngatkn();
        }

        //public string getNextID()
        //{
        //    string MaNV = nvd.nextID();
        //    if (MaNV == "") return "1811061038";
        //    int so = int.Parse(MaNV.Substring(8)) + 1;
        //    string ma = "181106103";
        //    if (so < 10)
        //        ma = "181106103";
        //    else
        //    {
        //        if (so < 100)
        //            ma = "1811061";
        //        else
        //        {
        //            if (so < 1000)
        //                ma = "181106";
        //        }
        //    }
        //    return ma + so.ToString();
        }
    }