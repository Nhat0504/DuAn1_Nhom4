namespace GUI.Views
{
    partial class KichThuocUserControl
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
            panel1 = new Panel();
            button3 = new Button();
            btn_Sua = new Button();
            btn_Them = new Button();
            dgv_KichThuoc = new DataGridView();
            txt_KichThuoc = new TextBox();
            txt_Ma = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_KichThuoc).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btn_Sua);
            panel1.Controls.Add(btn_Them);
            panel1.Controls.Add(dgv_KichThuoc);
            panel1.Controls.Add(txt_KichThuoc);
            panel1.Controls.Add(txt_Ma);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1265, 788);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(902, 280);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(656, 280);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(94, 29);
            btn_Sua.TabIndex = 6;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(380, 280);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 29);
            btn_Them.TabIndex = 5;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // dgv_KichThuoc
            // 
            dgv_KichThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_KichThuoc.Location = new Point(61, 396);
            dgv_KichThuoc.Name = "dgv_KichThuoc";
            dgv_KichThuoc.RowHeadersWidth = 51;
            dgv_KichThuoc.Size = new Size(1127, 292);
            dgv_KichThuoc.TabIndex = 4;
            dgv_KichThuoc.CellClick += dgv_KichThuoc_CellClick;
            // 
            // txt_KichThuoc
            // 
            txt_KichThuoc.Location = new Point(527, 195);
            txt_KichThuoc.Name = "txt_KichThuoc";
            txt_KichThuoc.Size = new Size(359, 27);
            txt_KichThuoc.TabIndex = 3;
            // 
            // txt_Ma
            // 
            txt_Ma.Location = new Point(527, 99);
            txt_Ma.Name = "txt_Ma";
            txt_Ma.Size = new Size(359, 27);
            txt_Ma.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 198);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "Kich Thuoc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(380, 102);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 0;
            label1.Text = "Ma";
            // 
            // KichThuocUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "KichThuocUserControl";
            Size = new Size(1271, 794);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_KichThuoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_KichThuoc;
        private TextBox txt_Ma;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button btn_Sua;
        private Button btn_Them;
        private DataGridView dgv_KichThuoc;
    }
}
