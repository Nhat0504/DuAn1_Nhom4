using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class LoaiSPRepos : ILoaiSPRepos
    {
        private QuanLyBanQuanAoContext _dbContext;
        private List<LoaiSanPham> _lstLoaiSP;
        public LoaiSPRepos()
        {
            _dbContext = new QuanLyBanQuanAoContext();
            _lstLoaiSP = new List<LoaiSanPham>();
        }
        public bool Add(LoaiSanPham obj)
        {
            _dbContext.LoaiSanPhams.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Update(LoaiSanPham obj)
        {
            _dbContext.LoaiSanPhams.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Delete(LoaiSanPham obj)
        {
            _dbContext.LoaiSanPhams.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public List<LoaiSanPham> GetAll()
        {
            _lstLoaiSP = _dbContext.LoaiSanPhams.ToList();
            return _lstLoaiSP;
        }
    }
}
