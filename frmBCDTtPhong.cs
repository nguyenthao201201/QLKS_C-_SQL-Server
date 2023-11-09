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
    public partial class frmBCDTtPhong : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string constr,sql;
        public frmBCDTtPhong()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();

            rptDTtP rpt = new rptDTtP();
            sql = "SELECT tblPhong.LoaiPhong, sum(tblHD.TienPhong) as DoanhThu, count(tblCTTP.MaPhong) as SoLan FROM tblPhong INNER JOIN "
             + "tblCTTP ON tblPhong.MaPhong = tblCTTP.MaPhong INNER JOIN tblPhieu INNER JOIN tblHD ON tblPhieu.MaPhieu = tblHD.MaPhieu ON tblCTTP.MaPhieu = tblPhieu.MaPhieu where tblHD.NgayTt between '"+Convert.ToString(Tungay.Text)+"' and '"+Convert.ToString(Denngay.Text)+"' Group by tblPhong.LoaiPhong Order by count(tblCTTP.MaPhong) desc";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            rpt.SetDataSource(dt);
            rpt.DataDefinition.FormulaFields["Tungay"].Text = "'" + Convert.ToString(Tungay.Text) + "'";
            rpt.DataDefinition.FormulaFields["Denngay"].Text = "'" + Convert.ToString(Denngay.Text) + "'";
            rptDtTheoPhongprv rp = new rptDtTheoPhongprv(rpt);
            rp.Show();
            conn.Close();
        }

        private void frmBCDTtPhong_Load(object sender, EventArgs e)
        {
            constr = "Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True";
            conn.ConnectionString = constr;
            
        }
    }
}
