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
    public partial class FormThongTinKhachHang : Form
    {
        public FormThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void FormThongTinKhachHang_Shown(object sender, EventArgs e)
        {
            tbxHoTen.Focus();
        }

        private void tbxHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbxCMND.Focus();
        }

        private void tbxCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbxSDT.Focus();
        }

        private void tbxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbxSoNguoi.Focus();
        }

        private void tbxSoNgayDat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbxSoDem.Focus();
        }

        private void tbxSoDem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbxMaPhong.Focus();
        }

        private void btnXuatPhieu_Click(object sender, EventArgs e)
        {
            if (tbxHoTen.Text == "" || tbxCMND.Text == "" || tbxSDT.Text == "" || tbxSoNguoi.Text == "" ||
                 tbxMaPhong.Text == "" || pickNgayDat.Text == "" || tbxMaNhanVienDatPhong.Text == "")
                    MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MessageBox.Show("Sign up success!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbxHoTen.Clear();
                this.tbxCMND.Clear();
                this.tbxSDT.Clear();
                this.tbxSoDem.Clear();
                this.tbxMaPhong.Clear();
                this.pickNgayDat.Refresh();
                this.pickNgayTra.Refresh();
                this.tbxSoNguoi.Clear();
                this.tbxMaNhanVienDatPhong.Clear();
                this.tbxHoTen.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.tbxHoTen.Clear();
            this.tbxCMND.Clear();
            this.tbxSDT.Clear();
            this.tbxSoDem.Clear();
            this.tbxMaPhong.Clear();
            this.pickNgayDat.Refresh();
            this.pickNgayTra.Refresh();
            this.tbxSoNguoi.Clear();
            this.tbxMaNhanVienDatPhong.Clear();
            this.tbxHoTen.Focus();
        }

        private void tbxSoNguoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.tbxSoDem.Focus();
        }

        private void tbxMaPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbxMaNhanVienDatPhong.Focus();
        }
    }
}
