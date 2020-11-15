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
    class PhieuHenDL
    {
        KetNoi kn = new KetNoi(frmDangnhap.tenmay);

        public void insert(string SoPhieuHen, string MaKH, string MaNV, string NgayLapPhieuHen)
        {
            /*string ngaytra = "0/0/0000";*/
            string sql = "insert into PhieuHen values('" + SoPhieuHen + "', '" + MaKH + "', '" + MaNV + "', '" + NgayLapPhieuHen + "', '" + 0 + "')";

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
            string query = "select max(SoPhieuHen) from PhieuHen";
            DataTable dt = kn.gettable(query);
            return dt.Rows[0][0].ToString();

        }

        public void ngatkn()
        {
            kn.disconnect();
        }

        public DataTable gridviewcome(string MaNV)
        {
            DataTable mytable = new DataTable();
            mytable = kn.laybangPhieuHenchodgv(MaNV);
            return mytable;
        }

        public DataTable khachhangcome()
        {
            string query = "select a.MaKH from KhachHang a";
            DataTable dt = kn.gettable(query);
            return dt;
        }
    }
}
