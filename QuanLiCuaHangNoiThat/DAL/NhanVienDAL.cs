using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class NhanVienDAL
    {
        private static NhanVienDAL instance;
        public static NhanVienDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAL();
                return instance;
            }
        }

        public DataTable LayDuLieuDAL()
        {
            return DataBase.Instance.LayDuLieu("proc_select_all_NV", null);
        }

        public bool ThemNhanVien(NhanVien nv)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@TenNV", nv.TenNV),
                new SqlParameter("@NgaySinh", nv.NgaySinh),
                new SqlParameter("@GioiTinh", nv.GioiTinh),
                new SqlParameter("@DiaChi", nv.DiaChi),
                new SqlParameter("@SDT", nv.SDT),
                new SqlParameter("@ChucVu", nv.ChucVu),
                new SqlParameter("@NgayTuyenDung", nv.NgayTuyenDung),
                new SqlParameter("@Anh",nv.Anh)
            };

            int result = DataBase.Instance.ThucThi("proc_themNV", param);
            return result > 0;
        }
        public bool SuaThongTin(NhanVien nv)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@MaNV", nv.MaNV),
                new SqlParameter("@TenNV", nv.TenNV),
                new SqlParameter("@NgaySinh", nv.NgaySinh),
                new SqlParameter("@GioiTinh", nv.GioiTinh),
                new SqlParameter("@DiaChi", nv.DiaChi),
                new SqlParameter("@SDT", nv.SDT),
                new SqlParameter("@Anh",nv.Anh)
            };
            int result = DataBase.Instance.ThucThi("proc_updateNV", param);
            return result > 0;
        }

        public bool XoaNhanVien(string maNV)
        {
            SqlParameter[] param =
            {
                 new SqlParameter("@MaNV", maNV)
            };
            int result = DataBase.Instance.ThucThi("proc_XoaNV", param);
            return result> 0;
        }
        
    }
}
