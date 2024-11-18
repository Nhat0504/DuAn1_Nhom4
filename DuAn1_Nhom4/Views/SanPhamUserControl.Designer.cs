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
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView2 = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            dataGridView3 = new DataGridView();
            groupBox4 = new GroupBox();
            txt_Ten = new TextBox();
            txt_giaban = new TextBox();
            txt_MLSP = new TextBox();
            txt_SoLuong = new TextBox();
            txt_ma = new TextBox();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_Add = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox5 = new GroupBox();
            dgrid_SanPham = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_SanPham).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(14, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 333);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Mặt Hàng Kinh Doanh";
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(278, 288);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(141, 290);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(16, 288);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 241);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 27);
            textBox1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(377, 209);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(409, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(828, 333);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi Tiết Sản Phẩm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView3);
            groupBox3.ForeColor = SystemColors.ControlLightLight;
            groupBox3.Location = new Point(6, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(414, 301);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thuộc Tính Sản Phẩm";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 26);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(402, 265);
            dataGridView3.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txt_Ten);
            groupBox4.Controls.Add(txt_giaban);
            groupBox4.Controls.Add(txt_MLSP);
            groupBox4.Controls.Add(txt_SoLuong);
            groupBox4.Controls.Add(txt_ma);
            groupBox4.Controls.Add(btn_xoa);
            groupBox4.Controls.Add(btn_sua);
            groupBox4.Controls.Add(btn_Add);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label1);
            groupBox4.ForeColor = SystemColors.ControlLightLight;
            groupBox4.Location = new Point(426, 26);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(396, 301);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông Tin Sản Phẩm";
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(161, 77);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(193, 27);
            txt_Ten.TabIndex = 13;
            // 
            // txt_giaban
            // 
            txt_giaban.Location = new Point(161, 208);
            txt_giaban.Name = "txt_giaban";
            txt_giaban.Size = new Size(193, 27);
            txt_giaban.TabIndex = 12;
            // 
            // txt_MLSP
            // 
            txt_MLSP.Location = new Point(161, 161);
            txt_MLSP.Name = "txt_MLSP";
            txt_MLSP.Size = new Size(193, 27);
            txt_MLSP.TabIndex = 11;
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(161, 119);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(193, 27);
            txt_SoLuong.TabIndex = 10;
            // 
            // txt_ma
            // 
            txt_ma.Location = new Point(161, 37);
            txt_ma.Name = "txt_ma";
            txt_ma.Size = new Size(193, 27);
            txt_ma.TabIndex = 9;
            txt_ma.TextChanged += textBox2_TextChanged;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xoa.ForeColor = SystemColors.ControlText;
            btn_xoa.Location = new Point(271, 256);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 8;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sua.ForeColor = SystemColors.ControlText;
            btn_sua.Location = new Point(145, 256);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 29);
            btn_sua.TabIndex = 7;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_Sua_Click;
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add.ForeColor = SystemColors.ControlText;
            btn_Add.Location = new Point(22, 256);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(94, 29);
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
            label6.Location = new Point(33, 215);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 5;
            label6.Text = "Giá Bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(33, 168);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "Mã Loại Sp";
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
            // groupBox5
            // 
            groupBox5.Controls.Add(dgrid_SanPham);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = SystemColors.ControlLightLight;
            groupBox5.Location = new Point(3, 359);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1234, 342);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh Sách Sản phẩm";
            // 
            // dgrid_SanPham
            // 
            dgrid_SanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrid_SanPham.GridColor = SystemColors.ActiveBorder;
            dgrid_SanPham.Location = new Point(6, 26);
            dgrid_SanPham.Name = "dgrid_SanPham";
            dgrid_SanPham.RowHeadersWidth = 51;
            dgrid_SanPham.Size = new Size(1222, 310);
            dgrid_SanPham.TabIndex = 0;
            dgrid_SanPham.CellClick += dgrid_SanPham_CellClick;
            // 
            // SanPhamUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SanPhamUserControl";
            Size = new Size(1265, 800);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrid_SanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private DataGridView dgrid_SanPham;
        private TextBox txt_SoLuong;
        private TextBox txt_ma;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_Add;
        private TextBox txt_giaban;
        private TextBox txt_MLSP;
        private DataGridView dataGridView3;
        private TextBox txt_Ten;
    }
}
