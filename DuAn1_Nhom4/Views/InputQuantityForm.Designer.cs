namespace GUI.Views
{
    partial class InputQuantityForm
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
            label1 = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            txtSoLuong = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtSoLuong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 60);
            label1.Name = "label1";
            label1.Size = new Size(197, 28);
            label1.TabIndex = 0;
            label1.Text = "Mời nhập số lượng:";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(75, 148);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(134, 48);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(284, 148);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 48);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(236, 65);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(236, 27);
            txtSoLuong.TabIndex = 4;
            // 
            // InputQuantityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 223);
            Controls.Add(txtSoLuong);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(label1);
            Name = "InputQuantityForm";
            Text = "InputQuantityForm";
            ((System.ComponentModel.ISupportInitialize)txtSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnOk;
        private Button btnCancel;
        private NumericUpDown txtSoLuong;
    }
}