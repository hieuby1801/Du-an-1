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
        public FrmQLSanPham()
        {
            InitializeComponent();
            LoadDSSanPham();
        }

        void LoadDSSanPham()
        {
            string query = "select maSP as [Mã SP], tenSP as [Tên Sản Phẩm], donGia as [Giá Bán], maNhomSP as [Mã Nhóm SP] from SanPham";
            DataProvider dataProvider = new DataProvider();
            dataGridViewSP.DataSource = dataProvider.ExcuteQuery(query);
        }
    }
}
