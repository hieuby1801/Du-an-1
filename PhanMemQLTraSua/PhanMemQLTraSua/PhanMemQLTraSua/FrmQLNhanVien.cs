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
    public partial class FrmQLNhanVien : Form
    {
        public FrmQLNhanVien()
        {
            InitializeComponent();
            LoadDSNhanVien();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void LoadDSNhanVien()
        {
            string query = "select ID as [ID], maNV as [Mã NV], sdt as [Số điện thoại], tenNV as [Tên nhân viên], tinhTrang as [Tình trạng], diaChi as [Địa chỉ], vaiTro as [Vai trò], matKhau as [Mật khẩu] from NhanVien";
            DataProvider dataProvider = new DataProvider();
            dataGridViewNhanVien.DataSource = dataProvider.ExcuteQuery(query);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
