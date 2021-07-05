namespace DoAn_2.MenuTab
{
    partial class HoaDonChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonChiTiet));
            this.dataGridViewct = new System.Windows.Forms.DataGridView();
            this.hdid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvsanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DongiaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanvientt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxttNo = new System.Windows.Forms.TextBox();
            this.btnthanhtoanno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbexit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewct)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewct
            // 
            this.dataGridViewct.AllowUserToAddRows = false;
            this.dataGridViewct.AllowUserToDeleteRows = false;
            this.dataGridViewct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hdid,
            this.TenKH,
            this.masp,
            this.tensp,
            this.loaisp,
            this.slsp,
            this.dvsanpham,
            this.DongiaSP,
            this.thanhtoan,
            this.hdtime,
            this.sdt,
            this.no,
            this.nhanvientt});
            this.dataGridViewct.Location = new System.Drawing.Point(47, 111);
            this.dataGridViewct.Name = "dataGridViewct";
            this.dataGridViewct.ReadOnly = true;
            this.dataGridViewct.RowHeadersVisible = false;
            this.dataGridViewct.Size = new System.Drawing.Size(835, 259);
            this.dataGridViewct.TabIndex = 1;
            // 
            // hdid
            // 
            this.hdid.HeaderText = "ID";
            this.hdid.Name = "hdid";
            this.hdid.ReadOnly = true;
            this.hdid.Width = 50;
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // masp
            // 
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            // 
            // tensp
            // 
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // loaisp
            // 
            this.loaisp.HeaderText = "Loại";
            this.loaisp.Name = "loaisp";
            this.loaisp.ReadOnly = true;
            // 
            // slsp
            // 
            this.slsp.HeaderText = "Số lượng";
            this.slsp.Name = "slsp";
            this.slsp.ReadOnly = true;
            // 
            // dvsanpham
            // 
            this.dvsanpham.HeaderText = "Đơn vị";
            this.dvsanpham.Name = "dvsanpham";
            this.dvsanpham.ReadOnly = true;
            // 
            // DongiaSP
            // 
            this.DongiaSP.HeaderText = "Đơn giá";
            this.DongiaSP.Name = "DongiaSP";
            this.DongiaSP.ReadOnly = true;
            // 
            // thanhtoan
            // 
            this.thanhtoan.HeaderText = "Thanh toán";
            this.thanhtoan.Name = "thanhtoan";
            this.thanhtoan.ReadOnly = true;
            // 
            // hdtime
            // 
            this.hdtime.HeaderText = "Thời gian";
            this.hdtime.Name = "hdtime";
            this.hdtime.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // no
            // 
            this.no.HeaderText = "Nợ";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // nhanvientt
            // 
            this.nhanvientt.HeaderText = "Nhân viên thanh toán";
            this.nhanvientt.Name = "nhanvientt";
            this.nhanvientt.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(726, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "In hóa đơn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(573, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 48);
            this.button3.TabIndex = 4;
            this.button3.Text = "Xuất file Excel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBoxttNo
            // 
            this.textBoxttNo.Location = new System.Drawing.Point(47, 72);
            this.textBoxttNo.Name = "textBoxttNo";
            this.textBoxttNo.Size = new System.Drawing.Size(204, 20);
            this.textBoxttNo.TabIndex = 5;
            // 
            // btnthanhtoanno
            // 
            this.btnthanhtoanno.BackColor = System.Drawing.Color.Transparent;
            this.btnthanhtoanno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthanhtoanno.BackgroundImage")));
            this.btnthanhtoanno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthanhtoanno.Location = new System.Drawing.Point(278, 57);
            this.btnthanhtoanno.Name = "btnthanhtoanno";
            this.btnthanhtoanno.Size = new System.Drawing.Size(147, 48);
            this.btnthanhtoanno.TabIndex = 6;
            this.btnthanhtoanno.Text = "Thanh toán";
            this.btnthanhtoanno.UseVisualStyleBackColor = false;
            this.btnthanhtoanno.Click += new System.EventHandler(this.btnthanhtoanno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tiền khách đưa";
            // 
            // lbexit
            // 
            this.lbexit.AutoSize = true;
            this.lbexit.BackColor = System.Drawing.Color.Transparent;
            this.lbexit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbexit.ForeColor = System.Drawing.Color.White;
            this.lbexit.Location = new System.Drawing.Point(863, 9);
            this.lbexit.Name = "lbexit";
            this.lbexit.Size = new System.Drawing.Size(19, 22);
            this.lbexit.TabIndex = 9;
            this.lbexit.Text = "x";
            this.lbexit.Click += new System.EventHandler(this.lbexit_Click);
            // 
            // HoaDonChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 408);
            this.Controls.Add(this.lbexit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthanhtoanno);
            this.Controls.Add(this.textBoxttNo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewct);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoaDonChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn chi tiết";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.HoaDonChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn slsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvsanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn DongiaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanvientt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxttNo;
        private System.Windows.Forms.Button btnthanhtoanno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbexit;
    }
}