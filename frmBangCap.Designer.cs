﻿namespace QLTTNN
{
    partial class frmBangCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangCap));
            this.trvGiaoVien = new System.Windows.Forms.TreeView();
            this.chbTimKiem = new System.Windows.Forms.CheckBox();
            this.btoXoa = new System.Windows.Forms.Button();
            this.btoSua = new System.Windows.Forms.Button();
            this.dgvBangCap = new System.Windows.Forms.DataGridView();
            this.colMaBangCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBangCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbMaBangCap = new System.Windows.Forms.CheckBox();
            this.chbTenBangCap = new System.Windows.Forms.CheckBox();
            this.tboMaBangCap = new System.Windows.Forms.TextBox();
            this.tboTenBangCap = new System.Windows.Forms.TextBox();
            this.btoTimKiem = new System.Windows.Forms.Button();
            this.btoDong = new System.Windows.Forms.Button();
            this.btoThem = new System.Windows.Forms.Button();
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangCap)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            this.SuspendLayout();
            // 
            // trvGiaoVien
            // 
            this.trvGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvGiaoVien.Location = new System.Drawing.Point(565, 219);
            this.trvGiaoVien.Name = "trvGiaoVien";
            this.trvGiaoVien.Size = new System.Drawing.Size(231, 260);
            this.trvGiaoVien.TabIndex = 46;
            // 
            // chbTimKiem
            // 
            this.chbTimKiem.AutoSize = true;
            this.chbTimKiem.Location = new System.Drawing.Point(23, 177);
            this.chbTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbTimKiem.Name = "chbTimKiem";
            this.chbTimKiem.Size = new System.Drawing.Size(72, 18);
            this.chbTimKiem.TabIndex = 44;
            this.chbTimKiem.Text = "Tìm kiếm";
            this.chbTimKiem.UseVisualStyleBackColor = true;
            this.chbTimKiem.CheckedChanged += new System.EventHandler(this.chbTimKiem_CheckedChanged);
            // 
            // btoXoa
            // 
            this.btoXoa.Image = ((System.Drawing.Image)(resources.GetObject("btoXoa.Image")));
            this.btoXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoXoa.Location = new System.Drawing.Point(390, 167);
            this.btoXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btoXoa.Name = "btoXoa";
            this.btoXoa.Size = new System.Drawing.Size(112, 45);
            this.btoXoa.TabIndex = 39;
            this.btoXoa.Text = "Xóa";
            this.btoXoa.UseVisualStyleBackColor = true;
            this.btoXoa.Click += new System.EventHandler(this.btoXoa_Click);
            // 
            // btoSua
            // 
            this.btoSua.Image = ((System.Drawing.Image)(resources.GetObject("btoSua.Image")));
            this.btoSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoSua.Location = new System.Drawing.Point(271, 167);
            this.btoSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btoSua.Name = "btoSua";
            this.btoSua.Size = new System.Drawing.Size(112, 45);
            this.btoSua.TabIndex = 38;
            this.btoSua.Text = "Sửa";
            this.btoSua.UseVisualStyleBackColor = true;
            this.btoSua.Click += new System.EventHandler(this.btoSua_Click);
            // 
            // dgvBangCap
            // 
            this.dgvBangCap.AllowUserToAddRows = false;
            this.dgvBangCap.AllowUserToDeleteRows = false;
            this.dgvBangCap.AllowUserToResizeColumns = false;
            this.dgvBangCap.AllowUserToResizeRows = false;
            this.dgvBangCap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBangCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBangCap,
            this.colTenBangCap});
            this.dgvBangCap.Location = new System.Drawing.Point(23, 219);
            this.dgvBangCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBangCap.MultiSelect = false;
            this.dgvBangCap.Name = "dgvBangCap";
            this.dgvBangCap.ReadOnly = true;
            this.dgvBangCap.RowHeadersWidth = 62;
            this.dgvBangCap.RowTemplate.Height = 28;
            this.dgvBangCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangCap.Size = new System.Drawing.Size(536, 261);
            this.dgvBangCap.TabIndex = 37;
            this.dgvBangCap.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangCap_RowEnter);
            // 
            // colMaBangCap
            // 
            this.colMaBangCap.DataPropertyName = "MaBangCap";
            this.colMaBangCap.HeaderText = "Mã bằng cấp";
            this.colMaBangCap.MinimumWidth = 8;
            this.colMaBangCap.Name = "colMaBangCap";
            this.colMaBangCap.ReadOnly = true;
            this.colMaBangCap.Width = 200;
            // 
            // colTenBangCap
            // 
            this.colTenBangCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenBangCap.DataPropertyName = "TenBangCap";
            this.colTenBangCap.HeaderText = "Tên bằng cấp";
            this.colTenBangCap.MinimumWidth = 8;
            this.colTenBangCap.Name = "colTenBangCap";
            this.colTenBangCap.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(824, 22);
            this.statusStrip1.TabIndex = 40;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 17);
            this.lblStatus.Text = "Thông báo:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(456, 31);
            this.label3.TabIndex = 41;
            this.label3.Text = "QUẢN LÝ DANH SÁCH BẰNG CẤP";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chbMaBangCap);
            this.groupBox1.Controls.Add(this.chbTenBangCap);
            this.groupBox1.Controls.Add(this.tboMaBangCap);
            this.groupBox1.Controls.Add(this.tboTenBangCap);
            this.groupBox1.Location = new System.Drawing.Point(23, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(773, 116);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bằng cấp";
            // 
            // chbMaBangCap
            // 
            this.chbMaBangCap.AutoSize = true;
            this.chbMaBangCap.Checked = true;
            this.chbMaBangCap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMaBangCap.Location = new System.Drawing.Point(7, 32);
            this.chbMaBangCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbMaBangCap.Name = "chbMaBangCap";
            this.chbMaBangCap.Size = new System.Drawing.Size(84, 18);
            this.chbMaBangCap.TabIndex = 16;
            this.chbMaBangCap.Text = "Mã bằng cấp";
            this.chbMaBangCap.UseVisualStyleBackColor = true;
            // 
            // chbTenBangCap
            // 
            this.chbTenBangCap.AutoSize = true;
            this.chbTenBangCap.Checked = true;
            this.chbTenBangCap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTenBangCap.Location = new System.Drawing.Point(7, 70);
            this.chbTenBangCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbTenBangCap.Name = "chbTenBangCap";
            this.chbTenBangCap.Size = new System.Drawing.Size(88, 18);
            this.chbTenBangCap.TabIndex = 15;
            this.chbTenBangCap.Text = "Tên bằng cấp";
            this.chbTenBangCap.UseVisualStyleBackColor = true;
            // 
            // tboMaBangCap
            // 
            this.tboMaBangCap.Location = new System.Drawing.Point(150, 29);
            this.tboMaBangCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboMaBangCap.Name = "tboMaBangCap";
            this.tboMaBangCap.Size = new System.Drawing.Size(112, 20);
            this.tboMaBangCap.TabIndex = 1;
            // 
            // tboTenBangCap
            // 
            this.tboTenBangCap.Location = new System.Drawing.Point(150, 68);
            this.tboTenBangCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboTenBangCap.Name = "tboTenBangCap";
            this.tboTenBangCap.Size = new System.Drawing.Size(412, 20);
            this.tboTenBangCap.TabIndex = 2;
            // 
            // btoTimKiem
            // 
            this.btoTimKiem.Enabled = false;
            this.btoTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btoTimKiem.Image")));
            this.btoTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoTimKiem.Location = new System.Drawing.Point(510, 167);
            this.btoTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btoTimKiem.Name = "btoTimKiem";
            this.btoTimKiem.Size = new System.Drawing.Size(112, 45);
            this.btoTimKiem.TabIndex = 45;
            this.btoTimKiem.Text = "Tìm";
            this.btoTimKiem.UseVisualStyleBackColor = true;
            this.btoTimKiem.Click += new System.EventHandler(this.btoTimKiem_Click);
            // 
            // btoDong
            // 
            this.btoDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btoDong.Location = new System.Drawing.Point(683, 167);
            this.btoDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btoDong.Name = "btoDong";
            this.btoDong.Size = new System.Drawing.Size(112, 45);
            this.btoDong.TabIndex = 43;
            this.btoDong.Text = "Đóng";
            this.btoDong.UseVisualStyleBackColor = true;
            this.btoDong.Click += new System.EventHandler(this.btoDong_Click);
            // 
            // btoThem
            // 
            this.btoThem.Image = ((System.Drawing.Image)(resources.GetObject("btoThem.Image")));
            this.btoThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoThem.Location = new System.Drawing.Point(152, 167);
            this.btoThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btoThem.Name = "btoThem";
            this.btoThem.Size = new System.Drawing.Size(112, 45);
            this.btoThem.TabIndex = 36;
            this.btoThem.Text = "Thêm";
            this.btoThem.UseVisualStyleBackColor = true;
            this.btoThem.Click += new System.EventHandler(this.btoThem_Click);
            // 
            // eprError
            // 
            this.eprError.ContainerControl = this;
            // 
            // frmBangCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 518);
            this.Controls.Add(this.trvGiaoVien);
            this.Controls.Add(this.chbTimKiem);
            this.Controls.Add(this.btoXoa);
            this.Controls.Add(this.btoSua);
            this.Controls.Add(this.dgvBangCap);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btoTimKiem);
            this.Controls.Add(this.btoDong);
            this.Controls.Add(this.btoThem);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBangCap";
            this.Text = "frmBangCap";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangCap)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvGiaoVien;
        private System.Windows.Forms.CheckBox chbTimKiem;
        private System.Windows.Forms.Button btoXoa;
        private System.Windows.Forms.Button btoSua;
        private System.Windows.Forms.DataGridView dgvBangCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBangCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBangCap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbMaBangCap;
        private System.Windows.Forms.CheckBox chbTenBangCap;
        private System.Windows.Forms.TextBox tboMaBangCap;
        private System.Windows.Forms.TextBox tboTenBangCap;
        private System.Windows.Forms.Button btoTimKiem;
        private System.Windows.Forms.Button btoDong;
        private System.Windows.Forms.Button btoThem;
        private System.Windows.Forms.ErrorProvider eprError;
    }
}