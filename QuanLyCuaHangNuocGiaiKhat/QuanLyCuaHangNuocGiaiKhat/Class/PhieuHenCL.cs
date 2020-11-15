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
    class PhieuHenCL
    {
        PhieuHenDL phd = new PhieuHenDL();

        public bool them(string SoPhieuHen, string MaKH, string MaNV, string NgayLapPhieuHen)
        {
            try
            {
                phd.insert(SoPhieuHen.Trim().ToString(), MaKH.Trim().ToString(), MaNV.Trim().ToString(), NgayLapPhieuHen.Trim().ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable loadgridview(string MaNV)
        {
            DataTable dt = new DataTable();
            dt = phd.gridviewcome(MaNV.Trim().ToString());
            return dt;
        }

        public DataTable loadcbkh()
        {
            DataTable dt = new DataTable();
            dt = phd.khachhangcome();
            return dt;
        }

        //public string getNextID()
        //{
        //    string SoPhieuHen = phd.nextID();
        //    if (SoPhieuHen == "") return "SPH001";
        //    int so = int.Parse(SoPhieuHen.Substring(2)) + 1;
        //    string ma = "SPH00";
        //    if (so < 10)
        //        ma = "SPH00";
        //    else
        //    {
        //        if (so < 100)
        //            ma = "SPH0";
        //        else
        //        {
        //            if (so < 1000)
        //                ma = "SPH";
        //        }
        //    }
        //    return ma + so.ToString();

        }
    }
