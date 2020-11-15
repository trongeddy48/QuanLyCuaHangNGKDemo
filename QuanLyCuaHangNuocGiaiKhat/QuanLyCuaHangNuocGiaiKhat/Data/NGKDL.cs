using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangNuocGiaiKhat.ThucThe;

namespace QuanLyCuaHangNuocGiaiKhat.Data
{
    class NGKDL
    {
        KetNoi kn = new KetNoi(frmDangnhap.tenmay);

        public void insert(string MaNGK, string TenNGK, string MaNhaCungUng, int SoLuong, string MaLoaiNGK)
        {
            string sql = "insert into NGK values ('" + MaNGK + "', N'" + TenNGK + "', '" + MaNhaCungUng + "', '" + SoLuong + "', '" + MaLoaiNGK + "', '" + 0 + "')";

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

        public void update(string MaNGK, string TenNGK, string MaNhaCungUng, int SoLuong, string MaLoaiNGK)
        {
            string sql = "update NGK set TenNGK=N'" + TenNGK + "', MaNhaCungUng='" + MaNhaCungUng + "', SoLuong='" + SoLuong + "', MaLoaiNGK='" + MaLoaiNGK + "'" + "where MaNGK='" + MaNGK + "'";

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

        public void delete(string MaNGK)
        {
            string sql = "update NGK set Daxoa='" + 1 + "' where MaNGK='" + MaNGK + "'";

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
            string query = "select max(MaNGK) from NGK";
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
            mytable = kn.laybangNGKchodgv();
            return mytable;
        }

        public DataTable gridviewcomedelNGK()
        {
            DataTable mytable = new DataTable();
            mytable = kn.laybangNGKchodgvXoaNGK();
            return mytable;
        }              

        public DataTable ncucome()
        {
            string query = "select * from NhaCungUng where Daxoa=0";
            DataTable dt = kn.gettable(query);
            return dt;
        }

        public DataTable loaingkcome()
        {
            string query = "select * from LoaiNGK where Daxoa=0";
            DataTable dt = kn.gettable(query);
            return dt;
        }
    }
}
