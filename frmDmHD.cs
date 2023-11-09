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
    public partial class frmDmHD : Form
    {
        string sql,constr;
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public frmDmHD()
        {
            InitializeComponent();
        }
        public void laybanghoadon()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from tblHD");
            GridViewDSHD.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridViewDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridViewDSHD.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells[0].Value.ToString();
                txtPttt.Text = row.Cells[1].Value.ToString();
                txtNgayTT.Text = row.Cells[2].Value.ToString();
                txtTienDV.Text = row.Cells[3].Value.ToString();
                txtTienPhong.Text = row.Cells[4].Value.ToString();
                txtTongTien.Text = row.Cells[5].Value.ToString();
                txtMaNV.Text = row.Cells[6].Value.ToString();
                txtMaKH.Text = row.Cells[7].Value.ToString();



            }
            catch
            {

            }
        }
        public void laykeyword()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from tblHD where MaHD like '%"+txtKeyWordHD.Text+"%' or PhuongThucTt like N'%"+txtKeyWordHD.Text+"%' or MaNV like '%"+txtKeyWordHD.Text+"%' or MaKH like '%"+txtKeyWordHD.Text+"%' or NgayTt like '%"+txtKeyWordHD.Text+"%' or TongTien like '%"+txtKeyWordHD.Text+"%'");
            GridViewDSHD.DataSource = dt;
        }

        private void txtKeyWordHD_TextChanged(object sender, EventArgs e)
        {
            laykeyword();
        }

        private void frmDmHD_Load(object sender, EventArgs e)
        {
            laybanghoadon();
        }
    }
}
