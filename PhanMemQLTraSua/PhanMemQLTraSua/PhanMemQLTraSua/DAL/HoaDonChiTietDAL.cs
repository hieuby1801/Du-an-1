using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQLTraSua.DAL
{
    public class HoaDonChiTietDAL
    {
        private static HoaDonChiTietDAL instance;

        public static HoaDonChiTietDAL Instance
        {
            get { if (instance == null) instance = new HoaDonChiTietDAL(); return HoaDonChiTietDAL.instance; }
            private set { HoaDonChiTietDAL.instance = value; }
        }

        public void updateHDCT(int maHD, int maSP, int soLuong)
        {
            string query = string.Format("update HoaDonChiTiet set soLuong = {0} where maHD = {1} and maSP = {2}", soLuong, maHD, maSP);
            //int run = DataProvider.Instance.ExcuteNonQuery(query);
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
