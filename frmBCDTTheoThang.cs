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
    public partial class frmBCDTTheoThang : Form
    {
        string sql, constr;
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public frmBCDTTheoThang()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmBCDTTheoThang_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            rptDoanhThuTheoThang rpt = new rptDoanhThuTheoThang();
            sql = "SELECT distinct Month(NgayTt) as Thang, Year(NgayTt) as Nam,sum(TienPhong) as DTPhong, sum(TienDV) as DTDV, sum(TongTien) as TongDT FROM tblHD "
                 + "where Month(NgayTt) between '" + string.Format("{0:MM}", Convert.ToDateTime(Tungay.Value.ToString())) + "'" + " and '" + string.Format("{0:MM}", Convert.ToDateTime(Denngay.Value.ToString())) + "'" +
                 " and Year(NgayTt) between '" + string.Format("{0:yyyy}", Convert.ToDateTime(Tungay.Value.ToString())) + "'" + " and '" + string.Format("{0:yyyy}", Convert.ToDateTime(Denngay.Value.ToString())) + "'" +
                 " Group by Month(NgayTt), Year(NgayTt) order by Month(NgayTt) asc";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            rpt.SetDataSource(dt);
            rpt.DataDefinition.FormulaFields["Tungay"].Text = "'" + string.Format("{0:MM/yyyy}", Convert.ToDateTime(Tungay.Value.ToString())) + "'";
            rpt.DataDefinition.FormulaFields["Denngay"].Text = "'" + string.Format("{0:MM/yyyy}", Convert.ToDateTime(Denngay.Value.ToString())) + "'";

            rptDoanhThuKSprv rp = new rptDoanhThuKSprv(rpt);
            rp.Show();
            conn.Close();
        }
    }
}
