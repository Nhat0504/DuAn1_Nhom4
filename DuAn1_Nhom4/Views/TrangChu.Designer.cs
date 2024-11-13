namespace GUI.Views
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            SanPham = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Navy;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(SanPham);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 168);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 679);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label9
            // 
            label9.BackColor = Color.Navy;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(5, 503);
            label9.Margin = new Padding(2);
            label9.Name = "label9";
            label9.Size = new Size(210, 61);
            label9.TabIndex = 9;
            label9.Text = "Đăng xuất";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += btn_DangXuat_Click;
            // 
            // label8
            // 
            label8.BackColor = Color.Navy;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(5, 415);
            label8.Margin = new Padding(2);
            label8.Name = "label8";
            label8.Size = new Size(210, 61);
            label8.TabIndex = 8;
            label8.Text = "Thống Kê";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += btn_ThongKe_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.Navy;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(5, 350);
            label7.Margin = new Padding(2);
            label7.Name = "label7";
            label7.Size = new Size(210, 61);
            label7.TabIndex = 7;
            label7.Text = "Khách Hàng";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += btn_KhachHang_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Navy;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(5, 285);
            label6.Margin = new Padding(2);
            label6.Name = "label6";
            label6.Size = new Size(210, 61);
            label6.TabIndex = 6;
            label6.Text = "Nhân Viên";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += btn_NhanVien_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Navy;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(5, 220);
            label5.Margin = new Padding(2);
            label5.Name = "label5";
            label5.Size = new Size(210, 61);
            label5.TabIndex = 5;
            label5.Text = "Khuyến Mãi";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += btn_KhuyenMai_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Navy;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(5, 155);
            label4.Margin = new Padding(2);
            label4.Name = "label4";
            label4.Size = new Size(210, 61);
            label4.TabIndex = 4;
            label4.Text = "Hóa Đơn";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += btn_HoaDon_Click;
            // 
            // SanPham
            // 
            SanPham.BackColor = Color.Navy;
            SanPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            SanPham.ForeColor = SystemColors.ControlLightLight;
            SanPham.Image = Properties.Resources.Product;
            SanPham.ImageAlign = ContentAlignment.MiddleLeft;
            SanPham.Location = new Point(5, 90);
            SanPham.Margin = new Padding(2);
            SanPham.Name = "SanPham";
            SanPham.Size = new Size(210, 61);
            SanPham.TabIndex = 2;
            SanPham.Text = "Sản Phẩm";
            SanPham.TextAlign = ContentAlignment.MiddleCenter;
            SanPham.Click += btn_SanPham_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Image = Properties.Resources.Cart;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(5, 25);
            label1.Margin = new Padding(2);
            label1.Name = "label1";
            label1.Size = new Size(210, 61);
            label1.TabIndex = 1;
            label1.Text = "Bán Hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += btn_BanHang_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Navy;
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(0, -9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(220, 188);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(50, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe Script", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(141, 323);
            label10.Name = "label10";
            label10.Size = new Size(630, 199);
            label10.TabIndex = 2;
            label10.Text = "Welcome";
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Location = new Point(226, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 720);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1532, 753);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TrangChu";
            Text = "TrangChu";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label SanPham;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label10;
        private Panel panel1;
    }
}