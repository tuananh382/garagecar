namespace GUI
{
    partial class frmThongTinTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinTaiKhoan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxQuyenHan = new System.Windows.Forms.TextBox();
            this.lblQuyenHan = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxHoTen = new System.Windows.Forms.TextBox();
            this.lblHoten = new System.Windows.Forms.Label();
            this.btnThoat = new buttoncustom.RJButton();
            this.btnDoiMatKhau = new buttoncustom.RJButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnDoiMatKhau);
            this.panel1.Location = new System.Drawing.Point(-1, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 231);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtBoxQuyenHan);
            this.panel4.Controls.Add(this.lblQuyenHan);
            this.panel4.Location = new System.Drawing.Point(86, 107);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 54);
            this.panel4.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(-2, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 2);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // txtBoxQuyenHan
            // 
            this.txtBoxQuyenHan.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxQuyenHan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxQuyenHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxQuyenHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtBoxQuyenHan.Location = new System.Drawing.Point(103, 17);
            this.txtBoxQuyenHan.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxQuyenHan.Name = "txtBoxQuyenHan";
            this.txtBoxQuyenHan.ReadOnly = true;
            this.txtBoxQuyenHan.Size = new System.Drawing.Size(191, 16);
            this.txtBoxQuyenHan.TabIndex = 5;
            this.txtBoxQuyenHan.Click += new System.EventHandler(this.txtBoxQuyenHan_Click);
            this.txtBoxQuyenHan.TextChanged += new System.EventHandler(this.txtBoxQuyenHan_TextChanged);
            // 
            // lblQuyenHan
            // 
            this.lblQuyenHan.AutoSize = true;
            this.lblQuyenHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyenHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblQuyenHan.Location = new System.Drawing.Point(2, 16);
            this.lblQuyenHan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuyenHan.Name = "lblQuyenHan";
            this.lblQuyenHan.Size = new System.Drawing.Size(97, 17);
            this.lblQuyenHan.TabIndex = 2;
            this.lblQuyenHan.Text = "Quyền hạn: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtBoxTaiKhoan);
            this.panel3.Controls.Add(this.lblTaiKhoan);
            this.panel3.Location = new System.Drawing.Point(86, 54);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 49);
            this.panel3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(0, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 2);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // txtBoxTaiKhoan
            // 
            this.txtBoxTaiKhoan.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtBoxTaiKhoan.Location = new System.Drawing.Point(103, 15);
            this.txtBoxTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTaiKhoan.Name = "txtBoxTaiKhoan";
            this.txtBoxTaiKhoan.ReadOnly = true;
            this.txtBoxTaiKhoan.Size = new System.Drawing.Size(191, 16);
            this.txtBoxTaiKhoan.TabIndex = 3;
            this.txtBoxTaiKhoan.Click += new System.EventHandler(this.txtBoxTaiKhoan_Click);
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTaiKhoan.Location = new System.Drawing.Point(2, 14);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(85, 17);
            this.lblTaiKhoan.TabIndex = 4;
            this.lblTaiKhoan.Text = "Tài khoản:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtBoxHoTen);
            this.panel2.Controls.Add(this.lblHoten);
            this.panel2.Location = new System.Drawing.Point(86, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 46);
            this.panel2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label6.Location = new System.Drawing.Point(2, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 2);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // txtBoxHoTen
            // 
            this.txtBoxHoTen.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtBoxHoTen.Location = new System.Drawing.Point(103, 14);
            this.txtBoxHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxHoTen.Name = "txtBoxHoTen";
            this.txtBoxHoTen.ReadOnly = true;
            this.txtBoxHoTen.Size = new System.Drawing.Size(191, 16);
            this.txtBoxHoTen.TabIndex = 1;
            this.txtBoxHoTen.Click += new System.EventHandler(this.txtBoxHoTen_Click);
            this.txtBoxHoTen.TextChanged += new System.EventHandler(this.txtBoxHoTen_TextChanged);
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.BackColor = System.Drawing.SystemColors.Control;
            this.lblHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblHoten.Location = new System.Drawing.Point(2, 13);
            this.lblHoten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(83, 17);
            this.lblHoten.TabIndex = 0;
            this.lblHoten.Text = "Họ và tên:";
            this.lblHoten.Click += new System.EventHandler(this.lblHoten_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(258, 180);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(162, 40);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(40, 179);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(162, 41);
            this.btnDoiMatKhau.TabIndex = 9;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.BtnDoiMatKhau_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(440, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(109, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // frmThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 308);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThongTinTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.FrmThongTinTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxHoTen;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.TextBox txtBoxQuyenHan;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.TextBox txtBoxTaiKhoan;
        private System.Windows.Forms.Label lblQuyenHan;
        private buttoncustom.RJButton btnThoat;
        private buttoncustom.RJButton btnDoiMatKhau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}