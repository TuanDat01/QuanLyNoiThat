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
    public partial class frmNhapHang : Form
    {
        public DonNhap donNhap = new DonNhap();
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            pnDonNhap.Visible= false;
            List<Hang> list = HangBLL.Instance.LayDuLieuBLL();
            foreach (Hang hang in list)
            {
                ucHang item = new ucHang(hang, isSale: false);
                item.Click += ucHang_Click;
                item.Tag = hang;
                

                flpHang.Controls.Add(item);
            }
        }

        private void ucHang_Click(object sender, EventArgs e)
        {
            // gán sender bằng ucHang mà bạn đã nhấp vào
            ucHang clickedItem = sender as ucHang;
            ChiTietDonNhap ctDonNhap= new ChiTietDonNhap();
            ctDonNhap.MaHang = clickedItem.hang.MaHang;
            ctDonNhap.MaDon = this.donNhap.MaDon;
            ctDonNhap.SoLuong = 1;
            ctDonNhap.ThanhTien = clickedItem.hang.GiaNhap;
            if (ChiTietDonNhapBLL.Instance.Insert(ctDonNhap))
            {
                ctDonNhap.MaChiTiet = ChiTietDonNhapBLL.Instance.GetMaCT();
                ucChiTietDon ucCTDonNhap = new ucChiTietDon(ctDonNhap,isSale: false);
                flpChiTietDonNhap.Controls.Add(ucCTDonNhap);
            }
            
        }

        private void btnThemDonNhap_Click(object sender, EventArgs e)
        {
            pnDonNhap.Visible = true;
            frmQuanLi frmQL = Application.OpenForms.OfType<frmQuanLi>().FirstOrDefault();
            NhanVien nhanVienTaoDon = frmQL.nhanVien;
            if (DonNhapBLL.Instance.Insert(nhanVienTaoDon.MaNV))
            {
                donNhap.MaDon = DonNhapBLL.Instance.GetMaDon();
            }

        }
    }
}
