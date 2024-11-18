using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Views
{
    public partial class InputQuantityForm : Form
    {
        public int SoLuong { get; private set; }
        private int maxSoLuong;

        public InputQuantityForm(int maxSoLuong)
        {
            InitializeComponent();
            this.maxSoLuong = maxSoLuong;
            txtSoLuong.Minimum = 1;              
            txtSoLuong.Maximum = maxSoLuong;     // Số lượng tối đa
            txtSoLuong.Value = 1;  // Đặt giá trị mặc định là 1
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SoLuong = (int)txtSoLuong.Value;     // Lấy giá trị từ NumericUpDown
            this.DialogResult = DialogResult.OK; // Đặt kết quả trả về là OK
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Đặt kết quả trả về là Cancel
            this.Close();
        }
    }
}
