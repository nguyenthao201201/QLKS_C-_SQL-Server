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
    public partial class frmdsphieuthue : Form
    {
        public frmdsphieuthue()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void laydanhmucphieu()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select MaPhieu,Convert(varchar(10),NgayDen,103) as NgayDen, TienCoc,TrangThai,MaNV,MaKH from tblPhieu");
            grdDmPhieuthue.DataSource = dt;
        }
        public void laybangcttp()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select MaPhong,Convert(varchar(10),NgayDatPhong,103) as NgayDatPhong, LoaiPhong,DonGia, NgayO, Convert(varchar(10),NgayTraPhong,103) as NgayTraPhong from tblCTTP where MaPhieu = '" + txtMaPhieu.Text + "'");
            grdCttp.DataSource = dt;
        }
        public void laykeyphieu()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select MaPhieu,Convert(varchar(10),NgayDen,103) as NgayDen, TienCoc,TrangThai,MaNV,MaKH from tblPhieu where MaKH like'%" + txtTimPhieu.Text + "%' or TrangThai like N'%" + txtTimPhieu.Text + "%' or NgayDen like '%" + txtTimPhieu.Text + "%' or MaPhieu like '%" + txtTimPhieu.Text + "%' or MaNV like '%" + txtTimPhieu.Text + "%'");
            grdDmPhieuthue.DataSource = dt;
        }
        private void grdDmPhieuthue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void frmdsphieuthue_Load(object sender, EventArgs e)
        {
           laydanhmucphieu();
           // laybangcttp();
            //laykeyphieu();
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdDmPhieuthue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = grdDmPhieuthue.Rows[e.RowIndex];
                txtMaPhieu.Text = row.Cells[0].Value.ToString();
                txtNgayDen.Text = row.Cells[1].Value.ToString();
                txtTienCoc.Text = row.Cells[2].Value.ToString();
                txtMaKH.Text = row.Cells[5].Value.ToString();
                txtTrangThai.Text = row.Cells[3].Value.ToString();


            }
            catch
            {

            }
        }

        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {
            laybangcttp();
        }

        private void txtTimPhieu_TextChanged(object sender, EventArgs e)
        {
            laykeyphieu();
        }

        private void grdCttp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = grdCttp.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells[0].Value.ToString();
                txtNgayDat.Text = row.Cells[1].Value.ToString();
                txtLoaiPhong.Text = row.Cells[2].Value.ToString();
                txtDonGia.Text = row.Cells[3].Value.ToString();
                txtNgayTra.Text = row.Cells[5].Value.ToString();


            }
            catch
            {

            }
        }

        private void txtTimPhieu_Click(object sender, EventArgs e)
        {
            laykeyphieu();
        }
    }
}
