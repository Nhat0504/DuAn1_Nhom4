using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel;

namespace GUI.Views
{
    public partial class BanHangUserControl : UserControl
    {

        private BindingList<SanPham> gioHang = new BindingList<SanPham>();

        public BanHangUserControl()
        {
            InitializeComponent();
            LoadSanPhamList();
            LoadDanhSachKhachHang();


        }

        void LoadSanPhamList()
        {
            string connectionSTR = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string query = "SELECT MaSanPham as [Mã Sản Phẩm], TenSanPham as [Tên Sản Phẩm], Gia as [Giá], SoLuong as [Tồn Kho] FROM dbo.SanPham";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            connection.Close();

           
            if (!dataGridView2.Columns.Contains("Chọn Sản Phẩm"))
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "Chọn Sản Phẩm";  // Đảm bảo tên cột đúng
                btnColumn.HeaderText = "Chọn Sản Phẩm";
                btnColumn.Text = "Chọn";
                btnColumn.UseColumnTextForButtonValue = true;
                dataGridView2.Columns.Add(btnColumn);
            }

           
            dataGridView2.DataSource = dataTable;
            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.Columns["Giá"].DefaultCellStyle.Format = "#,##0 VNĐ";
           
            dataGridView2.CellContentClick += DataGridView2_CellContentClick;
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra cột "Chọn Sản Phẩm" có tồn tại và là cột bấm
            if (e.ColumnIndex == dataGridView2.Columns["Chọn Sản Phẩm"]?.Index && e.RowIndex >= 0)
            {
              
                var maSanPhamCell = dataGridView2.Rows[e.RowIndex].Cells["Mã Sản Phẩm"];
                var tenSanPhamCell = dataGridView2.Rows[e.RowIndex].Cells["Tên Sản Phẩm"];
                var giaCell = dataGridView2.Rows[e.RowIndex].Cells["Giá"];
                var soLuongCell = dataGridView2.Rows[e.RowIndex].Cells["Tồn Kho"];

                if (maSanPhamCell.Value != null &&
                    tenSanPhamCell.Value != null &&
                    giaCell.Value != null &&
                    soLuongCell.Value != null)
                {
                    int maSanPham = Convert.ToInt32(maSanPhamCell.Value);
                    string tenSanPham = tenSanPhamCell.Value.ToString();
                    decimal gia = Convert.ToDecimal(giaCell.Value);
                    int soLuong = Convert.ToInt32(soLuongCell.Value);

                    
                    using (InputQuantityForm inputForm = new InputQuantityForm(soLuong))
                    {
                        if (inputForm.ShowDialog() == DialogResult.OK) // Nếu nhấn OK
                        {
                            int soluongChon = inputForm.SoLuong;

                            if (soluongChon <= soLuong)
                            {
                                
                                SanPham sanPhamChon = new SanPham
                                {
                                    MaSanPham = maSanPham,
                                    TenSanPham = tenSanPham,
                                    Gia = gia,
                                    SoLuong = soluongChon
                                };

                                gioHang.Add(sanPhamChon);

                                // Cập nhật giỏ hàng
                                UpdateGioHang();
                                MessageBox.Show($"Đã thêm {soluongChon} {tenSanPham} vào giỏ hàng.");
                            }
                            else
                            {
                                MessageBox.Show("Số lượng không hợp lệ.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu sản phẩm không hợp lệ. Vui lòng kiểm tra lại.");
                }
            }
        }





        // Cập nhật DataGridView giỏ hàng
        private void UpdateGioHang()
        {
            DataTable dtGioHang = new DataTable();
            dtGioHang.Columns.Add("Mã Sản Phẩm");
            dtGioHang.Columns.Add("Tên Sản Phẩm");
            dtGioHang.Columns.Add("Số Lượng", typeof(int));
            dtGioHang.Columns.Add("Tổng Tiền (VNĐ)", typeof(decimal));

            foreach (var sp in gioHang)
            {
                dtGioHang.Rows.Add(sp.MaSanPham, sp.TenSanPham, sp.SoLuong, sp.Gia * sp.SoLuong);
            }
            dataGridView1.DataSource = dtGioHang;
            if (dataGridView1.Columns.Contains("Tổng Tiền (VNĐ)"))
            {
                dataGridView1.Columns["Tổng Tiền (VNĐ)"].DefaultCellStyle.Format = "#,##0 VNĐ";
            }

            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;


        }

        private void LoadDanhSachKhachHang()
        {
            string connectionSTR = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string query = "SELECT TenKhachHang FROM dbo.KhachHang";

            try
            {
                // Mở kết nối
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                // Đọc dữ liệu từ cơ sở dữ liệu vào DataTable
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                // Đóng kết nối
                connection.Close();

                // Kiểm tra dữ liệu đã nạp vào DataTable chưa
                if (dataTable.Rows.Count > 0)
                {
                    // Gán DataTable vào ComboBox
                    comboBoxKhachHang.DisplayMember = "TenKhachHang";  // Hiển thị tên khách hàng trong ComboBox
                    comboBoxKhachHang.DataSource = dataTable;  // Gán nguồn dữ liệu cho ComboBox
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu khách hàng.");
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private bool KiemTraMaNhanVienHopLe(string maNhanVien)
        {
            string connectionSTR = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string query = "SELECT COUNT(*) FROM dbo.NhanVien WHERE MaNhanVien = @MaNhanVien";

            try
            {
                // Mở kết nối
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                // Thêm tham số để bảo vệ câu lệnh SQL khỏi SQL Injection
                command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);

                // Kiểm tra xem có nhân viên nào có mã này không
                int count = (int)command.ExecuteScalar();

                // Đóng kết nối
                connection.Close();

                // Nếu count > 0 thì mã nhân viên hợp lệ, ngược lại không hợp lệ
                return count > 0;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }

        private void txtMaNhanVien_Leave(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNhanVien.Text.Trim();  

            if (!string.IsNullOrEmpty(maNhanVien))  
            {
                bool isValid = KiemTraMaNhanVienHopLe(maNhanVien);  
                if (!isValid)
                {
                    MessageBox.Show("Mã nhân viên không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaNhanVien.Focus();  
                }
            }
            else
            {
                MessageBox.Show("Mã nhân viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void TaoHoaDon()
        {
            // Kiểm tra dữ liệu hợp lệ
            string maNhanVien = txtMaNhanVien.Text.Trim();
            string tenKhachHang = comboBoxKhachHang.Text.Trim();

            if (string.IsNullOrEmpty(maNhanVien) || string.IsNullOrEmpty(tenKhachHang))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên và chọn khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            DateTime ngayTao = dateTimePicker1.Value;

            
            int maKhachHang = GetMaKhachHang(tenKhachHang);

            // Kiểm tra nếu không tìm thấy khách hàng
            if (maKhachHang == -1)
            {
                MessageBox.Show("Khách hàng không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            int maHoaDonMoi = GetNewMaHoaDon();  
            string maHoaDon = maHoaDonMoi.ToString();  

            
            decimal tongTien = GetTotalFromCart(); 

          
            string connectionSTR = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string query = "INSERT INTO HoaDon (MaHoaDon, MaNhanVien, MaKhachHang, NgayTaoHoaDon, TrangThai, TongTien) " +
                           "VALUES (@MaHoaDon, @MaNhanVien, @MaKhachHang, @NgayTaoHoaDon, 'Chưa thanh toán', @TongTien)";

            try
            {
                // Mở kết nối
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                // Thêm tham số vào câu truy vấn
                command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                command.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                command.Parameters.AddWithValue("@NgayTaoHoaDon", ngayTao);
                command.Parameters.AddWithValue("@TongTien", tongTien);

                // Thực thi câu truy vấn
                command.ExecuteNonQuery();

                // Đóng kết nối
                connection.Close();

                // Cập nhật lại DataGridView
                LoadHoaDonData();
                MessageBox.Show("Hóa đơn đã được tạo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetNewMaHoaDon()
        {
            int newMaHoaDon = 1;

            // Kết nối đến cơ sở dữ liệu để lấy mã hóa đơn lớn nhất
            string connectionSTR = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string query = "SELECT MAX(CAST(MaHoaDon AS INT)) FROM HoaDon WHERE ISNUMERIC(MaHoaDon) = 1";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    // Lấy mã hóa đơn lớn nhất và cộng thêm 1
                    newMaHoaDon = Convert.ToInt32(result) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy mã hóa đơn mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return newMaHoaDon;
        }



        private decimal GetTotalFromCart()
        {
            decimal tongTien = 0;

            // Duyệt qua các dòng trong DataGridView giỏ hàng để tính tổng tiền
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["DonGia"].Value != null && row.Cells["SoLuong"].Value != null)
                {
                    decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    tongTien += donGia * soLuong;
                }
            }

            return tongTien;
        }

        private int GetMaKhachHang(string tenKhachHang)
        {
            // Truy vấn để lấy MaKhachHang từ bảng KhachHang theo TenKhachHang
            int maKhachHang = -1; // -1 là giá trị trả về khi không tìm thấy khách hàng
            string query = "SELECT MaKhachHang FROM KhachHang WHERE TenKhachHang = @TenKhachHang";

            string connectionSTR = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);

                // Thực thi truy vấn và lấy kết quả
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    maKhachHang = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy Mã Khách Hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return maKhachHang;
        }

        private void LoadHoaDonData()
        {
            string connectionSTR = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);

            // Truy vấn SQL để lấy thông tin bao gồm Tên khách hàng
            string query = "SELECT HoaDon.MaHoaDon, HoaDon.MaNhanVien, KhachHang.TenKhachHang, HoaDon.NgayTaoHoaDon, HoaDon.TrangThai, HoaDon.TongTien " +
                           "FROM HoaDon " +
                           "INNER JOIN KhachHang ON HoaDon.MaKhachHang = KhachHang.MaKhachHang";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                // Đọc dữ liệu từ cơ sở dữ liệu vào DataTable
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                connection.Close();

                // Gán DataTable vào DataGridView
                dataGridView3.DataSource = dataTable;
                dataGridView3.DefaultCellStyle.ForeColor = Color.Black;

                // Định dạng cột NgàyTao
                dataGridView3.Columns["NgayTaoHoaDon"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaoHoaDon();
        }

    }

}

    
    public class SanPham
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
    }





