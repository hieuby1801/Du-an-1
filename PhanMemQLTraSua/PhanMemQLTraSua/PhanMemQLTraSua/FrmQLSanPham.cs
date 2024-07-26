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
    }
}
