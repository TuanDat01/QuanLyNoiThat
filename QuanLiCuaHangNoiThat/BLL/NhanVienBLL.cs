using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;

namespace BLL
{
    public class NhanVienBLL
    {
        private static NhanVienBLL instance;
        public static NhanVienBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienBLL();
                return instance;
            }
        }
        public List<NhanVien> LayDuLieuBLL()
        {
            DataTable dt = NhanVienDAL.Instance.LayDuLieuDAL();
            return ConverDataTableToList(dt);
        }

        public NhanVien ChiTietNhanVien(DataGridView dgvNhanVien)
        {
            NhanVien nv = new NhanVien();
            DataGridViewRow row = dgvNhanVien.SelectedCells[0].OwningRow;
            nv.MaNV = int.Parse(row.Cells["MaNV"].Value.ToString());
            nv.TenNV = row.Cells["TenNV"].Value.ToString();
            nv.GioiTinh = row.Cells["GioiTinh"].Value.ToString();
            nv.NgaySinh = row.Cells["NgaySinh"].Value.ToString();
            nv.DiaChi = row.Cells["DiaChi"].Value.ToString();
            nv.SDT = row.Cells["SDT"].Value.ToString();
            nv.ChucVu = row.Cells["ChucVu"].Value.ToString();
            nv.NgayTuyenDung = row.Cells["NgayTuyenDung"].Value.ToString();
            nv.TrangThai = row.Cells["TrangThai"].Value.ToString();
            nv.Anh = (byte[])(row.Cells["anh"].Value);

            return nv;

        }

        public bool ThemNhanVien(NhanVien nv)
        {
            if (nv.TenNV == "")
            {
                MessageBox.Show("Không được để trống tên nhân viên");
                return false;
            }

            return NhanVienDAL.Instance.ThemNhanVien(nv);
        }

        public bool SuaThongTin(NhanVien nv)
        {
            if (nv.TenNV == "")
            {
                MessageBox.Show("Không được để trống tên nhân viên");
                return false;
            }

            return NhanVienDAL.Instance.SuaThongTin(nv);
        }

        public bool XoaNhanVien(string maNV)
        {
            return NhanVienDAL.Instance.XoaNhanVien(maNV);
        }

        public List<NhanVien> ConverDataTableToList(DataTable dt)
        {
            List<NhanVien> lst = new List<NhanVien>();
            lst = (from DataRow row in dt.Rows
                   select new NhanVien()
                   {
                       MaNV = int.Parse(row["MaNV"].ToString()),
                       TenNV = row["HoTen"].ToString(),
                       GioiTinh = row["GioiTinh"].ToString(),
                       NgaySinh = Convert.ToDateTime(row["NgaySinh"]).ToString("dd/MM/yyy"),
                       DiaChi = row["DiaChi"].ToString(),
                       SDT = row["SDT"].ToString(),
                       ChucVu = row["ChucVu"].ToString(),
                       NgayTuyenDung = Convert.ToDateTime(row["NgayTuyenDung"]).ToString("dd/MM/yyy"),
                       TrangThai = row["TrangThai"].ToString() == "True" ? "Đang làm" : "Đã nghỉ",
                       Anh = row["Anh"] != DBNull.Value ? (byte[])row["Anh"] : null
                   }).ToList();
            return lst;
        }
    }
}
