﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
    
       
namespace BLL
{
    
    public class HangBLL
    {
        private static HangBLL instance;
        public static HangBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HangBLL();
                return instance;
            }
        }
        public List<Hang> LayDuLieuBLL ()
        {
            DataTable dt = HangDAL.Instance.LayDuLieuDAL();
            List<Hang> lst = new List<Hang>();
            foreach (DataRow row in dt.Rows)
            {
                Hang hang = new Hang();
                hang.MaHang = int.Parse(row["MaHang"].ToString());
                hang.TenHang = row["TenHang"].ToString();
                hang.BaoHanh = int.Parse(row["BaoHanh"].ToString());
                hang.SoLuong = int.Parse(row["SoLuong"].ToString());
                hang.GiaNhap = decimal.Parse(row["GiaNhap"].ToString());
                hang.DonGia = decimal.Parse(row["DonGia"].ToString());
                hang.XuatXu = row["XuatXu"].ToString();
                hang.MaNCC = int.Parse(row["MaNCC"].ToString());
                hang.MaLoai = int.Parse(row["MaLoai"].ToString());
                hang.TrangThai = row["TrangThai"].ToString() == "True" ? "Đang bán":"Đã ngừng bán";
                hang.TenNCC = NhaCungCapBLL.Instance.findNCCByID(hang.MaNCC);
                hang.TenLoai = LoaiHangBLL.Instance.findLoaiByID(hang.MaLoai);
                lst.Add(hang);
            }
                return lst;
        }

        public bool ThemHang(Hang hang)
        {
            return HangDAL.Instance.ThemHang(hang);
        }
        public string TaoMaHang()
        {
            Random rnd = new Random();
            string s = "";
            s += (char)rnd.Next('A', 'Z');
            for (int i = 1; i <= 3; i++)
                s += (char)rnd.Next('0', '9');
            if (!check(s))
                s = TaoMaHang();

            return s;
        }
        public bool check(string s)
        {
            DataTable data = TimHangTheoMa(s);
            return data != null;
        }
        public DataTable TimHangTheoTen(string ten)
        {
            return HangDAL.Instance.TimHangTheoTen(ten);
        }
        public DataTable TimHangTheoMa(string ma)
        {
            return HangDAL.Instance.TimHangTheoMa(ma);
        }

        public Hang LayHang(DataGridView data)
        {
            Hang hang = new Hang();
            //DataGridViewRow row = data.SelectedCells[0].OwningRow;
            //hang.MaHang = row.Cells["MaHang"].Value.ToString();
            //hang.TenHang = row.Cells["TenHang"].Value.ToString();
            //hang.Gia = decimal.Parse(row.Cells["Gia"].Value.ToString());
            //hang.ThoiGianBaoHanh = int.Parse(row.Cells["BaoHanh"].Value.ToString());
            //hang.XuatXu = row.Cells["XuatXu"].Value.ToString();
            //hang.SoLuongCon = int.Parse(row.Cells["SoLuong"].Value.ToString());
            return hang;
        }

        public bool XoaHang(string maHang)
        {
            return HangDAL.Instance.XoaHang(maHang);
        }

        public bool SuaHang(Hang hang)
        {
            return HangDAL.Instance.SuaHang(hang);
        }
        private String findNCCByID(int maNCC)
        {

            return null;
        }

        public List<String> findAllXuatXu()
        {
            DataTable dt = HangDAL.Instance.findAllXuatXu();
            List<string> list = new List<string>();
            list.Add("");
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(dr["XuatXu"].ToString());
            }
            return list;
        }

        public DataTable FindHang(string tenhang, string ncc, string loai, string xuatxu)
        {
             return HangDAL.Instance.FindHang(tenhang, ncc, loai, xuatxu);
        }

        public Hang FindById(int maHang)
        {
            DataTable dt = HangDAL.Instance.FindById(maHang);
            Hang hang = new Hang();
            hang.MaHang = maHang;
            hang.TenHang = dt.Rows[0]["TenHang"].ToString();
            hang.MaNCC = int.Parse(dt.Rows[0]["MaNCC"].ToString());
            hang.MaLoai = int.Parse(dt.Rows[0]["MaLoai"].ToString());
            hang.DonGia = decimal.Parse(dt.Rows[0]["DonGia"].ToString());
            hang.BaoHanh = int.Parse(dt.Rows[0]["BaoHanh"].ToString());
            hang.XuatXu = dt.Rows[0]["MaLoai"].ToString();
            hang.SoLuong = int.Parse(dt.Rows[0]["SoLuong"].ToString());
            hang.GiaNhap = int.Parse(dt.Rows[0]["GiaNhap"].ToString());
            return hang;
        }
    }
    }









































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































