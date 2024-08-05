using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public int updateHDCT(int maHD, int maSP, int soLuong)
        {
            string query = string.Format("update HoaDonChiTiet set soLuong = {0} where maHD = {1} and maSP = {2}", soLuong, maHD, maSP);
            return DataProvider.Instance.ExcuteNonQuery(query);            
        }

        public int insertHDCT(int maHD, int maSP, int soLuong)
        {
            string query = string.Format("insert into HoaDonChiTiet values ({0},{1},{2})", maSP, maHD, soLuong);
            return DataProvider.Instance.ExcuteNonQuery(query); 
        }

        public bool checkHDCT (int maHD, int maSP)
        {
            string query = string.Format("exec spCheckHDCT {0},{1}", maHD, maSP);
            int result = Convert.ToInt16(DataProvider.Instance.ExcuteScalar(query)); 
            if (result > 0) return true;
            else return false;
        }

        public int getSLSP (int maHD, int maSP)
        {
            string query = string.Format("select soLuong from HoaDonChiTiet where maHD = {0} and maSP = {1}", maHD, maSP);
            return Convert.ToInt16(DataProvider.Instance.ExcuteScalar(query));
        }
        
        public void xuatHD (int maHD)
        {
            string query = "exec spBangThanhToan " + maHD;
            DataTable dataTable = DataProvider.Instance.ExcuteQuery(query);
            string query1 = "exec spTongTien " + maHD;
            int tongTien = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query1));
            string query2 = "select thoiGianXuat from HoaDon where maHD = " + maHD;
            string tgian = Convert.ToString(DataProvider.Instance.ExcuteScalar(query2));    
            StringBuilder sb = new StringBuilder();

            sb.Append("Hoá Đơn Thanh Toán");
            sb.AppendLine();
            sb.Append("-----------------------------------------------------");
            sb.AppendLine();
            // Add column names as the header row
            foreach (DataColumn column in dataTable.Columns)
            {
                sb.Append(column.ColumnName).Append("\t").Append("\t");
            }
            sb.AppendLine();

            // Add data rows
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    sb.Append(item.ToString()).Append("\t").Append("\t");
                }
                sb.AppendLine();
            }
            sb.Append("-----------------------------------------------------");
            sb.AppendLine();
            sb.Append("Khách hàng : ").Append("\t").Append("\t").Append("\t").Append("\t").Append("Khách lẻ");
            sb.AppendLine();
            sb.Append("Thời gian xuất : ").Append("\t").Append("\t").Append("\t").Append("\t").Append(tgian);
            sb.AppendLine();
            sb.Append("Tổng tiền : ").Append("\t").Append("\t").Append("\t").Append("\t").Append(tongTien);


            // Show the data in a message box
            MessageBox.Show(sb.ToString(), "Hoá Đơn Thanh Toán", MessageBoxButtons.OK);

        }
    }
}
