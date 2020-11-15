using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;
using QuanLyCuaHangNuocGiaiKhat.ThucThe;

namespace QuanLyCuaHangNuocGiaiKhat.Data
{
    class CTPhieuHenDL
    {
        KetNoi kn = new KetNoi(frmDangnhap.tenmay);

        public void insert(string SoChiTietPhieuHen, string SoPhieuHen, string MaNGK, string TenNGK, string SoLuong)
        {
            string sql = "insert into ChiTietPhieuHen values('" + SoChiTietPhieuHen + "', '" + SoPhieuHen + "', '" + MaNGK + "', '" + TenNGK + "', '" + Int32.Parse(SoLuong.ToString()) + "')";

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
            string query = "select max(SoChiTietPhieuHen) from ChiTietPhieuHen";
            DataTable dt = kn.gettable(query);
            return dt.Rows[0][0].ToString();

        }

        public void ngatkn()
        {
            kn.disconnect();
        }

        public DataTable gridviewcome(string MaKH)
        {
            DataTable mytable = new DataTable();
            mytable = kn.gettablectpmforgridview(MaKH);
            return mytable;
        }

        public DataTable phieuhencome(string MaNV)
        {
            string query = "select * from PhieuHen where MaNV='" + MaNV + "'";
            DataTable dt = kn.gettable(query);
            return dt;
        }

        public DataTable NGKcome()
        {
            string query = "select * from NGK where Daxoa=0";
            DataTable dt = kn.gettable(query);
            return dt;
        }

        public string tenNGK(string MaNGK)
        {
            string query = "select MaNGK from NGK where Daxoa=0 and MaNGK='" + MaNGK + "'";
            DataTable dt = kn.gettable(query);
            return dt.Rows[0][0].ToString();
        }
    }
}