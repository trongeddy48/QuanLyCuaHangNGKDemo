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
    class TimKhachHangDL
    {
        KetNoi kn = new KetNoi(frmDangnhap.tenmay);

        public void ngatkn()
        {
            kn.disconnect();
        }

        public DataTable gridviewcome()
        {
            DataTable mytable = new DataTable();
            mytable = kn.laybangKhachHangchodgv();
            return mytable;
        }

        public DataTable SearchtenKHProtocol(string keyword)
        {
            string query = "select MaKH as N'Mã Khách Hàng', TenKH as N'Tên Khách Hàng', DiaChiKH as N'Địa Chỉ', SdtKH as N'Số Điện Thoại' from KhachHang where Daxoa=0 and TenKH like N" + "'" + "%" + keyword + "%" + "'";
            DataTable dt = kn.gettable(query);
            return dt;
        }
    }
}
