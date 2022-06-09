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
    public partial class FormTraCuuPhong : Form
    {
        public FormTraCuuPhong()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
                this.Close();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.tbxSucChua.Clear();
            this.tbxGiaToiThieu.Clear();
            this.tbxGiaToiDa.Clear();
            this.chkboxPhongVip.Checked = false;
            this.tbxSucChua.Focus();
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            if (this.tbxSucChua.Text == "" || this.tbxGiaToiThieu.Text == "" || this.tbxGiaToiDa.Text == "")
                MessageBox.Show("Please enter all required information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult traloi = MessageBox.Show("Find success!", "Notify", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (traloi == DialogResult.OK)
                {
                    
                }
            }
        }

        private void tbxSucChua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.tbxGiaToiThieu.Focus();
        }

        private void tbxGiaToiThieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.tbxGiaToiDa.Focus();
        }

        private void FormTraCuuPhong_Shown(object sender, EventArgs e)
        {
            this.tbxSucChua.Focus();
        }

        private void tbxGiaToiThieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
