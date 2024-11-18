using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDon
{
    public int MaHoaDon { get; set; }

    public int? MaKhachHang { get; set; }

    public int? MaNhanVien { get; set; }

    public DateOnly NgayTaoHoaDon { get; set; }

    public decimal TongTien { get; set; }

    public string? TrangThai { get; set; }

    public int? MaThanhToan { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual KhachHang? MaKhachHangNavigation { get; set; }

    public virtual NhanVien? MaNhanVienNavigation { get; set; }

    public virtual ThanhToan? MaThanhToanNavigation { get; set; }
}
