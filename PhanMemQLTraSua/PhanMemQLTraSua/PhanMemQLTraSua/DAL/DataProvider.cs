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
        private string conectionStr = "Data Source=.;Initial Catalog=qltrasua;Integrated Security=True";
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
    }
}
