using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTPKS
{
    public partial class rptDoanhThuKSprv : Form
    {
        public rptDoanhThuKSprv( rptDoanhThuTheoThang rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void rptDoanhThuKSprv_Load(object sender, EventArgs e)
        {

        }
    }
}
