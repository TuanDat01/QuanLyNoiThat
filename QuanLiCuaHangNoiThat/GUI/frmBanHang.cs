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
    public partial class frmBanHang : Form
    {
        public KhachHang khachhang =  null; 
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            List<Hang> list = HangBLL.Instance.LayDuLieuBLL();
            foreach (Hang hang in list)
            {
                ucHang item = new ucHang(hang, isSale: true);
                item.Tag= hang;
                
                fpnHang.Controls.Add(item);
            }
        }
        private void handleClickUcHang(object sender, EventArgs e)
        {
            ucChiTietDon ucChiTiet = new ucChiTietDon();

        }

        public void GetValue(KhachHang kh)
        {
            this.khachhang = kh;
        }
        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmQuanLiKhachHang frmQuanLiKH = new frmQuanLiKhachHang();
            frmQuanLiKH.mydata = new frmQuanLiKhachHang.GETDATA(GetValue);
            frmQuanLiKH.ShowDialog();
            if (khachhang != null)
            {
                lbKhachHang.Text = $"Khách hàng: {khachhang.TenKH}";
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (khachhang == null)
            {
                MessageBox.Show("Chưa chọn khách hàng", "Thông báo");
            }
            else
            {
                frmThemKhachHang frm = new frmThemKhachHang(khachhang, isUpdate: true);
                frm.ShowDialog();
            }
        }
    }
}
