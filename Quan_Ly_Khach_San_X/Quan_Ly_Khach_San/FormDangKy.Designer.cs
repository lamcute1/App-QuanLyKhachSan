
namespace Quan_Ly_Khach_San
{
    partial class FormDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangKy));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.NgaySinhpicker = new System.Windows.Forms.DateTimePicker();
            this.tbxQueQuan = new System.Windows.Forms.TextBox();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.tbxSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.tbxXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.lblXacNhanMatKhau = new System.Windows.Forms.Label();
            this.tbxHoten = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.tbxTenDangNhap2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMatKhau2 = new System.Windows.Forms.TextBox();
            this.tbxTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnDangKy);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 598);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 109);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXoa.Font = new System.Drawing.Font("Bodoni MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Transparent;
            this.btnXoa.Location = new System.Drawing.Point(407, 35);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(164, 52);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Clear";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThoat.Font = new System.Drawing.Font("Bodoni MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Transparent;
            this.btnThoat.Location = new System.Drawing.Point(609, 35);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(164, 52);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Exit";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDangKy.Font = new System.Drawing.Font("Bodoni MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.Transparent;
            this.btnDangKy.Location = new System.Drawing.Point(208, 35);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(164, 52);
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Text = "Sign up";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Bodoni MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Location = new System.Drawing.Point(12, 35);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 52);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 79);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(187, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 68);
            this.label2.TabIndex = 2;
            this.label2.Text = "INFORMATION";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.chkAdmin);
            this.panel3.Controls.Add(this.NgaySinhpicker);
            this.panel3.Controls.Add(this.tbxQueQuan);
            this.panel3.Controls.Add(this.lblQueQuan);
            this.panel3.Controls.Add(this.tbxSDT);
            this.panel3.Controls.Add(this.lblSDT);
            this.panel3.Controls.Add(this.lblNgaySinh);
            this.panel3.Controls.Add(this.tbxXacNhanMatKhau);
            this.panel3.Controls.Add(this.lblXacNhanMatKhau);
            this.panel3.Controls.Add(this.tbxHoten);
            this.panel3.Controls.Add(this.lblHoTen);
            this.panel3.Controls.Add(this.tbxTenDangNhap2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbxMatKhau2);
            this.panel3.Controls.Add(this.tbxTenDangNhap);
            this.panel3.Controls.Add(this.lblMatKhau);
            this.panel3.Controls.Add(this.lblTenDangNhap);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(785, 707);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Quan_Ly_Khach_San.Properties.Resources.Eye_Visible_icon;
            this.pictureBox1.Location = new System.Drawing.Point(661, 476);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Quan_Ly_Khach_San.Properties.Resources.Eye_Visible_icon;
            this.pictureBox4.Location = new System.Drawing.Point(661, 411);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdmin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.chkAdmin.Location = new System.Drawing.Point(596, 538);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(100, 32);
            this.chkAdmin.TabIndex = 25;
            this.chkAdmin.Text = "Admin";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // NgaySinhpicker
            // 
            this.NgaySinhpicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NgaySinhpicker.CalendarForeColor = System.Drawing.Color.White;
            this.NgaySinhpicker.CalendarMonthBackground = System.Drawing.Color.DeepSkyBlue;
            this.NgaySinhpicker.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.NgaySinhpicker.CalendarTitleForeColor = System.Drawing.Color.DeepSkyBlue;
            this.NgaySinhpicker.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.NgaySinhpicker.CustomFormat = "";
            this.NgaySinhpicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NgaySinhpicker.Location = new System.Drawing.Point(294, 160);
            this.NgaySinhpicker.Name = "NgaySinhpicker";
            this.NgaySinhpicker.Size = new System.Drawing.Size(405, 35);
            this.NgaySinhpicker.TabIndex = 24;
            this.NgaySinhpicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NgaySinhpicker_KeyPress_1);
            // 
            // tbxQueQuan
            // 
            this.tbxQueQuan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxQueQuan.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxQueQuan.Location = new System.Drawing.Point(294, 222);
            this.tbxQueQuan.Name = "tbxQueQuan";
            this.tbxQueQuan.Size = new System.Drawing.Size(405, 35);
            this.tbxQueQuan.TabIndex = 16;
            this.tbxQueQuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQueQuan_KeyPress);
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueQuan.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblQueQuan.Location = new System.Drawing.Point(72, 229);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(128, 28);
            this.lblQueQuan.TabIndex = 15;
            this.lblQueQuan.Text = "Home town";
            // 
            // tbxSDT
            // 
            this.tbxSDT.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxSDT.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxSDT.Location = new System.Drawing.Point(294, 287);
            this.tbxSDT.Name = "tbxSDT";
            this.tbxSDT.Size = new System.Drawing.Size(405, 35);
            this.tbxSDT.TabIndex = 14;
            this.tbxSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSDT_KeyPress);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSDT.Location = new System.Drawing.Point(72, 291);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(157, 28);
            this.lblSDT.TabIndex = 13;
            this.lblSDT.Text = "Phone number";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNgaySinh.Location = new System.Drawing.Point(72, 166);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(140, 28);
            this.lblNgaySinh.TabIndex = 11;
            this.lblNgaySinh.Text = "Date of birth";
            // 
            // tbxXacNhanMatKhau
            // 
            this.tbxXacNhanMatKhau.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxXacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxXacNhanMatKhau.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxXacNhanMatKhau.Location = new System.Drawing.Point(294, 480);
            this.tbxXacNhanMatKhau.Name = "tbxXacNhanMatKhau";
            this.tbxXacNhanMatKhau.PasswordChar = '*';
            this.tbxXacNhanMatKhau.Size = new System.Drawing.Size(361, 35);
            this.tbxXacNhanMatKhau.TabIndex = 10;
            // 
            // lblXacNhanMatKhau
            // 
            this.lblXacNhanMatKhau.AutoSize = true;
            this.lblXacNhanMatKhau.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXacNhanMatKhau.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblXacNhanMatKhau.Location = new System.Drawing.Point(72, 480);
            this.lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            this.lblXacNhanMatKhau.Size = new System.Drawing.Size(192, 28);
            this.lblXacNhanMatKhau.TabIndex = 9;
            this.lblXacNhanMatKhau.Text = "Confirm password";
            // 
            // tbxHoten
            // 
            this.tbxHoten.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxHoten.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxHoten.Location = new System.Drawing.Point(294, 105);
            this.tbxHoten.Name = "tbxHoten";
            this.tbxHoten.Size = new System.Drawing.Size(405, 35);
            this.tbxHoten.TabIndex = 8;
            this.tbxHoten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTenNhanVien_KeyPress);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblHoTen.Location = new System.Drawing.Point(72, 105);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(114, 28);
            this.lblHoTen.TabIndex = 7;
            this.lblHoTen.Text = "Full name";
            // 
            // tbxTenDangNhap2
            // 
            this.tbxTenDangNhap2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxTenDangNhap2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxTenDangNhap2.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxTenDangNhap2.Location = new System.Drawing.Point(294, 356);
            this.tbxTenDangNhap2.Name = "tbxTenDangNhap2";
            this.tbxTenDangNhap2.Size = new System.Drawing.Size(405, 35);
            this.tbxTenDangNhap2.TabIndex = 6;
            this.tbxTenDangNhap2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTenDangNhap2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(72, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // tbxMatKhau2
            // 
            this.tbxMatKhau2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxMatKhau2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxMatKhau2.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxMatKhau2.Location = new System.Drawing.Point(294, 411);
            this.tbxMatKhau2.Name = "tbxMatKhau2";
            this.tbxMatKhau2.PasswordChar = '*';
            this.tbxMatKhau2.Size = new System.Drawing.Size(361, 35);
            this.tbxMatKhau2.TabIndex = 4;
            this.tbxMatKhau2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMatKhau2_KeyPress);
            // 
            // tbxTenDangNhap
            // 
            this.tbxTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxTenDangNhap.Location = new System.Drawing.Point(267, 39);
            this.tbxTenDangNhap.Name = "tbxTenDangNhap";
            this.tbxTenDangNhap.Size = new System.Drawing.Size(405, 31);
            this.tbxTenDangNhap.TabIndex = 3;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMatKhau.Location = new System.Drawing.Point(72, 415);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(106, 28);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Password";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenDangNhap.Location = new System.Drawing.Point(83, 45);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(170, 25);
            this.lblTenDangNhap.TabIndex = 1;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 707);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.FormDangKy_Shown);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbxMatKhau2;
        private System.Windows.Forms.TextBox tbxTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox tbxHoten;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox tbxTenDangNhap2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox tbxXacNhanMatKhau;
        private System.Windows.Forms.Label lblXacNhanMatKhau;
        private System.Windows.Forms.TextBox tbxQueQuan;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.TextBox tbxSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker NgaySinhpicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}