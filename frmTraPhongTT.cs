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
    public partial class frmTraPhongTT : Form
    {
        string constr, sql;
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da1 = new SqlDataAdapter();
        public frmTraPhongTT()
        {
            InitializeComponent();
        }
        public void laymakh()
        {
            KetNoi kn = new KetNoi();
            SqlCommand mysqlcommand = new SqlCommand();
            mysqlcommand.Connection = kn.kn;
            mysqlcommand.CommandText = "select distinct MaKH from tblPhieu where TrangThai Not in(N'Hủy',N'Đã thanh toán')";
            kn.kn_csdl();
            SqlDataAdapter mysqladatareader = new SqlDataAdapter();
            mysqladatareader.SelectCommand = mysqlcommand;
            DataSet mydataset = new DataSet();
            mysqladatareader.Fill(mydataset, "KQ");
            DataTable table_MK = new DataTable();
            table_MK = mydataset.Tables["KQ"];
            cbxMaKH.DataSource = table_MK;
            cbxMaKH.DisplayMember = table_MK.Columns["MaKH"].ToString();
            cbxMaKH.ValueMember = table_MK.Columns["MaKH"].ToString();
        }
        public void layttkh()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True");
            conn.Open();
            SqlCommand cm1 = new SqlCommand("select tblKH.TenKH,tblKH.SdtKH,tblKH.Cccd,tblPhieu.MaPhieu,Convert(varchar(10),tblPhieu.NgayDen,103) as NgayDen,tblPhieu.TienCoc,tblNV.MaNV,tblNV.TenNV from tblPhieu inner join tblKH on tblPhieu.MaKH = tblKH.MaKH" +
                            " inner join tblNV on tblPhieu.MaNV = tblNV.MaNV where tblPhieu.MaKH = '" + cbxMaKH.SelectedValue.ToString()+"' and tblPhieu.TrangThai Not in (N'Hủy', N'Đã thanh toán')", conn);
            SqlDataReader reader1 = cm1.ExecuteReader();
            while (reader1.Read())
            {
                txtTenKH.Text = reader1[0].ToString();
                txtSdt.Text = reader1[1].ToString();
                txtCccd.Text = reader1[2].ToString();
                txtMaHD.Text = reader1[3].ToString();
                txtNgayDen.Text = reader1[4].ToString();
                  //  Convert.ToDateTime(reader1[4]).ToShortDateString();
                txtTienCoc.Text = reader1[5].ToString();
                txtMaNV.Text = reader1[6].ToString();
                txtTenNVtMaNV.Text = reader1[7].ToString();
            }
        }
        public void laycttp()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("SELECT MaPhong, Convert(varchar(10),NgayDatPhong,103) as NgayDatPhong, LoaiPhong, DonGia, NgayO, ThanhTien FROM   tblCTTP where MaPhieu = '"+txtMaHD.Text+"'");
            grdCttp.DataSource = dt;
        }
        public void layctsddv()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select MaPhong as MaPhongsddv, MaDV, SoLuong,Convert(varchar(10),NgayGoi,103) as NgayGoi,ThanhTien from sdDV where MaPhieu = '" + txtMaHD.Text + "'");
            GridViewDSSDDV.DataSource = dt;
        }
            private void frmTraPhongTT_Load(object sender, EventArgs e)
        {
            laymakh();
            //tinhtienphong();
            // layttkh();
            //laycttp();
        }
        public void tinhtienphong()
        {
            
        }
        private void cbxMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            layttkh();
            laycttp();
            layctsddv();
            int sc = GridViewDSSDDV.Rows.Count;
            float thanhtiendv = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtiendv += float.Parse(GridViewDSSDDV.Rows[i].Cells["ThanhTien"].Value.ToString());
            lblTongTienDV.Text = (thanhtiendv).ToString();
            lblTongTienDV.Text = string.Format("{0:0,0}", float.Parse(lblTongTienDV.Text));
            int sl = grdCttp.Rows.Count;
            float thanhtienphong = 0;
            for (int i = 0; i < sl - 1; i++)
                thanhtienphong += float.Parse(grdCttp.Rows[i].Cells["ThanhTien"].Value.ToString());
            lblTienphong.Text = (thanhtienphong).ToString();
            lblTienphong.Text = string.Format("{0:0,0}", float.Parse(lblTienphong.Text));

            txtTongTien.Text = (thanhtiendv + thanhtienphong).ToString();
            float.TryParse(txtTongTien.Text, out float tongtien);
            //txtTienCoc.Text = string.Format("{0:0,0}", float.Parse(txtTienCoc.Text));
            float.TryParse(txtTienCoc.Text, out float tiencoc);
            txtThanhToan.Text = (tongtien - tiencoc).ToString();
            txtTongTien.Text = string.Format("{0:0,0}", float.Parse(txtTongTien.Text));
            txtThanhToan.Text = string.Format("{0:0,0}", float.Parse(txtThanhToan.Text));


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Form f = new frmSuacttp();
            f.ShowDialog();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string kn1 = "Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True";
            con.ConnectionString = kn1;
            con.Open();
            rptHoaDon rpt = new rptHoaDon();
            string sqlhd = "SELECT distinct tblCTTP.MaPhong, convert (varchar(10),tblCTTP.NgayDatPhong,103) as NgayDatPhong, tblCTTP.LoaiPhong, tblCTTP.DonGia, tblCTTP.NgayO, tblCTTP.ThanhTien, sdDV.MaPhong as MPDV,convert(varchar(10),sdDV.NgayGoi,103) as NgayGoi, " +
                            "sdDV.ThanhTien AS ThanhtienDV, sdDV.SoLuong, sdDV.MaDV FROM sdDV right JOIN tblCTTP ON sdDV.MaPhieu = tblCTTP.MaPhieu and tblCTTP.MaPhong = sdDV.MaPhong where tblCTTP.MaPhieu = '"+txtMaHD.Text+"'";
           // string sqlhd = "select MaPhong,convert (varchar(10),tblCTTP.NgayDatPhong,103) as NgayDatPhong, LoaiPhong, DonGia, NgayO, ThanhTien from tblCTTP where MaPhieu ='" + txtMaHD.Text + "'";
           //string dv=  " select MaPhong as MaPhongDV, MaDV as MaDVV, SoLuong as SoLuongDV, convert(varchar(10), sdDV.NgayGoi, 103) as NgayGoiDV, ThanhTien as ThanhTienDVV from sdDV where MaPhieu = '" + txtMaHD.Text + "'";
            da = new SqlDataAdapter(sqlhd, con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            rpt.SetDataSource(dt);//đỗ dữ liệu vừa truy vấn vào bảng 
            rpt.DataDefinition.FormulaFields["MaHD"].Text = "'" + txtMaHD.Text + "'";
            rpt.DataDefinition.FormulaFields["TenKH"].Text = "'" + txtTenKH.Text + "'";
            rpt.DataDefinition.FormulaFields["SdtKH"].Text = "'" + txtSdt.Text + "'";
            rpt.DataDefinition.FormulaFields["Cccd"].Text = "'" + txtCccd.Text + "'";
            rpt.DataDefinition.FormulaFields["NgayDen"].Text = "'" + txtNgayDen.Text + "'";
            rpt.DataDefinition.FormulaFields["TienPhong"].Text = "'" + lblTienphong.Text + "'";
            rpt.DataDefinition.FormulaFields["TienDV"].Text = "'" + lblTongTienDV.Text + "'";
            rpt.DataDefinition.FormulaFields["TongTien"].Text = "'" + txtTongTien.Text + "'";
           //rpt.DataDefinition.FormulaFields["NgayTt"].Text = "'" + dtNgayTt.Text + "'";

            //SqlConnection con1 = new SqlConnection("Data Source=LAPTOP-LI182UBO\\SQLEXPRESS;Initial Catalog=QLyKS;Integrated Security=True");
            //con1.Open();
            //string sqlphong = "SELECT MaPhong, NgayDatPhong, LoaiPhong, DonGia, NgayO, ThanhTien FROM   tblCTTP where MaPhieu = N'" + txtMaHD.Text + "'";
            //da1 = new SqlDataAdapter(sqlphong, con1);
            //DataTable dtphong = new DataTable();
            //dtphong.Clear();
            //da1.Fill(dtphong);
            //rpt.SetDataSource(dtphong);
            rptHoaDonprv rp = new rptHoaDonprv(rpt);
            rp.Show();
            con.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text != "" && txtTongTien.Text != "" )
            {
                constr = "Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True";
                conn.ConnectionString = constr;
                conn.Open();
              
                sql = "Insert into tblHD values ('" + txtMaHD.Text + "',N'" + cbxPttt.Text + "','" + dtNgayTt.Value.ToShortDateString() + "','" + decimal.Parse(txtTongTien.Text) + "','" + decimal.Parse(lblTongTienDV.Text) + "','" + decimal.Parse(lblTienphong.Text) + "','"+txtMaNV.Text+"','"+txtMaHD.Text+"','"+cbxMaKH.SelectedValue.ToString()+"')"
                       + " update tblPhieu set TrangThai = N'Đã thanh toán' where MaPhieu = '"+txtMaHD.Text+"'"
                       + "update tblPhong set TrangThai =N'Trống' where MaPhong in(Select MaPhong from tblCTTP where MaPhieu ='"+txtMaHD.Text+"')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lưu hóa đơn thành công!");
                btnIn.Enabled = true;
               conn.Close();
               
            }
        }
    }
}
