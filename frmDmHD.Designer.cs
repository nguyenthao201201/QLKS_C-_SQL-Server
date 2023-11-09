
namespace QLTPKS
{
    partial class frmDmHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmHD));
            this.GridViewDSHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuongThucTt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtPttt = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTienPhong = new System.Windows.Forms.TextBox();
            this.txtTienDV = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtNgayTT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKeyWordHD = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewDSHD
            // 
            this.GridViewDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.PhuongThucTt,
            this.NgayTt,
            this.TienDV,
            this.TienPhong,
            this.TongTien,
            this.MaNV,
            this.MaPhieu,
            this.MaKH});
            this.GridViewDSHD.Location = new System.Drawing.Point(63, 315);
            this.GridViewDSHD.Name = "GridViewDSHD";
            this.GridViewDSHD.RowHeadersWidth = 62;
            this.GridViewDSHD.RowTemplate.Height = 28;
            this.GridViewDSHD.Size = new System.Drawing.Size(995, 288);
            this.GridViewDSHD.TabIndex = 0;
            this.GridViewDSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDSHD_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 119;
            // 
            // PhuongThucTt
            // 
            this.PhuongThucTt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PhuongThucTt.DataPropertyName = "PhuongThucTt";
            this.PhuongThucTt.HeaderText = "Phương thức thanh toán";
            this.PhuongThucTt.MinimumWidth = 8;
            this.PhuongThucTt.Name = "PhuongThucTt";
            this.PhuongThucTt.Width = 169;
            // 
            // NgayTt
            // 
            this.NgayTt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgayTt.DataPropertyName = "NgayTt";
            this.NgayTt.HeaderText = "Ngày thanh toán";
            this.NgayTt.MinimumWidth = 8;
            this.NgayTt.Name = "NgayTt";
            this.NgayTt.Width = 149;
            // 
            // TienDV
            // 
            this.TienDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TienDV.DataPropertyName = "TienDV";
            this.TienDV.HeaderText = "Tiền DV";
            this.TienDV.MinimumWidth = 8;
            this.TienDV.Name = "TienDV";
            this.TienDV.Width = 95;
            // 
            // TienPhong
            // 
            this.TienPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TienPhong.DataPropertyName = "TienPhong";
            this.TienPhong.HeaderText = "Tiền phòng";
            this.TienPhong.MinimumWidth = 8;
            this.TienPhong.Name = "TienPhong";
            this.TienPhong.Width = 115;
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 103;
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 67;
            // 
            // MaPhieu
            // 
            this.MaPhieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã phiếu ";
            this.MaPhieu.MinimumWidth = 8;
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.Width = 106;
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 67;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(159, 23);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 26);
            this.txtMaHD.TabIndex = 1;
            // 
            // txtPttt
            // 
            this.txtPttt.Location = new System.Drawing.Point(159, 75);
            this.txtPttt.Name = "txtPttt";
            this.txtPttt.Size = new System.Drawing.Size(198, 26);
            this.txtPttt.TabIndex = 2;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(497, 16);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 26);
            this.txtMaKH.TabIndex = 3;
            // 
            // txtTienPhong
            // 
            this.txtTienPhong.Location = new System.Drawing.Point(159, 128);
            this.txtTienPhong.Name = "txtTienPhong";
            this.txtTienPhong.Size = new System.Drawing.Size(147, 26);
            this.txtTienPhong.TabIndex = 4;
            // 
            // txtTienDV
            // 
            this.txtTienDV.Location = new System.Drawing.Point(500, 123);
            this.txtTienDV.Name = "txtTienDV";
            this.txtTienDV.Size = new System.Drawing.Size(153, 26);
            this.txtTienDV.TabIndex = 5;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(787, 72);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(170, 26);
            this.txtTongTien.TabIndex = 6;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(497, 74);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 26);
            this.txtMaNV.TabIndex = 7;
            // 
            // txtNgayTT
            // 
            this.txtNgayTT.Location = new System.Drawing.Point(787, 20);
            this.txtNgayTT.Name = "txtNgayTT";
            this.txtNgayTT.Size = new System.Drawing.Size(247, 26);
            this.txtNgayTT.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã HĐ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Phương thức TT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã KH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tiền phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tiền dịch vụ: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(632, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tổng tiền:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(379, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã NV:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(632, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ngày thanh toán: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(479, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(305, 41);
            this.label9.TabIndex = 137;
            this.label9.Text = "Danh mục hóa đơn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(87, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 23);
            this.label10.TabIndex = 138;
            this.label10.Text = "Thông tin hóa đơn: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(63, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 23);
            this.label11.TabIndex = 139;
            this.label11.Text = "Danh sách hóa đơn:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1088, 548);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 55);
            this.btnExit.TabIndex = 140;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(616, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 141;
            this.label12.Text = "Tìm HĐ:";
            // 
            // txtKeyWordHD
            // 
            this.txtKeyWordHD.Location = new System.Drawing.Point(699, 274);
            this.txtKeyWordHD.Name = "txtKeyWordHD";
            this.txtKeyWordHD.Size = new System.Drawing.Size(145, 26);
            this.txtKeyWordHD.TabIndex = 142;
            this.txtKeyWordHD.TextChanged += new System.EventHandler(this.txtKeyWordHD_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNgayTT);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.txtTienDV);
            this.panel1.Controls.Add(this.txtTienPhong);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.txtPttt);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Location = new System.Drawing.Point(63, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 163);
            this.panel1.TabIndex = 143;
            // 
            // frmDmHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 613);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtKeyWordHD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GridViewDSHD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDmHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục hóa đơn";
            this.Load += new System.EventHandler(this.frmDmHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewDSHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtPttt;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTienPhong;
        private System.Windows.Forms.TextBox txtTienDV;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtNgayTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuongThucTt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtKeyWordHD;
        private System.Windows.Forms.Panel panel1;
    }
}