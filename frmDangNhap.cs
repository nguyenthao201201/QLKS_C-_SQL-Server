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
    public partial class frmDangNhap : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPass.PasswordChar = '*';
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int dem;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True");
            string sql = "Select tblID.ID,tblID.Pass,tblID.Quyen,tblID.MaNV,tblNV.TenNV,tblNV.ChucVu from tblID inner join tblNV on tblID.MaNV =tblNV.MaNV where ID='" + txtUsername.Text +
            "' and Pass='" + txtPass.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (txtUsername.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ username và password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataAdapter adapt = new SqlDataAdapter(cmd); DataSet ds = new DataSet();
                adapt.Fill(ds);
                DataTable dtUser = new DataTable();
                adapt.Fill(dtUser);
                SqlDataReader sdr = cmd.ExecuteReader();
                conn.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dtUser.Load(sdr);
                    DataRow userRow = dtUser.Rows[0];
                    loginUser.MaNV = userRow["MaNV"].ToString();
                    loginUser.TenNV = userRow["TenNV"].ToString();
                    loginUser.ChucVu = userRow["ChucVu"].ToString();
                    loginUser.Quyen = userRow["Quyen"].ToString();

                    
                    this.Hide();
                    frmMain f = new frmMain();
                    f.Show();
                   
                }
                else
                {
                    dem++;
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dem == 3)
                    {
                        MessageBox.Show("Thử lại sau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Exit();
                    }
                }
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            btnLogin.Focus();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtPass.Focus();
        }
    }
}
