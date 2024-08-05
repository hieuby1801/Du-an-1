using PhanMemQLTraSua.DAL;
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
    public partial class FrmQLSanPham : Form
    {
        private bool them = true;
        public FrmQLSanPham()
        {
            InitializeComponent();
            LoadDSSanPham();
            txtMaSP.ReadOnly = true;
            txtTenSP.ReadOnly = true;
            txtSLTonKho.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtMaNhomSP.ReadOnly = true;
            dataGridViewSP.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa2.Enabled = false;
        }

        void LoadDSSanPham()
        {
            dataGridViewSP.DataSource = SanPhamDAL.Instance.DSSanPham();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            txtMaSP.ReadOnly = true;
            txtTenSP.ReadOnly = true;
            txtSLTonKho.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtMaNhomSP.ReadOnly = true;
            dataGridViewSP.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa2.Enabled = true;
            btnThem.Enabled = false;
            btnCapNhat.Enabled = false; 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            txtMaSP.ReadOnly = true;
            txtTenSP.ReadOnly = false;
            txtSLTonKho.ReadOnly = false;
            txtDonGia.ReadOnly = false;
            txtMaNhomSP.ReadOnly = false;
            dataGridViewSP.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa2.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoa1.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            them = false;
            txtMaSP.ReadOnly = true;
            txtTenSP.ReadOnly = false;
            txtSLTonKho.ReadOnly = false;
            txtDonGia.ReadOnly = false;
            txtMaNhomSP.ReadOnly = false;
            dataGridViewSP.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa2.Enabled = false;
            btnThem.Enabled = false;
            btnXoa1.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        void LamMoi()
        {
            txtDonGia.Text = "";
            txtMaNhomSP.Text = "";
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSLTonKho.Text = "";
            txtMaSP.ReadOnly = true;
            txtTenSP.ReadOnly = true;
            txtSLTonKho.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtMaNhomSP.ReadOnly = true;
            dataGridViewSP.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa2.Enabled = false;
            btnXoa1.Enabled = true;
            btnThem.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenSP = txtTenSP.Text;
            int donGia = Convert.ToInt16(txtDonGia.Text);
            int slTonKho;
            try
            {
                slTonKho = Convert.ToInt16(txtSLTonKho.Text);
            }
            catch
            {
                slTonKho = 0;
            }
            int maNhomSP = Convert.ToInt16(txtMaNhomSP.Text);
            if (them)
                ThemSanPham(tenSP, slTonKho, donGia, maNhomSP);
            else
            {
                int maSP = Convert.ToInt16(txtMaSP.Text);
                SuaSanPham(maSP, tenSP, slTonKho, donGia, maNhomSP);
            }
            LoadDSSanPham();
            LamMoi();
        }

        void ThemSanPham(string tenSP, int slTonKho, int donGia, int maNhomSP)
        {
            SanPhamDAL.Instance.ThemSanPham(tenSP, slTonKho, donGia, maNhomSP);
        }

        void SuaSanPham(int maSP, string tenSP, int slTonKho, int donGia, int maNhomSP)
        {
            SanPhamDAL.Instance.SuaSanPham(maSP, tenSP, slTonKho, donGia, maNhomSP);
        }

        private void dataGridViewSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSP.Rows[e.RowIndex];

                // Gán giá trị từng ô của dòng vào TextBox tương ứng
                txtMaSP.Text = row.Cells[0].Value.ToString(); // Giả sử ô đầu tiên gán vào textBox1
                txtTenSP.Text = row.Cells[1].Value.ToString(); // Ô thứ hai gán vào textBox2
                txtSLTonKho.Text = row.Cells[2].Value.ToString();
                txtDonGia.Text = row.Cells[3].Value.ToString();
                txtMaNhomSP.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            int maSP = Convert.ToInt32(txtMaSP.Text);
            XoaSanPham(maSP);
            LoadDSSanPham();
        }

        void XoaSanPham(int maSP)
        {
            SanPhamDAL.Instance.XoaSanPham(maSP);
        }
    }
}
