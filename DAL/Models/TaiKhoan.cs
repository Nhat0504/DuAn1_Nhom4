using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TaiKhoan
{
    public int MaNhanVien { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? TrangThai { get; set; }

    public virtual NhanVien MaNhanVienNavigation { get; set; } = null!;
}
