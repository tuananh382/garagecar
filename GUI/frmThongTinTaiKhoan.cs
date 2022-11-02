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
    public partial class frmThongTinTaiKhoan : Form
    {
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }


        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmThayDoiMatKhau tdmk = new frmThayDoiMatKhau();
            tdmk.ShowDialog();
        }

        private void FrmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            txtBoxHoTen.Text = TaiKhoanBUS.Instance.LayHoTen();
            txtBoxTaiKhoan.Text = TaiKhoanBUS.Instance.LayTenTaiKhoan();
            txtBoxQuyenHan.Text = TaiKhoanBUS.Instance.LayQuyenHan();
        }

        private void lblHoten_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBoxQuyenHan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxHoTen_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            txtBoxHoTen.BackColor = Color.White;
            lblHoten.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            txtBoxTaiKhoan.BackColor = SystemColors.Control;
            lblTaiKhoan.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            txtBoxQuyenHan.BackColor = SystemColors.Control;
            lblQuyenHan.BackColor = SystemColors.Control;
        }

        private void txtBoxTaiKhoan_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            txtBoxTaiKhoan.BackColor = Color.White;
            lblTaiKhoan.BackColor = Color.White;
            panel2.BackColor = SystemColors.Control;
            txtBoxHoTen.BackColor = SystemColors.Control;
            lblHoten.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
            txtBoxQuyenHan.BackColor = SystemColors.Control;
            lblQuyenHan.BackColor = SystemColors.Control;
        }

        private void txtBoxQuyenHan_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
            txtBoxQuyenHan.BackColor = Color.White;
            lblQuyenHan.BackColor = Color.White;
            panel2.BackColor = SystemColors.Control;
            txtBoxHoTen.BackColor = SystemColors.Control;
            lblHoten.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            txtBoxTaiKhoan.BackColor = SystemColors.Control;
            lblTaiKhoan.BackColor = SystemColors.Control;
        }

        //private void txtBoxHoTen_MouseDown(object sender, MouseEventArgs e)
        //{
        //    panel2.BackColor = Color.White;
        //    txtBoxHoTen.BackColor = Color.White;
        //    lblHoten.BackColor = Color.White;
        //}

        //private void txtBoxHoTen_MouseUp(object sender, MouseEventArgs e)
        //{
        //    panel2.BackColor = SystemColors.Control;
        //    txtBoxHoTen.BackColor = SystemColors.Control;
        //    lblHoten.BackColor = SystemColors.Control;
        //}

        //private void txtBoxTaiKhoan_MouseDown(object sender, MouseEventArgs e)
        //{
        //    panel3.BackColor = Color.White;
        //    txtBoxTaiKhoan.BackColor = Color.White;
        //    lblTaiKhoan.BackColor = Color.White;
        //}

        //private void txtBoxTaiKhoan_MouseUp(object sender, MouseEventArgs e)
        //{
        //    panel3.BackColor = SystemColors.Control;
        //    txtBoxTaiKhoan.BackColor = SystemColors.Control;
        //    lblTaiKhoan.BackColor = SystemColors.Control;
        //}

        //private void txtBoxQuyenHan_MouseDown(object sender, MouseEventArgs e)
        //{
        //    panel4.BackColor = Color.White;
        //    txtBoxQuyenHan.BackColor = Color.White;
        //    lblQuyenHan.BackColor = Color.White;
        //}

        //private void txtBoxQuyenHan_MouseUp(object sender, MouseEventArgs e)
        //{
        //    panel4.BackColor = SystemColors.Control;
        //    txtBoxQuyenHan.BackColor = SystemColors.Control;
        //    lblQuyenHan.BackColor = SystemColors.Control;
        //}
    }
   
}
