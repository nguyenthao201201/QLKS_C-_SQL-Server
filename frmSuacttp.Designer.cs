
namespace QLTPKS
{
    partial class frmSuacttp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuacttp));
            this.grdCttp = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTraPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtNgayDat = new System.Windows.Forms.TextBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtNgayO = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimMaPhong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCttp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCttp
            // 
            this.grdCttp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCttp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.MaPhieu,
            this.NgayDatPhong,
            this.LoaiPhong,
            this.DonGia,
            this.NgayO,
            this.ThanhTien,
            this.NgayTraPhong});
            this.grdCttp.Location = new System.Drawing.Point(21, 344);
            this.grdCttp.Name = "grdCttp";
            this.grdCttp.RowHeadersWidth = 62;
            this.grdCttp.RowTemplate.Height = 28;
            this.grdCttp.Size = new System.Drawing.Size(934, 208);
            this.grdCttp.TabIndex = 171;
            this.grdCttp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCttp_CellClick);
            this.grdCttp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCttp_CellContentClick);
            // 
            // MaPhong
            // 
            this.MaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Số phòng";
            this.MaPhong.MinimumWidth = 8;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 114;
            // 
            // MaPhieu
            // 
            this.MaPhieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã phiếu";
            this.MaPhieu.MinimumWidth = 8;
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.Width = 110;
            // 
            // NgayDatPhong
            // 
            this.NgayDatPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgayDatPhong.DataPropertyName = "NgayDatPhong";
            this.NgayDatPhong.HeaderText = "Ngày đặt";
            this.NgayDatPhong.MinimumWidth = 8;
            this.NgayDatPhong.Name = "NgayDatPhong";
            this.NgayDatPhong.Width = 108;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LoaiPhong.DataPropertyName = "LoaiPhong";
            this.LoaiPhong.HeaderText = "Loại phòng";
            this.LoaiPhong.MinimumWidth = 8;
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.Width = 124;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 8;
            this.DonGia.Name = "DonGia";
            // 
            // NgayO
            // 
            this.NgayO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgayO.DataPropertyName = "NgayO";
            this.NgayO.HeaderText = "Ngày ở";
            this.NgayO.MinimumWidth = 8;
            this.NgayO.Name = "NgayO";
            this.NgayO.Width = 94;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 120;
            // 
            // NgayTraPhong
            // 
            this.NgayTraPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgayTraPhong.DataPropertyName = "NgayTraPhong";
            this.NgayTraPhong.HeaderText = "Ngày trả";
            this.NgayTraPhong.MinimumWidth = 8;
            this.NgayTraPhong.Name = "NgayTraPhong";
            this.NgayTraPhong.Width = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 172;
            this.label1.Text = "Loại phòng:";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(155, 158);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(167, 26);
            this.txtLoaiPhong.TabIndex = 173;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(543, 162);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(170, 26);
            this.txtDonGia.TabIndex = 174;
            // 
            // txtNgayDat
            // 
            this.txtNgayDat.Location = new System.Drawing.Point(155, 207);
            this.txtNgayDat.Name = "txtNgayDat";
            this.txtNgayDat.Size = new System.Drawing.Size(230, 26);
            this.txtNgayDat.TabIndex = 175;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(155, 109);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(100, 26);
            this.txtMaPhieu.TabIndex = 177;
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Location = new System.Drawing.Point(543, 213);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(209, 26);
            this.dtNgayTra.TabIndex = 179;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(543, 111);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(100, 26);
            this.txtMaPhong.TabIndex = 180;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1023, 385);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(117, 55);
            this.btnSua.TabIndex = 181;
            this.btnSua.Text = "Tính";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtNgayO
            // 
            this.txtNgayO.Location = new System.Drawing.Point(905, 162);
            this.txtNgayO.Name = "txtNgayO";
            this.txtNgayO.Size = new System.Drawing.Size(100, 26);
            this.txtNgayO.TabIndex = 183;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(905, 215);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(170, 26);
            this.txtThanhTien.TabIndex = 184;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 185;
            this.label2.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 186;
            this.label3.Text = "Ngày đặt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 187;
            this.label4.Text = "Ngày trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(418, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 188;
            this.label5.Text = "Mã phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(780, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 189;
            this.label6.Text = "Ngày ở:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(780, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 190;
            this.label7.Text = "Thành tiền:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 23);
            this.label8.TabIndex = 191;
            this.label8.Text = "Mã phiếu:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DarkOrange;
            this.label21.Location = new System.Drawing.Point(337, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(327, 41);
            this.label21.TabIndex = 193;
            this.label21.Text = "Cập nhật tiền phòng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 192;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(1023, 503);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 49);
            this.btnThoat.TabIndex = 194;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(1023, 446);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(117, 51);
            this.btnThanhToan.TabIndex = 195;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(643, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 23);
            this.label9.TabIndex = 196;
            this.label9.Text = "Tìm phòng:";
            // 
            // txtTimMaPhong
            // 
            this.txtTimMaPhong.Location = new System.Drawing.Point(772, 303);
            this.txtTimMaPhong.Name = "txtTimMaPhong";
            this.txtTimMaPhong.Size = new System.Drawing.Size(156, 26);
            this.txtTimMaPhong.TabIndex = 197;
            this.txtTimMaPhong.Text = "Nhập số phòng";
            this.txtTimMaPhong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimMaPhong_MouseClick);
            this.txtTimMaPhong.TextChanged += new System.EventHandler(this.txtTimMaPhong_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 23);
            this.label10.TabIndex = 198;
            this.label10.Text = "Chi tiết thuê phòng:";
            // 
            // frmSuacttp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 587);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTimMaPhong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtNgayO);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.dtNgayTra);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.txtNgayDat);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtLoaiPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdCttp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSuacttp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật tiền phòng";
            this.Load += new System.EventHandler(this.frmSuacttp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCttp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCttp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtNgayDat;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtNgayO;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimMaPhong;
        private System.Windows.Forms.Label label10;
    }
}