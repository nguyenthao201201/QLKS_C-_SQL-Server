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
    public partial class frmBCDoanhThutKH : Form
    {
        string sql, constr;
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public frmBCDoanhThutKH()
        {
            InitializeComponent();
        }

        private void frmBCDoanhThutKH_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            rptDtTheoKH rpt = new rptDtTheoKH();
            sql = "SELECT tblKH.TenKH, tblKH.SdtKH, tblKH.Cccd, count(tblHD.MaHD) as SoLan, sum(tblHD.TongTien) as DoanhThu "
                  + "FROM tblHD INNER JOIN tblKH ON tblHD.MaKH = tblKH.MaKH where tblHD.NgayTt between '"+Convert.ToString(Tungay.Text)+"' and '"+Convert.ToString(Denngay.Text)+"' "
                   + "group by tblKH.TenKH, tblKH.SdtKH, tblKH.Cccd Order by count(tblHD.MaHD) desc";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            rpt.SetDataSource(dt);
            rpt.DataDefinition.FormulaFields["Tungay"].Text = "'" + Convert.ToString(Tungay.Text) + "'";
            rpt.DataDefinition.FormulaFields["Denngay"].Text = "'" + Convert.ToString(Denngay.Text) + "'";
            

            rptDTtheoKHprv rp = new rptDTtheoKHprv(rpt);
            rp.Show();
            conn.Close();

        }
    }
}
