using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ChiTietSanPham
{
    public int MaChiTietSp { get; set; }

    public int? MaSanPham { get; set; }

    public int? MaMauSac { get; set; }

    public int? MaKichThuoc { get; set; }

    public int SoLuong { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual KichThuoc? MaKichThuocNavigation { get; set; }

    public virtual MauSac? MaMauSacNavigation { get; set; }

    public virtual SanPham? MaSanPhamNavigation { get; set; }
}
