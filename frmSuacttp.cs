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
    public partial class frmSuacttp : Form
    {
        public frmSuacttp()
        {
            InitializeComponent();
        }
        public void laybangctpd()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from tblCTTP where MaPhieu in (Select MaPhieu from tblPhieu where TrangThai not in(N'Hủy', N'Đã thanh toán')) ");
            grdCttp.DataSource = dt;
        }
        public void laykeyword()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from tblCTTP where MaPhong like N'%" + txtTimMaPhong.Text + "%'");
            grdCttp.DataSource = dt;
        }
        public void laymakh()
        {
            //KetNoi kn = new KetNoi();
            //SqlCommand mysqlcommand = new SqlCommand();
            //mysqlcommand.Connection = kn.kn;
            //mysqlcommand.CommandText = "SELECT distinct tblPhieu.MaKH,tblKH.TenKH FROM tblPhieu  inner join tblKH on tblPhieu.MaKH = tblKH.MaKH where TrangThai not in (N'Hủy',N'Đã thanh toán')";
            //kn.kn_csdl();
            //SqlDataAdapter mysqladatareader = new SqlDataAdapter();
            //mysqladatareader.SelectCommand = mysqlcommand;
            //DataSet mydataset = new DataSet();
            //mysqladatareader.Fill(mydataset, "KQ");
            //DataTable table_MK = new DataTable();
            //table_MK = mydataset.Tables["KQ"];
            //cbxMaKH.DataSource = table_MK;
            //cbxMaKH.DisplayMember = table_MK.Columns["TenKH"].ToString();
            //cbxMaKH.ValueMember = table_MK.Columns["MaKH"].ToString();
        }
        private void frmSuacttp_Load(object sender, EventArgs e)
        {
            // laymakh();
            laybangctpd();
        }
        public void laymaphieu()
        {
            //KetNoi kn = new KetNoi();
            //SqlConnection con = new SqlConnection("Data Source=LAPTOP-LI182UBO\\SQLEXPRESS;Initial Catalog=QLyKS;Integrated Security=True");
            //con.Open();
            //SqlCommand cm = new SqlCommand("Select MaPhieu from tblPhieu where MaKH='" + cbxMaKH.SelectedValue.ToString() + "'", con);
            //SqlDataReader reader = cm.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    reader.Read();
            //    txtMaPhieu.Text = reader.GetString(0).ToString();
            //}
        }
        private void cbxMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

            //laymaphieu();
            //laybangctpd();



        }

        private void grdCttp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grdCttp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = grdCttp.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells[1].Value.ToString();
                txtMaPhieu.Text = row.Cells[0].Value.ToString();
                txtLoaiPhong.Text = row.Cells[7].Value.ToString();
                txtDonGia.Text = row.Cells[3].Value.ToString();
                txtNgayO.Text = row.Cells[4].Value.ToString();
                txtThanhTien.Text = row.Cells[5].Value.ToString();
                txtNgayDat.Text = Convert.ToDateTime(row.Cells[2].Value).ToShortDateString();
              // txtNgayTraPhong.Text = Convert.ToDateTime(row.Cells[8].Value).ToShortDateString();


            }
            catch
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhieu.Text != "" && txtMaPhong.Text != "" && txtNgayDat.Text != "" )
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("Update tblCTTP set NgayTraPhong = '"+dtNgayTra.Value.ToShortDateString()+"' where MaPhong ='"+txtMaPhong.Text+"' "+ "Update tblCTTP set NgayO = ( SELECT DATEDIFF(DAY,NgayDatPhong,NgayTraPhong) as NgayO) where MaPhong ='"+txtMaPhong.Text+"' "+ "update tblCTTP set ThanhTien = DonGia*NgayO where MaPhong ='"+txtMaPhong.Text+"'");
                if (kq > 0)
                {
                    MessageBox.Show("Thành công!");
                    laybangctpd();
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
        
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new frmTraPhongTT();
            f.ShowDialog();
            
            
        }

        private void txtTimMaPhong_TextChanged(object sender, EventArgs e)
        {
            laykeyword();
        }

        private void txtTimMaPhong_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimMaPhong.Text = "";
        }
    }
}
