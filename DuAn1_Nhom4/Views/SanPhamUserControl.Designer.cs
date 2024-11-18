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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_Add = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            txt_ma = new TextBox();
            txt_SoLuong = new TextBox();
            txt_MLSP = new TextBox();
            txt_giaban = new TextBox();
            txt_Ten = new TextBox();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_SanPham).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
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
            groupBox4.Location = new Point(9, 18);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1228, 335);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông Tin Sản Phẩm";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(491, 130);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "Mã Loại Sp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(495, 47);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 5;
            label6.Text = "Giá Bán";
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add.ForeColor = SystemColors.ControlText;
            btn_Add.Location = new Point(124, 232);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(110, 53);
            btn_Add.TabIndex = 6;
            btn_Add.Text = "Thêm ";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_sua
            // 
            btn_sua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sua.ForeColor = SystemColors.ControlText;
            btn_sua.Location = new Point(413, 232);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(114, 53);
            btn_sua.TabIndex = 7;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_Sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xoa.ForeColor = SystemColors.ControlText;
            btn_xoa.Location = new Point(649, 232);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(117, 53);
            btn_xoa.TabIndex = 8;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // txt_ma
            // 
            txt_ma.Location = new Point(161, 37);
            txt_ma.Name = "txt_ma";
            txt_ma.Size = new Size(208, 27);
            txt_ma.TabIndex = 9;
            txt_ma.TextChanged += textBox2_TextChanged;
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(161, 119);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(208, 27);
            txt_SoLuong.TabIndex = 10;
            // 
            // txt_MLSP
            // 
            txt_MLSP.Location = new Point(582, 123);
            txt_MLSP.Name = "txt_MLSP";
            txt_MLSP.Size = new Size(208, 27);
            txt_MLSP.TabIndex = 11;
            // 
            // txt_giaban
            // 
            txt_giaban.Location = new Point(582, 40);
            txt_giaban.Name = "txt_giaban";
            txt_giaban.Size = new Size(208, 27);
            txt_giaban.TabIndex = 12;
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(161, 77);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(208, 27);
            txt_Ten.TabIndex = 13;
            // 
            // SanPhamUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Name = "SanPhamUserControl";
            Size = new Size(1265, 800);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrid_SanPham).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox5;
        private DataGridView dgrid_SanPham;
        private GroupBox groupBox4;
        private TextBox txt_Ten;
        private TextBox txt_giaban;
        private TextBox txt_MLSP;
        private TextBox txt_SoLuong;
        private TextBox txt_ma;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_Add;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}
