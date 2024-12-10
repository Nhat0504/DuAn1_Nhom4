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
        private ILoaiSPService _loaiSPservice;
        private SanPham _lstSanPham;
        public SanPhamUserControl()
        {
            InitializeComponent();
            _iSanPhamservice = new SanPhamService();
            _loaiSPservice = new LoaiSPService();
            _lstSanPham = new SanPham();
            LoadDataFormDb();
            loadCBX();
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
            dgrid_SanPham.Columns[5].Name = "TrangThai";
            dgrid_SanPham.Rows.Clear();
            foreach (var x in _iSanPhamservice.GetAll())
            {
                dgrid_SanPham.Rows.Add(x.MaSanPham, x.TenSanPham, x.Gia, x.SoLuong, x.MaLoaiSp, x.TrangThai == 1 ? "Đang kinh doanh" : "Ngừng kinh doanh");
            }
            dgrid_SanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrid_SanPham.DefaultCellStyle.ForeColor = Color.Black;
            dgrid_SanPham.Columns["Gia"].DefaultCellStyle.Format = "#,##0 VNĐ";
        }
        //public void LoadDataFormDb(string input)
        //{
        //    dgrid_SanPham.ColumnCount = 6;
        //    dgrid_SanPham.Columns[0].Name = "MaSanPham";
        //    dgrid_SanPham.Columns[0].Visible = true;
        //    dgrid_SanPham.Columns[1].Name = "TenSanPham";
        //    dgrid_SanPham.Columns[2].Name = "Gia";
        //    dgrid_SanPham.Columns[3].Name = "SoLuong";
        //    dgrid_SanPham.Columns[4].Name = "MaLoaiSp";
        //    dgrid_SanPham.Columns[5].Name = "TrangThai";
        //    foreach (var x in _iSanPhamservice.GetAll())
        //    {
        //        dgrid_SanPham.Rows.Add(x.MaSanPham, x.TenSanPham, x.Gia, x.SoLuong, x.MaLoaiSp, x.TrangThai == 1 ? "Đang kinh doanh" : "Ngừng kinh doanh");
        //    }
        //}

        public void loadCBX()
        {
            foreach (var item in _loaiSPservice.GetAll())
            {
                cbx_MaloaiSP.Items.Add(item.MaLoaiSp);
            }
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
            var b = _loaiSPservice.GetAll().FirstOrDefault(x => x.MaLoaiSp == int.Parse(cbx_MaloaiSP.Text));
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
                    return;
                    
                }
                try
                {
                    var a = new SanPham()
                    {
                        MaSanPham = int.Parse(txt_ma.Text),
                        TenSanPham = txt_Ten.Text,
                        Gia = int.Parse(txt_giaban.Text),
                        SoLuong = int.Parse(txt_SoLuong.Text),
                        MaLoaiSp = b.MaLoaiSp,
                        TrangThai = rb_KD.Checked == true ? 1 : 0,

                    };
                    _iSanPhamservice.Add(a);
                    MessageBox.Show("Thêm thành công");
                    reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi");
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_lstSanPham == null)
            {
                MessageBox.Show("Không tìm thấy mã VGA", "Cảnh báo");
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
                    int maSanPham = int.Parse(txt_ma.Text);
                    var sanPham = _iSanPhamservice.GetAll().FirstOrDefault(c => c.MaSanPham == maSanPham);
                    var b = _loaiSPservice.GetAll().FirstOrDefault(x => x.MaLoaiSp == int.Parse(cbx_MaloaiSP.Text));
                    if (sanPham == null)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm có mã này", "Lỗi");
                        return;
                    }

                    // Cập nhật thông tin sản phẩm
                    sanPham.TenSanPham = txt_Ten.Text;
                    sanPham.Gia = int.Parse(txt_giaban.Text);
                    sanPham.SoLuong = int.Parse(txt_SoLuong.Text);
                    b.MaLoaiSp = int.Parse(cbx_MaloaiSP.Text);
                    sanPham.TrangThai = rb_KD.Checked == true ? 1 : 0;
                    _iSanPhamservice.Update(sanPham);

                    MessageBox.Show("Sửa thành công");
                    sd();
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi");
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
                cbx_MaloaiSP.Text = r.Cells[4].Value?.ToString();
                rb_KD.Checked = r.Cells[5].Value.ToString() == "Đang kinh doanh";
                rb_NKD.Checked = r.Cells[5].Value.ToString() == "Ngừng kinh doanh";

            }
        }

        public void reset()
        {
            LoadDataFormDb();
            _lstSanPham = null;
            txt_ma.Text = "";
            txt_Ten.Text = "";
            txt_SoLuong.Text = "";
            txt_giaban.Text = "";
            cbx_MaloaiSP.Text = "";
            rb_KD.Checked = false;
            rb_NKD.Checked = false;
        }
        public void sd()
        {
            this.panel1.Controls.Clear();
            SanPhamUserControl frm_sanPham = new SanPhamUserControl() { Dock = DockStyle.Fill };
            this.panel1.Controls.Add(frm_sanPham);
        }




        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            LoaiSPUserControl frm_sanPham = new LoaiSPUserControl() { Dock = DockStyle.Fill };
            this.panel1.Controls.Add(frm_sanPham);
            frm_sanPham.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            CTSPUserControl frm_sanPham = new CTSPUserControl() { Dock = DockStyle.Fill };
            this.panel1.Controls.Add(frm_sanPham);
            frm_sanPham.Show();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
