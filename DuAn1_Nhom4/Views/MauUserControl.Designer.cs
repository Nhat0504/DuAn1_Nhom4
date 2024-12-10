namespace GUI.Views
{
    partial class MauUserControl
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
            btn_Them = new Button();
            btn_Sua = new Button();
            button1 = new Button();
            dgv_Mau = new DataGridView();
            txt_Ma = new TextBox();
            txt_Ten = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Mau).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Them);
            panel1.Controls.Add(btn_Sua);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dgv_Mau);
            panel1.Controls.Add(txt_Ma);
            panel1.Controls.Add(txt_Ten);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1265, 788);
            panel1.TabIndex = 0;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(314, 254);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 29);
            btn_Them.TabIndex = 7;
            btn_Them.Text = "Them";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(589, 254);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(94, 29);
            btn_Sua.TabIndex = 6;
            btn_Sua.Text = "Sua";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // button1
            // 
            button1.Location = new Point(852, 254);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgv_Mau
            // 
            dgv_Mau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Mau.Location = new Point(27, 367);
            dgv_Mau.Name = "dgv_Mau";
            dgv_Mau.RowHeadersWidth = 51;
            dgv_Mau.Size = new Size(1216, 364);
            dgv_Mau.TabIndex = 4;
            dgv_Mau.CellClick += dgv_Mau_CellClick;
            // 
            // txt_Ma
            // 
            txt_Ma.Location = new Point(480, 68);
            txt_Ma.Name = "txt_Ma";
            txt_Ma.Size = new Size(328, 27);
            txt_Ma.TabIndex = 3;
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(480, 154);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(328, 27);
            txt_Ten.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(338, 161);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Màu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(338, 75);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã";
            // 
            // MauUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "MauUserControl";
            Size = new Size(1271, 794);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Mau).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_Ma;
        private TextBox txt_Ten;
        private Label label2;
        private Label label1;
        private Button btn_Them;
        private Button btn_Sua;
        private Button button1;
        private DataGridView dgv_Mau;
    }
}
