﻿namespace DoAn_2.MenuTab
{
    partial class TonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TonKho));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.txtGianhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDeleteIMG = new FontAwesome.Sharp.IconButton();
            this.btnButtonChooseIMG = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comboLoai = new System.Windows.Forms.ComboBox();
            this.comboDonvi = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.btnExportExcel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(563, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(114, 51);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(180, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(114, 78);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(180, 20);
            this.txtTensp.TabIndex = 2;
            // 
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(114, 106);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(180, 20);
            this.txtSl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Giá nhập";
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(114, 159);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(180, 20);
            this.txtGiaban.TabIndex = 12;
            // 
            // txtGianhap
            // 
            this.txtGianhap.Location = new System.Drawing.Point(114, 132);
            this.txtGianhap.Name = "txtGianhap";
            this.txtGianhap.Size = new System.Drawing.Size(180, 20);
            this.txtGianhap.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Đơn vị";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(17, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 40);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(124, 282);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 40);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAn_2.Properties.Resources._default;
            this.pictureBox1.Location = new System.Drawing.Point(17, 328);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnDeleteIMG
            // 
            this.btnDeleteIMG.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteIMG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteIMG.BackgroundImage")));
            this.btnDeleteIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteIMG.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDeleteIMG.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDeleteIMG.IconColor = System.Drawing.Color.Black;
            this.btnDeleteIMG.IconSize = 16;
            this.btnDeleteIMG.Location = new System.Drawing.Point(163, 328);
            this.btnDeleteIMG.Name = "btnDeleteIMG";
            this.btnDeleteIMG.Rotation = 0D;
            this.btnDeleteIMG.Size = new System.Drawing.Size(131, 47);
            this.btnDeleteIMG.TabIndex = 23;
            this.btnDeleteIMG.Text = "Xóa ảnh";
            this.btnDeleteIMG.UseVisualStyleBackColor = false;
            this.btnDeleteIMG.Click += new System.EventHandler(this.btnDeleteIMG_Click);
            // 
            // btnButtonChooseIMG
            // 
            this.btnButtonChooseIMG.BackColor = System.Drawing.Color.Transparent;
            this.btnButtonChooseIMG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnButtonChooseIMG.BackgroundImage")));
            this.btnButtonChooseIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnButtonChooseIMG.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnButtonChooseIMG.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnButtonChooseIMG.IconColor = System.Drawing.Color.Black;
            this.btnButtonChooseIMG.IconSize = 16;
            this.btnButtonChooseIMG.Location = new System.Drawing.Point(163, 391);
            this.btnButtonChooseIMG.Name = "btnButtonChooseIMG";
            this.btnButtonChooseIMG.Rotation = 0D;
            this.btnButtonChooseIMG.Size = new System.Drawing.Size(131, 47);
            this.btnButtonChooseIMG.TabIndex = 24;
            this.btnButtonChooseIMG.Text = "Chọn ảnh";
            this.btnButtonChooseIMG.UseVisualStyleBackColor = false;
            this.btnButtonChooseIMG.Click += new System.EventHandler(this.btnButtonChooseIMG_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(339, 97);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 20);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // comboLoai
            // 
            this.comboLoai.FormattingEnabled = true;
            this.comboLoai.Items.AddRange(new object[] {
            "Nước ngọt",
            "Bánh",
            "Mì",
            "Nước suối",
            "Xúc xích"});
            this.comboLoai.Location = new System.Drawing.Point(114, 186);
            this.comboLoai.Name = "comboLoai";
            this.comboLoai.Size = new System.Drawing.Size(180, 21);
            this.comboLoai.TabIndex = 27;
            this.comboLoai.SelectedIndexChanged += new System.EventHandler(this.comboloai_SelectedIndexChanged);
            // 
            // comboDonvi
            // 
            this.comboDonvi.FormattingEnabled = true;
            this.comboDonvi.Items.AddRange(new object[] {
            "Chai",
            "Lon",
            "Gói",
            "Hộp",
            "Thùng"});
            this.comboDonvi.Location = new System.Drawing.Point(114, 217);
            this.comboDonvi.Name = "comboDonvi";
            this.comboDonvi.Size = new System.Drawing.Size(180, 21);
            this.comboDonvi.TabIndex = 28;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Location = new System.Drawing.Point(237, 282);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(57, 40);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // LabelSearch
            // 
            this.LabelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.BackColor = System.Drawing.Color.Transparent;
            this.LabelSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearch.ForeColor = System.Drawing.Color.White;
            this.LabelSearch.Location = new System.Drawing.Point(542, 99);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(63, 17);
            this.LabelSearch.TabIndex = 30;
            this.LabelSearch.Text = "Tìm kiếm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Giảm giá (%)";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(114, 247);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(180, 20);
            this.txtGiamGia.TabIndex = 31;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.BackgroundImage")));
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportExcel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExportExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExportExcel.IconColor = System.Drawing.Color.Black;
            this.btnExportExcel.IconSize = 16;
            this.btnExportExcel.Location = new System.Drawing.Point(702, 79);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Rotation = 0D;
            this.btnExportExcel.Size = new System.Drawing.Size(200, 37);
            this.btnExportExcel.TabIndex = 36;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // TonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 494);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.comboDonvi);
            this.Controls.Add(this.comboLoai);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnButtonChooseIMG);
            this.Controls.Add(this.btnDeleteIMG);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiaban);
            this.Controls.Add(this.txtGianhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.txtTensp);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "TonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tồn kho";
            this.Load += new System.EventHandler(this.sanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.TextBox txtGianhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnDeleteIMG;
        private FontAwesome.Sharp.IconButton btnButtonChooseIMG;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comboLoai;
        private System.Windows.Forms.ComboBox comboDonvi;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiamGia;
        private FontAwesome.Sharp.IconButton btnExportExcel;
    }
}