using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface ILoaiSPRepos
    {
        public bool Add(LoaiSanPham obj);
        public bool Delete(LoaiSanPham obj);
        public List<LoaiSanPham> GetAll();
        public bool Update(LoaiSanPham obj);
    }
}
