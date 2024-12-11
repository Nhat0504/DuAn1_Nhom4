using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.ComponentModel;
using BUS;
using DAL;
using System.Text.RegularExpressions;
using DAL.Models;

namespace GUI.Views
{
    public partial class BanHangUserControl : UserControl
    {
        public BanHangUserControl()
        {
            InitializeComponent();
            LoadData();
            LoadDataGridView();
            InitializeCurrentCTHD();

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
            // Kiểm tra nếu người dùng nhập 1 số "0"
            if (phoneNumber == "0")
            {
                return true;
            }

            // Kiểm tra nếu người dùng nhập 10 số
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





        // Biến lưu giữ thông tin mã tự động tăng
        private int _currentCTHD = 1; // Biến khởi tạo mã tự động tăng dần

        // Khai báo DataGridView
        

        // Load DataGridView cho giao diện
        private void LoadDataGridView()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM SanPham";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể load dữ liệu từ database: {ex.Message}");
                }
            }
        }

        // Cập nhật giao diện sau khi giảm số lượng sản phẩm
        private void UpdateGridView(string maSanPham, int soLuongTru)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["MaSanPham"].Value?.ToString() == maSanPham)
                {
                    int currentQuantity = int.Parse(row.Cells["SoLuong"].Value.ToString());
                    row.Cells["SoLuong"].Value = currentQuantity - soLuongTru;
                    break;
                }
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
                    isProductExists = true;
                    int currentQuantity = int.Parse(row.Cells["SoLuong"].Value.ToString());
                    row.Cells["SoLuong"].Value = currentQuantity + soLuong;
                    row.Cells["ThanhTien"].Value = (currentQuantity + soLuong) * gia;

                    SaveToChiTietHoaDon(maHoaDon, maSanPham, currentQuantity + soLuong, gia, (currentQuantity + soLuong) * gia);

                    break;
                }
            }

            if (!isProductExists)
            {
                decimal thanhTien = gia * soLuong;

                if (dtgvHoaDonCho.Columns.Count == 0)
                {
                    dtgvHoaDonCho.Columns.Add("MaCTHD", "Mã CTHD");
                    dtgvHoaDonCho.Columns.Add("MaSanPham", "Mã Sản Phẩm");
                    dtgvHoaDonCho.Columns.Add("MaHoaDon", "Mã Hóa Đơn");
                    dtgvHoaDonCho.Columns.Add("Gia", "Giá");
                    dtgvHoaDonCho.Columns.Add("SoLuong", "Số Lượng");
                    dtgvHoaDonCho.Columns.Add("ThanhTien", "Thành Tiền");
                }

                dtgvHoaDonCho.Rows.Add(_currentCTHD, maSanPham, maHoaDon, gia, soLuong, thanhTien);

                _currentCTHD++;
                UpdateProductQuantity(maSanPham, soLuong);
                SaveToChiTietHoaDon(maHoaDon, maSanPham, soLuong, gia, thanhTien);
                
            }
        }

        private void UpdateProductQuantity(string maSanPham, int soLuongTru)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string updateQuery = "UPDATE SanPham SET SoLuong = SoLuong - @SoLuong WHERE MaSanPham = @MaSanPham AND SoLuong >= @SoLuong";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@SoLuong", soLuongTru);
                        cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
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
                
                string maHoaDon = dtgvHoaDonCho.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();

                
                HienThiTongTien(maHoaDon);
            }
        }

        private void HienThiTongTien(string maHoaDon)
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dtgvHoaDonCho.Rows)
            {
                
                if (row.Cells["MaHoaDon"].Value?.ToString() == maHoaDon)
                {
                   
                    if (row.Cells["ThanhTien"]?.Value != null && decimal.TryParse(row.Cells["ThanhTien"].Value.ToString(), out decimal thanhTien))
                    {
                        tongTien += thanhTien;
                    }
                }
            }

          
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
               FROM ChiTietHoaDon h
               INNER JOIN KhachHang k ON h.MaKhachHang = k.MaKhachHang
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
                        string query = "UPDATE ChiTietHoaDon SET TrangThai = 'Đã thanh toán' WHERE MaHoaDon = @MaHoaDon";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaHoaDon", selectedMaHoaDon);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                 
                    RemoveInvoiceFromUI(selectedMaHoaDon);

                  
                    ResetUI();

                    MessageBox.Show("Thanh toán thành công!");

                    
                    if (dtgvHoaDonCho.SelectedRows.Count > 0) 
                    {
                        DataGridViewRow selectedRow = dtgvHoaDonCho.SelectedRows[0];

                        string maHoaDon = cboHoaDon.SelectedItem.ToString();
                        string maSanPham = selectedRow.Cells["MaSanPhamColumn"].Value.ToString(); 
                        int soLuong = int.Parse(selectedRow.Cells["SoLuongColumn"].Value.ToString()); 
                        decimal donGia = decimal.Parse(selectedRow.Cells["GiaColumn"].Value.ToString());
                        decimal thanhTien = donGia * soLuong; // Tính thành tiền

                      
                        SaveToChiTietHoaDon(maHoaDon, maSanPham, soLuong, donGia, thanhTien);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một dòng từ danh sách.");
                    }

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


        private void SaveToChiTietHoaDon(string maHoaDon, string maSanPham, int soLuong, decimal donGia, decimal thanhTien)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO ChiTietHoaDon (MaCTHD, MaHoaDon, MaSanPham, SoLuong, DonGia, ThanhTien, NgayTaoHoaDon) VALUES (@MaCTHD, @MaHoaDon, @MaSanPham, @SoLuong, @DonGia, @ThanhTien, @NgayTaoHoaDon)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaCTHD", _currentCTHD);
                    cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmd.Parameters.AddWithValue("@DonGia", donGia);  // Tham số cho đơn giá
                    cmd.Parameters.AddWithValue("@ThanhTien", thanhTien);
                    cmd.Parameters.AddWithValue("@NgayTaoHoaDon", DateTime.Now);


                    cmd.ExecuteNonQuery();
                    _currentCTHD++; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lưu chi tiết hóa đơn: {ex.Message}");
                }
            }
        }



        private void InitializeCurrentCTHD()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyBanQuanAo;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ISNULL(MAX(MaCTHD), 0) FROM ChiTietHoaDon";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    _currentCTHD = (int)cmd.ExecuteScalar() + 1; // Bắt đầu từ mã lớn nhất + 1
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi khởi tạo MaCTHD: {ex.Message}");
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
                
                RemoveInvoiceFromUI(selectedMaHoaDon);

              
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
            
            for (int i = 0; i < cboHoaDon.Items.Count; i++)
            {
                if (Convert.ToInt32(cboHoaDon.Items[i]) == maHoaDon)
                {
                    cboHoaDon.Items.RemoveAt(i);
                    break;
                }
            }

            
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

