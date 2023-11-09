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
    public partial class frmDmNhanVien : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        int i;
        string constr;
        public frmDmNhanVien()
        {
            InitializeComponent();
        }

        public void laybangnhanvien()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from tblNV");
            GridViewDSNV.DataSource = dt;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmDmNhanVien_Load(object sender, EventArgs e)
        {
            laybangnhanvien();
            constr = "Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True";
            con.ConnectionString = constr;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dg ==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            

            if (txtTenNV.Text=="")
            {
                errorProvider1.SetError(txtTenNV, "Bạn chưa nhập Tên nhân viên!");
            }
            if(txtSdtNV.Text=="")
            {
                errorProvider1.SetError(txtSdtNV, "Bạn chưa nhập Số điện thoại!");
            }
            if(txtMaNV.Text=="")
            {
                errorProvider1.SetError(txtMaNV, "Bạn chưa nhập Mã Nhân viên!");
            }
            if(txtCccdNV.Text=="")
            {
                errorProvider1.SetError(txtCccdNV, "Bạn chưa nhập Mã số CCCD!");
            }
            if(txtMaNV.Text!="" && txtTenNV.Text!="" && txtSdtNV.Text!="" && txtCccdNV.Text!="")
            {
                KetNoi kn = new KetNoi();
                int kq=kn.xulydulieu("INSERT INTO tblNV VALUES ('"+txtMaNV.Text+"',N'"+txtTenNV.Text+"',N'"+txtDiaChiNV.Text+"','"+txtSdtNV.Text+"','"+txtCccdNV.Text+"',N'"+txtGtNV.Text+"',N'"+cbxChucVu.Text+"')");
                if(kq>0)
                {
                    MessageBox.Show("Thêm thành công!");
                    laybangnhanvien();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại!");
                }
            }
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenNV, "");
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMaNV, "");
        }

        private void txtSdtNV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSdtNV, "");
        }

        private void txtCccdNV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCccdNV, "");
        }

        private void GridViewDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "")
            {
                errorProvider1.SetError(txtTenNV, "Bạn chưa nhập Tên nhân viên!");
            }
            if (txtSdtNV.Text == "")
            {
                errorProvider1.SetError(txtSdtNV, "Bạn chưa nhập Số điện thoại!");
            }
            if (txtMaNV.Text == "")
            {
                errorProvider1.SetError(txtMaNV, "Bạn chưa nhập Mã Nhân viên!");
            }
            if (txtCccdNV.Text == "")
            {
                errorProvider1.SetError(txtCccdNV, "Bạn chưa nhập Mã số CCCD!");
            }
            if (txtMaNV.Text != "" && txtTenNV.Text != "" && txtSdtNV.Text != "" && txtCccdNV.Text != "")
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("delete from tblNV where MaNV ='"+txtMaNV.Text+"'");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    laybangnhanvien();
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "")
            {
                errorProvider1.SetError(txtTenNV, "Bạn chưa nhập Tên nhân viên!");
            }
            if (txtSdtNV.Text == "")
            {
                errorProvider1.SetError(txtSdtNV, "Bạn chưa nhập Số điện thoại!");
            }
            if (txtMaNV.Text == "")
            {
                errorProvider1.SetError(txtMaNV, "Bạn chưa nhập Mã Nhân viên!");
            }
            if (txtCccdNV.Text == "")
            {
                errorProvider1.SetError(txtCccdNV, "Bạn chưa nhập Mã số CCCD!");
            }
            if (txtMaNV.Text != "" && txtTenNV.Text != "" && txtSdtNV.Text != "" && txtCccdNV.Text != "")
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("update tblNV set TenNV=N'" + txtTenNV.Text + "',DiaChiNV=N'" + txtDiaChiNV.Text + "',SdtNV='" + txtSdtNV.Text + "',CccdNV='" + txtCccdNV.Text + "',GtNV=N'" + txtGtNV.Text + "', ChucVu = N'"+cbxChucVu.Text+"'where MaNV='" + txtMaNV.Text + "'");
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    laybangnhanvien();
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
            
        }
        public void LoadGridViewByKeyWord()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from tblNV where TenNV like N'%" + txtKeyWord.Text + "%' or DiaChiNV like N'%" + txtKeyWord.Text + "%' or GtNV like N'%" + txtKeyWord.Text +"%' or ChucVu like N'%"+txtKeyWord.Text+"%' or SdtNV like '%"+txtKeyWord.Text+"%' or CccdNV like '%"+txtKeyWord.Text+"%'");
            GridViewDSNV.DataSource = dt;
        }
        //private void btnTimKiem_Click(object sender, EventArgs e)
        //{
        //    LoadGridViewByKeyWord();
        //}

        private void txtKeyWord_TextChanged(object sender, EventArgs e)
        {
            LoadGridViewByKeyWord();
        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            GridViewDSNV.CurrentCell = GridViewDSNV[0, GridViewDSNV.RowCount - 1];
            NapCT();
            txtMaNV.Focus();
            btnAddNew.Enabled = true;
            //int count = 0;
            //count = GridViewDSNV.Rows.Count;
            //string chuoi = "";
            //int chuoi2 = 0;
            //chuoi = Convert.ToString(GridViewDSNV.Rows[count - 2].Cells[0].Value);
            //chuoi2 = Convert.ToInt32(chuoi.Remove(0, 3));
            //if (chuoi2 + 1 < 10)
            //    txtMaNV.Text = "NV0" + (chuoi2 + 1).ToString();
            //else if (chuoi2 + 1 < 100)
            //    txtMaNV.Text = "NV" + (chuoi2 + 1).ToString();
        }
        public void NapCT()
        {
            int i = GridViewDSNV.CurrentRow.Index;// Lấy số thứ tự dòng hiện thời 
            txtMaNV.Text = GridViewDSNV.Rows[i].Cells["MaNV"].Value.ToString();
            txtTenNV.Text = GridViewDSNV.Rows[i].Cells["TenNV"].Value.ToString();
            txtSdtNV.Text = GridViewDSNV.Rows[i].Cells["SdtNV"].Value.ToString();
            txtDiaChiNV.Text = GridViewDSNV.Rows[i].Cells["DiaChiNV"].Value.ToString();
            txtCccdNV.Text = GridViewDSNV.Rows[i].Cells["CccdNV"].Value.ToString();
            txtGtNV.Text = GridViewDSNV.Rows[i].Cells["GtNV"].Value.ToString();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            i = GridViewDSNV.CurrentRow.Index;
            if (i < GridViewDSNV.RowCount - 1)
            {
                GridViewDSNV.CurrentCell = GridViewDSNV[0, i + 1];
                NapCT();
            }
            else
            {
                GridViewDSNV.CurrentCell = GridViewDSNV[0, 0];
                NapCT();
            }
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = GridViewDSNV.CurrentRow.Index;
            if (i > 0)
            {
                GridViewDSNV.CurrentCell = GridViewDSNV[0, i - 1];
                NapCT();
            }
            else
            {
                GridViewDSNV.CurrentCell = GridViewDSNV[0, GridViewDSNV.RowCount - 1];
                NapCT();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            GridViewDSNV.ClearSelection();
            GridViewDSNV.CurrentCell = GridViewDSNV[0, 0];
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            GridViewDSNV.CurrentCell = GridViewDSNV[0, GridViewDSNV.RowCount - 1];
            NapCT();
        }

        private void GridViewDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridViewDSNV.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();

                txtDiaChiNV.Text = row.Cells[2].Value.ToString();
                txtSdtNV.Text = row.Cells[3].Value.ToString();
                txtCccdNV.Text = row.Cells[4].Value.ToString();
                txtGtNV.Text = row.Cells[5].Value.ToString();
                cbxChucVu.Text = row.Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            con.Open();
            rptdsnv rpt = new rptdsnv();

            string sql = "Select MaNV, TenNV, GtNV, CccdNV, SdtNV, DiaChiNV, ChucVu from tblNV where TenNV like N'%" + txtKeyWord.Text + "%' or DiaChiNV like N'%" + txtKeyWord.Text + "%' or GtNV like N'%" + txtKeyWord.Text + "%' or ChucVu like N'%" + txtKeyWord.Text + "%' or SdtNV like '%" + txtKeyWord.Text + "%' or CccdNV like '%" + txtKeyWord.Text + "%'";
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            rpt.SetDataSource(dt);
            rptdsnvprv rp = new rptdsnvprv(rpt);
            rp.Show();
            con.Close();

        }
    }
}
