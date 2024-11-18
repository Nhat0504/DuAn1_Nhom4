namespace GUI.Views
{
    partial class ThongKeUserControl
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            button1 = new Button();
            monthCalendar1 = new MonthCalendar();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1259, 694);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1251, 661);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thống Kê Doanh Thu";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(monthCalendar1);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(651, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(594, 649);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn Thống Kê Theo:";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(168, 562);
            button1.Name = "button1";
            button1.Size = new Size(179, 58);
            button1.TabIndex = 5;
            button1.Text = "Lọc";
            button1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(113, 328);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.ForeColor = SystemColors.ActiveCaptionText;
            radioButton4.Location = new Point(27, 273);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(103, 24);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Theo Năm";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = SystemColors.ActiveCaptionText;
            radioButton3.Location = new Point(27, 204);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(113, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Theo Tháng";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.ActiveCaptionText;
            radioButton2.Location = new Point(27, 142);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(106, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Theo Ngày";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = SystemColors.ActiveCaptionText;
            radioButton1.Location = new Point(27, 84);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(96, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Hôm Nay";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(639, 649);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bảng Doanh Thu";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(627, 617);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(radioButton9);
            tabPage2.Controls.Add(radioButton8);
            tabPage2.Controls.Add(radioButton7);
            tabPage2.Controls.Add(radioButton6);
            tabPage2.Controls.Add(radioButton5);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage2.ForeColor = SystemColors.ControlLightLight;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1251, 661);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thống Kê Sản Phẩm";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(671, 294);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(298, 24);
            radioButton9.TabIndex = 15;
            radioButton9.TabStop = true;
            radioButton9.Text = "Sản Phẩm Có Số Lượng Nhỏ Hơn 1000";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(671, 240);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(246, 24);
            radioButton8.TabIndex = 14;
            radioButton8.TabStop = true;
            radioButton8.Text = "Sản Phẩm Có Số Lượng > 1000";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(671, 177);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(271, 24);
            radioButton7.TabIndex = 13;
            radioButton7.TabStop = true;
            radioButton7.Text = "Sản Phẩm Bán Chạy Trong 6 tháng";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(671, 110);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(327, 24);
            radioButton6.TabIndex = 12;
            radioButton6.TabStop = true;
            radioButton6.Text = "Sản Phẩm Không Bán Được Trong 6 Tháng";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(671, 44);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(147, 24);
            radioButton5.TabIndex = 11;
            radioButton5.TabStop = true;
            radioButton5.Text = "Tất Cả Sản Phẩm";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(842, 572);
            button2.Name = "button2";
            button2.Size = new Size(164, 57);
            button2.TabIndex = 10;
            button2.Text = "Lọc Danh Sách";
            button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(671, 394);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(671, 528);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 8;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(671, 462);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 7;
            label7.Text = "Đến Ngày";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(671, 340);
            label6.Name = "label6";
            label6.Size = new Size(178, 20);
            label6.TabIndex = 6;
            label6.Text = "Lọc Danh Sách Từ Ngày:";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(617, 601);
            dataGridView2.TabIndex = 0;
            // 
            // ThongKeUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "ThongKeUserControl";
            Size = new Size(1265, 700);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private Button button1;
        private MonthCalendar monthCalendar1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label7;
        private Label label6;
        private DataGridView dataGridView2;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
    }
}
