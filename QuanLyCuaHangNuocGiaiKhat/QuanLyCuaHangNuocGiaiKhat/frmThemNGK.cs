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
    public partial class frmThemNGK : Form
    {
        public frmThemNGK()
        {
            InitializeComponent();
        }

        NGKCL nbl = new NGKCL();

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridViewThemNGK_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMaNGK.Text = dgvThemnuoc.Rows[row].Cells[0].Value.ToString();
            txtTenNGK.Text = dgvThemnuoc.Rows[row].Cells[1].Value.ToString();
            cboManhacu.Text = dgvThemnuoc.Rows[row].Cells[2].Value.ToString();
            txtSoluong.Text = dgvThemnuoc.Rows[row].Cells[4].Value.ToString();
            cboLoaiNGK.Text = dgvThemnuoc.Rows[row].Cells[3].Value.ToString();
            //cboLoaiNGK.SelectedValue = dgvThemnuoc.Rows[row].Cells[4].Value.ToString();
        }

        private void Setcontrol(bool stats)
        {
            txtMaNGK.Enabled = stats;
            txtTenNGK.Enabled = stats;
            cboManhacu.Enabled = stats;
            cboLoaiNGK.Enabled = stats;
            cboManhacu.Enabled = stats;
            txtSoluong.Enabled = stats;
            btnLuu.Enabled = stats;
            btnThem.Enabled = !stats;
            btnHuythem.Enabled = stats;
        }

        private void Resetcontrol()
        {
            txtMaNGK.Text = "";
            txtTenNGK.Text = "";
            txtSoluong.Text = "";
            GetloaiNGK();
            Getncu();
        }        

        private void Getncu()
        {            
            cboManhacu.ValueMember = "MaNhaCungUng";
            cboManhacu.DataSource = nbl.loadcbncu();
        }

        private void GetloaiNGK()
        {
            cboLoaiNGK.DisplayMember = "TenLoaiNGK";
            cboLoaiNGK.ValueMember = "MaLoaiNGK";
            cboLoaiNGK.DataSource = nbl.loadcbloaingk();
        }

        private void ResetGridview()
        {
            dgvThemnuoc.DataSource = null;
            dgvThemnuoc.DataSource = nbl.loadgridview();
        }

        private void ThemNGK_Form_Load(object sender, EventArgs e)
        {

            ResetGridview();
            Setcontrol(false);
            GetloaiNGK();
            Getncu();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Setcontrol(true);
            txtMaNGK.Text = "NGK0";
            txtTenNGK.Text = "";
            cboManhacu.Text = "";
            cboLoaiNGK.Text = "";
            txtSoluong.Text = "";
            //txtMaNGK.Text = nbl.getNextID();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (nbl.them(txtMaNGK.Text, txtTenNGK.Text, cboManhacu.SelectedValue.ToString(), txtSoluong.Text, cboLoaiNGK.SelectedValue.ToString()) == true)
            {
                MessageBox.Show("Thêm NGK Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Setcontrol(false);
                Resetcontrol();
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Thêm NGK Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuythem_Click_1(object sender, EventArgs e)
        {
            Setcontrol(false);
            Resetcontrol();
        }

        private void btnaddtheloai_Click_1(object sender, EventArgs e)
        {
            frmLoaiNGK lnf = new frmLoaiNGK();
            lnf.Show();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            frmNhaCU ncuf = new frmNhaCU();
            ncuf.Show();
        }       
    }
}
