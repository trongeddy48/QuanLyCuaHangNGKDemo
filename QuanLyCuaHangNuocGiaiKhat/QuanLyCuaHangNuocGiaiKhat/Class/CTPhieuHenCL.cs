using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using QuanLyCuaHangNuocGiaiKhat.Data;

namespace QuanLyCuaHangNuocGiaiKhat.Class
{
    class CTPhieuHenCL
    {
        CTPhieuHenDL ctphd = new CTPhieuHenDL();

        public bool them(string SoChiTietPhieuHen, string SoPhieuHen, string MaNGK, string TenNGK, string SoLuong)
        {
            try
            {
                ctphd.insert(SoChiTietPhieuHen.Trim().ToString(), SoPhieuHen.Trim().ToString(), MaNGK.Trim().ToString(), TenNGK.Trim().ToString(), SoLuong.Trim().ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable loadgridview(string MaKH)
        {
            DataTable dt = new DataTable();
            dt = ctphd.gridviewcome(MaKH.Trim().ToString());
            return dt;
        }

        public DataTable loadcbpm(string MaKH)
        {
            DataTable dt = new DataTable();
            dt = ctphd.phieuhencome(MaKH);
            return dt;
        }

        public DataTable loadcbNGK()
        {
            DataTable dt = new DataTable();
            dt = ctphd.NGKcome();
            return dt;
        }

        public string loadtxttenNGK(string MaNGK)
        {
            string dt;
            dt = ctphd.tenNGK(MaNGK.Trim().ToString());
            return dt;
        }

        public string getNextID()
        {
            string SoChiTietPhieuHen = ctphd.nextID();
            if (SoChiTietPhieuHen == "") return "CTPH001";
            int so = int.Parse(SoChiTietPhieuHen.Substring(4)) + 1;
            string ma = "CTPH00";
            if (so < 10)
                ma = "CTPH00";
            else
            {
                if (so < 100)
                    ma = "CTPH0";
                else
                {
                    if (so < 1000)
                        ma = "CTPH";
                }
            }
            return ma + so.ToString();
        }
    }
}
