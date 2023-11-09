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
    public partial class frmsdDV : Form
    {
        public frmsdDV()
        {
            InitializeComponent();
        }
        public void laybangdichvu()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from tblDV");
            GridViewDSDV.DataSource = dt;
        }
        public void laybangchitietDV()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from sdDV where MaPhieu ='"+txtMaPhieu.Text+"'");
            GridViewCTSDDV.DataSource = dt;
        }
        public void laymaphong()
        {
            KetNoi kn = new KetNoi();
            SqlCommand mysqlcommand = new SqlCommand();
            mysqlcommand.Connection = kn.kn;
            mysqlcommand.CommandText = "select MaPhong from tblPhong where TrangThai =N'Đang ở'";
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
      
        private void frmsdDV_Load(object sender, EventArgs e)
        {
            laybangdichvu();
            laybangchitietDV();
            laymaphong();
         //   laymaphieu();
        }

        private void GridViewDSDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = GridViewDSDV.Rows[e.RowIndex];
            txtMaDV.Text = row.Cells[0].Value.ToString();
            txtTenDV.Text = row.Cells[1].Value.ToString();
            txtGiaDV.Text = row.Cells[2].Value.ToString();
            txtDvt.Text = row.Cells[3].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void cbxMaPhong_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void cbxMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            KetNoi kn = new KetNoi();
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True");
            con.Open();
            SqlCommand cm = new SqlCommand("SELECT tblPhieu.MaPhieu FROM   tblCTTP INNER JOIN tblPhieu ON tblCTTP.MaPhieu = tblPhieu.MaPhieu where tblPhieu.TrangThai in (N'Đã cọc',N'Chưa thanh toán') and tblCTTP.MaPhong = '"+cbxMaPhong.SelectedValue.ToString()+"'", con);
            SqlDataReader reader = cm.ExecuteReader();
            if(reader.HasRows)
            {
                reader.Read();
                txtMaPhieu.Text = reader.GetString(0).ToString();
            }    
        }

        private void updownSoLuong_ValueChanged(object sender, EventArgs e)
        {
            float.TryParse(txtGiaDV.Text, out float Dongia);
            float Soluong = 1;
            Soluong = Convert.ToInt32(updownSoLuong.Value.ToString());
            float Thanhtien = Dongia * Soluong;
            txtThanhTien.Text = Thanhtien.ToString();

            //  float Dongia = Convert.ToDecimal(txtGiaDV.Text);
            //int Dongia = Convert.ToInt32(tx.Text);

            // txtThanhTien.Text = txtGiaDV.Text;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Text == "")
            {
                errorProvider1.SetError(txtMaDV, "Bạn chưa nhập Mã Dịch vụ!");
            }
            if (txtMaPhieu.Text == "")
            {
                errorProvider1.SetError(txtMaPhieu, "Bạn chưa nhập Số điện thoại!");
            }
            if (txtThanhTien.Text == "")
            {
                errorProvider1.SetError(txtThanhTien, "Bạn chưa nhập Mã khách hàng!");
            }
          
            if (txtMaDV.Text != "" && txtMaPhieu.Text != "" && txtMaPhieu.Text != "" && txtThanhTien.Text != "")
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("INSERT INTO sdDV (MaPhieu, MaDV, SoLuong, ThanhTien, NgayGoi, MaPhong) VALUES ('" + txtMaPhieu.Text + "','" + txtMaDV.Text + "','" + updownSoLuong.Value + "','" + txtThanhTien.Text + "','" + dtNgayGoi.Value.ToShortDateString() + "','"+cbxMaPhong.SelectedValue.ToString()+"')");
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    laybangchitietDV();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại!");
                }
            }
        }

        private void GridViewCTSDDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridViewDSDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = GridViewDSDV.Rows[e.RowIndex];
            txtMaDV.Text = row.Cells[0].Value.ToString();
            txtTenDV.Text = row.Cells[1].Value.ToString();
            txtGiaDV.Text = row.Cells[2].Value.ToString();
            txtDvt.Text = row.Cells[3].Value.ToString();
        }

        private void txtGiaDV_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(txtGiaDV.Text, out float Dongia);
            float Soluong = 1;
            Soluong = Convert.ToInt32(updownSoLuong.Value.ToString());
            float Thanhtien = Dongia * Soluong;
            txtThanhTien.Text = Thanhtien.ToString();
        }
    }
}
