using BUS.IServices;
using BUS.Services;
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

namespace GUI.Views
{
    public partial class NhanVienUserControl : UserControl
    {
        private INhanVienService _INhanVienServices;
        private NhanVien _nv;
        private Guid _id;
        public NhanVienUserControl()
        {
            InitializeComponent();
            _INhanVienServices = new NhanVienService();
            loadData();
        }
        public void loadData()
        {

            dgv_NhanVien.Rows.Clear();
            dgv_NhanVien.ColumnCount = 8;
            dgv_NhanVien.Columns[0].Name = "MaNhanVien";
            dgv_NhanVien.Columns[1].Name = "TenNhanVien";
            dgv_NhanVien.Columns[2].Name = "SDT";
            dgv_NhanVien.Columns[3].Name = "DiaChi";
            dgv_NhanVien.Columns[4].Name = "Email";
            dgv_NhanVien.Columns[5].Name = "NgaySinh";
            dgv_NhanVien.Columns[6].Name = "Gioitinh";
            dgv_NhanVien.Columns[7].Name = "ChucVu";

            dgv_NhanVien.Rows.Clear();
            foreach (var item in _INhanVienServices.GetAll())
            {
                dgv_NhanVien.Rows.Add(item.MaNhanVien, item.TenNhanVien, item.Sdt, item.DiaChi, item.Email, item.NgaySinh, item.GioiTinh == 1 ? "Nam" : "Nữ", item.ChucVu);
            }
            dgv_NhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_NhanVien.DefaultCellStyle.ForeColor = Color.Black;

        }

        public bool checknhap()
        {
            if (txt_Ma.Text == "" || txt_Ten.Text == "" || txt_SDT.Text == "" /*|| txt_user.Text == "" */|| txt_DiaChi.Text == "" || txt_Email.Text == "" || dtp_Date.Text == "") return false;
            return true;
        }

        public void reset()
        {
            loadData();
            txt_Ma.Text = "";
            txt_Ten.Text = "";
            txt_Email.Text = "";
            txt_SDT.Text = "";
            txt_DiaChi.Text = "";
            txt_ChucVu.Text = "";
            Nam_rb.Checked = false;
            Nu_rb.Checked = false;

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            int maSanPhamCanTim = int.Parse(txt_Ma.Text);
            var p = _INhanVienServices.GetAll().FirstOrDefault(x => x.MaNhanVien == maSanPhamCanTim);

            // Kiểm tra dữ liệu nhập vào
            if (!checknhap()) // Giả sử checknhap() trả về true nếu dữ liệu hợp lệ
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            if (p != null)
            {
                MessageBox.Show("Nhân viên đã tồn tại", "Thông báo");
                return;
            }

            // Xác nhận thêm sản phẩm
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // Tạo đối tượng sản phẩm mới
                    var a = new NhanVien()
                    {
                        MaNhanVien = int.Parse(txt_Ma.Text),
                        TenNhanVien = txt_Ten.Text,
                        GioiTinh = Nam_rb.Checked == true ? 1 : 0,
                        NgaySinh = dtp_Date.Value,
                        Sdt = int.Parse(txt_SDT.Text),
                        DiaChi = txt_DiaChi.Text,
                        ChucVu = txt_ChucVu.Text,
                    };

                    // Thêm sản phẩm vào cơ sở dữ liệu
                    _INhanVienServices.Add(a);
                    MessageBox.Show("Nhân viên thành công");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi");
                }
            }

        }

        private void dgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_nv == null)
                {
                    MessageBox.Show("Không tìm thấy");
                }
                else
                {
                    _INhanVienServices.Delete(_nv);
                    MessageBox.Show("Xóa thành công");
                    reset();
                }
            }
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow r = dgv_NhanVien.Rows[e.RowIndex];
                Guid id;
                if (Guid.TryParse(r.Cells[0].Value?.ToString(), out id))
                {
                    _nv = _INhanVienServices.GetAll().FirstOrDefault(c => c.MaNhanVien == int.Parse(id.ToString()));
                }
                txt_Ma.Text = r.Cells[0].Value?.ToString();
                txt_Ten.Text = r.Cells[1].Value?.ToString();
                txt_SDT.Text = r.Cells[2].Value?.ToString();
                txt_DiaChi.Text = r.Cells[3].Value?.ToString();
                txt_Email.Text = r.Cells[4].Value?.ToString();
                if (DateTime.TryParse(r.Cells[4].Value?.ToString(), out DateTime ngaySinh))
                {
                    dtp_Date.Value = ngaySinh;
                }
                else
                {
                    // Xử lý trường hợp chuyển đổi thất bại
                    MessageBox.Show("Giá trị ngày không hợp lệ.", "Lỗi");
                    // Hoặc bạn có thể đặt giá trị mặc định cho dtp_Date
                    dtp_Date.Value = DateTime.Today;
                }
                Nam_rb.Checked = r.Cells[6].Value.ToString() == "Nam";
                Nu_rb.Checked = r.Cells[6].Value.ToString() == "Nữ";
                txt_ChucVu.Text = r.Cells[7].Value?.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Ma.Text))
            {
                MessageBox.Show("Không tìm thấy mã VGA", "Cảnh báo");
                return;
            }
            else if (!checknhap()) // Giả sử hàm checknhap() kiểm tra các trường bắt buộc
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
                return;
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo);
                if (dialog != DialogResult.Yes)
                {
                    return;
                }

                try
                {
                    int maSanPham = int.Parse(txt_Ma.Text);
                    var nhanvien = _INhanVienServices.GetAll().FirstOrDefault(c => c.MaNhanVien == maSanPham);

                    if (nhanvien == null)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên có mã này", "Lỗi");
                        return;
                    }

                    // Cập nhật thông tin nhân viên
                    nhanvien.MaNhanVien = int.Parse(txt_Ma.Text);
                    nhanvien.TenNhanVien = txt_Ten.Text;
                    nhanvien.Email = txt_Email.Text;
                    nhanvien.Sdt = int.Parse(txt_SDT.Text);
                    nhanvien.DiaChi = txt_DiaChi.Text;
                    nhanvien.NgaySinh = dtp_Date.Value;
                    nhanvien.ChucVu = txt_ChucVu.Text;
                    nhanvien.GioiTinh = Nam_rb.Checked ? 1 : 0;

                    _INhanVienServices.Update(nhanvien);
                    MessageBox.Show("Sửa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi");
                }
            }
        }
    }
}
