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
    public partial class FormDichVuThem : Form
    {
        public FormDichVuThem()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Are you sure?", "Warninng", MessageBoxButtons.OKCancel
               , MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (tbxMaPhong.Text != "")
            {
                MessageBox.Show("Order success!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbxMaPhong.Clear();
                this.tbxMaPhong.Focus();
            }
            else
                MessageBox.Show("Please enter all required information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormDichVuThem_Shown(object sender, EventArgs e)
        {
            this.tbxMaPhong.Focus();
        }

        private void FormDichVuThem_Load(object sender, EventArgs e)
        {

        }
    }
}
