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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
            this.Cb_ShowPass.CheckedChanged += new System.EventHandler(this.Cb_ShowPass_CheckedChanged);
            //this.rdohienmatkhau.CheckedChanged += new System.EventHandler(this.rdohienmatkhau_CheckedChanged);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cb_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_ShowPass.Checked)
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtmatkhau.UseSystemPasswordChar= true;
            }
        }

        private void lblmatkhau_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string userName = txtTaiKhoan.Text;
            string passWord = txtmatkhau.Text;
            if ( Login(userName, passWord))
            {                
                MessageBox.Show("Đăng nhập thành công");
                FrmGiaoDienChinh frm = new FrmGiaoDienChinh();
                this.Hide();
                frm.ShowDialog();
                this.Show();
                txtTaiKhoan.Text = null;
                txtmatkhau.Text = null;
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác !");
                MessageBox.Show("Email hoặc mật khẩu không đúng !");
                txtTaiKhoan.Text = null;
                txtmatkhau.Text = null;
                txtTaiKhoan.Focus();
            }            
        }

        bool Login (string username, string passWord)
        {
            return AccountDAL.Instance.Login(username, passWord);
        }

       
        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
