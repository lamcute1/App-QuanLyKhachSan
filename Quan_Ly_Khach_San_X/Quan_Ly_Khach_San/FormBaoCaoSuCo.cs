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
    public partial class FormBaoCaoSuCo : Form
    {
        public FormBaoCaoSuCo()
        {
            InitializeComponent();
        }

        private void FormBaoCaoSuCo_Shown(object sender, EventArgs e)
        {
            this.tbxThongTinSuCo.Focus();
        }

        private void tbxThongTinSuCo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.tbxMaPhong.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Are you sure?", "Warninng", MessageBoxButtons.OKCancel
               , MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.tbxThongTinSuCo.Clear();
            this.tbxMaPhong.Clear();
            this.tbxThongTinSuCo.Focus();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (this.tbxThongTinSuCo.Text != "" && this.tbxMaPhong.Text != "")
            {
                MessageBox.Show("Reported a problem!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tbxMaPhong.Clear();
                this.tbxThongTinSuCo.Clear();
                this.tbxThongTinSuCo.Focus();
            }
            else
                MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
