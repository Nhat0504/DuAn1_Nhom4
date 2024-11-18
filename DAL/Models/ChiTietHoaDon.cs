using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ChiTietHoaDon
{
    public int MaCthd { get; set; }

    public int? MaHoaDon { get; set; }

    public int? MaChiTietSp { get; set; }

    public int SoLuong { get; set; }

    public decimal DonGia { get; set; }

    public decimal? ThanhTien { get; set; }

    public virtual ChiTietSanPham? MaChiTietSpNavigation { get; set; }

    public virtual HoaDon? MaHoaDonNavigation { get; set; }
}
