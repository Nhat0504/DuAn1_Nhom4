namespace GUI.Views
{
    partial class LoaiSPUserControl
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
            label1 = new Label();
            label2 = new Label();
            txt_Ma = new TextBox();
            txt_TenLoai = new TextBox();
            dgv_LoaiSP = new DataGridView();
            panel2 = new Panel();
            btn_Clear = new Button();
            label3 = new Label();
            txt_TimKiem = new TextBox();
            btn_sua = new Button();
            btn_Xoa = new Button();
            btn_SP = new Button();
            btn_Add = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_LoaiSP).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(226, 71);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã loại sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(226, 128);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên loại sản phẩm";
            // 
            // txt_Ma
            // 
            txt_Ma.Location = new Point(470, 64);
            txt_Ma.Name = "txt_Ma";
            txt_Ma.Size = new Size(390, 27);
            txt_Ma.TabIndex = 2;
            // 
            // txt_TenLoai
            // 
            txt_TenLoai.Location = new Point(470, 121);
            txt_TenLoai.Name = "txt_TenLoai";
            txt_TenLoai.Size = new Size(390, 27);
            txt_TenLoai.TabIndex = 3;
            // 
            // dgv_LoaiSP
            // 
            dgv_LoaiSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_LoaiSP.Location = new Point(56, 434);
            dgv_LoaiSP.Name = "dgv_LoaiSP";
            dgv_LoaiSP.RowHeadersWidth = 51;
            dgv_LoaiSP.Size = new Size(1167, 217);
            dgv_LoaiSP.TabIndex = 4;
            dgv_LoaiSP.CellClick += dgv_LoaiSP_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_Clear);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_TimKiem);
            panel2.Controls.Add(btn_sua);
            panel2.Controls.Add(btn_Xoa);
            panel2.Controls.Add(btn_SP);
            panel2.Controls.Add(btn_Add);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dgv_LoaiSP);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_TenLoai);
            panel2.Controls.Add(txt_Ma);
            panel2.Location = new Point(5, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1263, 788);
            panel2.TabIndex = 5;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(598, 234);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(94, 29);
            btn_Clear.TabIndex = 14;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(255, 388);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 13;
            label3.Text = "Tìm Kiếm";
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(434, 381);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(390, 27);
            txt_TimKiem.TabIndex = 12;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(598, 295);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 29);
            btn_sua.TabIndex = 11;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(766, 295);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(94, 29);
            btn_Xoa.TabIndex = 10;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_SP
            // 
            btn_SP.Location = new Point(1072, 62);
            btn_SP.Name = "btn_SP";
            btn_SP.Size = new Size(94, 29);
            btn_SP.TabIndex = 9;
            btn_SP.Text = "Sản phẩm";
            btn_SP.UseVisualStyleBackColor = true;
            btn_SP.Click += btn_SP_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(416, 295);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(94, 29);
            btn_Add.TabIndex = 7;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // LoaiSPUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "LoaiSPUserControl";
            Size = new Size(1271, 794);
            Load += LoaiSPUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_LoaiSP).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Ma;
        private TextBox txt_TenLoai;
        private DataGridView dgv_LoaiSP;
        private Panel panel2;
        private TextBox textBox3;
        private Label label3;
        private Button btn_SP;
        private Button button2;
        private Button btn_Add;
        private Button btn_Xoa;
        private Button btn_sua;
        private TextBox txt_TimKiem;
        private Button btn_Clear;
    }
}
