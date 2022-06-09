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
    public partial class FormTraPhong : Form
    {
        public FormTraPhong()
        {
            InitializeComponent();
        }

        private void FormTraPhong_Shown(object sender, EventArgs e)
        {
            this.tbxMaPhong.Focus();
        }

        private void tbxMaPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.tbxMaKhachHang.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.tbxMaPhong.Clear();
            this.tbxMaKhachHang.Clear();
            this.tbxSoTien.Clear();
            this.tbxMaPhong.Focus();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (this.tbxMaPhong.Text == "" || this.tbxMaKhachHang.Text == "")
                MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                this.tbxSoTien.Text = "xxxx (k)";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Are you sure?", "Warninng", MessageBoxButtons.OKCancel
                , MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btnXuatPhieu_Click(object sender, EventArgs e)
        {
            if (this.tbxSoTien.Text == "" || this.tbxMaPhong.Text == "" || this.tbxMaKhachHang.Text == "")
                MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MessageBox.Show("Print bill success!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormBienLai formbienlai = new FormBienLai();
                formbienlai.Show();
            }

        }
    }
}
