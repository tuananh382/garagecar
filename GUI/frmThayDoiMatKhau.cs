﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmThayDoiMatKhau : Form
    {
        public frmThayDoiMatKhau()
        {
            InitializeComponent();
        }

        bool XacNhanChuTaiKhoan()
        {
            return txtBoxNhapLaiMatKhauCu.Text == TaiKhoanBUS.Instance.LayMatKhau();
        }

        bool XacNhanMatKhauMoi()
        {
            return txtBoxNhapMatKhauMoi.Text == txtBoxXacNhanMatKhauMoi.Text;
        }
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmThayDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtBoxTaiKhoan.Text = TaiKhoanBUS.Instance.LayTenTaiKhoan();
        }

        //private void BtnHienMatKhauCu_Click(object sender, EventArgs e)
        //{
        //    if (btnHienMatKhauCu.Text == "Hiện mật khẩu")
        //    {
        //        btnHienMatKhauCu.Text = "Ẩn mật khẩu";
        //        txtBoxNhapLaiMatKhauCu.UseSystemPasswordChar = !txtBoxNhapLaiMatKhauCu.UseSystemPasswordChar;
        //    }
        //    else
        //    {
        //        btnHienMatKhauCu.Text = "Hiện mật khẩu";
        //        txtBoxNhapLaiMatKhauCu.UseSystemPasswordChar = !txtBoxNhapLaiMatKhauCu.UseSystemPasswordChar;
        //    }
        //}

        //private void BtnHienMatKhauMoi_Click(object sender, EventArgs e)
        //{

        //    if (btnHienMatKhauMoi.Text == "Hiện mật khẩu")
        //    {
        //        btnHienMatKhauMoi.Text = "Ẩn mật khẩu";
        //        txtBoxNhapMatKhauMoi.UseSystemPasswordChar = !txtBoxNhapMatKhauMoi.UseSystemPasswordChar;
        //    }
        //    else
        //    {
        //        btnHienMatKhauMoi.Text = "Hiện mật khẩu";
        //        txtBoxNhapMatKhauMoi.UseSystemPasswordChar = !txtBoxNhapMatKhauMoi.UseSystemPasswordChar;
        //    }
        //}

        //private void BtnHienMatKhauMoiXacNhan_Click(object sender, EventArgs e)
        //{

        //    if (btnHienMatKhauMoiXacNhan.Text == "Hiện mật khẩu")
        //    {
        //        btnHienMatKhauMoiXacNhan.Text = "Ẩn mật khẩu";
        //        txtBoxXacNhanMatKhauMoi.UseSystemPasswordChar = !txtBoxXacNhanMatKhauMoi.UseSystemPasswordChar;
        //    }
        //    else
        //    {
        //        btnHienMatKhauMoiXacNhan.Text = "Hiện mật khẩu";
        //        txtBoxXacNhanMatKhauMoi.UseSystemPasswordChar = !txtBoxXacNhanMatKhauMoi.UseSystemPasswordChar;
        //    }
        //}

        private void BtnLuuThayDoi_Click(object sender, EventArgs e)
        {
            if (XacNhanChuTaiKhoan())
            {
                if (XacNhanMatKhauMoi())
                {
                    TaiKhoanBUS.Instance.CapNhatMatKhau(txtBoxNhapMatKhauMoi.Text, TaiKhoanBUS.Instance.LayMaTaiKhoan());
                    MessageBox.Show("Cập nhật mật khẩu thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không trùng khớp. Xin vui lòng nhập lại!", "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBoxNhapLaiMatKhauCu.Clear();
                    txtBoxNhapMatKhauMoi.Clear();
                    txtBoxXacNhanMatKhauMoi.Clear();
              
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng. Xin vui lòng thử lại!", "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxNhapLaiMatKhauCu.Clear();
                txtBoxNhapMatKhauMoi.Clear();
                txtBoxXacNhanMatKhauMoi.Clear();
               
            }
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxNhapLaiMatKhauCu.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtBoxNhapLaiMatKhauCu.UseSystemPasswordChar = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxNhapMatKhauMoi.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            txtBoxNhapMatKhauMoi.UseSystemPasswordChar = true;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxXacNhanMatKhauMoi.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtBoxXacNhanMatKhauMoi.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
