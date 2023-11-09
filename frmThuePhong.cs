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
    public partial class frmThuePhong : Form
    {
        string sql,constr;
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public frmThuePhong()
        {
            InitializeComponent();
        }
        public void laybangkhachhang()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from tblKH");
            GridViewDSKH.DataSource = dt;
        }
        public void laybangphongtrong()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select MaPhong,LoaiPhong,DonGia from tblPhong where TrangThai =N'Trống'");
            GridViewDSPT.DataSource = dt;
        }
        public void laymanhanvien()
        {
            KetNoi kn = new KetNoi();
            SqlCommand mysqlcommand = new SqlCommand();
            mysqlcommand.Connection = kn.kn;
            mysqlcommand.CommandText = "select MaNV,TenNV from tblNV";
            kn.kn_csdl();
            SqlDataAdapter mysqladatareader = new SqlDataAdapter();
            mysqladatareader.SelectCommand = mysqlcommand;
            DataSet mydataset = new DataSet();
            mysqladatareader.Fill(mydataset, "KQ");
            DataTable table_MK = new DataTable();
            table_MK = mydataset.Tables["KQ"];
            cbxMaNV.DataSource = table_MK;
            cbxMaNV.DisplayMember = table_MK.Columns["TenNV"].ToString();
            cbxMaNV.ValueMember = table_MK.Columns["MaNV"].ToString();


            kn.kn.Close();

        }
        public void laybangcttp()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select MaPhong,Convert(varchar(10),NgayDatPhong,103) as NgayDatPhong,LoaiPhong,DonGia from tblCTTP where MaPhieu = '"+txtMaPhieu.Text+"'");
            GridViewCTTP.DataSource = dt;
        }
        private void frmThuePhong_Load(object sender, EventArgs e)
        {
            laybangphongtrong();
            laybangkhachhang();
            laymanhanvien();
            laybangcttp();
        }

        private void GridViewDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridViewDSKH.Rows[e.RowIndex];
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtCccd.Text = row.Cells[4].Value.ToString();
                txtMaKH.Text = row.Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn đã nhập đầy đủ thông tin và chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void GridViewDSPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            Form f = new frmDmKhachHang();
            f.Show();
        }


      
            private void GridViewDSPT_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
       

            if (txtMaPhieu.Text != "" && txtMaKH.Text != "")
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("INSERT INTO tblCTTP (MaPhong,MaPhieu,NgayDatPhong,LoaiPhong,DonGia) VALUES ('" + txtMaPhong.Text + "','" + txtMaPhieu.Text + "','" + dtNgayDat.Value.ToShortDateString() + "','" + txtLoaiPhong.Text + "','" + float.Parse(txtDonGia.Text) + "')" + " update tblPhong set TrangThai = N'Đang ở' where MaPhong in (Select MaPhong from tblCTTP where MaPhieu = '"+txtMaPhieu.Text+"')");
               // int kq = kn.xulydulieu("insert into tblPhieu (MaPhieu,NgayDen,TienCoc,MaNV, MaKH, TrangThai) values ('"+txtMaPhieu.Text+"','"+dtNgayDen.Value.ToString()+"','"+float.Parse(txtTienCoc.Text)+"','"+cbxMaNV.SelectedValue.ToString()+"','"+txtMaKH.Text+"',N'"+cbxTrangThai.Text+"') INSERT INTO tblCTTP(MaPhong, MaPhieu, NgayDatPhong, LoaiPhong, DonGia) VALUES('P1002', 'P10021711', '2022-11-16', N'Grand Premium Suite', 1600000)")
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

        private void btnDmPhieu_Click(object sender, EventArgs e)
        {
           
            Form f = new frmDmPhieuThue();
            f.Show();
               
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            

            if (txtMaPhieu.Text != "" && txtMaPhong.Text != "" && txtMaKH.Text != "")
            {
                constr = "Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True";
                conn.ConnectionString = constr;
                conn.Open();
                txtTienCoc.Text = string.Format("{0:0,0}", float.Parse(txtTienCoc.Text));
                sql = "Insert into tblPhieu values ('" + txtMaPhieu.Text + "','" + dtNgayDen.Value.ToShortDateString() + "','" + float.Parse(txtTienCoc.Text) + "',N'" + cbxTrangThai.Text + "','" + cbxMaNV.SelectedValue.ToString() + "','" + txtMaKH.Text + "')"
                       ;
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm phiếu thành công! Hãy thêm thông tin phòng thuê!");
                laybangphongtrong();
                conn.Close();
               
                btnThem.Enabled = true;
            }
        }
        public void LoadGridViewByKeyWordKH()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from tblKH where TenKH like N'%" + txtKeyWord.Text + "%' or DiaChiKH like N'%"+txtKeyWord.Text+"%' or SdtKH like '%"+txtKeyWord.Text+"%' or Cccd like '%"+txtKeyWord.Text+"%' or MaKH like '%"+txtKeyWord.Text+"%'");
            GridViewDSKH.DataSource = dt;
        }

        private void txtKeyWord_TextChanged(object sender, EventArgs e)
        {
            //txtMaKH.Text = "";
            LoadGridViewByKeyWordKH();
        }

        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {
//            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-LI182UBO\\SQLEXPRESS;Initial Catalog=QLyKS;Integrated Security=True");
//            conn.Open();
//            SqlCommand cm1 = new SqlCommand("SELECT tblPhieu.MaKH, tblPhieu.NgayDen, tblPhieu.TienCoc, tblPhieu.TrangThai, tblPhieu.MaNV, tblCTTP.MaPhong, tblCTTP.NgayDatPhong, tblCTTP.LoaiPhong, tblCTTP.DonGia"+
//"FROM   tblPhieu INNER JOIN tblCTTP ON tblPhieu.MaPhieu = tblCTTP.MaPhieuwhere tblPhieu.MaPhieu = '"+txtMaPhieu.Text+"'", conn); 

//            SqlDataReader reader1 = cm1.ExecuteReader();
//            while (reader1.Read())
//            {
//                txtMaKH.Text = reader1[0].ToString();
                
//                txtLoaiPhong.Text = reader1[0].ToString();
//                txtDonGia.Text = reader1[1].ToString();
//            }
        }

        private void GridViewCTTP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTaoma_Click(object sender, EventArgs e)
        {
            string maphong = Convert.ToString(txtMaPhong.Text);
            

            txtMaPhieu.Text = (maphong).ToString();

        }

        private void txtKeyWord_MouseClick(object sender, MouseEventArgs e)
        {
            txtKeyWord.Text = "";
        }

        private void GridViewDSPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridViewDSPT.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells[0].Value.ToString();
                txtLoaiPhong.Text = row.Cells[1].Value.ToString();
                txtDonGia.Text = row.Cells[2].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtCccd.Text = "";
            txtMaPhieu.Text = "";
            txtMaPhong.Text = "";
            txtLoaiPhong.Text = "";
            txtDonGia.Text = "";
            txtTienCoc.Text = "";
            cbxMaNV.Text = "";
        }

        private void GridViewDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridViewDSKH.Rows[e.RowIndex];
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtCccd.Text = row.Cells[4].Value.ToString();
                txtMaKH.Text = row.Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
