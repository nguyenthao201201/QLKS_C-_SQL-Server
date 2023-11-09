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
    public partial class rptdsnvprv : Form
    {
        public rptdsnvprv( rptdsnv rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void rptdsnvprv_Load(object sender, EventArgs e)
        {

        }
    }
}
