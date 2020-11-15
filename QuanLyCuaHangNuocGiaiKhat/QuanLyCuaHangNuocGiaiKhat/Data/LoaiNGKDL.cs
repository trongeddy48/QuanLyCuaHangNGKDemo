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
    class LoaiNGKDL
    {
        KetNoi kn = new KetNoi(frmDangnhap.tenmay);

        public void insert(string MaLoaiNGK, string TenLoaiNGK)
        {
            string sql = "insert into LoaiNGK values('" + MaLoaiNGK + "', N'" + TenLoaiNGK + "', '" + 0 + "')";

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

        public void update(string MaLoaiNGK, string TenLoaiNGK)
        {
            string sql = "update LoaiNGK set TenLoaiNGK=N'" + TenLoaiNGK + "'" + "where mals='" + MaLoaiNGK + "'";

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

        public void delete(string MaLoaiNGK)
        {
            string sql = "update LoaiNGK set Daxoa='" + 1 + "' where MaLoaiNGK='" + MaLoaiNGK + "'";

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
            string query = "select max(MaLoaiNGK) from LoaiNGK";
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
            mytable = kn.laybangLoaiNGKchodgv();
            return mytable;
        }
    }
}
