using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SanPham
{
    public int? MaSanPham { get; set; }

    public string TenSanPham { get; set; } = null!;

    public decimal Gia { get; set; }

    public int SoLuong { get; set; }

    public int? MaLoaiSp { get; set; }

    public int TrangThai { get; set; } 

    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();

    public virtual LoaiSanPham? MaLoaiSpNavigation { get; set; }
}
