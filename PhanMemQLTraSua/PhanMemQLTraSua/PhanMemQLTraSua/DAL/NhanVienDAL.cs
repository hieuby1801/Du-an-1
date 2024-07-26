using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanMemQLTraSua.DAL
{
    public class NhanVienDAL
    {
        private static NhanVienDAL instance;

        public static NhanVienDAL Instance
        {
            get { if (instance == null) instance = new NhanVienDAL(); return NhanVienDAL.instance; }
            private set { NhanVienDAL.instance = value; }
        }

        public DataTable DSNhanVien()
        {
            DataTable dt = new DataTable();
            string query = "select ID as [ID], maNV as [Mã NV], sdt as [Số điện thoại], tenNV as [Tên nhân viên], tinhTrang as [Tình trạng], diaChi as [Địa chỉ], vaiTro as [Vai trò], matKhau as [Mật khẩu] from NhanVien";
            dt = DataProvider.Instance.ExcuteQuery(query);
            return dt;
        }

        public void ThemNhanVien( string maNV ,string sdt ,string tenNV ,int tinhTrang ,string diaChi ,int vaiTro ,string matKhau )
        {
            string query = string.Format("insert into NhanVien values('{0}', '{1}', N'{2}', {3}, N'{4}', {5}, '{6}')", maNV, sdt, tenNV, tinhTrang, diaChi, vaiTro, matKhau);
            try
            {
                SqlConnection connection = new SqlConnection(DataProvider.Instance.conectionStr);
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

            }
            finally { }
        }

        public void SuaNhanVien(string maNV, string sdt, string tenNV, int tinhTrang, string diaChi, int vaiTro, string matKhau)
        {
            string query = string.Format("update NhanVien set sdt = '{0}', tenNV = N'{1}', tinhTrang = {2}," +
                "diaChi = N'{3}', vaiTro = {4}, matKhau = '{5}' where maNV = '{6}'", sdt, tenNV, tinhTrang, diaChi, vaiTro, matKhau, maNV);
            try
            {
                SqlConnection connection = new SqlConnection(DataProvider.Instance.conectionStr);
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

            }
            finally { }
        }
    }
}
