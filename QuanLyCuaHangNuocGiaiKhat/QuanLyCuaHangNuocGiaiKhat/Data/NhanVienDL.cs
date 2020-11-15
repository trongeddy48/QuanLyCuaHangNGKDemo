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
    class NhanVienDL
    {
        KetNoi kn = new KetNoi(frmDangnhap.tenmay);

        public void insert(string MaNV, string TenNV, string DiaChi, string SdtNV)
        {
            string sql = "insert into nhanvien values('" + MaNV + "', N'" + TenNV + "', N'" + DiaChi + "', '" + SdtNV + "', '" + 0 + "')";

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

        public void update(string MaNV, string TenNV, string DiaChi, string SdtNV)
        {
            string sql = "update nhanvien set TenNV=N'" + TenNV + "', DiaChi=N'" + DiaChi + "', SdtNV='" + SdtNV + "', Daxoa='" + 0 + "'" + "where MaNV='" + MaNV + "'";

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

        public void delete(string MaNV)
        {
            string sql = "update nhanvien set Daxoa='" + 1 + "' where MaNV='" + MaNV + "'";

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
            string query = "select max(MaNV) from nhanvien";
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
            mytable = kn.laybangNhanVienchodgv();
            return mytable;
        }

        public DataTable gridviewcomedelnhanvien()
        {
            DataTable mytable = new DataTable();
            mytable = kn.laybangNhanVienchodgvXoaNV();
            return mytable;
        }
    }
}
