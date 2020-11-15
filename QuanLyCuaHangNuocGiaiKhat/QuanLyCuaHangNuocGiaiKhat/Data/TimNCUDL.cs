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
    class TimNCUDL
    {
        KetNoi kn = new KetNoi(frmDangnhap.tenmay);

        public void ngatkn()
        {
            kn.disconnect();
        }

        public DataTable SearchtenLoaiNGKProtocol(string keyword)
        {
            string query = "select MaLoaiNGK as N'Mã Lọai NGK', TenLoaiNGK as N'Tên Lọai NGK' from LoaiNGK where Daxoa=0 and TenLoaiNGK like N" + "'" + "%" + keyword + "%" + "'";
            DataTable dt = kn.gettable(query);
            return dt;
        }       

        public DataTable SearchtenNCUProtocol(string keyword)
        {
            string query = "select MaNhaCungUng as N'Mã Nhà Cung Ứng', TenNhaCungUng as N'Tên Nhà Cung Ứng', DiaChiNhaCungUng as N'Địa Chỉ', SdtNhaCungUng as N'Số Điện Thọai' from NhaCungUng where Daxoa=0 and TenNhaCungUng like N" + "'" + "%" + keyword + "%" + "'";
            DataTable dt = kn.gettable(query);
            return dt;
        }
    }
}
