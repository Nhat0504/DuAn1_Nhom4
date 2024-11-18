using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.IServices;
using BUS.Services;
using DAL.Models;

namespace GUI.Views
{
    public partial class SanPhamUserControl : UserControl
    {
        private ISanPhamService _iSanPhamservice;
        private SanPham _lstSanPham;
        public SanPhamUserControl()
        {
            InitializeComponent();
            _iSanPhamservice = new SanPhamService();
            _lstSanPham = new SanPham();
            LoadDataFormDb();
        }
        public void LoadDataFormDb()
        {
            dgrid_SanPham.ColumnCount = 6;
            dgrid_SanPham.Columns[0].Name = "MaSanPham";
            dgrid_SanPham.Columns[0].Visible = true;
            dgrid_SanPham.Columns[1].Name = "TenSanPham";
            dgrid_SanPham.Columns[2].Name = "Gia";
            dgrid_SanPham.Columns[3].Name = "SoLuong";
            dgrid_SanPham.Columns[4].Name = "MaLoaiSp";
            dgrid_SanPham.Columns[5].Name = "MoTa";
            foreach (var x in _iSanPhamservice.GetAll())
            {
                dgrid_SanPham.Rows.Add(x.MaSanPham, x.TenSanPham, x.Gia, x.SoLuong, x.MaLoaiSp, x.MoTa);
            }
            dgrid_SanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrid_SanPham.DefaultCellStyle.ForeColor = Color.Black;
            dgrid_SanPham.Columns["Gia"].DefaultCellStyle.Format = "#,##0 VNĐ";
        }
        public bool checknhap()
        {
            if (txt_Ten.Text == "") return false;
            return true;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var maSanPhamCanTim = int.Parse(txt_ma.Text);
            var p = _iSanPhamservice.GetAll().FirstOrDefault(x => x.MaSanPham == maSanPhamCanTim);
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
                    var a = new DAL.Models.SanPham()
                    {
                        MaSanPham = int.Parse(txt_ma.Text),
                        TenSanPham = txt_Ten.Text,
                        Gia = int.Parse(txt_giaban.Text),
                        SoLuong = int.Parse(txt_SoLuong.Text),
                        //MaLoaiSp = int.Parse(txt_MLSP.Text)

                    };
                    _iSanPhamservice.Add(a);
                    MessageBox.Show("Thêm thành công");

                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_lstSanPham == null)
            {
                MessageBox.Show("Không tìm thấy mã VGA", "Cảnh báo");
            }
            else if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (_lstSanPham.MaSanPham == int.Parse(txt_ma.Text) && _iSanPhamservice.GetAll().FirstOrDefault(c => c.MaSanPham == int.Parse(txt_ma.Text)) != null)
                    {
                        _lstSanPham.MaSanPham = int.Parse(txt_ma.Text);
                        _lstSanPham.TenSanPham = txt_Ten.Text;
                        _lstSanPham.Gia = int.Parse(txt_giaban.Text);
                        _lstSanPham.SoLuong = int.Parse(txt_SoLuong.Text);
                        _iSanPhamservice.Update(_lstSanPham);
                        MessageBox.Show("Sửa thành công");

                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
                }
            }
        }

        private void dgrid_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow r = dgrid_SanPham.Rows[e.RowIndex];
                Guid id;
                if (Guid.TryParse(r.Cells[0].Value?.ToString(), out id))
                {
                    _lstSanPham = _iSanPhamservice.GetAll().FirstOrDefault(c => c.MaSanPham == int.Parse(id.ToString()));
                }
                txt_ma.Text = r.Cells[0].Value?.ToString();
                txt_Ten.Text = r.Cells[1].Value?.ToString();
                txt_giaban.Text = r.Cells[2].Value?.ToString();
                txt_SoLuong.Text = r.Cells[3].Value?.ToString();
                txt_MLSP.Text = r.Cells[4].Value?.ToString();

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_lstSanPham == null)
                {
                    MessageBox.Show("Không tìm thấy");
                }
                else
                {
                    _iSanPhamservice.Delete(_lstSanPham);
                    MessageBox.Show("Xóa thành công");
               
                }
            }
        }
    }
}
