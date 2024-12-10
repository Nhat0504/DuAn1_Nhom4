namespace GUI.Views
{
    partial class CTSPUserControl
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
            txt_SoLuong = new TextBox();
            cbx_KT = new ComboBox();
            dgv_CTSP = new DataGridView();
            btn_Them = new Button();
            btn_Sua = new Button();
            button3 = new Button();
            txt_MaCTSP = new TextBox();
            panel1 = new Panel();
            cbx_MaSp = new ComboBox();
            cbx_Mau = new ComboBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_CTSP).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(70, 86);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "MaChiTietSp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(70, 142);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "MaSanPham";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(471, 93);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "MaMauSac";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(471, 142);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 3;
            label4.Text = "MaKichThuoc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(869, 89);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "SoLuong";
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(962, 86);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(205, 27);
            txt_SoLuong.TabIndex = 5;
            // 
            // cbx_KT
            // 
            cbx_KT.FormattingEnabled = true;
            cbx_KT.Location = new Point(582, 134);
            cbx_KT.Name = "cbx_KT";
            cbx_KT.Size = new Size(205, 28);
            cbx_KT.TabIndex = 11;
            // 
            // dgv_CTSP
            // 
            dgv_CTSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_CTSP.Location = new Point(70, 396);
            dgv_CTSP.Name = "dgv_CTSP";
            dgv_CTSP.RowHeadersWidth = 51;
            dgv_CTSP.Size = new Size(1097, 270);
            dgv_CTSP.TabIndex = 12;
            dgv_CTSP.CellClick += dgv_CTSP_CellClick;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(354, 276);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 29);
            btn_Them.TabIndex = 13;
            btn_Them.Text = "Them";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(634, 276);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(94, 29);
            btn_Sua.TabIndex = 14;
            btn_Sua.Text = "Sua";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // button3
            // 
            button3.Location = new Point(879, 276);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 15;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_MaCTSP
            // 
            txt_MaCTSP.Location = new Point(184, 86);
            txt_MaCTSP.Name = "txt_MaCTSP";
            txt_MaCTSP.Size = new Size(202, 27);
            txt_MaCTSP.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(cbx_MaSp);
            panel1.Controls.Add(cbx_Mau);
            panel1.Controls.Add(btn_Them);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbx_KT);
            panel1.Controls.Add(txt_SoLuong);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(txt_MaCTSP);
            panel1.Controls.Add(btn_Sua);
            panel1.Controls.Add(dgv_CTSP);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1259, 694);
            panel1.TabIndex = 17;
            // 
            // cbx_MaSp
            // 
            cbx_MaSp.FormattingEnabled = true;
            cbx_MaSp.Location = new Point(184, 139);
            cbx_MaSp.Name = "cbx_MaSp";
            cbx_MaSp.Size = new Size(205, 28);
            cbx_MaSp.TabIndex = 18;
            // 
            // cbx_Mau
            // 
            cbx_Mau.FormattingEnabled = true;
            cbx_Mau.Location = new Point(582, 89);
            cbx_Mau.Name = "cbx_Mau";
            cbx_Mau.Size = new Size(205, 28);
            cbx_Mau.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(471, 363);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 27);
            textBox1.TabIndex = 19;
            // 
            // CTSPUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "CTSPUserControl";
            Size = new Size(1265, 700);
            ((System.ComponentModel.ISupportInitialize)dgv_CTSP).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_SoLuong;
        private TextBox txt_Mau;
        private ComboBox cbx_KT;
        private DataGridView dgv_CTSP;
        private Button btn_Them;
        private Button btn_Sua;
        private Button button3;
        private TextBox txt_MaCTSP;
        private Panel panel1;
        private ComboBox cbx_Mau;
        private ComboBox cbx_MaSp;
        private TextBox textBox1;
    }
}
