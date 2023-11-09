
namespace QLTPKS
{
    partial class frmDmKhachHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmKhachHang));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNapLai = new System.Windows.Forms.Button();
            this.GridViewDSKH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SdtKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GtKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtGtKH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKeyWordKH = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.txtSdtKH = new System.Windows.Forms.TextBox();
            this.txtCccd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnIN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 23);
            this.label9.TabIndex = 82;
            this.label9.Text = "Bảng thông tin khách hàng:";
            // 
            // btnNapLai
            // 
            this.btnNapLai.Location = new System.Drawing.Point(91, 90);
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.Size = new System.Drawing.Size(100, 47);
            this.btnNapLai.TabIndex = 81;
            this.btnNapLai.Text = "Thêm";
            this.btnNapLai.UseVisualStyleBackColor = true;
            this.btnNapLai.Click += new System.EventHandler(this.btnNapLai_Click);
            // 
            // GridViewDSKH
            // 
            this.GridViewDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDSKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.DiaChiKH,
            this.SdtKH,
            this.Cccd,
            this.GtKH});
            this.GridViewDSKH.Location = new System.Drawing.Point(55, 358);
            this.GridViewDSKH.Name = "GridViewDSKH";
            this.GridViewDSKH.RowHeadersWidth = 62;
            this.GridViewDSKH.RowTemplate.Height = 28;
            this.GridViewDSKH.Size = new System.Drawing.Size(1067, 449);
            this.GridViewDSKH.TabIndex = 80;
            this.GridViewDSKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDSKH_CellClick);
            this.GridViewDSKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDSKH_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 93;
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Họ và tên";
            this.TenKH.MinimumWidth = 8;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 113;
            // 
            // DiaChiKH
            // 
            this.DiaChiKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DiaChiKH.DataPropertyName = "DiaChiKH";
            this.DiaChiKH.HeaderText = "Địa Chỉ";
            this.DiaChiKH.MinimumWidth = 8;
            this.DiaChiKH.Name = "DiaChiKH";
            this.DiaChiKH.Width = 96;
            // 
            // SdtKH
            // 
            this.SdtKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SdtKH.DataPropertyName = "SdtKH";
            this.SdtKH.HeaderText = "Số điện thoại";
            this.SdtKH.MinimumWidth = 8;
            this.SdtKH.Name = "SdtKH";
            this.SdtKH.Width = 138;
            // 
            // Cccd
            // 
            this.Cccd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cccd.DataPropertyName = "Cccd";
            this.Cccd.HeaderText = "Số CCCD";
            this.Cccd.MinimumWidth = 8;
            this.Cccd.Name = "Cccd";
            this.Cccd.Width = 114;
            // 
            // GtKH
            // 
            this.GtKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GtKH.DataPropertyName = "GtKH";
            this.GtKH.HeaderText = "Giới tính";
            this.GtKH.MinimumWidth = 8;
            this.GtKH.Name = "GtKH";
            this.GtKH.Width = 103;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Chocolate;
            this.label8.Location = new System.Drawing.Point(525, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(342, 41);
            this.label8.TabIndex = 79;
            this.label8.Text = "Danh mục Khách hàng";
            // 
            // txtGtKH
            // 
            this.txtGtKH.FormattingEnabled = true;
            this.txtGtKH.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtGtKH.Location = new System.Drawing.Point(360, 170);
            this.txtGtKH.Name = "txtGtKH";
            this.txtGtKH.Size = new System.Drawing.Size(78, 28);
            this.txtGtKH.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(933, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 77;
            this.label7.Text = "Nhập từ khóa:";
            // 
            // txtKeyWordKH
            // 
            this.txtKeyWordKH.Location = new System.Drawing.Point(1049, 88);
            this.txtKeyWordKH.Name = "txtKeyWordKH";
            this.txtKeyWordKH.Size = new System.Drawing.Size(186, 26);
            this.txtKeyWordKH.TabIndex = 75;
            this.txtKeyWordKH.TextChanged += new System.EventHandler(this.txtKeyWordKH_TextChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(347, 90);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 47);
            this.btnDel.TabIndex = 74;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(219, 90);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 47);
            this.btnEdit.TabIndex = 73;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1152, 514);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 50);
            this.btnNext.TabIndex = 72;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(1152, 597);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(94, 50);
            this.btnFirst.TabIndex = 71;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(1152, 680);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(94, 50);
            this.btnLast.TabIndex = 70;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.Location = new System.Drawing.Point(1152, 431);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(94, 50);
            this.btnPrv.TabIndex = 69;
            this.btnPrv.Text = "Trước";
            this.btnPrv.UseVisualStyleBackColor = true;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(146, 218);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(234, 26);
            this.txtTenKH.TabIndex = 68;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(146, 267);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(758, 26);
            this.txtDiaChiKH.TabIndex = 67;
            // 
            // txtSdtKH
            // 
            this.txtSdtKH.Location = new System.Drawing.Point(557, 172);
            this.txtSdtKH.Name = "txtSdtKH";
            this.txtSdtKH.Size = new System.Drawing.Size(234, 26);
            this.txtSdtKH.TabIndex = 66;
            // 
            // txtCccd
            // 
            this.txtCccd.Location = new System.Drawing.Point(557, 218);
            this.txtCccd.Name = "txtCccd";
            this.txtCccd.Size = new System.Drawing.Size(234, 26);
            this.txtCccd.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Giới tính ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Họ và tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Số ĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "CCCD";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(146, 172);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(115, 26);
            this.txtMaKH.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Mã KH";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Enabled = false;
            this.btnAddNew.Location = new System.Drawing.Point(475, 88);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(100, 47);
            this.btnAddNew.TabIndex = 57;
            this.btnAddNew.Text = "Tạo mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Location = new System.Drawing.Point(1294, 754);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 53);
            this.btnExit.TabIndex = 56;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnIN
            // 
            this.btnIN.Location = new System.Drawing.Point(1294, 680);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(111, 50);
            this.btnIN.TabIndex = 84;
            this.btnIN.Text = "In DS";
            this.btnIN.UseVisualStyleBackColor = true;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // frmDmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1444, 826);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnNapLai);
            this.Controls.Add(this.GridViewDSKH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGtKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKeyWordKH);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtDiaChiKH);
            this.Controls.Add(this.txtSdtKH);
            this.Controls.Add(this.txtCccd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(350, 276);
            this.Name = "frmDmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục Khách hàng";
            this.Load += new System.EventHandler(this.frmDmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNapLai;
        private System.Windows.Forms.DataGridView GridViewDSKH;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtGtKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKeyWordKH;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.TextBox txtSdtKH;
        private System.Windows.Forms.TextBox txtCccd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SdtKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cccd;
        private System.Windows.Forms.DataGridViewTextBoxColumn GtKH;
        private System.Windows.Forms.Button btnIN;
    }
}