using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTPKS
{
    public partial class frmMain : Form
    {
       
        public frmMain()
        {
            InitializeComponent();
        }

        //public frmMain( string ID, string Pass,string Quyen)
        //{
        //    InitializeComponent();
        //    this.ID = ID;
        //    this.Pass = Pass;
        //    this.Quyen = Quyen;
        //}

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmDmPhong();
            f.ShowDialog();
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new frmDmKhachHang();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(280, 80);
            f.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmDangNhap();
            f.Show();
            this.Hide();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmDmNhanVien();
            f.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblMaNV.Text = loginUser.MaNV;
            lblTenNV.Text = loginUser.TenNV;
            lblChucVu.Text = loginUser.ChucVu;
            lblquyen.Text = loginUser.Quyen;
           
            if (string.Compare(lblquyen.Text, @"User      ") == 0)
            {
                quảnLýNgườiDùngToolStripMenuItem.Enabled = false;
                quảnLýDịchVụToolStripMenuItem.Enabled = false;
               // quảnLýPhòngToolStripMenuItem.Enabled = false;
                doanhThuDịchVụToolStripMenuItem.Enabled = false;
                doanhThuTheoKháchHàngToolStripMenuItem.Enabled = false;
                báoCáoDoanhThuTheoPhòngToolStripMenuItem.Enabled = false;
                tổngDoanhThuKháchSạnToolStripMenuItem.Enabled = false;
                quảnLýNhânViênToolStripMenuItem.Enabled = false;
                quảnLýPhòngToolStripMenuItem.Enabled = false; 
                
             
            }
           
                
           
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmThuePhong();
            f.ShowDialog();
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmDmDichVu();
            f.ShowDialog();
        }

        private void sửDụngDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmsdDV();
            f.ShowDialog();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmSuacttp();
            f.ShowDialog();
        }

        //private void danhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form f = new frmDmHoaDon();
        //    f.ShowDialog();
        //}

        //private void danhMụcPhiếuThuêToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form f = new frmDmPhieuThuePhong();
        //    f.ShowDialog();
        //}

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form f = new frmQuanLyUser();
            f.ShowDialog();

        }

        private void danhMụcPhiếuThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmdsphieuthue();
            f.ShowDialog();
        }

        private void danhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmDmHD();
            f.ShowDialog();
        }

        private void báoCáoDoanhThuTheoPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmBCDTtPhong();
            f.ShowDialog();
        }

        private void doanhThuTheoKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmBCDoanhThutKH();
            f.ShowDialog();
        }

        private void doanhThuDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmBCDoanhThutDV();
            f.ShowDialog();
        }

        private void tổngDoanhThuKháchSạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmBCDTTheoThang();
            f.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form f = new frmDangNhap();
            f.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form f = new frmDangNhap();
            f.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmDangNhap();
            f.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
