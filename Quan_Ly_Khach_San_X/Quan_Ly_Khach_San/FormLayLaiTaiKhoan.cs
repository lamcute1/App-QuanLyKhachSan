using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Khach_San
{
    public partial class FormLayLaiTaiKhoan : Form
    {
        public FormLayLaiTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            if (tbxSDT.Text == "" || tbxTenDangNhap.Text == "" || tbxTenNhanVien.Text == "")
                MessageBox.Show("Please enter all required information!", "Warning",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                FormDoiMatKhau formdoimatkhau = new FormDoiMatKhau();
                formdoimatkhau.Show();
            }
        }

        private void tbxTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbxTenDangNhap.Focus();
        }

        private void tbxTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbxSDT.Focus();
        }

        private void FormLayLaiTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void FormLayLaiTaiKhoan_Shown(object sender, EventArgs e)
        {
            this.tbxTenNhanVien.Focus();
        }
    }
}
