using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class KichThuoc
{
    public int MaKichThuoc { get; set; }

    public string TenKichThuoc { get; set; } = null!;

    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();
}
