using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucChiTietDon : UserControl
    {
        public ChiTietDonNhap CTDonNhap { get; set; }
        private Hang hang = new Hang();
        bool isSale = false;
        public ucChiTietDon()
        {
            InitializeComponent();
        }

        public ucChiTietDon(ChiTietDonNhap CTDonNhap, bool isSale)
        {
            InitializeComponent();
            this.CTDonNhap = CTDonNhap;
            this.isSale = isSale;
            this.hang = HangBLL.Instance.FindById(this.CTDonNhap.MaHang);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soLuong = CTDonNhap.SoLuong;
            soLuong -= 1;
            if (soLuong >= 0)
            {
                lbSoLuong.Text = (soLuong).ToString();
                if (!isSale)
                {
                    lbThanhTien.Text = (soLuong * hang.GiaNhap).ToString();
                    CTDonNhap.SoLuong = soLuong;
                    ChiTietDonNhapBLL.Instance.UpdateSoLuongHang(CTDonNhap.MaChiTiet, CTDonNhap.SoLuong);
                }
                else
                {
                    lbThanhTien.Text = (soLuong * hang.DonGia).ToString();   
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int soLuong = CTDonNhap.SoLuong;
            soLuong += 1;
            lbSoLuong.Text = soLuong.ToString();
            if (!isSale)
            {
                lbThanhTien.Text = (soLuong * hang.GiaNhap).ToString();
                CTDonNhap.SoLuong = soLuong;
                ChiTietDonNhapBLL.Instance.UpdateSoLuongHang(CTDonNhap.MaChiTiet, CTDonNhap.SoLuong);
            }

            else
            {
                lbThanhTien.Text = (soLuong * hang.DonGia).ToString();

            }
        }

        private void ucChiTietDon_Load(object sender, EventArgs e)
        {
            llbTenHang.Text = hang.TenHang.ToString();
            lbThanhTien.Text = hang.GiaNhap.ToString();
        }
    }
}
