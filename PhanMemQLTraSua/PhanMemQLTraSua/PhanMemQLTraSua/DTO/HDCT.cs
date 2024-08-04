using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQLTraSua.DTO
{
    public class HDCT
    {
        private int maHDCT;
        private int maHD;
        private int maSP;
        private int soLuong;

        public int MaHDCT { get => maHDCT; set => maHDCT = value; }
        public int MaHD { get => maHD; set => maHD = value; }
        public int MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public HDCT(int maHDCT, int maHD, int maSP, int soluong)
        {
            this.MaHDCT = maHDCT;
            this.MaHD = maHD;   
            this.MaSP = maSP;
            this.SoLuong = soluong;
        }

        public HDCT() { }
    }
}
