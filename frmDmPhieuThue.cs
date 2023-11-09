using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTPKS
{
    public partial class frmDmPhieuThue : Form
    {
        string constr, sql;
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public frmDmPhieuThue()
        {
            InitializeComponent();
        }
        public void laydanhmucphieu()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select MaPhieu,Convert(varchar(10),NgayDen,103) as NgayDen, TienCoc,TrangThai,MaNV,MaKH from tblPhieu where TrangThai =N'Chưa thanh toán'");
            grdDmPhieuthue.DataSource = dt;
        }
        private void frmDmPhieuThue_Load(object sender, EventArgs e)
        {
            laydanhmucphieu();
          //  laybangcttp();
            laybangphongtrong();
        }
        public void laykeyphieu()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select MaPhieu,Convert(varchar(10),NgayDen,103) as NgayDen, TienCoc,TrangThai,MaNV,MaKH from tblPhieu where MaKH like'%" + txtTimPhieu.Text + "%' or TrangThai like N'%" + txtTimPhieu.Text + "%' or NgayDen like '%"+txtTimPhieu.Text+"%' or MaPhieu like '%"+txtTimPhieu.Text+"%' or MaNV like '%"+txtTimPhieu.Text+"%'");
            grdDmPhieuthue.DataSource = dt;
        }
        public void laybangphongtrong()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select MaPhong as SoPhong,LoaiPhong as LoaiPhongTrong,DonGia as GiaPhong from tblPhong where TrangThai =N'Trống'");
            grdDSPT.DataSource = dt;
        }
        public void laybangcttp()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select MaPhong,Convert(varchar(10),NgayDatPhong,103) as NgayDatPhong, LoaiPhong,DonGia from tblCTTP where MaPhieu = '" + txtMaPhieu.Text + "'");
            grdCttp.DataSource = dt;
        }
        private void grdDmPhieuthue_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdCttp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    DataGridViewRow row = new DataGridViewRow();
            //    row = grdCttp.Rows[e.RowIndex];
            //    txtMaPhong.Text = row.Cells[1].Value.ToString();
            //    //////txtNgayDat.Text = row.Cells[1].Value.ToString();
            //    txtLoaiPhongcu.Text = row.Cells[4].Value.ToString();
            //    ////////txtDonGia.Text = row.Cells[3].Value.ToString();



            //}
            //catch
            //{

            //}
        }

        private void btnThemphong_Click(object sender, EventArgs e)
        {


            if (txtMaPhieu.Text != "" && txtMaPhong.Text != "" && txtMaKH.Text != "")
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("INSERT INTO tblCTTP (MaPhong,MaPhieu,NgayDatPhong,LoaiPhong,DonGia) VALUES ('" + txtMaPhong.Text + "','" + txtMaPhieu.Text + "','" + dtNgayDat.Value.ToShortDateString() + "',N'" + txtLoaiPhong.Text + "','" + float.Parse(txtDonGia.Text) + "')" +"update tblPhong set TrangThai =N'Đang ở' where MaPhong = '"+txtMaPhong.Text+"'" );
                if (kq > 0)
                {
                    MessageBox.Show("Thêm chi tiết thuê phòng thành công!");

                    laybangcttp();
                   laybangphongtrong();

                }
                else
                {
                    MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại!");
                }

            }
        }
  

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Form f = new frmSuacttp();
            f.ShowDialog();
        }

        private void grdDSPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = grdDSPT.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells[0].Value.ToString();
                txtLoaiPhong.Text = row.Cells[1].Value.ToString();
                txtDonGia.Text = row.Cells[2].Value.ToString();

            }
            catch
            {

            }
        }

        private void txtTimPhieu_TextChanged(object sender, EventArgs e)
        {
            
            laykeyphieu();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtTimPhieu_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimPhieu.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn hủy không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                constr = "Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True";
                conn.ConnectionString = constr;
                conn.Open();
                txtTienCoc.Text = string.Format("{0:0,0}", float.Parse(txtTienCoc.Text));
                sql = "update tblPhieu set TrangThai =N'Hủy' where MaPhieu ='" + txtMaPhieu.Text + "'" +
                       "Update tblPhong set TrangThai =N'Trống' where MaPhong in (Select MaPhong from tblCTTP where MaPhieu ='" + txtMaPhieu.Text + "')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hủy phiếu thành công!");
                laydanhmucphieu();
            }
            
        }
    }
}
