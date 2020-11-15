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
    class TimNGKDL
    {
        KetNoi kn = new KetNoi(frmDangnhap.tenmay);

        public void ngatkn()
        {
            kn.disconnect();
        }

        public DataTable gridviewcome()
        {
            DataTable mytable = new DataTable();
            mytable = kn.laybangNGKchodgv();
            return mytable;
        }

        public DataTable SearchtenNGKProtocol(string keyword)
        {
            string query = "select MaNGK as N'Mã Nước Khát', TenNGK as N'Tên Giải Khát', MaNhaCungUng as N'Mã Nhà Cung Ứng', SoLuong as N'Số Lượng', MaLoaiNGK as N'Mã Loại Nước Giải Khát' from NGK where Daxoa=0 and TenNGK like N" + "'" + "%" + keyword + "%" + "'";
            DataTable dt = kn.gettable(query);
            return dt;
        }

        public DataTable SearchtenLNGKProtocol(string keyword, string MaLoaiNGK)
        {
            string query = "select MaNGK as N'Mã Nước Giải Khát', TenNGK as N'Tên Nước Giải Khát', MaNhaCungUng as N'Mã Nhà Cung Ứng', SoLuong as N'Số Lượng', MaLoaiNGK as N'Mã Loại Nước Giải Khát' from NGK where Daxoa=0 and TenNGK like N" + "'" + "%" + keyword + "%" + "' " + "and MaLoaiNGK=N'" + MaLoaiNGK + "'";
            DataTable dt = kn.gettable(query);
            return dt;
        }
        
        public DataTable SearchtenNCUProtocol(string keyword, string MaNhaCungUng)
        {
            string query = "select MaNGK as N'Mã Nước Giải Khát', TenNGK as N'Tên Nước Giải Khát', MaNhaCungUng as N'Mã Nhà Cung Ứng', SoLuong as N'Số Lượng', MaLoaiNGK as N'Mã Loại Nước Giải Khát' from NGK where Daxoa=0 and TneNGK like N" + "'" + "%" + keyword + "%" + "' " + "and MaNhaCungUng=N'" + MaNhaCungUng + "'";
            DataTable dt = kn.gettable(query);
            return dt;
        }
        
        public DataTable ncucome()
        {
            string query = "select * from NhaCungUng where Daxoa=0";
            DataTable dt = kn.gettable(query);
            return dt;
        }

        public DataTable loaiNGKcome()
        {
            string query = "select * from LoaiNGK where Daxoa=0";
            DataTable dt = kn.gettable(query);
            return dt;
        }
    }
}