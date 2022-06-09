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
    public partial class FormMENU : Form
    {
        public FormMENU()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            FormThongTinKhachHang formttkh = new FormThongTinKhachHang();
            formttkh.Show();
            panel3.Controls.Clear();
        }

        private void btnTraCuuPhong_Click(object sender, EventArgs e)
        {
            FormTraCuuPhong formtracuuphong = new FormTraCuuPhong();
            formtracuuphong.TopLevel = false;
            panel3.Controls.Clear();
            panel3.Controls.Add(formtracuuphong);
            formtracuuphong.Dock = DockStyle.Fill;
            formtracuuphong.Show();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            FormTraPhong formtraphong = new FormTraPhong();
            formtraphong.Show();
            panel3.Controls.Clear();
        }

        private void btnDichVuThem_Click(object sender, EventArgs e)
        {
            FormDichVuThem formdichvuthem = new FormDichVuThem();
            formdichvuthem.TopLevel = false;
            panel3.Controls.Clear();
            panel3.Controls.Add(formdichvuthem);
            formdichvuthem.Dock = DockStyle.Fill;
            formdichvuthem.Show();
        }

        private void btnBaoCaoSuCo_Click(object sender, EventArgs e)
        {
            FormBaoCaoSuCo formbaocaosuco = new FormBaoCaoSuCo();
            formbaocaosuco.Show();
            panel3.Controls.Clear();
        }

        private void FormMENU_Load(object sender, EventArgs e)
        {

        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            FormQuanLyNhanVien formquanlynhanvien = new FormQuanLyNhanVien();
            formquanlynhanvien.TopLevel = false;
            panel3.Controls.Clear();
            panel3.Controls.Add(formquanlynhanvien);
            formquanlynhanvien.Dock = DockStyle.Fill;
            formquanlynhanvien.Show();
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            FormQuanLyKhachHang formquanlykhachhang = new FormQuanLyKhachHang();
            formquanlykhachhang.TopLevel = false;
            panel3.Controls.Clear();
            panel3.Controls.Add(formquanlykhachhang);
            formquanlykhachhang.Dock = DockStyle.Fill;
            formquanlykhachhang.Show();
        }

        
    }
}
