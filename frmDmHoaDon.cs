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
    public partial class frmDmHoaDon : Form
    {
        string constr, sql;
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public frmDmHoaDon()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void laybanghoadon()
        {
            constr = "Data Source=LAPTOP-LI182UBO\\SQLEXPRESS;Initial Catalog=QLyKS;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            // laydanhmucphieu();
            sql= "select distinct tblHD.MaHD,tblHD.NgayTt,tblHD.TienPhong,tblHD.TienDV,tblHD.TongTien,tblHD.PhuongThucTt,tblKH.TenKH,tblKH.Cccd,tblNV.TenNV,tblPhieu.MaPhong,tblPhieu.NgayDen from tblHD inner join tblKH on tblHD.MaKH = tblKH.MaKH inner join tblNV on tblHD.MaNV = tblNV.MaNV inner join tblPhieu on tblHD.MaPhieu = tblPhieu.MaPhieu";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt); ;
            GridViewDSHD.DataSource = dt;
            GridViewDSHD.Refresh();
        }
        private void frmDmHoaDon_Load(object sender, EventArgs e)
        {
            laybanghoadon();
        }

        private void GridViewDSHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = GridViewDSHD.CurrentRow.Index;//lấy số thứ tự dòng hiện thời
                txtMaHD.Text = GridViewDSHD.Rows[i].Cells["MaHD"].Value.ToString();
                txtNgayTt.Text = Convert.ToDateTime(GridViewDSHD.Rows[i].Cells["NgayTt"].Value.ToString()).ToShortDateString();
                txtNgayDen.Text = Convert.ToDateTime(GridViewDSHD.Rows[i].Cells["NgayTt"].Value.ToString()).ToShortDateString();
                txtTenKH.Text = GridViewDSHD.Rows[i].Cells["TenKH"].Value.ToString();
                txtTenNV.Text = GridViewDSHD.Rows[i].Cells["TenNV"].Value.ToString();
                txtMaPhong.Text = GridViewDSHD.Rows[i].Cells["MaPhong"].Value.ToString();
                txtTienDV.Text = GridViewDSHD.Rows[i].Cells["TienDV"].Value.ToString();
                txtTienPhong.Text = GridViewDSHD.Rows[i].Cells["TienPhong"].Value.ToString();
                txtTongHD.Text = GridViewDSHD.Rows[i].Cells["TongTien"].Value.ToString();
                
                txtCccd.Text = GridViewDSHD.Rows[i].Cells["Cccd"].Value.ToString();


            }
            catch
            {

            }
        }
    }
}
