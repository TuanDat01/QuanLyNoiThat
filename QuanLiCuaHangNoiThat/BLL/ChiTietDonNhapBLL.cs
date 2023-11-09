using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietDonNhapBLL
    {
        private static ChiTietDonNhapBLL instance;
        public static ChiTietDonNhapBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietDonNhapBLL();
                return instance;
            }
        }

        public bool Insert(ChiTietDonNhap ct)
        {
            return ChiTietDonNhapDAL.Instance.Insert(ct);
        }

        public int GetMaCT()
        {
            return ChiTietDonNhapDAL.Instance.GetMaCT();
        }

        public bool UpdateSoLuongHang(int maCT, int soLuong)
        {
            return ChiTietDonNhapDAL.Instance.UpdateSoLuongHang(maCT, soLuong);
        }
    }
}
