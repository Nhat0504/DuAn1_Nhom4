using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel;
using BUS;
using DAL;
using System.Text.RegularExpressions;
using DTO;

namespace GUI.Views
{
    public partial class BanHangUserControl : UserControl
    {
        public BanHangUserControl()
        {
            InitializeComponent();
            LoadData();
            InitializeDataGridView();
            
        }

        private void LoadData()
        {
            
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM SanPham";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }

           
            cboHoaDon.Items.Clear();
            dtgvHoaDonCho.Rows.Clear();
        }

        private void txtSoDienThoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string soDienThoai = txtSoDienThoai.Text.Trim();

                // Kiểm tra số điện thoại hợp lệ
                if (!IsValidPhoneNumber(soDienThoai))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.");
                    txtSoDienThoai.Focus();
                    return;
                }

                // Gọi hàm tìm tên khách hàng theo số điện thoại
                if (GetCustomerNameByPhone(soDienThoai))
                {
                    MessageBox.Show("Tìm thấy khách hàng!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng với số điện thoại này.");
                    txtTenKhachHang.Text = string.Empty; // Xóa thông tin tên khách hàng nếu không tìm thấy
                }
            }
        }



        private bool IsValidPhoneNumber(string phoneNumber)
        {
           
            var regex = new System.Text.RegularExpressions.Regex(@"^0\d{9}$");
            return regex.IsMatch(phoneNumber);
        }


        private bool GetCustomerNameByPhone(string phoneNumber)
        {
            try
            {
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Sử dụng đúng tên cột (không có khoảng trắng)
                    string query = "SELECT TenKhachHang FROM KhachHang WHERE SDT = @SDT";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SDT", phoneNumber);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtTenKhachHang.Text = reader["TenKhachHang"].ToString(); // Điền tên khách hàng
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kết nối cơ sở dữ liệu: {ex.Message}");
                return false;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txtTenKhachHang.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();

            if (string.IsNullOrEmpty(tenKhachHang) || string.IsNullOrEmpty(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên khách hàng và số điện thoại.");
                return;
            }

            if (!IsValidPhoneNumber(soDienThoai))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.");
                txtSoDienThoai.Focus();
                return;
            }

            Random random = new Random();
            int maHoaDonInt = random.Next(1, 1000);
            string maHoaDon = maHoaDonInt.ToString("D3");

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO HoaDon (MaHoaDon, NgayTaoHoaDon, TongTien) VALUES (@MaHoaDon, @NgayTaoHoaDon, @TongTien)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDonInt);
                        cmd.Parameters.AddWithValue("@NgayTaoHoaDon", DateTime.Now);
                        cmd.Parameters.AddWithValue("@TongTien", 0); // Gán giá trị 0 cho TongTien

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            cboHoaDon.Items.Add(maHoaDon);
                            cboHoaDon.SelectedItem = maHoaDon;
                            MessageBox.Show($"Tạo hóa đơn thành công! Mã hóa đơn: {maHoaDon}");
                        }
                        else
                        {
                            MessageBox.Show("Không thể tạo hóa đơn. Vui lòng thử lại.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo hóa đơn: {ex.Message}");
            }
        }





        private void InitializeDataGridView()
        {
            // Xóa cấu hình cột cũ
            dtgvHoaDonCho.Columns.Clear();

            // Thêm các cột mới
            dtgvHoaDonCho.Columns.Add("MaSanPham", "Mã Sản Phẩm");
            dtgvHoaDonCho.Columns.Add("MaHoaDon", "Mã Hóa Đơn");
            dtgvHoaDonCho.Columns.Add("DonGiaSanPham", "Đơn Giá"); // Đơn Giá cho 1 sản phẩm
            dtgvHoaDonCho.Columns.Add("SoLuong", "Số Lượng");
            dtgvHoaDonCho.Columns.Add("ThanhTien", "Thành Tiền"); // Đổi tên từ DonGia sang Thành Tiền

            // Định dạng hiển thị số lượng, đơn giá và thành tiền
            dtgvHoaDonCho.Columns["DonGiaSanPham"].DefaultCellStyle.Format = "N0";
            dtgvHoaDonCho.Columns["SoLuong"].DefaultCellStyle.Format = "N0";
            dtgvHoaDonCho.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";

            // Cài đặt chế độ đọc và kích thước cột
            foreach (DataGridViewColumn col in dtgvHoaDonCho.Columns)
            {
                col.ReadOnly = true; // Không cho phép chỉnh sửa
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                
                string maSanPham = dataGridView2.Rows[e.RowIndex].Cells["MaSanPham"].Value.ToString();
                int maxSoLuong = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString());
                decimal gia = decimal.Parse(dataGridView2.Rows[e.RowIndex].Cells["Gia"].Value.ToString());

                
                using (var form = new InputQuantityForm(maxSoLuong))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        
                        int soLuong = form.SoLuong;

                       
                        AddRowToHoaDonCho(maSanPham, gia, soLuong);
                    }
                }
            }
        }


        private void AddRowToHoaDonCho(string maSanPham, decimal gia, int soLuong)
        {
            if (cboHoaDon.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn.");
                return;
            }

            string maHoaDon = cboHoaDon.SelectedItem.ToString();

            bool isProductExists = false;

            foreach (DataGridViewRow row in dtgvHoaDonCho.Rows)
            {
                if (row.Cells["MaSanPham"].Value?.ToString() == maSanPham &&
                    row.Cells["MaHoaDon"].Value?.ToString() == maHoaDon)
                {
                    int currentQuantity = int.Parse(row.Cells["SoLuong"].Value.ToString());
                    row.Cells["SoLuong"].Value = currentQuantity + soLuong;
                    row.Cells["ThanhTien"].Value = (currentQuantity + soLuong) * gia;

                    isProductExists = true;
                    break;
                }
            }

            if (!isProductExists)
            {
                decimal thanhTien = gia * soLuong;
                dtgvHoaDonCho.Rows.Add(maSanPham, maHoaDon, gia, soLuong, thanhTien);
            }

            // Cập nhật số lượng sản phẩm trong cơ sở dữ liệu và giao diện
            UpdateProductQuantity(maSanPham, soLuong);
        }

        private void UpdateProductQuantity(string maSanPham, int soLuongTru)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Trừ số lượng sản phẩm trong cơ sở dữ liệu
                    string updateQuery = "UPDATE SanPham SET SoLuong = SoLuong - @SoLuong WHERE MaSanPham = @MaSanPham AND SoLuong >= @SoLuong";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@SoLuong", soLuongTru);
                        cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Nếu thành công, cập nhật lại giao diện
                            UpdateGridView(maSanPham, soLuongTru);
                        }
                        else
                        {
                            MessageBox.Show("Không đủ số lượng sản phẩm để thêm vào hóa đơn.");
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Lỗi khi cập nhật số lượng sản phẩm: {ex.Message}");
                }
            }
        }

        private void UpdateGridView(string maSanPham, int soLuongTru)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["MaSanPham"].Value?.ToString() == maSanPham)
                {
                    int currentQuantity = int.Parse(row.Cells["SoLuong"].Value.ToString());
                    row.Cells["SoLuong"].Value = currentQuantity - soLuongTru;

                    if (currentQuantity - soLuongTru <= 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red; // Hiển thị sản phẩm đã hết hàng
                    }

                    break;
                }
            }
        }






        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  
            {
                string searchQuery = txtSearch.Text.ToLower(); 

               
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataGridView2.DataSource;

               
                bindingSource.Filter = $"TenSanPham LIKE '%{searchQuery}%'";

               
                dataGridView2.DataSource = bindingSource;
            }
        }

        private void dtgvHoaDonCho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy mã hóa đơn từ dòng được chọn
                string maHoaDon = dtgvHoaDonCho.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();

                // Hiển thị tổng tiền cho mã hóa đơn được chọn
                HienThiTongTien(maHoaDon);
            }
        }

        private void HienThiTongTien(string maHoaDon)
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dtgvHoaDonCho.Rows)
            {
                // Lọc các dòng có mã hóa đơn trùng khớp
                if (row.Cells["MaHoaDon"].Value?.ToString() == maHoaDon)
                {
                    decimal thanhTien = decimal.Parse(row.Cells["ThanhTien"].Value.ToString());
                    tongTien += thanhTien;
                }
            }

            // Hiển thị tổng tiền lên label9
            label9.Text = tongTien.ToString("N0");
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            
            lblTienThua.Text = "0";
        }
        private void txtTienKhachDua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (decimal.TryParse(label9.Text, out decimal tongTien) &&
                    decimal.TryParse(txtTienKhachDua.Text, out decimal tienKhachDua))
                {
                    if (tienKhachDua < tongTien)
                    {
                        MessageBox.Show($"Số tiền khách đưa chưa đủ. Còn thiếu: {tongTien - tienKhachDua:N0}",
                                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblTienThua.Text = "0";
                    }
                    else
                    {
                        lblTienThua.Text = (tienKhachDua - tongTien).ToString("N0");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số tiền hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblTienThua.Text = "0";
                }
            }
        }


        private void cboHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";

            try
            {
                if (cboHoaDon.SelectedItem != null)
                {

                    int selectedMaHoaDon = Convert.ToInt32(cboHoaDon.SelectedItem.ToString());

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = @"
                SELECT k.TenKhachHang, k.SDT
                FROM HoaDon h
                LEFT JOIN KhachHang k ON h.MaKhachHang = k.MaKhachHang
                WHERE h.MaHoaDon = @MaHoaDon";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaHoaDon", selectedMaHoaDon);

                            conn.Open();

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Điền thông tin khách hàng
                                    txtTenKhachHang.Text = reader["TenKhachHang"].ToString();
                                    txtSoDienThoai.Text = reader["SDT"].ToString();
                                }
                                else
                                {
                                    // Không tìm thấy dữ liệu, xóa thông tin cũ
                                   
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hóa đơn.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin khách hàng: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cboHoaDon.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để thanh toán.");
                return;
            }

            // Kiểm tra nếu tiền khách đưa chưa nhập
            if (string.IsNullOrEmpty(txtTienKhachDua.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền khách đưa.");
                return;
            }

            int selectedMaHoaDon = Convert.ToInt32(cboHoaDon.SelectedItem.ToString());
            decimal tongTien = decimal.Parse(label9.Text);
            decimal tienKhachTra = decimal.Parse(txtTienKhachDua.Text);

            if (tienKhachTra >= tongTien)
            {
                try
                {
                    string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE HoaDon SET TrangThai = 'Đã thanh toán' WHERE MaHoaDon = @MaHoaDon";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaHoaDon", selectedMaHoaDon);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Xóa hóa đơn khỏi giao diện
                    RemoveInvoiceFromUI(selectedMaHoaDon);

                    // Reset giao diện
                    ResetUI();

                    MessageBox.Show("Thanh toán thành công!");
                    SaveInvoiceDetailsToDatabase();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thanh toán: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Số tiền khách trả không đủ. Vui lòng kiểm tra lại!");
            }
        }

        private void SaveInvoiceDetailsToDatabase()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dtgvHoaDonCho.Rows)
                    {
                        if (row.IsNewRow) continue; // Bỏ qua hàng mới trống

                        string maHoaDon = row.Cells["MaHoaDon"].Value.ToString();
                        string maSanPham = row.Cells["MaSanPham"].Value.ToString();
                        decimal donGia = decimal.Parse(row.Cells["DonGiaSanPham"].Value.ToString());
                        int soLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());
                        decimal thanhTien = decimal.Parse(row.Cells["ThanhTien"].Value.ToString());

                        string query = @"INSERT INTO ChiTietHoaDon (MaHoaDon, MaSanPham, DonGia, SoLuong, ThanhTien) 
                                 VALUES (@MaHoaDon, @MaSanPham, @DonGia, @SoLuong, @ThanhTien)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                            cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);
                            cmd.Parameters.AddWithValue("@DonGia", donGia);
                            cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmd.Parameters.AddWithValue("@ThanhTien", thanhTien);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Thông tin hóa đơn đã được lưu thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu thông tin hóa đơn: {ex.Message}");
                }
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            if (cboHoaDon.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để hủy.");
                return;
            }

            int selectedMaHoaDon = Convert.ToInt32(cboHoaDon.SelectedItem.ToString());

            try
            {
                // Xóa hóa đơn khỏi giao diện
                RemoveInvoiceFromUI(selectedMaHoaDon);

                // Reset giao diện
                ResetUI();

                MessageBox.Show("Hóa đơn đã được hủy!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hủy hóa đơn: {ex.Message}");
            }
        }

        private void RemoveInvoiceFromUI(int maHoaDon)
        {
            // Xóa khỏi ComboBox
            for (int i = 0; i < cboHoaDon.Items.Count; i++)
            {
                if (Convert.ToInt32(cboHoaDon.Items[i]) == maHoaDon)
                {
                    cboHoaDon.Items.RemoveAt(i);
                    break;
                }
            }

            // Xóa các dòng khỏi DataGridView
            for (int i = dtgvHoaDonCho.Rows.Count - 1; i >= 0; i--)
            {
                if (dtgvHoaDonCho.Rows[i].Cells["MaHoaDon"].Value != null &&
                    Convert.ToInt32(dtgvHoaDonCho.Rows[i].Cells["MaHoaDon"].Value) == maHoaDon)
                {
                    dtgvHoaDonCho.Rows.RemoveAt(i);
                }
            }
        }

        private void ResetUI()
        {
            txtTienKhachDua.Text = string.Empty;
            label9.Text = "0";
            lblTienThua.Text = "0";
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            cboHoaDon.SelectedIndex = -1;
        }



        

    }
}

