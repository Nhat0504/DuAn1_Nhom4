using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepository;
using DAL.Models;

namespace DAL.Repository
{
    public class SanPhamRepos : ISanPhamRepos
    {
        private QuanLyBanQuanAoContext _dbContext;
        private List<SanPham> sanPhams;
        public SanPhamRepos()
        {
            _dbContext = new QuanLyBanQuanAoContext();
            sanPhams = new List<SanPham>();
        }
        public bool Add(SanPham obj)
        {
            _dbContext.SanPhams.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Update(SanPham obj)
        {
            _dbContext.SanPhams.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public List<SanPham> GetAll()
        {
            sanPhams = _dbContext.SanPhams.ToList();
            return sanPhams;
        }
    }
}
  