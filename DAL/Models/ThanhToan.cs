using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ThanhToan
{
    public int MaThanhToan { get; set; }

    public string TenHinhThuc { get; set; } = null!;

    public string? TrangThai { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
