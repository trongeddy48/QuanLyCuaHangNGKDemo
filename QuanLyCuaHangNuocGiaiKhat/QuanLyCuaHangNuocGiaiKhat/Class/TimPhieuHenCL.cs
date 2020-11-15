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
    class TimPhieuHenCL
    {
        TimPhieuHenDL sph = new TimPhieuHenDL();

        public DataTable loadgridview(string MaNV)
        {
            DataTable dt = new DataTable();
            dt = sph.gridviewcome(MaNV.Trim().ToString());
            return dt;
        }

        public DataTable loadcbkhachhang(string MaNV)
        {
            DataTable dt = new DataTable();
            dt = sph.Khachhangcome(MaNV.Trim().ToString());
            return dt;
        }

        public DataTable SearchlikeDate(string MaNV, string NgayLapPhieuHen)
        {
            DataTable dt = new DataTable();
            dt = sph.SearchtheoNgay(MaNV.Trim().ToString(), NgayLapPhieuHen.Trim().ToString());
            return dt;
        }

        public DataTable SearchlikeIDKh(string MaNV, string MaKH)
        {
            DataTable dt = new DataTable();
            dt = sph.SearchtheoMasv(MaNV.Trim().ToString(), MaKH.Trim().ToString());
            return dt;
        }

        public void ngatkn()
        {
            sph.ngatkn();
        }
    }
}
