namespace GUI.Views
{
    partial class NhanVienUserControl
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_Ten = new TextBox();
            txt_SDT = new TextBox();
            txt_DiaChi = new TextBox();
            txt_Email = new TextBox();
            textBox6 = new TextBox();
            btn_Add = new Button();
            button2 = new Button();
            btn_Xoa = new Button();
            groupBox1 = new GroupBox();
            dgv_NhanVien = new DataGridView();
            txt_Ma = new TextBox();
            dtp_Date = new DateTimePicker();
            label8 = new Label();
            txt_ChucVu = new TextBox();
            Nam_rb = new RadioButton();
            Nu_rb = new RadioButton();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_NhanVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 122);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 195);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Giới Tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 279);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Năm Sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(620, 54);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 3;
            label4.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(620, 122);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 4;
            label5.Text = "Địa Chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(620, 198);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(217, 115);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(250, 27);
            txt_Ten.TabIndex = 7;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(736, 47);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(250, 27);
            txt_SDT.TabIndex = 9;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(736, 115);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(250, 27);
            txt_DiaChi.TabIndex = 10;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(736, 195);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(250, 27);
            txt_Email.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(969, 401);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Tìm Kiếm";
            textBox6.Size = new Size(267, 27);
            textBox6.TabIndex = 12;
            // 
            // btn_Add
            // 
            btn_Add.ForeColor = SystemColors.ControlText;
            btn_Add.Location = new Point(141, 360);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(159, 47);
            btn_Add.TabIndex = 17;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(395, 360);
            button2.Name = "button2";
            button2.Size = new Size(174, 47);
            button2.TabIndex = 18;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.ForeColor = SystemColors.ControlText;
            btn_Xoa.Location = new Point(682, 360);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(161, 47);
            btn_Xoa.TabIndex = 19;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_NhanVien);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(3, 422);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1416, 275);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Nhân Viên Chi Tiết";
            // 
            // dgv_NhanVien
            // 
            dgv_NhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_NhanVien.Location = new Point(7, 26);
            dgv_NhanVien.Name = "dgv_NhanVien";
            dgv_NhanVien.RowHeadersWidth = 51;
            dgv_NhanVien.Size = new Size(1403, 243);
            dgv_NhanVien.TabIndex = 0;
            dgv_NhanVien.CellClick += dgv_NhanVien_CellClick;
            dgv_NhanVien.CellContentClick += dgv_NhanVien_CellContentClick;
            // 
            // txt_Ma
            // 
            txt_Ma.Location = new Point(217, 51);
            txt_Ma.Name = "txt_Ma";
            txt_Ma.Size = new Size(250, 27);
            txt_Ma.TabIndex = 22;
            // 
            // dtp_Date
            // 
            dtp_Date.CustomFormat = "dd/MMMM/yyyy";
            dtp_Date.Font = new Font("Segoe UI", 9F);
            dtp_Date.Location = new Point(217, 272);
            dtp_Date.Name = "dtp_Date";
            dtp_Date.Size = new Size(250, 27);
            dtp_Date.TabIndex = 23;
            dtp_Date.Value = new DateTime(2024, 12, 6, 0, 0, 0, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 58);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 24;
            label8.Text = "Mã NV";
            // 
            // txt_ChucVu
            // 
            txt_ChucVu.Location = new Point(736, 272);
            txt_ChucVu.Name = "txt_ChucVu";
            txt_ChucVu.Size = new Size(250, 27);
            txt_ChucVu.TabIndex = 25;
            // 
            // Nam_rb
            // 
            Nam_rb.AutoSize = true;
            Nam_rb.Location = new Point(217, 193);
            Nam_rb.Name = "Nam_rb";
            Nam_rb.Size = new Size(64, 24);
            Nam_rb.TabIndex = 26;
            Nam_rb.TabStop = true;
            Nam_rb.Text = "Nam";
            Nam_rb.UseVisualStyleBackColor = true;
            // 
            // Nu_rb
            // 
            Nu_rb.AutoSize = true;
            Nu_rb.Location = new Point(384, 191);
            Nu_rb.Name = "Nu_rb";
            Nu_rb.Size = new Size(52, 24);
            Nu_rb.TabIndex = 27;
            Nu_rb.TabStop = true;
            Nu_rb.Text = "Nữ";
            Nu_rb.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(620, 279);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 28;
            label7.Text = "Chức Vụ";
            // 
            // NhanVienUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(Nu_rb);
            Controls.Add(Nam_rb);
            Controls.Add(txt_ChucVu);
            Controls.Add(label8);
            Controls.Add(dtp_Date);
            Controls.Add(txt_Ma);
            Controls.Add(textBox6);
            Controls.Add(groupBox1);
            Controls.Add(btn_Xoa);
            Controls.Add(button2);
            Controls.Add(btn_Add);
            Controls.Add(txt_Email);
            Controls.Add(txt_DiaChi);
            Controls.Add(txt_SDT);
            Controls.Add(txt_Ten);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLightLight;
            Name = "NhanVienUserControl";
            Size = new Size(1423, 700);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_NhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_Ten;
        private TextBox txt_SDT;
        private TextBox txt_DiaChi;
        private TextBox txt_Email;
        private TextBox textBox6;
        private CheckBox rb;
        private CheckBox rb_Nu;
        private Button btn_Add;
        private Button button2;
        private Button btn_Xoa;
        private GroupBox groupBox1;
        private DataGridView dgv_NhanVien;
        private TextBox txt_Ma;
        private DateTimePicker dtp_Date;
        private Label label8;
        private TextBox txt_ChucVu;
        private RadioButton Nam_rb;
        private RadioButton Nu_rb;
        private Label label7;
    }
}
