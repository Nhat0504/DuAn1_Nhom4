using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface ILoaiSPService
    {
        bool Add(LoaiSanPham obj);
        bool Update(LoaiSanPham obj);
        bool Delete(LoaiSanPham obj);
        List<LoaiSanPham> GetAll();
        List<LoaiSanPham> GetById(string input);
    }
}
