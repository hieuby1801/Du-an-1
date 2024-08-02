using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQLTraSua.DTO
{
    public class SanPham
    {
        private int maSP;
        private string tenSP;
        private int slTonKho;
        private int donGia;
        private int maNhomSP;

        public int MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int SlTonKho { get => slTonKho; set => slTonKho = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int MaNhomSP { get => maNhomSP; set => maNhomSP = value; }

        public SanPham (int maSP, string tenSP, int slTonKho, int donGia, int maNhomSP)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.SlTonKho = slTonKho;
            this.DonGia = donGia;
            this.MaNhomSP = maNhomSP;           
        }

        public SanPham (DataRow row)
        {
            this.MaSP = (int)row["maSP"];
            this.TenSP = row["tenSP"].ToString();
            
            try
            {
                this.SlTonKho = (int)row["slTonKho"];
            }
            catch
            {
                this.SlTonKho = 0;
            }

            this.MaNhomSP = (int)row["maNhomSP"];
        }
    }
}
