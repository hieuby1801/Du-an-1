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
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
            LoadDSHD_HDCT();
        }

        void LoadDSHD_HDCT()
        {
            DataProvider dataProvider = new DataProvider();

            string queryHD = "select maHD as [Mã HĐ], thoiGianXuat as [Thời gian xuất HĐ], tongTien as [Tổng tiền], khachHang as [Khách hàng], maNV as [NV tạo HĐ] from HoaDon ";
            
            string queryHDCT = "select maHDCT as [Mã HĐCT], maSP as [Mã SP], maHD as [Mã HĐ], soLuong as [Số Lượng] from HoaDonChiTiet ";
            dataGridView1.DataSource = dataProvider.ExcuteQuery(queryHDCT);
            dataGridViewDSHD.DataSource = dataProvider.ExcuteQuery(queryHD);
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
    }
}
