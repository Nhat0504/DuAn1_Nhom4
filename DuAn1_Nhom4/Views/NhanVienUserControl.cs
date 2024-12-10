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
                dgv_NhanVien.Rows.Add(item.MaNhanVien, item.TenNhanVien, item.Sdt, item.DiaChi, item.Email, item.NgaySinh, item.GioiTinh, item.ChucVu);
            }
            dgv_NhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            rb_Nam.Checked = false;
            rb_Nu.Checked = false;

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

           
            var maNhanVien = int.Parse(txt_Ma.Text);
            // Kiểm tra xem nhân viên đã tồn tại chưa
            var existingNhanVien = _INhanVienServices.GetAll().FirstOrDefault(x => x.MaNhanVien == maNhanVien);
            if (existingNhanVien != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại", "Chú ý");
                return;
            }

            // Kiểm tra các trường bắt buộc khác (tùy theo yêu cầu)
            if (string.IsNullOrEmpty(txt_Ten.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên", "Lỗi");
                return;
            }

            // ... Kiểm tra các trường khác

            // Xác nhận thêm nhân viên
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không?", "Thêm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var nhanVien = new NhanVien
                    {
                        MaNhanVien = maNhanVien,
                        TenNhanVien = txt_Ten.Text,
                        ChucVu = txt_ChucVu.Text,
                        DiaChi = txt_DiaChi.Text,
                        Sdt = int.Parse(txt_SDT.Text),
                        Email = txt_Email.Text,
                        GioiTinh = rb_Nam.Checked ? 1 : 0,
                        
                    };

                    _INhanVienServices.Add(nhanVien);
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi");
                }
            }
        }

        private void dgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow r = dgv_NhanVien.Rows[e.RowIndex];
            //    _id = Guid.Parse(dgv_NhanVien.Rows[e.RowIndex].Cells[0].Value.ToString());
            //    _nv = _INhanVienServices.GetAll().FirstOrDefault(x => Guid.Parse(x.MaNhanVien) == _id);
            //    txt_Ma.Text = _nv.MaNhanVien;
            //    txt_Ten.Text = _nv.TenNhanVien;
            //    //cbx_CV.Text = _IChucVuServices.GetAll().FirstOrDefault(x => x.Idchucvu == _nv.Idchucvu).Tenchucvu;
            //    txt_SDT.Text = _nv.Sdt;
            //    txt_Email.Text = _nv.Email;
            //    txt_DiaChi.Text = _nv.DiaChi;
            //    dtp_Date.Value = _nv.NgaySinh.Value;
            //    txt_ChucVu.Text = _nv.ChucVu;
            //    MemoryStream memoryStream = new MemoryStream((byte[])r.Cells[2].Value);


            //    if (_nv.GioiTinh == 1)
            //    {
            //        rb_Nam.Checked = true;
            //    }
            //    else
            //    {
            //        rb_Nu.Checked = true;
            //    }
            //}
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
    }
}
