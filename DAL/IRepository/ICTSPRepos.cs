using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface ICTSPRepos
    {
        public bool Add(ChiTietSanPham obj);
        public bool Delete(ChiTietSanPham obj);
        public List<ChiTietSanPham> GetAll();
        public bool Update(ChiTietSanPham obj);
    }
}
