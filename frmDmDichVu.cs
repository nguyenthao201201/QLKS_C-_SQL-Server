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
    public partial class frmDmDichVu : Form
    {
        int i; 
        public frmDmDichVu()
        {
            InitializeComponent();
        }
        public void laybangdichvu()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from tblDV");
            GridViewDSDV.DataSource = dt;
        }
        private void frmDmDichVu_Load(object sender, EventArgs e)
        {
            laybangdichvu();
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
            if (txtTenDV.Text == "")
            {
                errorProvider1.SetError(txtTenDV, "Bạn chưa nhập Tên dịch vụ!");
            }
            if (txtMaDV.Text == "")
            {
                errorProvider1.SetError(txtMaDV, "Bạn chưa nhập Mã dịch vụ!");
            }
            if (txtGiaDV.Text == "")
            {
                errorProvider1.SetError(txtGiaDV, "Bạn chưa nhập Giá dịch vụ!");
            }
            if (cbxDvt.Text == "")
            {
                errorProvider1.SetError(cbxDvt, "Bạn chưa chọn Đơn vị tính!");
            }
            if (txtTenDV.Text != "" && txtMaDV.Text != "" && txtGiaDV.Text != "" && cbxDvt.Text != "")
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("INSERT INTO tblDV VALUES ('" + txtMaDV.Text + "',N'" + txtTenDV.Text + "','" + txtGiaDV.Text + "',N'" + cbxDvt.Text + "')");
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    laybangdichvu();
                    btnAddNew.Enabled = false; 
                }
                else
                {
                    MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại!");
                }
            }

        }
        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenDV, "");
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMaDV, "");
        }

        private void txtSdtNV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtGiaDV, "");
        }

        private void txtCccdNV_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbxDvt, "");
        }

        private void GridViewDSDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            if (txtTenDV.Text == "")
            {
                errorProvider1.SetError(txtTenDV, "Bạn chưa nhập Tên dịch vụ!");
            }
            if (txtMaDV.Text == "")
            {
                errorProvider1.SetError(txtMaDV, "Bạn chưa nhập Mã dịch vụ!");
            }
            if (txtGiaDV.Text == "")
            {
                errorProvider1.SetError(txtGiaDV, "Bạn chưa nhập Giá dịch vụ!");
            }
            if (cbxDvt.Text == "")
            {
                errorProvider1.SetError(cbxDvt, "Bạn chưa chọn Đơn vị tính!");
            }
            if (txtMaDV.Text != "" && txtTenDV.Text != "" && txtGiaDV.Text != "" && cbxDvt.Text != "")
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("delete from tblDV where MaDV ='" + txtMaDV.Text + "'");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    laybangdichvu();
                }
                else
                {
                    MessageBox.Show("Không thành công, vui lòng kiểm tra lại!");
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTenDV.Text == "")
            {
                errorProvider1.SetError(txtTenDV, "Bạn chưa nhập Tên dịch vụ!");
            }
            if (txtMaDV.Text == "")
            {
                errorProvider1.SetError(txtMaDV, "Bạn chưa nhập Mã dịch vụ!");
            }
            if (txtGiaDV.Text == "")
            {
                errorProvider1.SetError(txtGiaDV, "Bạn chưa nhập Giá dịch vụ!");
            }
            if (cbxDvt.Text == "")
            {
                errorProvider1.SetError(cbxDvt, "Bạn chưa chọn Đơn vị tính!");
            }
            if (txtMaDV.Text != "" && txtTenDV.Text != "" && txtGiaDV.Text != "" && cbxDvt.Text != "")
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("update tblDV set LoaiDV=N'" + txtTenDV.Text + "',GiaDV='" + txtGiaDV.Text + "',Dvt=N'" + cbxDvt.Text + "' where MaDV='" + txtMaDV.Text + "'");
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    laybangdichvu();
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
            dt = kn.laybang("Select * from tblDV where LoaiDV like N'%" + txtKeyWordDV.Text + "%' or GiaDV like '%"+txtKeyWordDV.Text+"%' or Dvt like N'%"+txtKeyWordDV.Text+"%'");
            GridViewDSDV.DataSource = dt;
        }

        //private void btnTimKiem_Click(object sender, EventArgs e)
        //{
        //    LoadGridViewByKeyWord();
        //}

        private void txtKeyWordDV_TextChanged(object sender, EventArgs e)
        {
            LoadGridViewByKeyWord();
        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            GridViewDSDV.CurrentCell = GridViewDSDV[0, GridViewDSDV.RowCount - 1];
            NapCT();
            txtMaDV.Focus();
            btnAddNew.Enabled = true;
        }
        public void NapCT()
        {
            int i = GridViewDSDV.CurrentRow.Index;// Lấy số thứ tự dòng hiện thời 
            txtMaDV.Text = GridViewDSDV.Rows[i].Cells["MaDV"].Value.ToString();
            txtTenDV.Text = GridViewDSDV.Rows[i].Cells["LoaiDV"].Value.ToString();
            txtGiaDV.Text = GridViewDSDV.Rows[i].Cells["GiaDV"].Value.ToString();
            cbxDvt.Text = GridViewDSDV.Rows[i].Cells["Dvt"].Value.ToString();
           
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = GridViewDSDV.CurrentRow.Index;
            if (i < GridViewDSDV.RowCount - 1)
            {
                GridViewDSDV.CurrentCell = GridViewDSDV[0, i + 1];
                NapCT();
            }
            else
            {
                GridViewDSDV.CurrentCell = GridViewDSDV[0, 0];
                NapCT();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            GridViewDSDV.ClearSelection();
            GridViewDSDV.CurrentCell = GridViewDSDV[0, 0];
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            GridViewDSDV.CurrentCell = GridViewDSDV[0, GridViewDSDV.RowCount - 1];
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = GridViewDSDV.CurrentRow.Index;
            if (i > 0)
            {
                GridViewDSDV.CurrentCell = GridViewDSDV[0, i - 1];
                NapCT();
            }
            else
            {
                GridViewDSDV.CurrentCell = GridViewDSDV[0, GridViewDSDV.RowCount - 1];
                NapCT();
            }
        }

        private void GridViewDSDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridViewDSDV.Rows[e.RowIndex];
                txtMaDV.Text = row.Cells[0].Value.ToString();
                txtTenDV.Text = row.Cells[1].Value.ToString();
                txtGiaDV.Text = row.Cells[2].Value.ToString();
                cbxDvt.Text = row.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
