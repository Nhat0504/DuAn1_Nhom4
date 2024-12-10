using BUS.IServices;
using BUS.Services;
using DAL.Models;
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
    public partial class CTSPUserControl : UserControl
    {
        private ICTSPService _CTSPservice;
        private IMauService _MauService;
        private ISanPhamService _SanPhamService;
        private ISizeService _sizeService;
        private ChiTietSanPham _ListCTSP;
        public CTSPUserControl()
        {
            InitializeComponent();
            _CTSPservice = new CTSPService();
            _MauService = new Mauservice();
            _sizeService = new SizeService();
            loadCBX1();
            loadCBX2();
            loadCBX3();
            LoadDataFromDB();
        }
        public void LoadDataFromDB()
        {
            dgv_CTSP.ColumnCount = 5;
            dgv_CTSP.Columns[0].Name = " Ma CTSP";
            dgv_CTSP.Columns[0].Visible = true;
            dgv_CTSP.Columns[1].Name = "Ma SP";
            dgv_CTSP.Columns[2].Name = "Ma Mau Sac";
            dgv_CTSP.Columns[3].Name = "Ma Khich Thuoc";
            dgv_CTSP.Columns[4].Name = "So luong";
            foreach (var x in _CTSPservice.GetAll())
            {
                dgv_CTSP.Rows.Add(x.MaChiTietSp, x.MaSanPham, x.MaMauSac, x.MaKichThuoc, x.SoLuong);
            }
            dgv_CTSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CTSP.DefaultCellStyle.ForeColor = Color.Black;

        }
        public void loadCBX1()
        {
            foreach (var item in _sizeService.GetAll())
            {
                cbx_KT.Items.Add(item.MaKichThuoc);
            }
        }
        public void loadCBX2()
        {
            foreach (var item in _MauService.GetAll())
            {
                cbx_Mau.Items.Add(item.MaMauSac);
            }
        }
        public void loadCBX3()
        {
            foreach (var item in _SanPhamService.GetAll())
            {
                cbx_MaSp.Items.Add(item.MaSanPham);
            }
        }
        public bool checknhap()
        {
            if (txt_MaCTSP.Text == "") return false;
            return true;
        }
        public void Reset()
        {
            this.panel1.Controls.Clear();
            CTSPUserControl frm_sanPham = new CTSPUserControl() { Dock = DockStyle.Fill };
            this.panel1.Controls.Add(frm_sanPham);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            var maSanPhamCanTim = int.Parse(txt_MaCTSP.Text);
            var p = _CTSPservice.GetAll().FirstOrDefault(x => x.MaChiTietSp == maSanPhamCanTim);
            var b = _MauService.GetAll().FirstOrDefault(x => x.MaMauSac == int.Parse(cbx_Mau.Text));
            var c = _sizeService.GetAll().FirstOrDefault(x => x.MaKichThuoc == int.Parse(cbx_KT.Text));
            var d = _SanPhamService.GetAll().FirstOrDefault(x => x.MaSanPham == int.Parse(cbx_KT.Text));
            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else if (p != null)
            {
                MessageBox.Show("Mã đã tồn tại", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm  không?", "Thêm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    return;

                }
                try
                {
                    var a = new ChiTietSanPham()
                    {
                        MaChiTietSp = int.Parse(txt_MaCTSP.Text),
                        MaSanPham = d.MaSanPham,
                        MaMauSac = b.MaMauSac,
                        MaKichThuoc = c.MaKichThuoc,
                        SoLuong = int.Parse(txt_SoLuong.Text),

                    };
                    _CTSPservice.Add(a);
                    MessageBox.Show("Thêm thành công");
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi");
                }
            }
        }

        private void dgv_CTSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow r = dgv_CTSP.Rows[e.RowIndex];
                Guid id;
                if (Guid.TryParse(r.Cells[0].Value?.ToString(), out id))
                {
                    _ListCTSP = _CTSPservice.GetAll().FirstOrDefault(c => c.MaChiTietSp == int.Parse(id.ToString()));
                }
                txt_MaCTSP.Text = r.Cells[0].Value?.ToString();
                cbx_MaSp.Text = r.Cells[1].Value?.ToString();
                cbx_Mau.Text = r.Cells[2].Value?.ToString();
                cbx_KT.Text = r.Cells[3].Value?.ToString();
                txt_SoLuong.Text = r.Cells[4].Value?.ToString();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_ListCTSP == null)
            {
                MessageBox.Show("Không tìm thấy mã VGA", "Cảnh báo");
            }
            else if (!checknhap())
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo);
                if (dialog != DialogResult.Yes)
                {
                    return;
                }

                try
                {
                    int maCTSP = int.Parse(txt_MaCTSP.Text);
                    var p = _CTSPservice.GetAll().FirstOrDefault(x => x.MaChiTietSp == maCTSP);
                    var b = _MauService.GetAll().FirstOrDefault(x => x.MaMauSac == int.Parse(cbx_Mau.Text));
                    var c = _sizeService.GetAll().FirstOrDefault(x => x.MaKichThuoc == int.Parse(cbx_KT.Text));
                    var d = _SanPhamService.GetAll().FirstOrDefault(x => x.MaSanPham == int.Parse(cbx_KT.Text));
                    if (maCTSP == null)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm có mã này", "Lỗi");
                        return;
                    }

                    // Cập nhật thông tin sản phẩm



                    MessageBox.Show("Sửa thành công");
                    Reset();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
