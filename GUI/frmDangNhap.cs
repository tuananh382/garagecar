using System;
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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }


        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            if (textDangNhap.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tài khoản!");
            }
            else if (textMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
                string TaiKhoan = textDangNhap.Text;
                string MatKhau = textMatKhau.Text;
                if (DangNhap(TaiKhoan, MatKhau))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông Báo");
                    frmMain f = new frmMain();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    textDangNhap.Clear();
                    textMatKhau.Clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại tên hoặc mật khẩu!");
                }

            }
        }
        bool DangNhap(string TaiKhoan, string MatKhau)
        {
            return TaiKhoanBUS.Instance.DangNhap(TaiKhoan,MatKhau);
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDangNhap_Click(object sender, EventArgs e)
        {
            textDangNhap.BackColor = Color.White;
            panel3.BackColor = Color.White;
            textMatKhau.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
        }

        private void textMatKhau_Click(object sender, EventArgs e)
        {
            textDangNhap.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            textMatKhau.BackColor = Color.White;
            panel4.BackColor = Color.White;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textMatKhau.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textMatKhau.UseSystemPasswordChar = true;
        }

        private void buttonDangNhap2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
