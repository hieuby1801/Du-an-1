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
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            Mtb1.Text = DateTime.Now.ToString("yyyy/MM/dd");

        }

        private void DataGR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            
            DataGR.DataSource = HoaDonDAL.Instance.LoadThongKeHD(Mtb1.Text);
            lbl_doanhThuNgay.Text = HoaDonDAL.Instance.DoanhThuNgay(Mtb1.Text).ToString();
        }

        private void btEX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
