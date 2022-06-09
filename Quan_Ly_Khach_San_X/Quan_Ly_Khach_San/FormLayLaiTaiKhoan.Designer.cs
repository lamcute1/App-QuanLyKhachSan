
namespace Quan_Ly_Khach_San
{
    partial class FormLayLaiTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLayLaiTaiKhoan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxTenNhanVien = new System.Windows.Forms.TextBox();
            this.tbxTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnLayLaiMatKhau = new System.Windows.Forms.Button();
            this.tbxSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 97);
            this.panel1.TabIndex = 0;
            // 
            // tbxTenNhanVien
            // 
            this.tbxTenNhanVien.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxTenNhanVien.Location = new System.Drawing.Point(309, 157);
            this.tbxTenNhanVien.Name = "tbxTenNhanVien";
            this.tbxTenNhanVien.Size = new System.Drawing.Size(427, 44);
            this.tbxTenNhanVien.TabIndex = 8;
            this.tbxTenNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTenNhanVien_KeyPress);
            // 
            // tbxTenDangNhap
            // 
            this.tbxTenDangNhap.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxTenDangNhap.Location = new System.Drawing.Point(309, 245);
            this.tbxTenDangNhap.Name = "tbxTenDangNhap";
            this.tbxTenDangNhap.Size = new System.Drawing.Size(427, 44);
            this.tbxTenDangNhap.TabIndex = 7;
            this.tbxTenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTenDangNhap_KeyPress);
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Bodoni MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTenNhanVien.Location = new System.Drawing.Point(44, 157);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(94, 38);
            this.lblTenNhanVien.TabIndex = 6;
            this.lblTenNhanVien.Text = "Name";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Bodoni MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTenDangNhap.Location = new System.Drawing.Point(44, 245);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(150, 38);
            this.lblTenDangNhap.TabIndex = 5;
            this.lblTenDangNhap.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnTroLai);
            this.panel2.Controls.Add(this.btnLayLaiMatKhau);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 164);
            this.panel2.TabIndex = 11;
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTroLai.Font = new System.Drawing.Font("Bodoni MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroLai.ForeColor = System.Drawing.Color.White;
            this.btnTroLai.Location = new System.Drawing.Point(498, 60);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(238, 67);
            this.btnTroLai.TabIndex = 2;
            this.btnTroLai.Text = "Back";
            this.btnTroLai.UseVisualStyleBackColor = false;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnLayLaiMatKhau
            // 
            this.btnLayLaiMatKhau.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLayLaiMatKhau.Font = new System.Drawing.Font("Bodoni MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayLaiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnLayLaiMatKhau.Location = new System.Drawing.Point(61, 60);
            this.btnLayLaiMatKhau.Name = "btnLayLaiMatKhau";
            this.btnLayLaiMatKhau.Size = new System.Drawing.Size(238, 67);
            this.btnLayLaiMatKhau.TabIndex = 1;
            this.btnLayLaiMatKhau.Text = "Gain Password";
            this.btnLayLaiMatKhau.UseVisualStyleBackColor = false;
            this.btnLayLaiMatKhau.Click += new System.EventHandler(this.btnLayLaiMatKhau_Click);
            // 
            // tbxSDT
            // 
            this.tbxSDT.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxSDT.Location = new System.Drawing.Point(309, 336);
            this.tbxSDT.Name = "tbxSDT";
            this.tbxSDT.Size = new System.Drawing.Size(427, 44);
            this.tbxSDT.TabIndex = 13;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Bodoni MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSDT.Location = new System.Drawing.Point(44, 336);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(210, 38);
            this.lblSDT.TabIndex = 12;
            this.lblSDT.Text = "Phone number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 36.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(106, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(589, 55);
            this.label3.TabIndex = 7;
            this.label3.Text = "ACCOUNT INFORMATION";
            // 
            // FormLayLaiTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.tbxSDT);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbxTenNhanVien);
            this.Controls.Add(this.tbxTenDangNhap);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLayLaiTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormLayLaiTaiKhoan_Load);
            this.Shown += new System.EventHandler(this.FormLayLaiTaiKhoan_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxTenNhanVien;
        private System.Windows.Forms.TextBox tbxTenDangNhap;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Button btnLayLaiMatKhau;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Label label3;
    }
}