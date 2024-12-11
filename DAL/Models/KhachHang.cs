using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class KhachHang
{
    public int MaKhachHang { get; set; }

    public string TenKhachHang { get; set; } = null!;

    public string? DiaChi { get; set; }

    public int? Sdt { get; set; }

    public string? Email { get; set; }

    public int? GioiTinh { get; set; }

    public DateTime? NgaySinh { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
