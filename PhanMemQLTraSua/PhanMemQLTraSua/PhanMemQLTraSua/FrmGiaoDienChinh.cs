using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQLTraSua
{
    public partial class FrmGiaoDienChinh : Form
    {
        public FrmGiaoDienChinh()
        {
            InitializeComponent();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            FrmHoaDon frmHD = new FrmHoaDon();
            this.Hide();
            frmHD.ShowDialog();
            this.Show();
        }

        private void FrmGiaoDienChinh_Load(object sender, EventArgs e)
        {
            lblHi.Text += FrmDangNhap.maNV;
            if (FrmDangNhap.vaiTro == 0)
            {
                btnNhanVien.Enabled = false;
                btnSanPham.Enabled = false;
                btnThongKe.Enabled = false; 
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FrmQLNhanVien frmQLNhanVien = new FrmQLNhanVien();
            this.Hide();
            frmQLNhanVien.ShowDialog(); 
            this.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            FrmQLSanPham frmSP = new FrmQLSanPham();
            this.Hide();
            frmSP.ShowDialog();
            this.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FrmThongKe frmTK = new FrmThongKe();
            this.Hide();
            frmTK.ShowDialog();
            this.Show();
        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            FrmLienHe frmLH = new FrmLienHe();
            this.Hide();
            frmLH.ShowDialog();
            this.Show();
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            FrmHuongDan frmHD = new FrmHuongDan();
            this.Hide();
            frmHD.ShowDialog();
            this.Show();
        }
    }
}
