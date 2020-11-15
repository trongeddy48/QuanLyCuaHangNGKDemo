using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyCuaHangNuocGiaiKhat.ThucThe;

namespace QuanLyCuaHangNuocGiaiKhat.Data
{
    class TimPhieuHenDL
    {
        KetNoi kn = new KetNoi(frmDangnhap.tenmay);

        public void ngatkn()
        {
            kn.disconnect();
        }

        public DataTable gridviewcome(string MaNV)
        {
            DataTable mytable = new DataTable();
            mytable = kn.laybangPhieuHenchodgv(MaNV);
            return mytable;
        }

        public DataTable Khachhangcome(string MaNV)
        {
            string query = "select distinct ph.MaKH from KhachHang kh, PhieuHen ph where kh.MaKH=ph.MaKH and Daxoa=0 and ph.MaNV='" + MaNV + "'";
            DataTable dt = kn.gettable(query);
            return dt;
        }

        public DataTable SearchtheoNgay(string MaNV, string NgayLapPhieuHen)
        {
            string query = "select SoPhieuHen as N'Số Phiếu Hẹn', MaKH as N'Mã Khách Hàng', MaNV as N'Mã Nhân Viên', NgayLapPhieuHen as N'Ngày Lập Phiếu Hẹn', trangthai as N'Trạng Thái' from PhieuHen where MaNV='" + MaNV + "' and NgayLapPhieuHen='" + NgayLapPhieuHen + "'";
            DataTable dt = kn.gettable(query);
            return dt;
        }

        public DataTable SearchtheoMasv(string MaNV, string MaKH)
        {
            string query = "select SoPhieuHen as N'Số Phiếu Hẹn', MaKH as N'Mã Khách Hàng', MaNV as N'Mã Nhân Viên', NgayLapPhieuHen as N'Ngày Lập Phiếu Hẹn', trangthai as N'Trạng Thái' from PhieuHen where MaNV='" + MaNV + "' and MaKH='" + MaKH + "'";
            DataTable dt = kn.gettable(query);
            return dt;
        }
    }
}
