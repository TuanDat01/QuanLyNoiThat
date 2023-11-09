using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class DonNhapBLL
    {
        private static DonNhapBLL instance;
        public static DonNhapBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonNhapBLL();
                return instance;
            }
        }

        public bool Insert(int maDon)
        {
            return DonNhapDAL.Instance.Insert(maDon);
        }

        public int GetMaDon()
        {
            return DonNhapDAL.Instance.GetMaDon();
        }
    }
}
