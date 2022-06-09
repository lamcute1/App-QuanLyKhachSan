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
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (String.Compare(tbxMatKhauMoi.Text.ToString(), tbxRepeatMatKhauMoi.Text.ToString()) == 0
                && tbxMatKhauMoi.Text != "" && tbxRepeatMatKhauMoi.Text != "")
                this.Close();
            else
                MessageBox.Show("Password does not match!", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
        }

        private void tbxMatKhauMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                tbxRepeatMatKhauMoi.Focus();
        }

        private void FormDoiMatKhau_Shown(object sender, EventArgs e)
        {
            this.tbxMatKhauMoi.Focus();
        }
    }
}
