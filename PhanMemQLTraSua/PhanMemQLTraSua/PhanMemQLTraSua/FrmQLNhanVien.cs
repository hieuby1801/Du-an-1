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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhanMemQLTraSua
{
    public partial class FrmQLNhanVien : Form
    {
        private bool them = true;
        public FrmQLNhanVien()
        {
            InitializeComponent();
            LoadDSNhanVien();
            txtMaNV.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtHoTen.ReadOnly = true;
            txtTinhTrang.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtVaiTro.ReadOnly = true;
            txtMK.ReadOnly = true;
            btnLuu.Enabled = false;
            btnXoa2.Enabled = false;
            dataGridViewNhanVien.Enabled = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void LoadDSNhanVien()
        {
            dataGridViewNhanVien.DataSource = NhanVienDAL.Instance.DSNhanVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tblPnlDataEntry_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string sdt = txtSDT.Text;
            string tenNV = txtHoTen.Text;
            int tinhTrang = Convert.ToInt16(txtTinhTrang.Text);
            string diaChi = txtDiaChi.Text;
            int vaiTro = Convert.ToInt16(txtVaiTro.Text);   
            string matKhau = txtMK.Text;
            if (them)
                ThemNhanVien(maNV, sdt, tenNV, tinhTrang, diaChi, vaiTro, matKhau);
            else
                SuaNhanVien(maNV, sdt, tenNV, tinhTrang, diaChi, vaiTro, matKhau);
            LoadDSNhanVien();
            LamMoi();
        }

        void ThemNhanVien(string maNV, string sdt, string tenNV, int tinhTrang, string diaChi, int vaiTro, string matKhau)
        {
            NhanVienDAL.Instance.ThemNhanVien(maNV, sdt, tenNV, tinhTrang, diaChi, vaiTro, matKhau);
        }

        void SuaNhanVien(string maNV, string sdt, string tenNV, int tinhTrang, string diaChi, int vaiTro, string matKhau)
        {
            NhanVienDAL.Instance.SuaNhanVien(maNV, sdt, tenNV, tinhTrang, diaChi, vaiTro, matKhau);
        }

        void XoaNhanVien(string maNv)
        {
            NhanVienDAL.Instance.XoaNhanVien(maNv);
        }
        void LamMoi()
        {
            txtMaNV.Text = "";
            txtSDT.Text = "";
            txtHoTen.Text = "";
            txtTinhTrang.Text = "";
            txtDiaChi.Text = "";
            txtVaiTro.Text = "";
            txtMK.Text = "";
            txtMaNV.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtHoTen.ReadOnly = true;
            txtTinhTrang.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtVaiTro.ReadOnly = true;
            txtMK.ReadOnly = true;
            btnLuu.Enabled = false;
            btnXoa2.Enabled = false;
            dataGridViewNhanVien.Enabled = false;
            btnXoa1.Enabled = true;
            btnThem.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewNhanVien.Rows[e.RowIndex];

                // Gán giá trị từng ô của dòng vào TextBox tương ứng
                txtMaNV.Text = row.Cells[1].Value.ToString(); // Giả sử ô đầu tiên gán vào textBox1
                txtSDT.Text = row.Cells[2].Value.ToString(); // Ô thứ hai gán vào textBox2
                txtHoTen.Text = row.Cells[3].Value.ToString();
                txtTinhTrang.Text = row.Cells[4].Value.ToString();
                txtDiaChi.Text = row.Cells[5].Value.ToString();
                txtVaiTro.Text = row.Cells[6].Value.ToString();
                txtMK.Text = row.Cells[7].Value.ToString();// Ô thứ ba gán vào textBox3
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            txtMaNV.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtHoTen.ReadOnly = false;
            txtTinhTrang.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtVaiTro.ReadOnly = false;
            txtMK.ReadOnly = false;
            btnLuu.Enabled = true;
            btnXoa2.Enabled = false;
            dataGridViewNhanVien.Enabled = true;
            btnXoa1.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            them = false;
            txtMaNV.ReadOnly = true;
            txtSDT.ReadOnly = false;
            txtHoTen.ReadOnly = false;
            txtTinhTrang.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtVaiTro.ReadOnly = false;
            txtMK.ReadOnly = false;
            btnLuu.Enabled = true;
            btnXoa2.Enabled = false;
            dataGridViewNhanVien.Enabled = true;
            btnXoa1.Enabled = false;
            btnThem.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtHoTen.ReadOnly = true;
            txtTinhTrang.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtVaiTro.ReadOnly = true;
            txtMK.ReadOnly = true;
            btnLuu.Enabled = false;
            btnCapNhat.Enabled = false;
            btnThem.Enabled = false;
            btnXoa2.Enabled = true;
            dataGridViewNhanVien.Enabled=true;
            
        }

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            XoaNhanVien(txtMaNV.Text);
            LoadDSNhanVien();

        }
    }
}
