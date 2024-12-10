namespace GUI.Views
{
    partial class SanPhamUserControl
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
            groupBox5 = new GroupBox();
            dgrid_SanPham = new DataGridView();
            groupBox4 = new GroupBox();
            cbx_MaloaiSP = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            Btn_Clear = new Button();
            label2 = new Label();
            rb_NKD = new RadioButton();
            rb_KD = new RadioButton();
            txt_Ten = new TextBox();
            txt_giaban = new TextBox();
            txt_SoLuong = new TextBox();
            txt_ma = new TextBox();
            btn_sua = new Button();
            btn_Add = new Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            txt_TimKiem = new TextBox();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_SanPham).BeginInit();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txt_TimKiem);
            groupBox5.Controls.Add(dgrid_SanPham);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = SystemColors.ControlLightLight;
            groupBox5.Location = new Point(17, 372);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1234, 379);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh Sách Sản phẩm";
            // 
            // dgrid_SanPham
            // 
            dgrid_SanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrid_SanPham.GridColor = SystemColors.ActiveBorder;
            dgrid_SanPham.Location = new Point(6, 57);
            dgrid_SanPham.Name = "dgrid_SanPham";
            dgrid_SanPham.RowHeadersWidth = 51;
            dgrid_SanPham.Size = new Size(1222, 316);
            dgrid_SanPham.TabIndex = 0;
            dgrid_SanPham.CellClick += dgrid_SanPham_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbx_MaloaiSP);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(button1);
            groupBox4.Controls.Add(Btn_Clear);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(rb_NKD);
            groupBox4.Controls.Add(rb_KD);
            groupBox4.Controls.Add(txt_Ten);
            groupBox4.Controls.Add(txt_giaban);
            groupBox4.Controls.Add(txt_SoLuong);
            groupBox4.Controls.Add(txt_ma);
            groupBox4.Controls.Add(btn_sua);
            groupBox4.Controls.Add(btn_Add);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(button2);
            groupBox4.ForeColor = SystemColors.ControlLightLight;
            groupBox4.Location = new Point(17, 19);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1228, 335);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông Tin Sản Phẩm";
            // 
            // cbx_MaloaiSP
            // 
            cbx_MaloaiSP.FormattingEnabled = true;
            cbx_MaloaiSP.Location = new Point(598, 80);
            cbx_MaloaiSP.Name = "cbx_MaloaiSP";
            cbx_MaloaiSP.Size = new Size(208, 28);
            cbx_MaloaiSP.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(495, 80);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 20;
            label5.Text = "Mã Loại SP";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(1014, 116);
            button1.Name = "button1";
            button1.Size = new Size(114, 53);
            button1.TabIndex = 18;
            button1.Text = "Loại Sản Phẩm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Btn_Clear
            // 
            Btn_Clear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Clear.ForeColor = SystemColors.ControlText;
            Btn_Clear.Location = new Point(754, 232);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(114, 53);
            Btn_Clear.TabIndex = 17;
            Btn_Clear.Text = "Clear";
            Btn_Clear.UseVisualStyleBackColor = true;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(495, 126);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 16;
            label2.Text = "Trạng thái";
            // 
            // rb_NKD
            // 
            rb_NKD.AutoSize = true;
            rb_NKD.Location = new Point(765, 130);
            rb_NKD.Name = "rb_NKD";
            rb_NKD.Size = new Size(153, 24);
            rb_NKD.TabIndex = 15;
            rb_NKD.TabStop = true;
            rb_NKD.Text = "Ngừng kinh doanh";
            rb_NKD.UseVisualStyleBackColor = true;
            // 
            // rb_KD
            // 
            rb_KD.AutoSize = true;
            rb_KD.Location = new Point(598, 126);
            rb_KD.Name = "rb_KD";
            rb_KD.Size = new Size(143, 24);
            rb_KD.TabIndex = 14;
            rb_KD.TabStop = true;
            rb_KD.Text = "Đang kinh doanh";
            rb_KD.UseVisualStyleBackColor = true;
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(161, 77);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(208, 27);
            txt_Ten.TabIndex = 13;
            // 
            // txt_giaban
            // 
            txt_giaban.Location = new Point(598, 40);
            txt_giaban.Name = "txt_giaban";
            txt_giaban.Size = new Size(208, 27);
            txt_giaban.TabIndex = 12;
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(161, 119);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(208, 27);
            txt_SoLuong.TabIndex = 10;
            // 
            // txt_ma
            // 
            txt_ma.Location = new Point(161, 37);
            txt_ma.Name = "txt_ma";
            txt_ma.Size = new Size(208, 27);
            txt_ma.TabIndex = 9;
            txt_ma.TextChanged += textBox2_TextChanged;
            // 
            // btn_sua
            // 
            btn_sua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sua.ForeColor = SystemColors.ControlText;
            btn_sua.Location = new Point(509, 232);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(114, 53);
            btn_sua.TabIndex = 7;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_Sua_Click;
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add.ForeColor = SystemColors.ControlText;
            btn_Add.Location = new Point(259, 232);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(110, 53);
            btn_Add.TabIndex = 6;
            btn_Add.Text = "Thêm ";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(495, 40);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 5;
            label6.Text = "Giá Bán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(33, 126);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Số Lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(36, 40);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã Sản Phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(33, 80);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Sản Phẩm";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(1014, 116);
            button2.Name = "button2";
            button2.Size = new Size(114, 53);
            button2.TabIndex = 19;
            button2.Text = "Chi Tiết Sản Phẩm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox5);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1259, 794);
            panel1.TabIndex = 5;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(349, 24);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(413, 27);
            txt_TimKiem.TabIndex = 6;
            txt_TimKiem.TextChanged += txt_TimKiem_TextChanged;
            // 
            // SanPhamUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "SanPhamUserControl";
            Size = new Size(1265, 800);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_SanPham).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox5;
        private DataGridView dgrid_SanPham;
        private GroupBox groupBox4;
        private TextBox txt_Ten;
        private TextBox txt_giaban;
        private TextBox txt_SoLuong;
        private TextBox txt_ma;
        private Button btn_sua;
        private Button btn_Add;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private RadioButton rb_NKD;
        private RadioButton rb_KD;
        private Button Btn_Clear;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Label label5;
        private ComboBox cbx_MaloaiSP;
        private TextBox txt_TimKiem;
    }
}
