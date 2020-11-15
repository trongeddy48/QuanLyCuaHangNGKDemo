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
    class TimNhanVienDL
    {
        KetNoi kn = new KetNoi(frmDangnhap.tenmay);

        public void ngatkn()
        {
            kn.disconnect();
        }

        public DataTable gridviewcome()
        {
            DataTable mytable = new DataTable();
            mytable = kn.laybangNhanVienchodgv();
            return mytable;
        }

        public DataTable SearchTennvProtocol(string keyword)
        {
            string query = "select MaNV as N'Mã Nhân Viên', TenNV as N'Tên Nhân Viên', DiaChi as N'Địa Chỉ', SdtNV as N'Số Điện Thoại' from nhanvien where Daxoa=0 and TenNV like N" + "'" + "%" + keyword + "%" + "'";
            DataTable dt = kn.gettable(query);
            return dt;
        }
    }
}
