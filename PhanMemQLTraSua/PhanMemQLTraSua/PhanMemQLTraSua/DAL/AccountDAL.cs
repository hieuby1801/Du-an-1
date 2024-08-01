using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Collections;

namespace PhanMemQLTraSua.DAL
{
    public class AccountDAL
    {
        private static AccountDAL instance;

        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return AccountDAL.instance; }
            private set { AccountDAL.instance = value; }
        }


        public bool Login (string username, string password)
        {
            try
            {
                SqlConnection connection = new SqlConnection(DataProvider.Instance.conectionStr);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;

                command.CommandText = "spDangNhap";
                command.Parameters.AddWithValue("maNV", username);
                command.Parameters.AddWithValue("matKhau", password);

                if (Convert.ToInt16(command.ExecuteScalar()) > 0)
                {
                    return true;
                }

                connection.Close();                           
            }
            catch (Exception ex)
            {

            }
            finally { }
            return false;
        }  

        public int getVaiTro (string maNV)
        {
            string query = "select vaiTro from NhanVien where maNV = '" + maNV + "'";
            int vaiTro;
            SqlConnection con = new SqlConnection(DataProvider.Instance.conectionStr);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            vaiTro = Convert.ToInt16(cmd.ExecuteScalar());
            con.Close();
            return vaiTro;
        }

    }
}
