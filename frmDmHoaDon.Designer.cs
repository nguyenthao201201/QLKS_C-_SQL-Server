
namespace QLTPKS
{
    partial class frmDmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmHoaDon));
            this.GridViewDSHD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCccd = new System.Windows.Forms.TextBox();
            this.txtTienPhong = new System.Windows.Forms.TextBox();
            this.txtTienDV = new System.Windows.Forms.TextBox();
            this.txtTongHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNgayDen = new System.Windows.Forms.TextBox();
            this.txtNgayTt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewDSHD
            // 
            this.GridViewDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.NgayTt,
            this.TienDV,
            this.TienPhong,
            this.TongTien});
            this.GridViewDSHD.Location = new System.Drawing.Point(4, 111);
            this.GridViewDSHD.Name = "GridViewDSHD";
            this.GridViewDSHD.RowHeadersWidth = 62;
            this.GridViewDSHD.RowTemplate.Height = 28;
            this.GridViewDSHD.Size = new System.Drawing.Size(655, 443);
            this.GridViewDSHD.TabIndex = 0;
            this.GridViewDSHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDSHD_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "MaHD";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(831, 111);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(102, 26);
            this.txtMaHD.TabIndex = 2;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(308, 586);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(160, 26);
            this.txtTenNV.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhân viên phụ trách:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(831, 165);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(171, 26);
            this.txtTenKH.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(723, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên KH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(723, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số CCCD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(723, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tiền phòng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(723, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tiền DV:";
            // 
            // txtCccd
            // 
            this.txtCccd.Location = new System.Drawing.Point(831, 218);
            this.txtCccd.Name = "txtCccd";
            this.txtCccd.Size = new System.Drawing.Size(171, 26);
            this.txtCccd.TabIndex = 12;
            // 
            // txtTienPhong
            // 
            this.txtTienPhong.Location = new System.Drawing.Point(831, 435);
            this.txtTienPhong.Name = "txtTienPhong";
            this.txtTienPhong.Size = new System.Drawing.Size(131, 26);
            this.txtTienPhong.TabIndex = 13;
            // 
            // txtTienDV
            // 
            this.txtTienDV.Location = new System.Drawing.Point(831, 489);
            this.txtTienDV.Name = "txtTienDV";
            this.txtTienDV.Size = new System.Drawing.Size(131, 26);
            this.txtTienDV.TabIndex = 14;
            // 
            // txtTongHD
            // 
            this.txtTongHD.Location = new System.Drawing.Point(831, 543);
            this.txtTongHD.Name = "txtTongHD";
            this.txtTongHD.Size = new System.Drawing.Size(131, 26);
            this.txtTongHD.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(723, 551);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tổng HĐ:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(831, 273);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(131, 26);
            this.txtMaPhong.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(723, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Số phòng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(723, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ngày đến:";
            // 
            // txtNgayDen
            // 
            this.txtNgayDen.Location = new System.Drawing.Point(831, 327);
            this.txtNgayDen.Name = "txtNgayDen";
            this.txtNgayDen.Size = new System.Drawing.Size(171, 26);
            this.txtNgayDen.TabIndex = 20;
            // 
            // txtNgayTt
            // 
            this.txtNgayTt.Location = new System.Drawing.Point(831, 381);
            this.txtNgayTt.Name = "txtNgayTt";
            this.txtNgayTt.Size = new System.Drawing.Size(171, 26);
            this.txtNgayTt.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(723, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ngày đi:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(968, 643);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 38);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DarkOrange;
            this.label21.Location = new System.Drawing.Point(382, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(277, 36);
            this.label21.TabIndex = 120;
            this.label21.Text = "Danh mục hóa đơn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(723, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 121;
            this.label2.Text = "Thông tin hóa đơn:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(705, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 505);
            this.panel1.TabIndex = 122;
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã HĐ";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 95;
            // 
            // NgayTt
            // 
            this.NgayTt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgayTt.DataPropertyName = "NgayTt";
            this.NgayTt.HeaderText = "Ngày TT";
            this.NgayTt.MinimumWidth = 8;
            this.NgayTt.Name = "NgayTt";
            this.NgayTt.Width = 103;
            // 
            // TienDV
            // 
            this.TienDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TienDV.DataPropertyName = "TienDV";
            this.TienDV.HeaderText = "Tiền DV";
            this.TienDV.MinimumWidth = 8;
            this.TienDV.Name = "TienDV";
            this.TienDV.Width = 102;
            // 
            // TienPhong
            // 
            this.TienPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TienPhong.DataPropertyName = "TienPhong";
            this.TienPhong.HeaderText = "Tiền phòng";
            this.TienPhong.MinimumWidth = 8;
            this.TienPhong.Name = "TienPhong";
            this.TienPhong.Width = 124;
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 111;
            // 
            // frmDmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1056, 691);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNgayTt);
            this.Controls.Add(this.txtNgayDen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTongHD);
            this.Controls.Add(this.txtTienDV);
            this.Controls.Add(this.txtTienPhong);
            this.Controls.Add(this.txtCccd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridViewDSHD);
            this.Controls.Add(this.panel1);
            this.Name = "frmDmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục hóa đơn:";
            this.Load += new System.EventHandler(this.frmDmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewDSHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCccd;
        private System.Windows.Forms.TextBox txtTienPhong;
        private System.Windows.Forms.TextBox txtTienDV;
        private System.Windows.Forms.TextBox txtTongHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNgayDen;
        private System.Windows.Forms.TextBox txtNgayTt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}