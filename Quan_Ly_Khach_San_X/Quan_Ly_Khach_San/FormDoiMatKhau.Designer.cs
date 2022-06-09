
namespace Quan_Ly_Khach_San
{
    partial class FormDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoiMatKhau));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.tbxMatKhauMoi = new System.Windows.Forms.TextBox();
            this.tbxRepeatMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(914, 97);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 36.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(218, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(469, 55);
            this.label3.TabIndex = 6;
            this.label3.Text = "CHANGE PASSWORD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnTroLai);
            this.panel2.Controls.Add(this.btnHoanThanh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 180);
            this.panel2.TabIndex = 21;
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTroLai.Font = new System.Drawing.Font("Bodoni MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroLai.ForeColor = System.Drawing.Color.White;
            this.btnTroLai.Location = new System.Drawing.Point(578, 60);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(238, 67);
            this.btnTroLai.TabIndex = 2;
            this.btnTroLai.Text = "Back";
            this.btnTroLai.UseVisualStyleBackColor = false;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHoanThanh.Font = new System.Drawing.Font("Bodoni MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanh.ForeColor = System.Drawing.Color.White;
            this.btnHoanThanh.Location = new System.Drawing.Point(94, 60);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(238, 67);
            this.btnHoanThanh.TabIndex = 1;
            this.btnHoanThanh.Text = "OK";
            this.btnHoanThanh.UseVisualStyleBackColor = false;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // tbxMatKhauMoi
            // 
            this.tbxMatKhauMoi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxMatKhauMoi.Location = new System.Drawing.Point(423, 157);
            this.tbxMatKhauMoi.Name = "tbxMatKhauMoi";
            this.tbxMatKhauMoi.PasswordChar = '*';
            this.tbxMatKhauMoi.Size = new System.Drawing.Size(427, 44);
            this.tbxMatKhauMoi.TabIndex = 18;
            this.tbxMatKhauMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMatKhauMoi_KeyPress);
            // 
            // tbxRepeatMatKhauMoi
            // 
            this.tbxRepeatMatKhauMoi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxRepeatMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxRepeatMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxRepeatMatKhauMoi.Location = new System.Drawing.Point(423, 245);
            this.tbxRepeatMatKhauMoi.Name = "tbxRepeatMatKhauMoi";
            this.tbxRepeatMatKhauMoi.PasswordChar = '*';
            this.tbxRepeatMatKhauMoi.Size = new System.Drawing.Size(427, 44);
            this.tbxRepeatMatKhauMoi.TabIndex = 17;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.BackColor = System.Drawing.Color.White;
            this.lblMatKhauMoi.Font = new System.Drawing.Font("Bodoni MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhauMoi.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMatKhauMoi.Location = new System.Drawing.Point(44, 157);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(204, 38);
            this.lblMatKhauMoi.TabIndex = 16;
            this.lblMatKhauMoi.Text = "New password";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.BackColor = System.Drawing.Color.White;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Bodoni MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTenDangNhap.Location = new System.Drawing.Point(44, 245);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(315, 38);
            this.lblTenDangNhap.TabIndex = 15;
            this.lblTenDangNhap.Text = "Confirm new password";
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbxMatKhauMoi);
            this.Controls.Add(this.tbxRepeatMatKhauMoi);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.lblTenDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.FormDoiMatKhau_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.TextBox tbxMatKhauMoi;
        private System.Windows.Forms.TextBox tbxRepeatMatKhauMoi;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label label3;
    }
}