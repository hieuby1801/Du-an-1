using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQLTraSua.DTO
{
    public class NhomSP
    {
        private string tenNhomSP;
        private int maNhomSP;

        public int MaNhomSP { get => maNhomSP; set => maNhomSP = value; }
        public string TenNhomSP { get => tenNhomSP; set => tenNhomSP = value; }

        public NhomSP (string tenNhomSP, int maNhomSP)
        {
            TenNhomSP = tenNhomSP;
            MaNhomSP = maNhomSP;               
        }

        public NhomSP (DataRow row)
        {
            this.MaNhomSP = (int)row["maNhomSP"];
            this.TenNhomSP = row["tenNhomSP"].ToString();
        }
    }
}
