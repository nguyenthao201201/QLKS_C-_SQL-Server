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
    public partial class frmDangKyPhong : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();
        string sql, constr;
        public frmDangKyPhong()
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
        public void laybangPhongTrong()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select MaPhong,LoaiPhong,DonGia from tblPhong where TrangThai =N'Trống'");
            GridViewDSPhongTrong.DataSource = dt;
        }
        

        private void frmDangKyPhong_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            laybangkhachhang();
            laybangPhongTrong();
            //laysongay();
            laymanhanvien();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void GridViewDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaPhieu.Text == "")
            {
                errorProvider1.SetError(txtMaPhieu, "Bạn chưa nhập Mã phiếu");
            }
            if (cbxTrangThai.Text == "")
            {
                errorProvider1.SetError(cbxTrangThai, "Bạn chưa nhập Trạng thái!");
            }
            if (txtMaPhong.Text == "")
            {
                errorProvider1.SetError(txtMaPhong, "Bạn chưa nhập Mã phòng!");
            }
            // phải nhập tiền cọc
            if (txtMaPhieu.Text != "" && cbxTrangThai.Text != "" && txtMaPhong.Text != "")
            {
                txtTienCoc.Text = string.Format("{0:0,0}", float.Parse(txtTienCoc.Text));
                sql = "INSERT INTO tblPhieu VALUES ('" + txtMaPhieu.Text + "','" + dtNgayDen.Value.ToShortDateString()+ "','" + float.Parse(txtTienCoc.Text) + "',N'" + cbxTrangThai.Text + "','"
                       + cbxMaNV.SelectedValue.ToString() + "','" + txtMaKH.Text + "','" + txtMaPhong.Text + "')"
                       + " Update tblPhong set TrangThai = N'Đang ở' where MaPhong = '" + txtMaPhong.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công");
                laybangPhongTrong();
                    
               }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            


           
            
        }

        private void GridViewDSPhongTrong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            Form f = new frmDmKhachHang();
            f.Show();
           
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }
        public void LoadGridViewByKeyWordKH()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from tblKH where TenKH like N'%" + txtKeyWord.Text + "%'");
            GridViewDSKH.DataSource = dt;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadGridViewByKeyWordKH();
        }


        private void btnNapLaiKH_Click(object sender, EventArgs e)
        {
            laybangkhachhang();
        }

        private void txtTienCoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void GridViewDSPhongTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridViewDSPhongTrong.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells[0].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnTaoMa_Click(object sender, EventArgs e)
        {
            string maphong = Convert.ToString(txtMaPhong.Text);
            string makh = Convert.ToString(txtMaKH.Text);
            string ngay = Convert.ToString(dtNgayDen.Text);
            txtMaPhieu.Text = "P" + maphong + makh +ngay;
           
        }

        private void txtKeyWord_MouseClick(object sender, MouseEventArgs e)
        {
            txtKeyWord.Text = "";
        }

        private void txtKeyWord_TextChanged(object sender, EventArgs e)
        {
            LoadGridViewByKeyWordKH();
        }
    }
}
