namespace GUI.Views
{
    partial class HoaDonUserControl
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
            MaHoaDon = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dtp_NgayMuaHang = new DateTimePicker();
            textBox7 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            textBox9 = new TextBox();
            label13 = new Label();
            rb_DaThanhToan = new RadioButton();
            rb_ChuaThanhToan = new RadioButton();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MaHoaDon
            // 
            MaHoaDon.AutoSize = true;
            MaHoaDon.ForeColor = SystemColors.ControlLightLight;
            MaHoaDon.Location = new Point(64, 51);
            MaHoaDon.Name = "MaHoaDon";
            MaHoaDon.Size = new Size(94, 20);
            MaHoaDon.TabIndex = 0;
            MaHoaDon.Text = "Mã Hóa Đơn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(64, 125);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 2;
            label3.Text = "NV Thanh Toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(64, 193);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 3;
            label4.Text = "Khách Hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(64, 260);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 4;
            label5.Text = "Ngày Tạo Hóa Đơn";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(221, 190);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(296, 28);
            comboBox2.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(221, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(221, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(296, 27);
            textBox3.TabIndex = 9;
            // 
            // dtp_NgayMuaHang
            // 
            dtp_NgayMuaHang.Location = new Point(221, 260);
            dtp_NgayMuaHang.Name = "dtp_NgayMuaHang";
            dtp_NgayMuaHang.Size = new Size(328, 27);
            dtp_NgayMuaHang.TabIndex = 10;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(953, 51);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(217, 27);
            textBox7.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(824, 132);
            label10.Name = "label10";
            label10.Size = new Size(110, 20);
            label10.TabIndex = 19;
            label10.Text = "Mã Thanh Toán";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(824, 58);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 20;
            label11.Text = "Tổng tiền";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(953, 125);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(217, 27);
            textBox9.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(775, 198);
            label13.Name = "label13";
            label13.Size = new Size(78, 20);
            label13.TabIndex = 25;
            label13.Text = "Trạng Thái";
            // 
            // rb_DaThanhToan
            // 
            rb_DaThanhToan.AutoSize = true;
            rb_DaThanhToan.ForeColor = SystemColors.ControlLightLight;
            rb_DaThanhToan.Location = new Point(890, 198);
            rb_DaThanhToan.Name = "rb_DaThanhToan";
            rb_DaThanhToan.Size = new Size(129, 24);
            rb_DaThanhToan.TabIndex = 26;
            rb_DaThanhToan.TabStop = true;
            rb_DaThanhToan.Text = "Đã Thanh Toán";
            rb_DaThanhToan.UseVisualStyleBackColor = true;
            // 
            // rb_ChuaThanhToan
            // 
            rb_ChuaThanhToan.AutoSize = true;
            rb_ChuaThanhToan.ForeColor = SystemColors.ControlLightLight;
            rb_ChuaThanhToan.Location = new Point(1083, 198);
            rb_ChuaThanhToan.Name = "rb_ChuaThanhToan";
            rb_ChuaThanhToan.Size = new Size(144, 24);
            rb_ChuaThanhToan.TabIndex = 27;
            rb_ChuaThanhToan.TabStop = true;
            rb_ChuaThanhToan.Text = "Chưa Thanh Toán";
            rb_ChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 502);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1298, 243);
            dataGridView1.TabIndex = 28;
            // 
            // HoaDonUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(rb_ChuaThanhToan);
            Controls.Add(rb_DaThanhToan);
            Controls.Add(label13);
            Controls.Add(textBox9);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBox7);
            Controls.Add(dtp_NgayMuaHang);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(MaHoaDon);
            Name = "HoaDonUserControl";
            Size = new Size(1298, 745);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MaHoaDon;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dtp_NgayMuaHang;
        private TextBox textBox7;
        private Label label10;
        private Label label11;
        private TextBox textBox9;
        private Label label13;
        private RadioButton rb_DaThanhToan;
        private RadioButton rb_ChuaThanhToan;
        private DataGridView dataGridView1;
    }
}
