using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonNhap
    {
        private int _maDon;
        private DateTime _ngayNhap;
        private decimal _tongGT;
        private int _maNV;

        public int MaDon { get => _maDon; set => _maDon = value; }
        public DateTime NgayNhap { get => _ngayNhap; set => _ngayNhap = value; }
        public decimal TongGT { get => _tongGT; set => _tongGT = value; }
        public int MaNV { get => _maNV; set => _maNV = value; }

        public DonNhap(int maDon, DateTime ngayNhap, decimal tongGT, int maNV)
        {
            MaDon = maDon;
            NgayNhap = ngayNhap;
            TongGT = tongGT;
            MaNV = maNV;
        }

        public DonNhap()
        {
        }
    }
}
