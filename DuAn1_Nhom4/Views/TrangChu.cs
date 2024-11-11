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
            this.panel1.Controls.Clear();
            BanHang frm_banSanPham = new BanHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(frm_banSanPham);
            frm_banSanPham.Show();
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            SanPham frm_banSanPham = new SanPham() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(frm_banSanPham);
            frm_banSanPham.Show();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            HoaDon frm_banSanPham = new HoaDon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(frm_banSanPham);
            frm_banSanPham.Show();
        }

        private void btn_KhuyenMai_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            KhuyenMai frm_banSanPham = new KhuyenMai() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(frm_banSanPham);
            frm_banSanPham.Show();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            NhanVien frm_banSanPham = new NhanVien() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(frm_banSanPham);
            frm_banSanPham.Show();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            KhachHang frm_banSanPham = new KhachHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(frm_banSanPham);
            frm_banSanPham.Show();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            ThongKe frm_banSanPham = new ThongKe() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(frm_banSanPham);
            frm_banSanPham.Show();
        }
    }
}
