using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using QuanLyCuaHangNuocGiaiKhat.Models;

namespace QuanLyCuaHangNuocGiaiKhat
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        HoaDonDB db = new HoaDonDB();    

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                HoaDonDB db = new HoaDonDB();
                List<HoaDon> ListHD = db.HoaDons.ToList();
                BindGrird(ListHD);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
        private void BindGrird(List<HoaDon> ListOrder)
        {
            GridViewPM.Rows.Clear();
            foreach (var item in ListOrder)
            {
                int index = GridViewPM.Rows.Add();
                GridViewPM.Rows[index].Cells[0].Value = item.SoHoaDon;
                GridViewPM.Rows[index].Cells[1].Value = item.MaKH;
                GridViewPM.Rows[index].Cells[2].Value = item.MaNV;
                GridViewPM.Rows[index].Cells[3].Value = item.NgayLapHoaDon;
            }
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            HoaDonDB db = new HoaDonDB();
            if (txtmapm.Text == "" || txtMakh.Text == "" || txtnhanvien.Text == "" || txtNgaylapHD.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!");
            }
            else
            {
                HoaDon st = db.HoaDons.FirstOrDefault(f => f.SoHoaDon == txtmapm.Text);
                if (txtMakh.Text.Length > 10 || txtMakh.Text.Length < 10)
                {
                    MessageBox.Show("Mã Khách Hàng phải đủ 10 ký tự!");
                }
                else
                {
                    
                    HoaDon s = new HoaDon() { SoHoaDon = txtmapm.Text, MaKH = txtMakh.Text, MaNV = txtnhanvien.Text, NgayLapHoaDon = txtNgaylapHD.Text };
                    db.HoaDons.Add(s);
                    db.SaveChanges();
                    List<HoaDon> listHoaDon = db.HoaDons.ToList();
                    BindGrird(listHoaDon);
                    MessageBox.Show("Thêm thành công !", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void GridViewPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtmapm.Text = GridViewPM.Rows[index].Cells[0].Value.ToString();
            txtMakh.Text = GridViewPM.Rows[index].Cells[1].Value.ToString();
            txtnhanvien.Text = GridViewPM.Rows[index].Cells[2].Value.ToString();
            txtNgaylapHD.Text = GridViewPM.Rows[index].Cells[3].Value.ToString();
        }        
    }
}