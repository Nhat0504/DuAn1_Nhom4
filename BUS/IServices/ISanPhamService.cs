using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface ISanPhamService
    {
        bool Add(SanPham obj);
        bool Update(SanPham obj);
        List<SanPham> GetAll();
        List<SanPham> GetById(string input);
    }
}
