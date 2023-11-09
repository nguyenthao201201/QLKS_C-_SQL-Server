
namespace QLTPKS
{
    partial class frmDmDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmDichVu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNapLai = new System.Windows.Forms.Button();
            this.GridViewDSDV = new System.Windows.Forms.DataGridView();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKeyWordDV = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.cbxDvt = new System.Windows.Forms.ComboBox();
            this.txtGiaDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 23);
            this.label9.TabIndex = 106;
            this.label9.Text = "Bảng thông tin dịch vụ:";
            // 
            // btnNapLai
            // 
            this.btnNapLai.Location = new System.Drawing.Point(156, 74);
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.Size = new System.Drawing.Size(100, 50);
            this.btnNapLai.TabIndex = 105;
            this.btnNapLai.Text = "Thêm";
            this.btnNapLai.UseVisualStyleBackColor = true;
            this.btnNapLai.Click += new System.EventHandler(this.btnNapLai_Click);
            // 
            // GridViewDSDV
            // 
            this.GridViewDSDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDSDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.LoaiDV,
            this.GiaDV,
            this.Dvt});
            this.GridViewDSDV.Location = new System.Drawing.Point(53, 163);
            this.GridViewDSDV.Name = "GridViewDSDV";
            this.GridViewDSDV.RowHeadersWidth = 62;
            this.GridViewDSDV.RowTemplate.Height = 28;
            this.GridViewDSDV.Size = new System.Drawing.Size(542, 395);
            this.GridViewDSDV.TabIndex = 104;
            this.GridViewDSDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDSDV_CellClick);
            this.GridViewDSDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDSDV_CellContentClick);
            // 
            // MaDV
            // 
            this.MaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.HeaderText = "Mã DV";
            this.MaDV.MinimumWidth = 8;
            this.MaDV.Name = "MaDV";
            this.MaDV.Width = 94;
            // 
            // LoaiDV
            // 
            this.LoaiDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LoaiDV.DataPropertyName = "LoaiDV";
            this.LoaiDV.HeaderText = "Tên DV";
            this.LoaiDV.MinimumWidth = 8;
            this.LoaiDV.Name = "LoaiDV";
            this.LoaiDV.Width = 99;
            // 
            // GiaDV
            // 
            this.GiaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GiaDV.DataPropertyName = "GiaDV";
            this.GiaDV.HeaderText = "Đơn giá";
            this.GiaDV.MinimumWidth = 8;
            this.GiaDV.Name = "GiaDV";
            // 
            // Dvt
            // 
            this.Dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Dvt.DataPropertyName = "Dvt";
            this.Dvt.HeaderText = "Đơn vị tính";
            this.Dvt.MinimumWidth = 8;
            this.Dvt.Name = "Dvt";
            this.Dvt.Width = 119;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Chocolate;
            this.label8.Location = new System.Drawing.Point(418, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 36);
            this.label8.TabIndex = 103;
            this.label8.Text = "Danh mục Dịch vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(883, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 102;
            this.label7.Text = "Tìm kiếm";
            // 
            // txtKeyWordDV
            // 
            this.txtKeyWordDV.Location = new System.Drawing.Point(837, 112);
            this.txtKeyWordDV.Name = "txtKeyWordDV";
            this.txtKeyWordDV.Size = new System.Drawing.Size(186, 26);
            this.txtKeyWordDV.TabIndex = 100;
            this.txtKeyWordDV.TextChanged += new System.EventHandler(this.txtKeyWordDV_TextChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(454, 74);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 50);
            this.btnDel.TabIndex = 99;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(305, 74);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 50);
            this.btnEdit.TabIndex = 98;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(708, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 91;
            this.label4.Text = "Đơn vị tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(708, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 90;
            this.label3.Text = "Đơn giá:";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(813, 252);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(115, 26);
            this.txtMaDV.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(707, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 88;
            this.label1.Text = "Mã DV:";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Enabled = false;
            this.btnAddNew.Location = new System.Drawing.Point(603, 74);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(100, 50);
            this.btnAddNew.TabIndex = 87;
            this.btnAddNew.Text = "Tạo mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Location = new System.Drawing.Point(964, 596);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 53);
            this.btnExit.TabIndex = 86;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(205, 599);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 50);
            this.btnNext.TabIndex = 97;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(338, 599);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(94, 50);
            this.btnFirst.TabIndex = 96;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(471, 599);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(94, 50);
            this.btnLast.TabIndex = 95;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.Location = new System.Drawing.Point(72, 599);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(94, 50);
            this.btnPrv.TabIndex = 94;
            this.btnPrv.Text = "Trước";
            this.btnPrv.UseVisualStyleBackColor = true;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(708, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 92;
            this.label5.Text = "Tên DV:";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(813, 293);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(192, 26);
            this.txtTenDV.TabIndex = 109;
            // 
            // cbxDvt
            // 
            this.cbxDvt.FormattingEnabled = true;
            this.cbxDvt.Items.AddRange(new object[] {
            "giờ",
            "km",
            "suất",
            "gói"});
            this.cbxDvt.Location = new System.Drawing.Point(813, 378);
            this.cbxDvt.Name = "cbxDvt";
            this.cbxDvt.Size = new System.Drawing.Size(121, 28);
            this.cbxDvt.TabIndex = 110;
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Location = new System.Drawing.Point(813, 332);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(192, 26);
            this.txtGiaDV.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(708, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 112;
            this.label2.Text = "Thông tin dịch vụ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(698, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 194);
            this.panel1.TabIndex = 113;
            // 
            // frmDmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 692);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGiaDV);
            this.Controls.Add(this.cbxDvt);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnNapLai);
            this.Controls.Add(this.GridViewDSDV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKeyWordDV);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(290, 85);
            this.Name = "frmDmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục dịch vụ";
            this.Load += new System.EventHandler(this.frmDmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDSDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNapLai;
        private System.Windows.Forms.DataGridView GridViewDSDV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKeyWordDV;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.ComboBox cbxDvt;
        private System.Windows.Forms.TextBox txtGiaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dvt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}