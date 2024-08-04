using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQLTraSua.DAL
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }  
        }

        internal string conectionStr = "Data Source=.;Initial Catalog=qltrasua;Integrated Security=True";
        public DataTable ExcuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(conectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dataTable);    

                connection.Close();
            }

            return dataTable;
        }

        public object ExcuteScalar(string query)
        {
            object result;

            SqlConnection connection = new SqlConnection(conectionStr);
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            result = command.ExecuteScalar();

            connection.Close();
            return result;
        }

        public int ExcuteNonQuery(string query)
        {
            int result = 0;

            using (SqlConnection connection = new SqlConnection(conectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                result = command.ExecuteNonQuery();

                connection.Close();
            }
            return result;
        }

        public bool Login(string username, string password)
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
    }
}
