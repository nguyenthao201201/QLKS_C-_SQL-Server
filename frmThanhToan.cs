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
    public partial class frmThanhToan : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        SqlConnection conn4 = new SqlConnection();

        public frmThanhToan()
        {
            InitializeComponent();
        }
        public void laybangchitietDV()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from sdDV where MaPhieu = '"+txtMaHD.Text+"'");
            GridViewDSSDDV.DataSource = dt;
        }
        public void laymaphong()
        {
            KetNoi kn = new KetNoi();
            SqlCommand mysqlcommand = new SqlCommand();
            mysqlcommand.Connection = kn.kn;
            mysqlcommand.CommandText = "select MaPhong from tblPhieu where TrangThai =N'Chưa thanh toán' or TrangThai =N'Đã cọc'";
            kn.kn_csdl();
            SqlDataAdapter mysqladatareader = new SqlDataAdapter();
            mysqladatareader.SelectCommand = mysqlcommand;
            DataSet mydataset = new DataSet();
            mysqladatareader.Fill(mydataset, "KQ");
            DataTable table_MK = new DataTable();
            table_MK = mydataset.Tables["KQ"];
            cbxMaPhong.DataSource = table_MK;
            cbxMaPhong.DisplayMember = table_MK.Columns["MaPhong"].ToString();
            cbxMaPhong.ValueMember = table_MK.Columns["MaPhong"].ToString();
        }
        public void layloaigiaphong()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True");
            conn.Open();
            SqlCommand cm1 = new SqlCommand("Select LoaiPhong,DonGia from tblPhong where MaPhong='" + cbxMaPhong.SelectedValue.ToString() + "'", conn);
            SqlDataReader reader1 = cm1.ExecuteReader();
            while (reader1.Read())
            {
                txtLoaiPhong.Text = reader1[0].ToString();
                txtDonGia.Text = reader1[1].ToString();
            }    
        }
        public void laymakh()
        {
            SqlConnection conn1 = new SqlConnection("Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True");
            conn1.Open();
            SqlCommand cm2 = new SqlCommand("Select tblKH.MaKH, tblKH.TenKH, tblKH.Cccd, tblKH.SdtKH, Convert(varchar(10),tblPhieu.NgayDen,103) as NgayDen, tblPhieu.TienCoc,tblNV.MaNV,tblNV.TenNV from tblPhieu inner join tblKH on tblPhieu.MaKH = tblKH.MaKH " +
                "inner join tblNV on tblPhieu.MaNV = tblNV.MaNV where MaPhong='" + cbxMaPhong.SelectedValue.ToString() + "'", conn1);
            SqlDataReader reader2 = cm2.ExecuteReader();
            while (reader2.Read())
            {
                txtMaKH.Text = reader2[0].ToString();
                txtTenKH.Text = reader2[1].ToString();
                txtCccd.Text = reader2[2].ToString();
                txtSdt.Text = reader2[3].ToString(); 
                txtNgayDen.Text = Convert.ToDateTime(reader2[4]).ToShortDateString();
                txtTienCoc.Text = reader2[5].ToString();
                txtMaNV.Text = reader2[6].ToString();
                txtTenNVtMaNV.Text = reader2[7].ToString();

                DateTime fromDate = Convert.ToDateTime(txtNgayDen.Text);
                // DateTime toDate = DateTime.Today;
                DateTime toDate = Convert.ToDateTime(dtNgayTt.Value);
                //TimeSpan time = toDate.Subtract(fromDate);
                TimeSpan time = toDate - fromDate;
                int days = time.Days;
                if (days == 0)
                {
                    txtSoNgay.Text = "1";
                }
                else
                {
                    txtSoNgay.Text = days.ToString();
                }
            }
        }
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            laymaphong();
           // laybangchitietDV();
        }

        private void cbxMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            KetNoi kn = new KetNoi();
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True");
            con.Open();
            SqlCommand cm = new SqlCommand("Select MaPhieu from tblPhieu where MaPhong='" + cbxMaPhong.SelectedValue.ToString() + "' and TrangThai=N'Chưa thanh toán' or TrangThai =N'Đã cọc'", con);
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txtMaHD.Text = reader.GetString(0).ToString();
               //txtMaKH.Text = reader.GetString(5).ToString();
            }
            laybangchitietDV();
            int sc = GridViewDSSDDV.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(GridViewDSSDDV.Rows[i].Cells["ThanhTien"].Value.ToString());
            lblTongTienDV.Text = (thanhtien).ToString();

            layloaigiaphong();
            laymakh();
            float.TryParse(txtDonGia.Text, out float dongia);
            float.TryParse(txtSoNgay.Text, out float songay);
           // int songay = Convert.ToInt32(txtSoNgay.Text);
            float tienphong = (dongia * songay);
            lblTienphong.Text = (tienphong).ToString();
            lblTienphong.Text = string.Format("{0:0,0}", float.Parse(lblTienphong.Text));
            txtTongTien.Text = (tienphong + thanhtien).ToString();
            float.TryParse(txtTongTien.Text, out float tongtien);
            float.TryParse(txtTienCoc.Text, out float tiencoc);
            //double tiencoc = Convert.ToDouble(txtTienCoc.Text);
            txtThanhToan.Text = (tongtien - tiencoc).ToString();
            //txtTongtien.Text = tongtien.ToString();
            txtTongTien.Text = string.Format("{0:0,0}", float.Parse(txtTongTien.Text));
            lblTongTienDV.Text = string.Format("{0:0,0}", float.Parse(lblTongTienDV.Text));
            txtThanhToan.Text = string.Format("{0:0,0}", float.Parse(txtThanhToan.Text));
            con.Close();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtNgayTt_ValueChanged(object sender, EventArgs e)
        {
            DateTime fromDate = Convert.ToDateTime(txtNgayDen.Text);
            // DateTime toDate = DateTime.Today;
            DateTime toDate = Convert.ToDateTime(dtNgayTt.Value);
            
            TimeSpan time = toDate - fromDate;
            int days = time.Days;
            if (days == 0)
            {
                txtSoNgay.Text = "1";
            }
            else
            {
                txtSoNgay.Text = days.ToString();
            }
        }

       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KetNoi kn = new KetNoi();
            SqlConnection conn3 = new SqlConnection("Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            // conn3.Open();
            conn3.Open();
            if (txtMaHD.Text == "")
            {
                errorProvider1.SetError(txtMaHD, "Bạn chưa nhập Mã Hóa đơn!");
            }
            if (cbxMaPhong.Text == "")
            {
                errorProvider1.SetError(cbxMaPhong, "Bạn chưa nhập Mã phòng!");
            }


            if (txtMaHD.Text != "" && cbxMaPhong.Text != "")
            {
                string sql;

                
                sql = "INSERT INTO tblHD VALUES ('" + txtMaHD.Text + "',N'" + cbxPttt.Text + "','" + dtNgayTt.Value.ToShortDateString() + "','" + float.Parse(txtTongTien.Text) + "','"
                       + float.Parse(lblTongTienDV.Text) + "','" + float.Parse(lblTienphong.Text) + "','" + txtMaNV.Text + "','"+txtMaHD.Text+"','"+txtMaKH.Text+"')"
                       + " Update tblPhong set TrangThai = N'Trống' where MaPhong = '" + cbxMaPhong.SelectedValue.ToString() + "'"
                       + " Update tblPhieu set TrangThai = N'Đã thanh toán' where MaPhieu ='"+txtMaHD.Text+"'";
                cmd = new SqlCommand(sql, conn3);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công");

               
                rptHoaDon rpt = new rptHoaDon();
                sql = "SELECT tblDV.LoaiDV, tblDV.GiaDV, sdDV.SoLuong, sdDV.ThanhTien, sdDV.NgayGoi FROM sdDV INNER JOIN tblDV ON sdDV.MaDV = tblDV.MaDV where MaPhieu = '" + txtMaHD.Text + "'";
               
                DataTable dt = new DataTable();
                da = new SqlDataAdapter(sql, conn4);
                dt.Clear();
                da.Fill(dt);
                rpt.SetDataSource(dt);// đổ dữ liệu truy vấn vào báo cáo 


                rptHoaDonprv rp = new rptHoaDonprv(rpt);
                rp.Show();



            }
            else
            {
                MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
            }
            conn3.Close();
        }

        private void GridViewDSSDDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
