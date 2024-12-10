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
    public partial class MauUserControl : UserControl
    {
        private IMauService _service;
        private MauSac _lstMau;
        public MauUserControl()
        {
            InitializeComponent();
            _service = new Mauservice();
            _lstMau = new MauSac();
            LoadDataFormDb();
        }

       
        public void LoadDataFormDb()
        {
            dgv_Mau.ColumnCount = 2;
            dgv_Mau.Columns[0].Name = "Mã";
            dgv_Mau.Columns[1].Name = "Tên";
            dgv_Mau.Rows.Clear();
            foreach (var x in _service.GetAll())
            {
                dgv_Mau.Rows.Add(x.MaMauSac, x.TenMauSac);
            }
            dgv_Mau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void Reset()
        {
            this.panel1.Controls.Clear();
            MauUserControl frm_sanPham = new MauUserControl() { Dock = DockStyle.Fill };
            this.panel1.Controls.Add(frm_sanPham);
            frm_sanPham.Show();
        }
        public bool checknhap()
        {
            if (txt_Ten.Text == "") return false;
            return true;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            var maMau = int.Parse(txt_Ma.Text);
            var p = _service.GetAll().FirstOrDefault(x => x.MaMauSac == maMau);
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
                    var a = new MauSac()
                    {
                        MaMauSac = int.Parse(txt_Ma.Text),
                        TenMauSac = txt_Ten.Text

                    };
                    _service.Add(a);
                    MessageBox.Show("Thêm thành công");
                    Reset();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_lstMau == null)
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
                    int maMau = int.Parse(txt_Ma.Text);
                    var mauSac = _service.GetAll().FirstOrDefault(c => c.MaMauSac == maMau);

                    if (mauSac == null)
                    {
                        MessageBox.Show("Không tìm thấy loại sản phẩm có mã này", "Lỗi");
                        return;
                    }

                    // Cập nhật thông tin loại sản phẩm
                    mauSac.TenMauSac = txt_Ten.Text;
                    _service.Update(mauSac);
                    MessageBox.Show("Sửa thành công");
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi");
                }
            }
        }

        private void dgv_Mau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow r = dgv_Mau.Rows[e.RowIndex];
                Guid id;
                if (Guid.TryParse(r.Cells[0].Value?.ToString(), out id))
                {
                    _lstMau = _service.GetAll().FirstOrDefault(c => c.MaMauSac == int.Parse(id.ToString()));
                }
                txt_Ma.Text = r.Cells[0].Value?.ToString();
                txt_Ten.Text = r.Cells[1].Value?.ToString();


            }
        }
    }
}
