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
    
        class NhaCungUngDL
        {
            KetNoi kn = new KetNoi(frmDangnhap.tenmay);

            public void insert(string MaNhaCungUng, string TenNhaCungUng, string DiaChiNhaCungUng, string SdtNhaCungUng)
            {
                string sql = "insert into NhaCungUng values('" + MaNhaCungUng + "', N'" + TenNhaCungUng + "', N'" + DiaChiNhaCungUng + "', '" + SdtNhaCungUng + "', '" + 0 + "')";

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

            public void update(string MaNhaCungUng, string TenNhaCungUng, string DiaChiNhaCungUng, string SdtNhaCungUng)
            {
                string sql = "update NhaCungUng set TenNhaCungUng=N'" + TenNhaCungUng + "', DiaChiNhaCungUng=N'" + DiaChiNhaCungUng + "', SdtNhaCungUng='" + SdtNhaCungUng + "' " + "where MaNhaCungUng='" + MaNhaCungUng + "'";

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

            public void delete(string MaNhaCungUng)
            {
                string sql = "update NhaCungUng set Daxoa='" + 1 + "' where MaNhaCungUng='" + MaNhaCungUng + "'";

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
                string query = "select max(MaNhaCungUng) from NhaCungUng";
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
                mytable = kn.laybangNhaCUchodgv();
                return mytable;
            }
        }
    }