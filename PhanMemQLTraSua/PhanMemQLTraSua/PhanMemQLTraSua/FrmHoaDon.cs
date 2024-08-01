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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

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

        private void dataGridViewDSHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isOpen = true;
            btnXoaHD.Enabled =  isOpen;
            tableLayoutPanel2.Enabled = isOpen;
            dataGridView1.DataSource = null;
        }

        private void dataGridViewDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isOpen = true;
            btnXoaHD.Enabled = isOpen;
            tableLayoutPanel2.Enabled = isOpen;

            DataGridViewRow row = dataGridViewDSHD.Rows[e.RowIndex];

            string maHD = row.Cells[0].Value.ToString();
            LoadHDCT(maHD);
        }

        void LoadHDCT(string maHD)
        {
            dataGridView1.DataSource = HoaDonDAL.Instance.LoadHDCT(maHD);
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {

        }

        void LoadDS_NhomSP()
        {
            List<NhomSP> list = NhomSPDAL.Instance.DSNhomSP();

            List<string> nhomSP = new List<string>();
            
            foreach (var item in list)
            {
                nhomSP.Add(item.TenNhomSP);
            }
            
            cboNhomSP.DataSource = nhomSP;
        }
        void DSSanPhamByNhom(int maNhomSP)
        {
            List<SanPham> list = SanPhamDAL.Instance.DSSanPhamByNhom(maNhomSP);

            List<string> SP = new List<string>();

            foreach (var item in list)
            {
                SP.Add(item.TenSP);
            }

            cboSP.DataSource = SP;    
        }

    }
}
