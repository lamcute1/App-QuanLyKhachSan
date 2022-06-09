
namespace Quan_Ly_Khach_San
{
    partial class FormTraCuuPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTraCuuPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxGiaToiDa = new System.Windows.Forms.TextBox();
            this.tbxGiaToiThieu = new System.Windows.Forms.TextBox();
            this.tbxSucChua = new System.Windows.Forms.TextBox();
            this.chkboxPhongVip = new System.Windows.Forms.CheckBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblSucChua = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 65);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 573);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1012, 567);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThoat.Font = new System.Drawing.Font("Bodoni MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(860, 54);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 40);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Exit";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXoa.Font = new System.Drawing.Font("Bodoni MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(423, 54);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 40);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Clear";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTim.Font = new System.Drawing.Font("Bodoni MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(19, 54);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(129, 40);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Find";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.tbxGiaToiDa);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnTim);
            this.panel3.Controls.Add(this.tbxGiaToiThieu);
            this.panel3.Controls.Add(this.tbxSucChua);
            this.panel3.Controls.Add(this.chkboxPhongVip);
            this.panel3.Controls.Add(this.lblGia);
            this.panel3.Controls.Add(this.lblSucChua);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1015, 100);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(613, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(353, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "From";
            // 
            // tbxGiaToiDa
            // 
            this.tbxGiaToiDa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxGiaToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxGiaToiDa.ForeColor = System.Drawing.Color.White;
            this.tbxGiaToiDa.Location = new System.Drawing.Point(659, 4);
            this.tbxGiaToiDa.Name = "tbxGiaToiDa";
            this.tbxGiaToiDa.Size = new System.Drawing.Size(170, 35);
            this.tbxGiaToiDa.TabIndex = 7;
            // 
            // tbxGiaToiThieu
            // 
            this.tbxGiaToiThieu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxGiaToiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxGiaToiThieu.ForeColor = System.Drawing.Color.White;
            this.tbxGiaToiThieu.Location = new System.Drawing.Point(423, 4);
            this.tbxGiaToiThieu.Name = "tbxGiaToiThieu";
            this.tbxGiaToiThieu.Size = new System.Drawing.Size(170, 35);
            this.tbxGiaToiThieu.TabIndex = 6;
            this.tbxGiaToiThieu.TextChanged += new System.EventHandler(this.tbxGiaToiThieu_TextChanged);
            this.tbxGiaToiThieu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxGiaToiThieu_KeyPress);
            // 
            // tbxSucChua
            // 
            this.tbxSucChua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbxSucChua.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxSucChua.ForeColor = System.Drawing.Color.White;
            this.tbxSucChua.Location = new System.Drawing.Point(153, 4);
            this.tbxSucChua.Name = "tbxSucChua";
            this.tbxSucChua.Size = new System.Drawing.Size(85, 35);
            this.tbxSucChua.TabIndex = 5;
            this.tbxSucChua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSucChua_KeyPress);
            // 
            // chkboxPhongVip
            // 
            this.chkboxPhongVip.AutoSize = true;
            this.chkboxPhongVip.Font = new System.Drawing.Font("Bodoni MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxPhongVip.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.chkboxPhongVip.Location = new System.Drawing.Point(852, 4);
            this.chkboxPhongVip.Name = "chkboxPhongVip";
            this.chkboxPhongVip.Size = new System.Drawing.Size(151, 36);
            this.chkboxPhongVip.TabIndex = 4;
            this.chkboxPhongVip.Text = "VIP Room";
            this.chkboxPhongVip.UseVisualStyleBackColor = true;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Bodoni MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblGia.Location = new System.Drawing.Point(275, 5);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(72, 32);
            this.lblGia.TabIndex = 1;
            this.lblGia.Text = "Price";
            // 
            // lblSucChua
            // 
            this.lblSucChua.AutoSize = true;
            this.lblSucChua.Font = new System.Drawing.Font("Bodoni MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucChua.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSucChua.Location = new System.Drawing.Point(14, 5);
            this.lblSucChua.Name = "lblSucChua";
            this.lblSucChua.Size = new System.Drawing.Size(110, 32);
            this.lblSucChua.TabIndex = 0;
            this.lblSucChua.Text = "Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(264, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(495, 60);
            this.label3.TabIndex = 5;
            this.label3.Text = "ROOM LOOKING UP";
            // 
            // FormTraCuuPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 738);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTraCuuPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.FormTraCuuPhong_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.CheckBox chkboxPhongVip;
        private System.Windows.Forms.TextBox tbxGiaToiDa;
        private System.Windows.Forms.TextBox tbxGiaToiThieu;
        private System.Windows.Forms.TextBox tbxSucChua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}