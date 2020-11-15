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
    public partial class frmChiTietPhieuHen : Form
    {
        public frmChiTietPhieuHen()
        {
            InitializeComponent();
        }

        CTPhieuHenCL ctphb = new CTPhieuHenCL();

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Setcontrol(bool stats)
        {
            cboMaPH.Enabled = stats;
            cboMaNGK.Enabled = stats;
            txtSoluong.Enabled = stats;
            btnthem.Enabled = !stats;
            btnhuythem.Enabled = stats;
            btnsave.Enabled = stats;
        }

        private void Resetcontrol()
        {
            txtSoluong.Text = "";
            cboMaPH.Text = "";
            cboMaNGK.Text = "";
            GetPhieuHen();
            GetNGK();
        }

        private void GetPhieuHen()
        {
            cboMaPH.DisplayMember = "SoPhieuHen";
            cboMaPH.ValueMember = "SoPhieuHen";
            cboMaPH.DataSource = ctphb.loadcbpm(frmDangnhap.tendangnhap);
        }

        private void GetNGK()
        {
            cboMaNGK.DisplayMember = "MaNGK";
            cboMaNGK.ValueMember = "MaNGK";
            cboMaNGK.DataSource = ctphb.loadcbNGK();

        }

        private void GettenNGK()
        {
            txttenNGK.Text = ctphb.loadtxttenNGK(cboMaNGK.SelectedValue.ToString()).ToString();
        }

        private void ResetGridview()
        {
            GridViewCTPM.DataSource = null;
            GridViewCTPM.DataSource = ctphb.loadgridview(frmDangnhap.tendangnhap);
        }

        private void ChiTietPhieuHen_Form_Load(object sender, EventArgs e)
        {
            ResetGridview();
            Setcontrol(false);
            GetNGK();
            GetPhieuHen();
            GettenNGK();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            Setcontrol(true);
            txtmactph.Text = ctphb.getNextID();
        }

        private void btnhuythem_Click_1(object sender, EventArgs e)
        {
            Setcontrol(false);
            Resetcontrol();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            if (ctphb.them(txtmactph.Text, cboMaPH.SelectedValue.ToString(), cboMaNGK.SelectedValue.ToString(), txttenNGK.Text, txtSoluong.Text) == true)
            {
                MessageBox.Show("Lập Chi Tiết Phiếu Hẹn Thành Công", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Setcontrol(false);
                Resetcontrol();
                ResetGridview();
            }
            else
            {
                MessageBox.Show("Lập Chi Tiết Phiếu Hẹn Thất Bại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbbmasach_SelectedIndexChanged(object sender, EventArgs e)
        {
            GettenNGK();
        }        
    }
}
