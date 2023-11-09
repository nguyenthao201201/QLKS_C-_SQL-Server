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
    public partial class frmHuongDan : Form
    {
        public frmHuongDan()
        {
            InitializeComponent();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "nDmKH":
                    webBrowser1.Navigate("D:\\QLTPKS\\QLTPKS\\Help\\Hướng dẫn Dm Khách hàng.mht");
                    //webBrowser1.ShowHelpt("")
                    break;
                default:
                    break;
            }
                
        }
    }
}
