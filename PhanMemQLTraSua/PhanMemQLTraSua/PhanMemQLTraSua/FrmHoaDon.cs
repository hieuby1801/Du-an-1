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
        static bool isUpdate = true;
        static int maSP, maHD;
        static List<SanPham> listSP;
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

            maHD = Convert.ToInt16(row.Cells[0].Value);
            LoadHDCT(maHD.ToString());
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
            listSP = SanPhamDAL.Instance.DSSanPhamByNhom(maNhomSP);
            cboSP.DataSource = listSP;
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

            maSP = Convert.ToInt16(row.Cells[1].Value);
            int maNhomSP = SanPhamDAL.Instance.getMaNhomSP(maSP);
            dudSoLuong.Enabled = true;
            dudSoLuong.SelectedIndex = Convert.ToInt16(row.Cells[3].Value);
            btnLuuSP.Enabled=true;
            cboNhomSP.Text = NhomSPDAL.Instance.getTenNhomSP(maNhomSP);
            cboSP.Text = SanPhamDAL.Instance.getTenSP(maSP);
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            int soLuong = Convert.ToInt16(dudSoLuong.Text);
            if(isUpdate)
            {
                int rowUpdated = HoaDonChiTietDAL.Instance.updateHDCT(maHD, maSP, soLuong);
                if (rowUpdated > 0)
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                else
                    MessageBox.Show("Lỗi ! Cập nhật dữ liệu không thành công");

                LoadHDCT(maHD.ToString());
            }
            else
            {
                //HDCT hDCT = new HDCT();
                //hDCT.MaHD = maHD;
                //hDCT.MaSP = maSP;
                //hDCT.SoLuong = soLuong;
                //
                if (HoaDonChiTietDAL.Instance.checkHDCT(maHD, maSP))
                {
                    int tongSL = soLuong + HoaDonChiTietDAL.Instance.getSLSP(maHD, maSP); 
                    int rowUpdated = HoaDonChiTietDAL.Instance.updateHDCT(maHD, maSP, tongSL);
                    if (rowUpdated > 0)
                        MessageBox.Show("Cập nhật dữ liệu thành công");
                    else
                        MessageBox.Show("Lỗi ! Cập nhật dữ liệu không thành công");

                    LoadHDCT(maHD.ToString());
                }
                else
                {
                    int rowInsert = HoaDonChiTietDAL.Instance.insertHDCT(maHD, maSP, soLuong);
                    if (rowInsert > 0)
                        MessageBox.Show("Cập nhật dữ liệu thành công");
                    else
                        MessageBox.Show("Lỗi ! Cập nhật dữ liệu không thành công");

                    LoadHDCT(maHD.ToString());
                }
            }
            if (HoaDonDAL.Instance.updateTongTien(maHD))
                MessageBox.Show("Cập nhật tổng tiền thành công");
            else
                MessageBox.Show("Lỗi ! Cập nhật tổng tiền không thành công");
            int indexHD = dataGridViewDSHD.SelectedRows[0].Index;
            LoadDSHD();
            dataGridViewDSHD.Rows[indexHD].Selected = true;
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
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cboSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboSP.SelectedIndex;
            maSP = listSP.ElementAt(index).MaSP;
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            HoaDonChiTietDAL.Instance.xuatHD(maHD);
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hoá đơn có mã " + maHD + " không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            // Nếu người dùng chọn OK
            if (result == DialogResult.OK)
            {
                if (HoaDonDAL.Instance.XoaHoaDon(maHD.ToString()) > 0)
                MessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                MessageBox.Show("Xóa không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                // Người dùng chọn Cancel, không làm gì cả
            }
            LoadDSHD();
            dataGridView1.DataSource = null;
        }

        private void dataGridViewDSHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isOpen = true;
            btnXoaHD.Enabled = isOpen;
            tableLayoutPanel2.Enabled = isOpen;
            dataGridView1.DataSource = null;
        }
    }
}
