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
    }
}
