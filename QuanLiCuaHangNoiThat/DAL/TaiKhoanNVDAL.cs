using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TaiKhoanNVDAL
    {
        private static TaiKhoanNVDAL instance;
        public static TaiKhoanNVDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanNVDAL();
                return instance;
            }
        }
        /// <summary>
        /// kiem tra tai khoan, mat khau co dung khong
        /// </summary>
        public string checkLogin(TaiKhoanNV tk)
        {
            string user = null;
            DataBase.Instance.moKetNoi();
            DataBase.Instance.cmd = new SqlCommand("proc_login", DataBase.Instance.conn);
            DataBase.Instance.cmd.CommandType = CommandType.StoredProcedure;
            DataBase.Instance.cmd.Parameters.AddWithValue("@user", tk.taikhoan);
            DataBase.Instance.cmd.Parameters.AddWithValue("@pass", tk.matkhau);
            DataBase.Instance.cmd.Connection = DataBase.Instance.conn;
            DataBase.Instance.reader = DataBase.Instance.cmd.ExecuteReader();
            if (DataBase.Instance.reader.HasRows)
            {
                while (DataBase.Instance.reader.Read())
                {
                    user = DataBase.Instance.reader.GetString(0);
                }

                user = "succerful";
            }
            else
            {
                user = "incorrect account or password";
            }
            DataBase.Instance.reader.Close();
            DataBase.Instance.dongKetNoi();
            return user;

        }
    }
}
