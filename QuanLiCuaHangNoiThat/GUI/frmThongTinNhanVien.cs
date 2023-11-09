using BLL;
using DTO;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThongTinNhanVien : Form
    {
        private bool isEdit;
        private NhanVien NhanVien;
        public frmThongTinNhanVien()
        {
            InitializeComponent();
        }
        public frmThongTinNhanVien(NhanVien nv, bool isEdit=false)
        {
            InitializeComponent();
            txtTenNV.Text = nv.TenNV.ToString();
            txtDiaChi.Text = nv.DiaChi.ToString();
            txtSDT.Text = nv.SDT.ToString();
            cbGioiTinh.Text = nv.GioiTinh.ToString();
            lbMaNV.Text += " " + nv.MaNV.ToString();
            dtNgaySinh.Value = DateTime.ParseExact(nv.NgaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            pbAnh.Image = converByteToImage(nv.Anh);
            this.isEdit = isEdit;
            this.NhanVien= nv;
        }
        public Image converByteToImage(Byte[] byteArr)
        {
            if (byteArr == null)
                return null;
            MemoryStream memoryStream = new MemoryStream(byteArr);
            return Image.FromStream(memoryStream);
        }
        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                txtTenNV.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                dtNgaySinh.Enabled = false;
                cbGioiTinh.Enabled = false;
                btnLuu.Visible = false;
                btnChonAnh.Visible = false;
            }   
            else
            {
                txtTenNV.ReadOnly = false;
                txtSDT.ReadOnly = false;
                txtDiaChi.ReadOnly = false;
                dtNgaySinh.Enabled = true;
                cbGioiTinh.Enabled = true;
                btnLuu.Visible = true;
                btnChonAnh.Visible = true;
            }
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVien.TenNV = txtTenNV.Text;
            NhanVien.NgaySinh = dtNgaySinh.Value.ToString("yyyy/MM/dd");
            NhanVien.GioiTinh = cbGioiTinh.Text;
            NhanVien.SDT = txtSDT.Text;
            NhanVien.DiaChi = txtDiaChi.Text;
            NhanVien.Anh = ImageToByteArray(pbAnh.Image);
            if (!NhanVienBLL.Instance.SuaThongTin(NhanVien))
                txtTenNV.Focus();
            else
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo");
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
