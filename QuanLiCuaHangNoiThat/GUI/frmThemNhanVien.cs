using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThemNhanVien : Form
    {
       
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            dtNgayTuyenDung.Value = DateTime.Now;
            pbAnh.Image = Properties.Resources.user1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            NhanVien newNhanVien = new NhanVien();
            newNhanVien.TenNV = txtTenNV.Text;
            newNhanVien.NgaySinh = dtNgaySinh.Value.ToString("yyyy/MM/dd");
            newNhanVien.GioiTinh = cbGioiTinh.Text;
            newNhanVien.SDT = txtSDT.Text;
            newNhanVien.DiaChi = txtDiaChi.Text;
            newNhanVien.ChucVu = cbChucVu.Text;
            newNhanVien.NgayTuyenDung = dtNgayTuyenDung.Value.ToString("yyyy/MM/dd");
            newNhanVien.Anh = ImageToByteArray(pbAnh.Image);
            
            if (!NhanVienBLL.Instance.ThemNhanVien(newNhanVien))
                txtTenNV.Focus();
            else
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo");
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (img.ShowDialog() == DialogResult.OK)
            {
                pbAnh.ImageLocation = img.FileName;
            }
        }
        /// <summary>
        /// Chuyển đổi một hình ảnh thành một mảng byte.
        /// </summary>
        /// <param name="image">Hình ảnh cần chuyển đổi.</param>
        /// <returns>Mảng byte chứa dữ liệu hình ảnh.</returns>
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
