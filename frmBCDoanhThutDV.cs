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
    public partial class frmBCDoanhThutDV : Form
    {
        string sql, constr;
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public frmBCDoanhThutDV()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmBCDoanhThutDV_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            rptDTDV rpt = new rptDTDV();
            sql = "SELECT tblDV.MaDV, tblDV.LoaiDV as TenDV, tblDV.GiaDV, sum(sdDV.SoLuong) as SoLuong, sum(sdDV.ThanhTien) as ThanhTien FROM tblDV INNER JOIN "
             + "sdDV ON tblDV.MaDV = sdDV.MaDV INNER JOIN tblHD ON sdDV.MaPhieu = tblHD.MaPhieu where tblHD.NgayTt between '" + Convert.ToString(Tungay.Text) + "' and '" + Convert.ToString(Denngay.Text) + "' "
             + "Group by tblDV.MaDV, tblDV.LoaiDV,tblDV.GiaDV Order by sum(sdDV.SoLuong) desc";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            rpt.SetDataSource(dt);
            rpt.DataDefinition.FormulaFields["Tungay"].Text = "'" + Convert.ToString(Tungay.Text) + "'";
            rpt.DataDefinition.FormulaFields["Denngay"].Text = "'" + Convert.ToString(Denngay.Text) + "'";
            rptDtTheoDVprv rp = new rptDtTheoDVprv(rpt);
            rp.Show();
            conn.Close();
            
            
        }
    }
}
