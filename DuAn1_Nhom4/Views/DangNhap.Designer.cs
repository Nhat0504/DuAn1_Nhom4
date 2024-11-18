namespace GUI.Views
{
    partial class DangNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_Email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_MK = new TextBox();
            label3 = new Label();
            btn_DangNhap = new Button();
            SuspendLayout();
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(179, 126);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(456, 27);
            txt_Email.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(81, 126);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(81, 254);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật Khẩu";
            // 
            // txt_MK
            // 
            txt_MK.Location = new Point(179, 247);
            txt_MK.Name = "txt_MK";
            txt_MK.Size = new Size(456, 27);
            txt_MK.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(286, 36);
            label3.Margin = new Padding(10, 0, 10, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(15, 5, 15, 5);
            label3.Size = new Size(199, 51);
            label3.TabIndex = 4;
            label3.Text = "Đăng Nhập";
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.BackColor = SystemColors.ActiveCaption;
            btn_DangNhap.Location = new Point(310, 335);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(126, 59);
            btn_DangNhap.TabIndex = 5;
            btn_DangNhap.Text = "Đăng Nhập";
            btn_DangNhap.UseVisualStyleBackColor = false;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_DangNhap);
            Controls.Add(label3);
            Controls.Add(txt_MK);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Email);
            Name = "DangNhap";
            Text = "DangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Email;
        private Label label1;
        private Label label2;
        private TextBox txt_MK;
        private Label label3;
        private Button btn_DangNhap;
    }
}