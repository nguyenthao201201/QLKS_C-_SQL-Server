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
    public partial class frmDmPhong : Form
    {
        int i; 
        public frmDmPhong()
        {
            InitializeComponent();
        }
        public void laybangphong()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from tblPhong");
            GridViewDSPhong.DataSource = dt;
        }
        private void frmDmPhong_Load(object sender, EventArgs e)
        {
            laybangphong();
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
            if (txtMaPhong.Text == "")
            {
                errorProvider1.SetError(txtMaPhong, "Bạn chưa nhập Mã phòng");
            }
            if (cbxLoaiPhong.Text == "")
            {
                errorProvider1.SetError(cbxLoaiPhong, "Bạn chưa nhập loại phòng!");
            }
            if (txtDonGia.Text == "")
            {
                errorProvider1.SetError(txtDonGia, "Bạn chưa nhập Đơn giá!");
            }
            if (cbxTrangThai.Text == "")
            {
                errorProvider1.SetError(cbxTrangThai, "Bạn chưa nhập Trạng Thái!");
            }
            if (txtMaPhong.Text != "" && cbxLoaiPhong.Text != "" && txtDonGia.Text != "" && cbxTrangThai.Text != "")
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("INSERT INTO tblPhong VALUES ('" + txtMaPhong.Text + "',N'" + cbxLoaiPhong.Text + "','" + txtDonGia.Text + "',N'" + cbxTrangThai.Text + "')");
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    laybangphong();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại!");
                }
            }
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMaPhong, "");
        }

        private void cbxTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbxTrangThai, "");
        }

        private void cbxLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbxLoaiPhong, "");
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDonGia, "");
        }

        private void GridViewDSPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "")
            {
                errorProvider1.SetError(txtMaPhong, "Bạn chưa nhập Mã phòng");
            }
            if (cbxLoaiPhong.Text == "")
            {
                errorProvider1.SetError(cbxLoaiPhong, "Bạn chưa nhập loại phòng!");
            }
            if (txtDonGia.Text == "")
            {
                errorProvider1.SetError(txtDonGia, "Bạn chưa nhập Đơn giá!");
            }
            if (cbxTrangThai.Text == "")
            {
                errorProvider1.SetError(cbxTrangThai, "Bạn chưa nhập Trạng Thái!");
            }
            if (txtMaPhong.Text != "" && cbxLoaiPhong.Text != "" && txtDonGia.Text != "" && cbxTrangThai.Text != "")
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("delete from tblPhong where MaPhong ='"+txtMaPhong.Text+"'");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    laybangphong();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công, vui lòng kiểm tra lại!");
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "")
            {
                errorProvider1.SetError(txtMaPhong, "Bạn chưa nhập Mã phòng");
            }
            if (cbxLoaiPhong.Text == "")
            {
                errorProvider1.SetError(cbxLoaiPhong, "Bạn chưa nhập loại phòng!");
            }
            if (txtDonGia.Text == "")
            {
                errorProvider1.SetError(txtDonGia, "Bạn chưa nhập Đơn giá!");
            }
            if (cbxTrangThai.Text == "")
            {
                errorProvider1.SetError(cbxTrangThai, "Bạn chưa nhập Trạng Thái!");
            }
            if (txtMaPhong.Text != "" && cbxLoaiPhong.Text != "" && txtDonGia.Text != "" && cbxTrangThai.Text != "")
            {
                KetNoi kn = new KetNoi();
                int kq = kn.xulydulieu("update tblPhong set TrangThai =N'"+cbxTrangThai.Text+"' where MaPhong ='"+txtMaPhong.Text+"'");
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    laybangphong();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công, vui lòng kiểm tra lại!");
                }
            }

        }
        public void LoadGridViewByKeyWord()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("Select * from tblPhong where LoaiPhong like N'%" + txtKeyWord.Text + "%' or TrangThai like N'%"+txtKeyWord.Text+"%' or DonGia like '%"+txtKeyWord.Text+"%'");
            GridViewDSPhong.DataSource = dt;
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
            GridViewDSPhong.CurrentCell = GridViewDSPhong[0, GridViewDSPhong.RowCount - 1];
            NapCT();
            txtMaPhong.Focus();
            btnAddNew.Enabled = true;
        }
        public void NapCT()
        {
            int i = GridViewDSPhong.CurrentRow.Index;// Lấy số thứ tự dòng hiện thời 
            txtMaPhong.Text = GridViewDSPhong.Rows[i].Cells["MaPhong"].Value.ToString();
            cbxLoaiPhong.Text = GridViewDSPhong.Rows[i].Cells["LoaiPhong"].Value.ToString();
            txtDonGia.Text = GridViewDSPhong.Rows[i].Cells["DonGia"].Value.ToString();
            cbxTrangThai.Text = GridViewDSPhong.Rows[i].Cells["TrangThai"].Value.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = GridViewDSPhong.CurrentRow.Index;
            if (i < GridViewDSPhong.RowCount - 1)
            {
                GridViewDSPhong.CurrentCell = GridViewDSPhong[0, i + 1];
                NapCT();
            }
            else
            {
                GridViewDSPhong.CurrentCell = GridViewDSPhong[0, 0];
                NapCT();
            }
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = GridViewDSPhong.CurrentRow.Index;
            if (i > 0)
            {
                GridViewDSPhong.CurrentCell = GridViewDSPhong[0, i - 1];
                NapCT();
            }
            else
            {
                GridViewDSPhong.CurrentCell = GridViewDSPhong[0, GridViewDSPhong.RowCount - 1];
                NapCT();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            GridViewDSPhong.ClearSelection();
            GridViewDSPhong.CurrentCell = GridViewDSPhong[0, 0];
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            GridViewDSPhong.CurrentCell = GridViewDSPhong[0, GridViewDSPhong.RowCount - 1];
            NapCT();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void GridViewDSPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = GridViewDSPhong.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells[0].Value.ToString();
                cbxLoaiPhong.Text = row.Cells[1].Value.ToString();
                txtDonGia.Text = row.Cells[2].Value.ToString();
                cbxTrangThai.Text = row.Cells[3].Value.ToString();

            }
            catch
            {

            }
        }
    }
}
