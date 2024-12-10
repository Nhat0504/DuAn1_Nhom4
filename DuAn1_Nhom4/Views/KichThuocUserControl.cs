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
    public partial class KichThuocUserControl : UserControl
    {
        private ISizeService _service;
        private KichThuoc _lstKichThuoc;
        public KichThuocUserControl()
        {
            InitializeComponent();
            _service = new SizeService();
            _lstKichThuoc = new KichThuoc();
            LoadDataFormDb();
        }


        public void LoadDataFormDb()
        {
            dgv_KichThuoc.ColumnCount = 2;
            dgv_KichThuoc.Columns[0].Name = "Mã";
            dgv_KichThuoc.Columns[1].Name = "Tên";
            dgv_KichThuoc.Rows.Clear();
            foreach (var x in _service.GetAll())
            {
                dgv_KichThuoc.Rows.Add(x.MaKichThuoc, x.TenKichThuoc);
            }
            dgv_KichThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void Reset()
        {
            this.panel1.Controls.Clear();
            KichThuocUserControl frm_sanPham = new KichThuocUserControl() { Dock = DockStyle.Fill };
            this.panel1.Controls.Add(frm_sanPham);
            frm_sanPham.Show();
        }
        public bool checknhap()
        {
            if (txt_KichThuoc.Text == "") return false;
            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var maKT = int.Parse(txt_Ma.Text);
            var p = _service.GetAll().FirstOrDefault(x => x.MaKichThuoc == maKT);
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
                    var a = new KichThuoc()
                    {
                        MaKichThuoc = int.Parse(txt_Ma.Text),
                        TenKichThuoc = txt_KichThuoc.Text

                    };
                    _service.Add(a);
                    MessageBox.Show("Thêm thành công");
                    Reset();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_lstKichThuoc == null)
            {
                MessageBox.Show("Không tìm thấy mã ", "Cảnh báo");
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
                    int maKichThuoc = int.Parse(txt_Ma.Text);
                    var kichThuoc = _service.GetAll().FirstOrDefault(c => c.MaKichThuoc == maKichThuoc);

                    if (kichThuoc == null)
                    {
                        MessageBox.Show("Không tìm thấy loại sản phẩm có mã này", "Lỗi");
                        return;
                    }

                    // Cập nhật thông tin loại sản phẩm
                    kichThuoc.TenKichThuoc = txt_KichThuoc.Text;
                    _service.Update(kichThuoc);
                    MessageBox.Show("Sửa thành công");
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi");
                }
            }
        }

        private void dgv_KichThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow r = dgv_KichThuoc.Rows[e.RowIndex];
                Guid id;
                if (Guid.TryParse(r.Cells[0].Value?.ToString(), out id))
                {
                    _lstKichThuoc = _service.GetAll().FirstOrDefault(c => c.MaKichThuoc == int.Parse(id.ToString()));
                }
                txt_Ma.Text = r.Cells[0].Value?.ToString();
                txt_KichThuoc.Text = r.Cells[1].Value?.ToString();
            }
        }
    }
}
