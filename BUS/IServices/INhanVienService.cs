using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface INhanVienService
    {
        bool Add(NhanVien obj);
        bool Update(NhanVien obj);
        bool Delete(NhanVien obj);
        List<NhanVien> GetAll();
        List<NhanVien> GetById(string input);
    }
}
