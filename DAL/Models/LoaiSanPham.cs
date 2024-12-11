using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class LoaiSanPham
{
    public int MaLoaiSp { get; set; }

    public string TenLoaiSp { get; set; } = null!;


    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
