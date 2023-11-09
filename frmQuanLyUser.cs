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
    public partial class frmQuanLyUser : Form
    {
        //string constr, sqlid;
        SqlDataAdapter da = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection();
        DataTable dt = new DataTable();
        public frmQuanLyUser()
        {
            InitializeComponent();
        }
        public void laybangID()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from tblID");
            GridViewDSID.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridViewDSID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridViewDSID.Rows[e.RowIndex];
                txtMaID.Text = row.Cells[0].Value.ToString();
                txtMaNV.Text = row.Cells[2].Value.ToString();
                txtPass.Text = row.Cells[1].Value.ToString();
                cbxQuyen.Text = row.Cells[3].Value.ToString();
               

            }
            catch
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
           
            
            if (txtMaID.Text != "" && txtTenNV.Text != "" && txtPass.Text != "" )
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("INSERT INTO tblID VALUES ('" + txtMaID.Text + "','" + txtPass.Text + "','"+cbxQuyen.Text+ "','" + txtMaID.Text + "')");
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    laybangID();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaID.Text == "")
            {
                errorProvider1.SetError(txtMaID, "Bạn chưa nhập Mã ID");
            }
            if (txtTenNV.Text == "")
            {
                errorProvider1.SetError(txtTenNV, "Bạn chưa nhập tên NV!");
            }
            if (txtPass.Text == "")
            {
                errorProvider1.SetError(txtPass, "Bạn chưa nhập Password!");
            }

            if (txtMaID.Text != "" )
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("update tblID set Pass='" + txtPass.Text + "',Quyen ='"+cbxQuyen.Text+"' where ID = '" + txtMaID.Text + "'");
                if(kq>0)
                {
                    MessageBox.Show("Sửa thành công!");
                    laybangID();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công, vui lòng kiểm tra lại!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaID.Text == "")
            {
                errorProvider1.SetError(txtMaID, "Bạn chưa nhập Mã ID");
            }
            if (txtTenNV.Text == "")
            {
                errorProvider1.SetError(txtTenNV, "Bạn chưa nhập tên NV!");
            }
            if (txtPass.Text == "")
            {
                errorProvider1.SetError(txtPass, "Bạn chưa nhập Password!");
            }

            if (txtMaID.Text != "" && txtTenNV.Text != "" && txtPass.Text != "")
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("delete from tblID where ID ='"+txtMaID.Text+"'");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    laybangID();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại!");
                }
            }
        }

      
        private void frmQuanLyUser_Load(object sender, EventArgs e)
        {
            laybangID();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            KetNoi kn = new KetNoi();
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True");
            con.Open();
            SqlCommand cm = new SqlCommand("Select TenNV,CccdNV,ChucVu from tblNV where MaNV='" + txtMaNV.Text + "'", con);
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txtTenNV.Text = reader.GetString(0).ToString();
                txtCccd.Text = reader.GetString(1).ToString();
                txtChucVu.Text = reader.GetString(2).ToString();
            }
            con.Close();
        }

        private void btnTimNV_Click(object sender, EventArgs e)
        {
            Form f = new frmDmNhanVien();
            f.ShowDialog();
        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            GridViewDSID.CurrentCell = GridViewDSID[0, GridViewDSID.RowCount - 1];
            NapCT();
            txtMaID.Focus();

            btnThem.Enabled = true;
            // sinh mã tự động 
            //int count = 0;
            //count = GridViewDSID.Rows.Count;
            //string chuoi = "";
            //int chuoi2 = 0;
            //chuoi = Convert.ToString(GridViewDSID.Rows[count - 2].Cells[0].Value);
            //chuoi2 = Convert.ToInt32(chuoi.Remove(0, 3));
            //if (chuoi2 + 1 < 10)
            //    txtMaID.Text = "NV0" + (chuoi2 + 1).ToString();
            //else if (chuoi2 + 1 < 100)
            //    txtMaID.Text = "NV" + (chuoi2 + 1).ToString();

        }
        public void NapCT()
        {
            int i = GridViewDSID.CurrentRow.Index;// Lấy số thứ tự dòng hiện thời 
            txtMaID.Text = GridViewDSID.Rows[i].Cells["MaID"].Value.ToString();
            txtPass.Text = GridViewDSID.Rows[i].Cells["Pass"].Value.ToString();
            txtMaNV.Text = GridViewDSID.Rows[i].Cells["MaNV"].Value.ToString();
            cbxQuyen.Text = GridViewDSID.Rows[i].Cells["Quyen"].Value.ToString();
            
        }
        public void laykey()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from tblID where ID like '%"+txtTimKiem.Text+"%' or Quyen like N'%"+txtTimKiem.Text+"%' or MaNV like '%"+txtTimKiem.Text+"%'");
            GridViewDSID.DataSource = dt;
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            laykey();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPass.PasswordChar = '*';
            }
        }

        private void txtMaID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
