using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class HangDAL
    {
        private static HangDAL instance;
        public static HangDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HangDAL();
                return instance;
            }
        }
        public bool ThemHang(Hang hang)
        {
            //SqlParameter[] param =
            //{
            //    new SqlParameter("@MaHang", hang.MaHang),
            //    new SqlParameter("@TenHang", hang.TenHang),
            //    new SqlParameter("@Gia", hang.Gia),
            //    new SqlParameter("@BaoHanh", hang.ThoiGianBaoHanh),
            //    new SqlParameter("@XuatXu", hang.XuatXu),
            //    new SqlParameter("@SoLuong", hang.SoLuongCon)
            //};

            //int result = DataBase.Instance.ThucThi("proc_themHang", param);
            //if (result > 0)
            //{
            //    return true;
            //}
            return false;
        }
        public bool XoaHang(string mahang)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@MaHang", mahang)
            };

            int result = DataBase.Instance.ThucThi("proc_xoaHang", param);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool SuaHang(Hang hang)
        {
            //SqlParameter[] param =
            //{
            //    new SqlParameter("@MaHang", hang.MaHang),
            //    new SqlParameter("@TenHang", hang.TenHang),
            //    new SqlParameter("@Gia", hang.Gia),
            //    new SqlParameter("@BaoHanh", hang.ThoiGianBaoHanh),
            //    new SqlParameter("@XuatXu", hang.XuatXu),
            //    new SqlParameter("@SoLuong", hang.SoLuongCon)
            //};

            //int result = DataBase.Instance.ThucThi("proc_suaHang", param);
            //if (result > 0)
            //{
            //    return true;
            //}
            return false;
        }

        public DataTable LayDuLieuDAL()
        {
            return DataBase.Instance.LayDuLieu("proc_SelectAllHang", null);
        }

        public DataTable TimHangTheoTen(string ten)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@TenHang", ten)
            };
            return DataBase.Instance.LayDuLieu("proc_search_by_name", param);
        }

        public DataTable TimHangTheoMa(string mahang)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@MaHang", mahang)
            };
            return DataBase.Instance.LayDuLieu("proc_search_by_id", param);
        }

        public DataTable FindHang(string tenhang, string ncc, string loai, string xuatxu)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@TenHang", tenhang),
                new SqlParameter("@NCC", ncc),
                new SqlParameter("@Loai",loai),
                new SqlParameter("@XuatXu", xuatxu),
            };

            return DataBase.Instance.LayDuLieu("proc_findHang",param);
        }
        public DataTable findAllXuatXu()
        {
            return DataBase.Instance.LayDuLieu("proc_selectAllXuatXu", null);
        }

        public DataTable FindById(int maHang)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@MaHang", maHang)
            };
            DataTable dataTable = DataBase.Instance.LayDuLieu("proc_FindHangById", param);
            return dataTable;
        }
    }
}
