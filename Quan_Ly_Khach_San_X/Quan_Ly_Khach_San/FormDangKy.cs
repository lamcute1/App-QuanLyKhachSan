using Quan_Ly_Khach_San.Modex;
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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.tbxMatKhau2.Text == "" || this.tbxTenDangNhap2.Text == "" || this.tbxHoten.Text == ""
                || this.NgaySinhpicker.Text == "" || this.tbxXacNhanMatKhau.Text == "" || this.tbxSDT.Text == ""
                || this.tbxQueQuan.Text == "")
                MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (this.tbxMatKhau2.Text == "" || this.tbxTenDangNhap2.Text == "" || this.tbxHoten.Text == ""
                || this.NgaySinhpicker.Text == "" || this.tbxXacNhanMatKhau.Text == "" || this.tbxSDT.Text == ""
                || this.tbxQueQuan.Text == "")
                MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {                

                if (String.Compare(this.tbxXacNhanMatKhau.Text.ToString(), this.tbxMatKhau2.Text.ToString()) == 0)
                {
                    Model1 context = new Model1();
                    TaiKhoan ac = new TaiKhoan();
                    ac.TenTK = tbxTenDangNhap2.Text.ToString();
                    ac.MatKhau = tbxMatKhau2.Text.ToString();
                    ac.MaTK = "TK" + ac.GetAll().Count.ToString();
                    ac.LoaiTK = true;
                    ac.MaNV = "NV05";
                    context.TaiKhoans.Add(ac);
                    context.SaveChanges();

                    DialogResult traloi;
                    traloi = MessageBox.Show("Sign up success!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (traloi == DialogResult.OK)
                    {
                        this.tbxHoten.Clear();
                        this.tbxTenDangNhap2.Clear();
                        this.tbxMatKhau2.Clear();
                        this.tbxXacNhanMatKhau.Clear();
                        this.chkAdmin.Checked = false;
                        this.tbxQueQuan.Clear();
                        this.tbxSDT.Clear();
                        this.NgaySinhpicker.Refresh();
                        this.tbxHoten.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Password does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormDangKy_Shown(object sender, EventArgs e)
        {
            tbxHoten.Focus();
        }

        private void tbxTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.NgaySinhpicker.Focus();
        }

        private void tbxTenDangNhap2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.tbxMatKhau2.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.tbxHoten.Clear();
            this.tbxTenDangNhap2.Clear();
            this.tbxMatKhau2.Clear();
            this.tbxXacNhanMatKhau.Clear();
            this.chkAdmin.Checked = false;
            this.tbxQueQuan.Clear();
            this.tbxSDT.Clear();
            this.NgaySinhpicker.Refresh();
            this.tbxHoten.Focus();
        }

        private void tbxMatKhau2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.tbxXacNhanMatKhau.Focus();
        }

        private void tbxQueQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.tbxSDT.Focus();
        }

        private void tbxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.tbxTenDangNhap2.Focus();
        }

        private void NgaySinhpicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.tbxQueQuan.Focus();
        }

        private void NgaySinhpicker_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.tbxQueQuan.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (tbxMatKhau2.PasswordChar == '*')
            {
                tbxMatKhau2.PasswordChar = '\0';
                pictureBox4.Image = Properties.Resources.Eye_Invisible_icon;
            }
            else
            {
                tbxMatKhau2.PasswordChar = '*';
                pictureBox4.Image = Properties.Resources.Eye_Visible_icon;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tbxXacNhanMatKhau.PasswordChar == '*')
            {
                tbxXacNhanMatKhau.PasswordChar = '\0';
                pictureBox1.Image = Properties.Resources.Eye_Invisible_icon;
            }
            else
            {
                tbxXacNhanMatKhau.PasswordChar = '*';
                pictureBox1.Image = Properties.Resources.Eye_Visible_icon;
            }
        }
    }
}
