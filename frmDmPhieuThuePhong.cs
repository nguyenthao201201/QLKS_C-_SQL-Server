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
    public partial class frmDmPhieuThuePhong : Form
    {
        string sql,sqlphieudat,constr;
        SqlConnection conn = new SqlConnection();
        SqlConnection conn2 = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public frmDmPhieuThuePhong()
        {
            InitializeComponent();
        }
        public void laydanhmucphieu()
        {
            constr = "Data Source=LAPTOP-LI182UBO\\SQLEXPRESS;Initial Catalog=QLyKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            // laydanhmucphieu();
            sqlphieudat = "select distinct P.MaPhieu,Convert(varchar(10),P.NgayDen, 103) as NgayDen,P.TienCoc,P.TrangThai,P.MaNV, P.MaPhong,K.MaKH,K.Cccd,K.TenKH,K.SdtKH from tblPhieu P INNER JOIN tblKH K on P.MaKH = K.MaKH";
            da = new SqlDataAdapter(sqlphieudat, conn);
            da.Fill(dt); ;
            GridViewDSPhieu.DataSource = dt;
            GridViewDSPhieu.Refresh();
            conn.Close();
        }
        private void frmDmPhieuThuePhong_Load(object sender, EventArgs e)
        {
            laydanhmucphieu();
        }
       
        private void GridViewDSPhieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = GridViewDSPhieu.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
                txtMaPhieu.Text = GridViewDSPhieu.Rows[i].Cells["MaPhieu"].Value.ToString();
                txtNgayDat.Text = Convert.ToDateTime(GridViewDSPhieu.Rows[i].Cells["NgayDen"].Value.ToString()).ToShortDateString();

                txtTienCoc.Text = GridViewDSPhieu.Rows[i].Cells["TienCoc"].Value.ToString();
                txtTrangThai.Text = GridViewDSPhieu.Rows[i].Cells["TrangThai"].Value.ToString();
                txtMaPhong.Text = GridViewDSPhieu.Rows[i].Cells["MaPhong"].Value.ToString();
                txtMaKH.Text = GridViewDSPhieu.Rows[i].Cells["MaKH"].Value.ToString();
                txtTenKH.Text = GridViewDSPhieu.Rows[i].Cells["TenKH"].Value.ToString();
                txtSdtKH.Text = GridViewDSPhieu.Rows[i].Cells["SdtKH"].Value.ToString();
                txtCccd.Text = GridViewDSPhieu.Rows[i].Cells["Cccd"].Value.ToString();

          
            }
            catch
            {

            }
        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            laydanhmucphieu();
        }

       private void btnXoa_Click(object sender, EventArgs e)
        {
           if (txtMaPhieu.Text != "" && txtTrangThai.Text != "" && txtMaPhong.Text != "")
            {
                string conde = "Data Source=LAPTOP-LI182UBO\\SQLEXPRESS;Initial Catalog=QLyKS;Integrated Security=True";
                conn2.ConnectionString = conde;
                conn2.Open();
                //sql = "update tblPhieu set TrangThai =N'Hủy' where MaPhieu ='" + txtMaPhieu.Text + "'"+ "update tblPhong set TrangThai=N'Trống' where MaPhong ='"+txtMaPhong.Text+"'";
                sql = "delete from tblPhieu where MaPhieu ='" + txtMaPhieu.Text + "'" + "update tblPhong set TrangThai = N'Đang ở'";
                cmd = new SqlCommand(sql, conn2);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công!");
                laydanhmucphieu();
              


            }

          
            else
            {
                MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
            }
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

       
    }
}
