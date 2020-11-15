using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangNuocGiaiKhat.Class;

namespace QuanLyCuaHangNuocGiaiKhat
{
    public partial class frmSuaNGK : Form
    {
        public frmSuaNGK()
        {
            InitializeComponent();
        }

        NGKCL sbl = new NGKCL();               

        private void Getncu()
        {
            cboNCU.DisplayMember = "TenNhaCungUng";
            cboNCU.ValueMember = "MaNhaCungUng";
            cboNCU.DataSource = sbl.loadcbncu();
        }

        private void GetloaiNGK()
        {
            cboLoaiNGK.DisplayMember = "MaLoaiNGK";
            cboLoaiNGK.ValueMember = "MaLoaiNGK";
            cboLoaiNGK.DataSource = sbl.loadcbloaingk();
        }

        private void ResetGridview()
        {
            dgvSuaNGK.DataSource = null;
            dgvSuaNGK.DataSource = sbl.loadgridview();
        }

        private void ChinhSuaNGK_Form_Load(object sender, EventArgs e)
        {
            ResetGridview();            
            GetloaiNGK();
            Getncu();
        }

        private void Gridviewupdate_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtMaNGK.Text = dgvSuaNGK.Rows[row].Cells[0].Value.ToString();
                txtTenNGK.Text = dgvSuaNGK.Rows[row].Cells[1].Value.ToString();                
                cboNCU.Text = dgvSuaNGK.Rows[row].Cells[2].Value.ToString();
                txtSoluong.Text = dgvSuaNGK.Rows[row].Cells[4].Value.ToString();
                cboLoaiNGK.Text = dgvSuaNGK.Rows[row].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }             
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (sbl.sua(txtMaNGK.Text, txtTenNGK.Text, cboNCU.SelectedValue.ToString(), txtSoluong.Text, cboLoaiNGK.SelectedValue.ToString()) == true)
            {
                MessageBox.Show("Cập Nhật Nước Giải Khát Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Cập Nhật Nước Giải Khát Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            frmNhaCU ncuf = new frmNhaCU();
            ncuf.Show();
        }

        private void btnaddLoaiNGK_Click(object sender, EventArgs e)
        {
            frmLoaiNGK lnf = new frmLoaiNGK();
            lnf.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }               
    }
}
