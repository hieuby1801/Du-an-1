﻿using PhanMemQLTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQLTraSua.DAL
{
    public class SanPhamDAL
    {
        private static SanPhamDAL instance;

        public static SanPhamDAL Instance
        {
            get { if (instance == null) instance = new SanPhamDAL(); return SanPhamDAL.instance; }
            private set { SanPhamDAL.instance = value; }
        }

        public DataTable DSSanPham()
        {
            DataTable dt = new DataTable();
            string query = "select maSP as [Mã SP], tenSP as [Tên Sản Phẩm], slTonKho as [SL Tồn], donGia as [Giá Bán], maNhomSP as [Mã Nhóm SP] from SanPham";
            dt = DataProvider.Instance.ExcuteQuery(query);
            return dt;
        }

        public void ThemSanPham(string tenSP, int slTonKho, int donGia, int maNhomSP)
        {
            string query = string.Format("insert into SanPham values(N'{0}', {1}, {2}, {3})", tenSP, slTonKho, donGia, maNhomSP);
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

        public void SuaSanPham(int maSP, string tenSP, int slTonKho, int donGia, int maNhomSP)
        {
            string query = string.Format("update SanPham set tenSP = N'{0}', slTonKho = {1}, donGia = {2}, maNhomSP = {3} where maSP = {4}", tenSP, slTonKho, donGia, maNhomSP, maSP);
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
        public void XoaSanPham(int maSP)
        {
            string query = string.Format("delete from SanPham where maSP = {0}", maSP);
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

        public List<SanPham> DSSanPhamByNhom(int maNhomSP)
        {
            List<SanPham> list = new List<SanPham>();

            string query = "select * from SanPham where maNhomSP = " + maNhomSP;

            DataTable table = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in table.Rows)
            {
                SanPham sp = new SanPham(item);
                list.Add(sp);
            }

            return list;
        }

        public int getMaNhomSP(int maSP)
        {
            string query = "select maNhomSP from SanPham where maSP = " + maSP;
            int result = Convert.ToInt16(DataProvider.Instance.ExcuteScalar(query));
            return result;  
        }

        public string getTenSP(int maSP)
        {
            string query = "select tenSP from SanPham where maSP = " + maSP;
            string result = Convert.ToString(DataProvider.Instance.ExcuteScalar(query));
            return result;
        }
    }
}
