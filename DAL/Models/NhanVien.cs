using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class NhanVien
{
    public int MaNhanVien { get; set; }

    public string TenNhanVien { get; set; } = null!;

    public int? Sdt { get; set; }

    public string? DiaChi { get; set; }

    public string? Email { get; set; }

    public DateTime? NgaySinh { get; set; }

    public int? GioiTinh { get; set; }

    public string? ChucVu { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual TaiKhoan? TaiKhoan { get; set; }
}
