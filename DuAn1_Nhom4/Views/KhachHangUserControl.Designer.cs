namespace GUI.Views
{
    partial class KhachHangUserControl
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
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            Nu_rb = new RadioButton();
            Nam_rb = new RadioButton();
            label6 = new Label();
            textBox5 = new TextBox();
            txt_Ten = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            textBox4 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(Nu_rb);
            groupBox1.Controls.Add(Nam_rb);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(txt_Ten);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1259, 694);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản Lý Khách Hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 195);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 24;
            label7.Text = "Ngay Sinh";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(218, 190);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 23;
            dateTimePicker1.Value = new DateTime(2024, 12, 6, 0, 0, 0, 0);
            // 
            // Nu_rb
            // 
            Nu_rb.AutoSize = true;
            Nu_rb.Location = new Point(372, 142);
            Nu_rb.Name = "Nu_rb";
            Nu_rb.Size = new Size(52, 24);
            Nu_rb.TabIndex = 22;
            Nu_rb.TabStop = true;
            Nu_rb.Text = "Nữ";
            Nu_rb.UseVisualStyleBackColor = true;
            // 
            // Nam_rb
            // 
            Nam_rb.AutoSize = true;
            Nam_rb.Location = new Point(218, 144);
            Nam_rb.Name = "Nam_rb";
            Nam_rb.Size = new Size(64, 24);
            Nam_rb.TabIndex = 21;
            Nam_rb.TabStop = true;
            Nam_rb.Text = "Nam";
            Nam_rb.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 33);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 20;
            label6.Text = "Ma";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(218, 26);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(245, 27);
            textBox5.TabIndex = 19;
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(218, 73);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(245, 27);
            txt_Ten.TabIndex = 18;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(0, 430);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1253, 258);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin Khách Hàng Chi Tiết";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1241, 226);
            dataGridView1.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(820, 403);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Tìm Kiếm";
            textBox4.Size = new Size(182, 36);
            textBox4.TabIndex = 15;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(647, 306);
            button3.Name = "button3";
            button3.Size = new Size(118, 60);
            button3.TabIndex = 14;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(647, 216);
            button2.Name = "button2";
            button2.Size = new Size(118, 52);
            button2.TabIndex = 13;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(647, 115);
            button1.Name = "button1";
            button1.Size = new Size(118, 53);
            button1.TabIndex = 12;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(218, 379);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 27);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 306);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 27);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 248);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 27);
            textBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 379);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 4;
            label5.Text = "Gmail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 306);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 248);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 144);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Giới Tính";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 76);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Khách Hàng";
            // 
            // KhachHangUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "KhachHangUserControl";
            Size = new Size(1265, 700);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txt_Ten;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private RadioButton Nu_rb;
        private RadioButton Nam_rb;
    }
}
