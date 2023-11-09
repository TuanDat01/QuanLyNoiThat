using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQuanLi : Form
    {
        public NhanVien nhanVien = new NhanVien();
        
        public frmQuanLi()
        {
            InitializeComponent();
            //test
            
        }
        public frmQuanLi(NhanVien nv)
        {
            InitializeComponent();
            this.nhanVien = nv;
        }
        private Form childForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (this.childForm != null)
            {
                this.childForm.Close();
            }
            this.childForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLNV());
        }

        private void btnQLHH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLHH());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBanHang());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLiKhachHang());
        }

        private void frmQuanLi_Load(object sender, EventArgs e)
        {
            nhanVien.MaNV = 1;
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhapHang());
        }
    }
}
