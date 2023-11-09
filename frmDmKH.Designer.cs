
namespace QLTPKS
{
    partial class frmDmKH
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
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SdtKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GtKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCccd = new System.Windows.Forms.TextBox();
            this.txtSdtKH = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.btnPrv = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGtKH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.SdtKH,
            this.GtKH,
            this.DiaChiKH,
            this.Cccd});
            this.grdData.Location = new System.Drawing.Point(13, 61);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 62;
            this.grdData.RowTemplate.Height = 28;
            this.grdData.Size = new System.Drawing.Size(655, 333);
            this.grdData.TabIndex = 0;
            this.grdData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellClick);
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH ";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 97;
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
            // SdtKH
            // 
            this.SdtKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SdtKH.DataPropertyName = "SdtKH";
            this.SdtKH.HeaderText = "Số ĐT";
            this.SdtKH.MinimumWidth = 8;
            this.SdtKH.Name = "SdtKH";
            this.SdtKH.Width = 90;
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
            // DiaChiKH
            // 
            this.DiaChiKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DiaChiKH.DataPropertyName = "DiaChiKH";
            this.DiaChiKH.HeaderText = "Địa chỉ";
            this.DiaChiKH.MinimumWidth = 8;
            this.DiaChiKH.Name = "DiaChiKH";
            this.DiaChiKH.Width = 93;
            // 
            // Cccd
            // 
            this.Cccd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cccd.DataPropertyName = "Cccd";
            this.Cccd.HeaderText = "CCCD";
            this.Cccd.MinimumWidth = 8;
            this.Cccd.Name = "Cccd";
            this.Cccd.Width = 90;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(859, 486);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 53);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Kết thúc";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(13, 8);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(121, 47);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Thêm ";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(688, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã KH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(774, 202);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(234, 26);
            this.txtMaKH.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "CCCD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số ĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(688, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(688, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Họ và tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(688, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Giới tính ";
            // 
            // txtCccd
            // 
            this.txtCccd.Location = new System.Drawing.Point(774, 396);
            this.txtCccd.Name = "txtCccd";
            this.txtCccd.Size = new System.Drawing.Size(234, 26);
            this.txtCccd.TabIndex = 11;
            // 
            // txtSdtKH
            // 
            this.txtSdtKH.Location = new System.Drawing.Point(774, 350);
            this.txtSdtKH.Name = "txtSdtKH";
            this.txtSdtKH.Size = new System.Drawing.Size(234, 26);
            this.txtSdtKH.TabIndex = 12;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(774, 297);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(234, 26);
            this.txtDiaChiKH.TabIndex = 13;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(774, 248);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(234, 26);
            this.txtTenKH.TabIndex = 14;
            // 
            // btnPrv
            // 
            this.btnPrv.Location = new System.Drawing.Point(24, 462);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(94, 50);
            this.btnPrv.TabIndex = 15;
            this.btnPrv.Text = "Trước";
            this.btnPrv.UseVisualStyleBackColor = true;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(392, 462);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(94, 50);
            this.btnLast.TabIndex = 16;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(276, 462);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(94, 50);
            this.btnFirst.TabIndex = 17;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(143, 462);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 50);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(143, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 47);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(270, 8);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(121, 47);
            this.btnDel.TabIndex = 20;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(397, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 47);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(822, 61);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(186, 26);
            this.txtKeyWord.TabIndex = 22;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(796, 121);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(105, 29);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(712, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nhập từ khóa:";
            // 
            // txtGtKH
            // 
            this.txtGtKH.FormattingEnabled = true;
            this.txtGtKH.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtGtKH.Location = new System.Drawing.Point(774, 442);
            this.txtGtKH.Name = "txtGtKH";
            this.txtGtKH.Size = new System.Drawing.Size(234, 28);
            this.txtGtKH.TabIndex = 25;
            // 
            // frmDmKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 575);
            this.Controls.Add(this.txtGtKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtKeyWord);
            this.Controls.Add(this.btnUpdate);
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
            this.Controls.Add(this.grdData);
            this.Name = "frmDmKH";
            this.Text = "frmDmKH";
            this.Load += new System.EventHandler(this.frmDmKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCccd;
        private System.Windows.Forms.TextBox txtSdtKH;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SdtKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GtKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cccd;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtGtKH;
    }
}