namespace GUI.Views
{
    partial class BanHangUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            label10 = new Label();
            txtSearch = new TextBox();
            dataGridView2 = new DataGridView();
            groupBox3 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            txtTienKhachDua = new TextBox();
            label9 = new Label();
            lblTienThua = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dtgvHoaDonCho = new DataGridView();
            cboHoaDon = new ComboBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            txtTenKhachHang = new TextBox();
            txtSoDienThoai = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvHoaDonCho).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1277, 694);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng bán hàng";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(txtSearch);
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(825, 43);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(443, 645);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách sản phẩm";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 61);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 2;
            label10.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(116, 58);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm sản phẩm ở đây";
            txtSearch.Size = new Size(233, 27);
            txtSearch.TabIndex = 1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 94);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(428, 545);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(txtTienKhachDua);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(lblTienThua);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(dtgvHoaDonCho);
            groupBox3.Controls.Add(cboHoaDon);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(315, 43);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(504, 645);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin hóa đơn";
            // 
            // button3
            // 
            button3.Location = new Point(247, 593);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Hủy";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(69, 593);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Thanh toán";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtTienKhachDua
            // 
            txtTienKhachDua.Location = new Point(163, 495);
            txtTienKhachDua.Name = "txtTienKhachDua";
            txtTienKhachDua.Size = new Size(125, 27);
            txtTienKhachDua.TabIndex = 10;
            txtTienKhachDua.TextChanged += txtTienKhachDua_TextChanged;
            txtTienKhachDua.KeyDown += txtTienKhachDua_KeyDown;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(163, 452);
            label9.Name = "label9";
            label9.Size = new Size(127, 20);
            label9.TabIndex = 9;
            label9.Text = "Chưa có tổng tiền";
            // 
            // lblTienThua
            // 
            lblTienThua.AutoSize = true;
            lblTienThua.Location = new Point(163, 545);
            lblTienThua.Name = "lblTienThua";
            lblTienThua.Size = new Size(126, 20);
            lblTienThua.TabIndex = 8;
            lblTienThua.Text = "Chưa có tiền thừa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 545);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 7;
            label7.Text = "Tiền thừa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 502);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 6;
            label6.Text = "Tiền khách đưa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 452);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 5;
            label5.Text = "Tổng hóa đơn: ";
            // 
            // dtgvHoaDonCho
            // 
            dtgvHoaDonCho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHoaDonCho.Location = new Point(6, 94);
            dtgvHoaDonCho.Name = "dtgvHoaDonCho";
            dtgvHoaDonCho.RowHeadersWidth = 51;
            dtgvHoaDonCho.Size = new Size(492, 320);
            dtgvHoaDonCho.TabIndex = 4;
            dtgvHoaDonCho.CellContentClick += dtgvHoaDonCho_CellContentClick;
            // 
            // cboHoaDon
            // 
            cboHoaDon.FormattingEnabled = true;
            cboHoaDon.Location = new Point(145, 39);
            cboHoaDon.Name = "cboHoaDon";
            cboHoaDon.Size = new Size(257, 28);
            cboHoaDon.TabIndex = 3;
            cboHoaDon.SelectedIndexChanged += cboHoaDon_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 47);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 2;
            label4.Text = "Chọn hóa đơn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txtTenKhachHang);
            groupBox2.Controls.Add(txtSoDienThoai);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(6, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(303, 645);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin khách hàng";
            // 
            // button1
            // 
            button1.Location = new Point(56, 298);
            button1.Name = "button1";
            button1.Size = new Size(135, 41);
            button1.TabIndex = 4;
            button1.Text = "Tạo hóa đơn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(114, 187);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.ReadOnly = true;
            txtTenKhachHang.Size = new Size(183, 27);
            txtTenKhachHang.TabIndex = 3;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(137, 77);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(160, 27);
            txtSoDienThoai.TabIndex = 2;
            txtSoDienThoai.KeyDown += txtSoDienThoai_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 190);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 73);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Số điện thoại";
            // 
            // BanHangUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "BanHangUserControl";
            Size = new Size(1265, 700);
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvHoaDonCho).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TextBox txtSearch;
        private DataGridView dataGridView2;
        private Button button3;
        private Button button2;
        private TextBox txtTienKhachDua;
        private Label label9;
        private Label lblTienThua;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dtgvHoaDonCho;
        private ComboBox cboHoaDon;
        private Label label4;
        private Button button1;
        private TextBox txtTenKhachHang;
        private TextBox txtSoDienThoai;
        private Label label2;
        private Label label1;
        private Label label10;
    }
}
