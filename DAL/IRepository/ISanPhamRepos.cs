using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.IRepository
{
    public interface ISanPhamRepos
    {
        public bool Add(SanPham obj);
        public List<SanPham> GetAll();
        public bool Update(SanPham obj);
    }
}
