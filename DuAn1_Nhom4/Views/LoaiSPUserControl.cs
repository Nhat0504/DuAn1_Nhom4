using BUS.IServices;
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
using DAL.Models;
using BUS.Services;

namespace GUI.Views
{
    public partial class LoaiSPUserControl : UserControl
    {
        private ILoaiSPService _service;
        private LoaiSanPham _lstLoaiSp;
        public LoaiSPUserControl()
        {
            InitializeComponent();
            _service = new LoaiSPService();
            _lstLoaiSp = new LoaiSanPham();
            LoadDataFormDb();
        }

        private void btn_SP_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            SanPhamUserControl frm_sanPham = new SanPhamUserControl() { Dock = DockStyle.Fill };
            this.panel2.Controls.Add(frm_sanPham);
            frm_sanPham.Show();
        }
        public void LoadDataFormDb()
        {
            dgv_LoaiSP.ColumnCount = 2;
            dgv_LoaiSP.Columns[0].Name = "Mã";
            dgv_LoaiSP.Columns[1].Name = "Tên";
            dgv_LoaiSP.Rows.Clear();
            foreach (var x in _service.GetAll())
            {
                dgv_LoaiSP.Rows.Add(x.MaLoaiSp, x.TenLoaiSp);
            }
            dgv_LoaiSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void Reset()
        {
            this.panel2.Controls.Clear();
            LoaiSPUserControl frm_sanPham = new LoaiSPUserControl() { Dock = DockStyle.Fill };
            this.panel2.Controls.Add(frm_sanPham);
            frm_sanPham.Show();
        }
        public bool checknhap()
        {
            if (txt_TenLoai.Text == "") return false;
            return true;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            var maLoaiSP = int.Parse(txt_Ma.Text);
            var p = _service.GetAll().FirstOrDefault(x => x.MaLoaiSp == maLoaiSP);
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
                    var a = new LoaiSanPham()
                    {
                        MaLoaiSp = int.Parse(txt_Ma.Text),
                        TenLoaiSp = txt_TenLoai.Text

                    };
                    _service.Add(a);
                    MessageBox.Show("Thêm thành công");
                    Reset();
                }
            }
        }

        private void LoaiSPUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (_lstLoaiSp == null)
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
                    int maLoaiSp = int.Parse(txt_Ma.Text);
                    var loaiSp = _service.GetAll().FirstOrDefault(c => c.MaLoaiSp == maLoaiSp);

                    if (loaiSp == null)
                    {
                        MessageBox.Show("Không tìm thấy loại sản phẩm có mã này", "Lỗi");
                        return;
                    }

                    // Cập nhật thông tin loại sản phẩm
                    loaiSp.TenLoaiSp = txt_TenLoai.Text;
                    _service.Update(loaiSp);
                    MessageBox.Show("Sửa thành công");
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi");
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_lstLoaiSp == null)
                {
                    MessageBox.Show("Không tìm thấy");
                }
                else
                {
                    _service.Delete(_lstLoaiSp);
                    MessageBox.Show("Xóa thành công");
                    Reset();
                }
            }
        }

        private void dgv_LoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow r = dgv_LoaiSP.Rows[e.RowIndex];
                Guid id;
                if (Guid.TryParse(r.Cells[0].Value?.ToString(), out id))
                {
                    _lstLoaiSp = _service.GetAll().FirstOrDefault(c => c.MaLoaiSp == int.Parse(id.ToString()));
                }
                txt_Ma.Text = r.Cells[0].Value?.ToString();
                txt_TenLoai.Text = r.Cells[1].Value?.ToString();
               

            }
        }
       
    }
}
