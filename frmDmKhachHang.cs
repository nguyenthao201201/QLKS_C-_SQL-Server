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
    public partial class frmDmKhachHang : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string constr;
        int i;
        public frmDmKhachHang()
        {
            InitializeComponent();
        }

        public void laybangkhachhang()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from tblKH");
            GridViewDSKH.DataSource = dt;
        }
        private void frmDmKhachHang_Load(object sender, EventArgs e)
        {
            laybangkhachhang();
            constr = "Data Source=LAPTOP-LI182UBO\\THAO;Initial Catalog=QLKS;Integrated Security=True";
            con.ConnectionString = constr;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "")
            {
                errorProvider1.SetError(txtTenKH, "Bạn chưa nhập Tên khách hàng!");
            }
            if (txtSdtKH.Text == "")
            {
                errorProvider1.SetError(txtSdtKH, "Bạn chưa nhập Số điện thoại!");
            }
            if (txtMaKH.Text == "")
            {
                errorProvider1.SetError(txtMaKH, "Bạn chưa nhập Mã khách hàng!");
            }
            if (txtCccd.Text == "")
            {
                errorProvider1.SetError(txtCccd, "Bạn chưa nhập Mã số CCCD!");
            }
            if (txtMaKH.Text != "" && txtTenKH.Text != "" && txtSdtKH.Text != "" && txtCccd.Text != "")
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("INSERT INTO tblKH VALUES ('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + txtDiaChiKH.Text + "','" + txtSdtKH.Text + "','" + txtCccd.Text + "',N'" + txtGtKH.Text + "')");
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    laybangkhachhang();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại!");
                }
            }
        }
        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenKH, "");
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMaKH, "");
        }

        private void txtSdtNV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSdtKH, "");
        }

        private void txtCccdNV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCccd, "");
        }

        private void GridViewDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "")
            {
                errorProvider1.SetError(txtTenKH, "Bạn chưa nhập Tên nhân viên!");
            }
            if (txtSdtKH.Text == "")
            {
                errorProvider1.SetError(txtSdtKH, "Bạn chưa nhập Số điện thoại!");
            }
            if (txtMaKH.Text == "")
            {
                errorProvider1.SetError(txtMaKH, "Bạn chưa nhập Mã Nhân viên!");
            }
            if (txtCccd.Text == "")
            {
                errorProvider1.SetError(txtCccd, "Bạn chưa nhập Mã số CCCD!");
            }
            if (txtMaKH.Text != "" && txtTenKH.Text != "" && txtSdtKH.Text != "" && txtCccd.Text != "")
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("delete from tblKH where MaKH ='" + txtMaKH.Text + "'");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    laybangkhachhang();
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "")
            {
                errorProvider1.SetError(txtTenKH, "Bạn chưa nhập Tên nhân viên!");
            }
            if (txtSdtKH.Text == "")
            {
                errorProvider1.SetError(txtSdtKH, "Bạn chưa nhập Số điện thoại!");
            }
            if (txtMaKH.Text == "")
            {
                errorProvider1.SetError(txtMaKH, "Bạn chưa nhập Mã Nhân viên!");
            }
            if (txtCccd.Text == "")
            {
                errorProvider1.SetError(txtCccd, "Bạn chưa nhập Mã số CCCD!");
            }
            if (txtMaKH.Text != "" && txtTenKH.Text != "" && txtSdtKH.Text != "" && txtCccd.Text != "")
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("update tblKH set TenKH=N'" + txtTenKH.Text + "',DiaChiKH=N'" + txtDiaChiKH.Text + "',SdtKH='" + txtSdtKH.Text + "',Cccd='" + txtCccd.Text + "',GtKH =N'" + txtGtKH.Text + "' where MaKH='" + txtMaKH.Text + "'");
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    laybangkhachhang();
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }
            
        }
        public void LoadGridViewByKeyWordKH()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from tblKH where TenKH like N'%" + txtKeyWordKH.Text + "%' or SdtKH like '%"+txtKeyWordKH.Text+"%' or Cccd like '%"+txtKeyWordKH.Text+"%' or GtKH like N'%"+txtKeyWordKH.Text+"%' or DiaChiKH like N'%"+txtKeyWordKH.Text+"%'");
            GridViewDSKH.DataSource = dt;
        }

        //private void btnTimKiem_Click(object sender, EventArgs e)
        //{
        //    LoadGridViewByKeyWordKH();
        //}

        private void txtKeyWordKH_TextChanged(object sender, EventArgs e)
        {
            LoadGridViewByKeyWordKH();
        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            GridViewDSKH.CurrentCell = GridViewDSKH[0, GridViewDSKH.RowCount - 1];
            NapCT();
            txtMaKH.Focus();
            btnAddNew.Enabled = true;
            //int count = 0;
            //count = GridViewDSKH.Rows.Count;
            //string chuoi = "";
            //int chuoi2 = 0;
            //chuoi = Convert.ToString(GridViewDSKH.Rows[count - 2].Cells[0].Value);
            //chuoi2 = Convert.ToInt32(chuoi.Remove(0,3));
            //int tt = chuoi2 + 1;
            //if (tt < 10)
            //    txtMaKH.Text = "KH0" + tt.ToString();
            //else if (tt == 10)

            //    txtMaKH.Text = "KH" + "10";
            //else
            //    txtMaKH.Text = "KH" + tt.ToString();
            ////int count = 0;
            //count = GridViewDSKH.Rows.Count;
            //string chuoi = Convert.ToString(GridViewDSKH.Rows[count - 2].Cells[0].Value);

            //    txtMaKH.Text = "KH0" + (chuoi + 1).ToString();



        }
        public void NapCT()
        {
            int i = GridViewDSKH.CurrentRow.Index;// Lấy số thứ tự dòng hiện thời 
            txtMaKH.Text = GridViewDSKH.Rows[i].Cells["MaKH"].Value.ToString();
            txtTenKH.Text = GridViewDSKH.Rows[i].Cells["TenKH"].Value.ToString();
            txtSdtKH.Text = GridViewDSKH.Rows[i].Cells["SdtKH"].Value.ToString();
            txtDiaChiKH.Text = GridViewDSKH.Rows[i].Cells["DiaChiKH"].Value.ToString();
            txtCccd.Text = GridViewDSKH.Rows[i].Cells["Cccd"].Value.ToString();
            txtGtKH.Text = GridViewDSKH.Rows[i].Cells["GtKH"].Value.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = GridViewDSKH.CurrentRow.Index;
            if (i < GridViewDSKH.RowCount - 1)
            {
                GridViewDSKH.CurrentCell = GridViewDSKH[0, i + 1];
                NapCT();
            }
            else
            {
                GridViewDSKH.CurrentCell = GridViewDSKH[0, 0];
                NapCT();
            }
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = GridViewDSKH.CurrentRow.Index;
            if (i > 0)
            {
                GridViewDSKH.CurrentCell = GridViewDSKH[0, i - 1];
                NapCT();
            }
            else
            {
                GridViewDSKH.CurrentCell = GridViewDSKH[0, GridViewDSKH.RowCount - 1];
                NapCT();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            GridViewDSKH.ClearSelection();
            GridViewDSKH.CurrentCell = GridViewDSKH[0, 0];
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            GridViewDSKH.CurrentCell = GridViewDSKH[0, GridViewDSKH.RowCount - 1];
            NapCT();
        }

        private void GridViewDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridViewDSKH.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();

                txtDiaChiKH.Text = row.Cells[2].Value.ToString();
                txtSdtKH.Text = row.Cells[3].Value.ToString();
                txtCccd.Text = row.Cells[4].Value.ToString();
                txtGtKH.Text = row.Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            con.Open();
            rptDSKH rpt = new rptDSKH();
            string sql = "select MaKH, TenKH, GtKH, Cccd as CCCD,SdtKH, DiaChiKH from tblKH where TenKH like N'%" + txtKeyWordKH.Text + "%' or SdtKH like '%" + txtKeyWordKH.Text + "%' or Cccd like '%" + txtKeyWordKH.Text + "%' or GtKH like N'%" + txtKeyWordKH.Text + "%' or DiaChiKH like N'%" + txtKeyWordKH.Text + "%' ";
            da = new SqlDataAdapter(sql, con);
            dt.Clear();
            da.Fill(dt);
            rpt.SetDataSource(dt);
            rptdskhprv rp = new rptdskhprv(rpt);
            rp.Show();
            con.Close();


        }
    }

}
