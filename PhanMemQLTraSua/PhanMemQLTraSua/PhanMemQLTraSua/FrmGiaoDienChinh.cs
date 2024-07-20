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

        }

        private void FrmGiaoDienChinh_Load(object sender, EventArgs e)
        {

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
    }
}
