using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Quan_Ly_Khach_San
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (this.tbxMatKhau.Text == "" || this.tbxTenDangNhap.Text == "")
                MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Modex.TaiKhoan x = new Modex.TaiKhoan();
                List<Modex.TaiKhoan> l = x.GetAll();
                int num = l.Count;
                bool flag = true;
                for (int i = 0; i < num; i++)
                {
                    if (String.Compare(tbxTenDangNhap.Text.ToString(), l[i].TenTK.ToString()) == 0 &&
                    String.Compare(tbxMatKhau.Text.ToString(), l[i].MatKhau.ToString()) == 0)
                    {
                        flag = false;
                        FormMENU formmenu = new FormMENU();
                        formmenu.Show();
                    }
                }
                if(flag)
                {
                    MessageBox.Show("Account does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy formdangky = new FormDangKy();
            formdangky.Show();
        }

        private void tbxTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbxMatKhau.Focus();
        }

        private void FormDangNhap_Shown(object sender, EventArgs e)
        {
            this.tbxTenDangNhap.Focus();
        }

        private void lblQuenMatKhau_Click(object sender, EventArgs e)
        {
            FormLayLaiTaiKhoan formlaylaitaikhoan = new FormLayLaiTaiKhoan();
            formlaylaitaikhoan.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (tbxMatKhau.PasswordChar == '*')
            {
                tbxMatKhau.PasswordChar = '\0';
                pictureBox4.Image = Properties.Resources.Eye_Invisible_icon;
            }
            else
            {
                tbxMatKhau.PasswordChar = '*';
                pictureBox4.Image = Properties.Resources.Eye_Visible_icon;
            }
        }
    }
}
