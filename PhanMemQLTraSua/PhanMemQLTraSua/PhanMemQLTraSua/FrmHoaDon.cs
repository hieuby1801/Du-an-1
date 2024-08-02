using PhanMemQLTraSua.DAL;
using PhanMemQLTraSua.DTO;
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
    public partial class FrmHoaDon : Form
    {
        bool isUpdate = true;
        public FrmHoaDon()
        {
            InitializeComponent();
            Reset();
            LoadDS_NhomSP();
        }

        void LoadDSHD()
        {
            dataGridViewDSHD.DataSource = HoaDonDAL.Instance.DSHoaDon();
        }

        void Reset()
        {
            LoadDSHD();
            
            btnThemHD.Enabled = true;
            btnXoaHD.Enabled = false;
            tableLayoutPanel2.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetHD_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            HoaDonDAL.Instance.ThemHoaDon(FrmDangNhap.maNV);
            LoadDSHD();
        }

        private void dataGridViewDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaHD.Enabled = true;
            btnThemSP.Enabled = true;
            btnSuaSP.Enabled = true; 
            tableLayoutPanel2.Enabled = true;
            dataGridView1.Enabled = false;
            cboNhomSP.Enabled = false;
            cboSP.Enabled = false;
            dudSoLuong.Enabled = false;
            btnLuuSP.Enabled = false;
            btnResetFrmSP.Enabled = false;

            DataGridViewRow row = dataGridViewDSHD.Rows[e.RowIndex];

            string maHD = row.Cells[0].Value.ToString();
            LoadHDCT(maHD);
        }

        void LoadHDCT(string maHD)
        {
            dataGridView1.DataSource = HoaDonDAL.Instance.LoadHDCT(maHD);
        }

        void LoadDS_NhomSP()
        {
            List<NhomSP> list = NhomSPDAL.Instance.DSNhomSP();
            cboNhomSP.DataSource = list;
            cboNhomSP.DisplayMember = "tenNhomSP";
        }
        void DSSanPhamByNhom(int maNhomSP)
        {
            List<SanPham> list = SanPhamDAL.Instance.DSSanPhamByNhom(maNhomSP);
            cboSP.DataSource = list;
            cboSP.DisplayMember = "tenSP";
        }

        private void cboNhomSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            NhomSP selected = cb.SelectedItem as NhomSP;
            id = selected.MaNhomSP;

            DSSanPhamByNhom(id);
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            isUpdate = false;
            cboSP.Enabled = true;
            cboNhomSP.Enabled = true;
            dudSoLuong.Enabled = true;  
            btnLuuSP.Enabled = true;
            btnResetFrmSP.Enabled = true;
            btnSuaSP.Enabled = false;
            btnThemSP.Enabled = false;
        }

        private void btnResetFrmSP_Click(object sender, EventArgs e)
        {
            btnXoaHD.Enabled = true;
            btnThemSP.Enabled = true;
            btnSuaSP.Enabled = true;
            tableLayoutPanel2.Enabled = true;
            dataGridView1.Enabled = false;
            cboNhomSP.Enabled = false;
            cboSP.Enabled = false;
            dudSoLuong.Enabled = false;
            btnLuuSP.Enabled = false;
            btnResetFrmSP.Enabled = false;
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            isUpdate = true;
            MessageBox.Show("Vui lòng chọn Sản phẩm muốn chỉnh sửa !");
            cboSP.Enabled = false;
            cboNhomSP.Enabled = false;
            dudSoLuong.Enabled = false;
            btnLuuSP.Enabled = false;
            btnResetFrmSP.Enabled = true;
            btnSuaSP.Enabled = false;
            btnThemSP.Enabled = false;
            dataGridView1.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            int maSP = Convert.ToInt16(row.Cells[1].Value);
            int maNhomSP = SanPhamDAL.Instance.getMaNhomSP(maSP);
            dudSoLuong.Enabled = true;
            dudSoLuong.SelectedIndex = Convert.ToInt16(row.Cells[3].Value);
            btnLuuSP.Enabled=true;
            cboNhomSP.Text = NhomSPDAL.Instance.getTenNhomSP(maNhomSP);
            cboSP.Text = SanPhamDAL.Instance.getTenSP(maSP);
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            if(isUpdate)
            {

            }
        }
    }
}
