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
    class KhachHangDL
    {
        KetNoi kn = new KetNoi(frmDangnhap.tenmay);

        public void insert(string MaKH, string TenKH, string DiaChiKH, string SdtKH)
        {
            string sql = "insert into sinhvien values('" + MaKH + "', N'" + TenKH + "', N'" + DiaChiKH + "', '" + SdtKH + "', '" + 0 + "')";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, kn.conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update(string MaKH, string TenKH, string DiaChiKH, string SdtKH)
        {
            string sql = "update KhachHang set TenKH=N'" + TenKH + "', DiaChiKH=N'" + DiaChiKH + "', SdtKH='" + SdtKH + "', daxoa='" + 0 + "'" + "where MaKH='" + MaKH + "'";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, kn.conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void delete(string MaKH)
        {
            string sql = "update KhachHang set Daxoa='" + 1 + "' where MaKH='" + MaKH + "'";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, kn.conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public string nextID()
        {
            string query = "select max(MaKH) from KhachHang";
            DataTable dt = kn.gettable(query);
            return dt.Rows[0][0].ToString();

        }

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

        public DataTable gridviewcomedelkhachhang()
        {
            DataTable mytable = new DataTable();
            mytable = kn.laybangKhachHangchodgvXoaKH();
            return mytable;
        }
    }
}