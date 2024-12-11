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
    public partial class KhachHangUserControl : UserControl
    {
        private IKhachHangService _ikhachHangService;
        private KhachHang _KH;
        public KhachHangUserControl()
        {
            InitializeComponent();
            _ikhachHangService = new KhachHangService();
            loadData();
        }
        public void loadData()
        {

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Ma Khach Hang";
            dataGridView1.Columns[1].Name = "Ten Khach Hang";
            dataGridView1.Columns[2].Name = "Dia chi";
            dataGridView1.Columns[3].Name = "SDT";
            dataGridView1.Columns[4].Name = "Email";
            dataGridView1.Columns[5].Name = "Gioi Tinh";
            dataGridView1.Columns[6].Name = "Ngay sinh";


            dataGridView1.Rows.Clear();
            foreach (var item in _ikhachHangService.GetAll())
            {
                dataGridView1.Rows.Add(item.MaKhachHang, item.TenKhachHang, item.DiaChi, item.Sdt, item.Email, item.GioiTinh == 1 ? "Nam" : "Nữ", item.NgaySinh);
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

        }
        public bool checknhap()
        {
            if (textBox5.Text == "" || txt_Ten.Text == "" || textBox1.Text == "" /*|| txt_user.Text == "" */|| textBox2.Text == "" || textBox3.Text == "" || dateTimePicker1.Text == "") return false;
            return true;
        }
        public void reset()
        {
            loadData();
            textBox5.Text = "";
            txt_Ten.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Text = "";
            Nam_rb.Checked = false;
            Nu_rb.Checked = false;

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int khachhangcantim = int.Parse(textBox5.Text);
            var p = _ikhachHangService.GetAll().FirstOrDefault(x => x.MaKhachHang == khachhangcantim);

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
                    var a = new KhachHang()
                    {
                        MaKhachHang = int.Parse(textBox5.Text),
                        TenKhachHang = txt_Ten.Text,
                        GioiTinh = Nam_rb.Checked == true ? 1 : 0,
                        NgaySinh = dateTimePicker1.Value,
                        Sdt = int.Parse(textBox1.Text),
                        DiaChi = textBox2.Text,
                        Email = textBox3.Text,
                    };

                    // Thêm sản phẩm vào cơ sở dữ liệu
                    _ikhachHangService.Add(a);
                    MessageBox.Show("Nhân viên thành công");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (_KH == null)
            //{
            //    MessageBox.Show("Không tìm thấy mã VGA", "Cảnh báo");
            //}
            //else if (!checknhap())
            //{
            //    MessageBox.Show("Không được để trống các trường", "Chú ý");
            //}
            //else
            //{
            //    OpenFileDialog op = new OpenFileDialog();
            //    DialogResult dialog = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo);
            //    if (dialog != DialogResult.Yes)
            //    {
            //        return;
            //    }

            //    try
            //    {
            //        int maKH = int.Parse(textBox5.Text);
            //        var khachhang = _ikhachHangService.GetAll().FirstOrDefault(c => c.MaKhachHang == maKH);
            //        if (khachhang == null)
            //        {
            //            MessageBox.Show("Không tìm thấy nhân viên có mã này", "Lỗi");
            //            return;
            //        }

            //        // Cập nhật thông tin sản phẩm
            //        khachhang.MaKhachHang = int.Parse(textBox5.Text);
            //        khachhang.TenKhachHang = txt_Ten.Text;
            //        khachhang.Email = textBox3.Text;
            //        khachhang.Sdt = int.Parse(textBox1.Text);
            //        khachhang.DiaChi = textBox2.Text;
            //        khachhang.NgaySinh = dateTimePicker1.Value;
            //        khachhang.GioiTinh = Nam_rb.Checked ? 1 : 0;

            //        _ikhachHangService.Update(khachhang);

            //        MessageBox.Show("Sửa thành công");

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi");
            //    }

            //}
            if (string.IsNullOrEmpty(textBox5.Text))
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
                    int maSanPham = int.Parse(textBox5.Text);
                    var khachhang = _ikhachHangService.GetAll().FirstOrDefault(c => c.MaKhachHang == maSanPham);

                    if (khachhang == null)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên có mã này", "Lỗi");
                        return;
                    }

                    // Cập nhật thông tin nhân viên
                    khachhang.MaKhachHang = int.Parse(textBox5.Text);
                    khachhang.TenKhachHang = txt_Ten.Text;
                    khachhang.Email = textBox3.Text;
                    khachhang.Sdt = int.Parse(textBox1.Text);
                    khachhang.DiaChi = textBox2.Text;
                    khachhang.NgaySinh = dateTimePicker1.Value;
                    khachhang.GioiTinh = Nam_rb.Checked ? 1 : 0;

                    _ikhachHangService.Update(khachhang);
                    MessageBox.Show("Sửa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_KH == null)
                {
                    MessageBox.Show("Không tìm thấy");
                }
                else
                {
                    _ikhachHangService.Delete(_KH);
                    MessageBox.Show("Xóa thành công");
                    reset();
                }
            }
        }
    }
}
