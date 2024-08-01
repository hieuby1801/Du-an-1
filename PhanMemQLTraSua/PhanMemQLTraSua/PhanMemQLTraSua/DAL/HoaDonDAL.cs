using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQLTraSua.DAL
{
    public class HoaDonDAL
    {
        private static HoaDonDAL instance;

        public static HoaDonDAL Instance
        {
            get { if (instance == null) instance = new HoaDonDAL(); return HoaDonDAL.instance; }
            private set { HoaDonDAL.instance = value; }
        }

        public DataTable DSHoaDon()
        {
            DataTable dt = new DataTable();
            string queryHD = "select maHD as [Mã HĐ], thoiGianXuat as [Thời gian xuất HĐ], tongTien as [Tổng tiền], khachHang as [Khách hàng], maNV as [NV tạo HĐ] from HoaDon ";
            dt = DataProvider.Instance.ExcuteQuery(queryHD);
            return dt;
        }

        public void ThemHoaDon(string maNV)
        {
            try
            {
                SqlConnection connection = new SqlConnection(DataProvider.Instance.conectionStr);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;

                command.CommandText = "spThemHD";
                command.Parameters.AddWithValue("maNV", maNV);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

            }
            finally { }          
        }

        public DataTable LoadHDCT(string maHD)
        {
            string query = "select maHDCT as [Mã HĐCT], maSP as [Mã SP], maHD as [Mã HĐ], soLuong as [Số Lượng] from HoaDonChiTiet where maHD = " + maHD;
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataProvider.Instance.conectionStr);
            connection.Open();

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            connection.Close();
            return dt;
        }
    }
}
