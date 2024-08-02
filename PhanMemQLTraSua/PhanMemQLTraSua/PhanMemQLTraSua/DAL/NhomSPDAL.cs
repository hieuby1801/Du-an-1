using PhanMemQLTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQLTraSua.DAL
{
    public class NhomSPDAL
    {
        private static NhomSPDAL instance;

        public static NhomSPDAL Instance
        {
            get { if (instance == null) instance = new NhomSPDAL(); return NhomSPDAL.instance; }
            private set { NhomSPDAL.instance = value; }
        }

        public List<NhomSP> DSNhomSP()
        {
            List<NhomSP> list = new List<NhomSP>();
            string query = "select * from NhomSP";

            DataTable table = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in table.Rows)
            {
                NhomSP nhom = new NhomSP(item);
                list.Add(nhom); 
            }

            return list;
        }

        public string getTenNhomSP(int maNhomSP)
        {
            string query = "select tenNhomSP from NhomSP where maNhomSP = " + maNhomSP;
            string result = Convert.ToString(DataProvider.Instance.ExcuteScalar(query));
            return result;
        }
    }
}
