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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear(); // Xóa hết các điều khiển hiện tại trong panel1
            BanHangUserControl frm_banHang = new BanHangUserControl() { Dock = DockStyle.Fill };
            // Tạo một đối tượng BanHangUserControl, dock nó vào panel1
            this.panel1.Controls.Add(frm_banHang); // Thêm BanHangUserControl vào panel1
        }


        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            SanPhamUserControl frm_sanPham = new SanPhamUserControl() { Dock = DockStyle.Fill };
            this.panel1.Controls.Add(frm_sanPham);
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            HoaDonUserControl frm_sanPham = new HoaDonUserControl() { Dock = DockStyle.Fill };
            this.panel1.Controls.Add(frm_sanPham);
        }

        private void btn_KhuyenMai_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            NhanVienUserControl frm_banSanPham = new NhanVienUserControl() { Dock = DockStyle.Fill };
            this.panel1.Controls.Add(frm_banSanPham);
            frm_banSanPham.Show();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            KhachHangUserControl frm_banSanPham = new KhachHangUserControl() { Dock = DockStyle.Fill };
            this.panel1.Controls.Add(frm_banSanPham);
            frm_banSanPham.Show();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            ThongKeUserControl frm_banSanPham = new ThongKeUserControl() { Dock = DockStyle.Fill };
            this.panel1.Controls.Add(frm_banSanPham);
            frm_banSanPham.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
