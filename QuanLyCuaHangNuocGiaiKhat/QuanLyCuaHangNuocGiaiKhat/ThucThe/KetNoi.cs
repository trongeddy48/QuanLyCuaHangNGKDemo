using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;

namespace QuanLyCuaHangNuocGiaiKhat.ThucThe
{
    class KetNoi
    {
        public SqlConnection conn;
        string cn = "";
        public static bool connectstat = true;
        string Tenmay = Dns.GetHostName();

        public KetNoi(string tenmay)
        {
            Tenmay = tenmay;
            cn = "Data Source="+ Tenmay + ";Initial Catalog=QLNN;Integrated Security=True";
            try
            {
                conn = new SqlConnection(cn);
                conn.Open();
                //connectstat = true;
            }
            catch
            {
                MessageBox.Show("Không Thể Kết Nối Đến Server!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connectstat = false;
            }

        }        

        public void disconnect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }

        public void justexcute(SqlCommand cmd)
        {
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
        }

        public DataTable laybangNGKchodgv()
        {
            string sql = "select a.MaNGK, a.TenNGK, a.MaNhaCungUng, a.MaLoaiNGK, a.SoLuong from NGK a, NhaCungUng b where a.MaNhaCungUng = b.MaNhaCungUng";
            DataTable dt = new DataTable();
            dt = gettable(sql);
            return dt;
        }

        public DataTable laybangNGKchodgvXoaNGK()
        {
            string sql = "select MaNGK as N'Mã Nước Giải Khát', TenNGK as N'Tên Nước Giải Khát', MaNhaCungUng as N'Mã Nhà Cung Ứng', SoLuong as N'Số Lượng', Daxoa as N'Đã Xóa' from NGK";
            DataTable dt = new DataTable();
            dt = gettable(sql);
            return dt;
        }

        public DataTable laybangKhachHangchodgv()
        {
            string sql = "select a.MaKH, a.TenKH, a.DiaChiKH, a.SdtKH from KhachHang a";
            DataTable dt = new DataTable();
            dt = gettable(sql);
            return dt;
        }
        
        public DataTable laybangKhachHangchodgvXoaKH()
        {
            string sql = "select MaKH as N'Mã Khách Hàng', TenKH as N'Tên Khách Hàng', DiaChiKH as N'Địa Chỉ', SdtKH as N'Số Điện Thọai', Daxoa as N'Đã Xóa' from KhachHang";
            DataTable dt = new DataTable();
            dt = gettable(sql);
            return dt;
        }

        public DataTable laybangNhanVienchodgv()
        {
            string sql = "select MaNV as N'Mã Nhân Viên', TenNV as N'Tên Nhân Viên', DiaChi as N'Địa Chỉ', SdtNV as N'Số Điện Thọai' from nhanvien where Daxoa=0";
            DataTable dt = new DataTable();
            dt = gettable(sql);
            return dt;
        }

        public DataTable laybangNhanVienchodgvXoaNV()
        {
            string sql = "select MaNV as N'Mã Nhân Viên', TenNV as N'Tên Nhân Viên', DiaChi as N'Địa Chỉ', SdtNV as N'Số Điện Thọai', Daxoa as N'Đã Xóa' from nhanvien";
            DataTable dt = new DataTable();
            dt = gettable(sql);
            return dt;
        }

        public DataTable laybangLoaiNGKchodgv()
        {
            string sql = "select MaLoaiNGK as N'Mã Lọai Nước Giải Khát', TenLoaiNGK as N'Tên Lọai Nước Giải Khát', Daxoa as N'Đã Xóa' from LoaiNGK";
            DataTable dt = new DataTable();
            dt = gettable(sql);
            return dt;
        }
                
        public DataTable laybangNhaCUchodgv()
        {
            string sql = "select MaNhaCungUng as N'Mã Nhà Cung Ứng', TenNhaCungUng as N'Tên Nhà Cung Ứng', DiaChiNhaCungUng as N'Địa Chỉ', SdtNhaCungUng as N'Số Điện Thọai', Daxoa as N'Đã Xóa' from NhaCungUng";
            DataTable dt = new DataTable();
            dt = gettable(sql);
            return dt;
        }
        public DataTable laybangPhieuHenchodgv(string MaNV)
        {
            string sql = "select a.SoPhieuHen, a.MaKH, a.MaNV, a.NgayLapPhieuHen from PhieuHen a";
            DataTable dt = new DataTable();
            dt = gettable(sql);
            return dt;
        }

        public DataTable bangKhachHangchorpt(string MaNV)
        {
            string sql = "select MaKH, TenKH, DiaChiKH, SdtKH from KhachHang";
            DataTable dt = new DataTable();
            dt = gettable(sql);
            return dt;
        }

        public DataTable bangNhanVienchorpt(string MaNV)
        {
            string sql = "select MaNV, TenNV, DiaChi, SdtNV from nhanvien";
            DataTable dt = new DataTable();
            dt = gettable(sql);
            return dt;
        }

        public DataTable laybangChiTietPHchodgv(string MaNV)
        {
            string sql = "select SoChiTietPhieuHen as N'Số Chi Tiết Phiếu Hẹn', ctph.SoPhieuHen as N'Số Phiếu Hẹn', MaNGK as N'Mã Nước Giải Khát', TenNGK as N'Tên Nước Giải Khát' from ChiTietPhieuHen ctph, PhieuHen ph where ctph.SoPhieuHen = ph.SoPhieuHen and ph.MaNV='" + MaNV + "'";
            DataTable dt = new DataTable();
            dt = gettable(sql);
            return dt;
        }
        public DataTable laybangHoaDonchodgv(string MaNV)
        {
            string sql = "select a.SoHoaDon, a.MaKH, a.MaNV, a.NgayLapHoaDon, a.trangthai from HoaDon a";
            DataTable dt = new DataTable();
            dt = gettable(sql);
            return dt;
        }

        public DataTable gettablectpmforgridview(string MaNV)
        {
            string sql = "select SoChiTietHoaDon as N'Số Chi Tiết Hóa Đơn', cthd.SoHoaDon as N'Số Hóa Đơn', MaNGK as N'Mã Nước Giải Khát', TenNGK as N'Tên Nước Giải Khát', SoLuong as N'Số Lượng' from ChiTietHoaDon cthd, HoaDon hd where cthd.SoHoaDon = hd.SoHoaDon and hd.manv='" + MaNV + "'";
            DataTable dt = new DataTable();
            dt = gettable(sql);
            return dt;
        }              

        public DataTable gettable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
