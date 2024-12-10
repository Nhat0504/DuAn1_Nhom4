using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class CTSPRepos : ICTSPRepos
    {
        private QuanLyBanQuanAoContext _dbContext;
        private List<ChiTietSanPham> _lstChitietSP;
        public CTSPRepos()
        {
            _dbContext = new QuanLyBanQuanAoContext();
            _lstChitietSP = new List<ChiTietSanPham>();
        }
        public bool Add(ChiTietSanPham obj)
        {
            _dbContext.ChiTietSanPhams.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Update(ChiTietSanPham obj)
        {
            _dbContext.ChiTietSanPhams.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Delete(ChiTietSanPham obj)
        {
            _dbContext.ChiTietSanPhams.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public List<ChiTietSanPham> GetAll()
        {
            _lstChitietSP = _dbContext.ChiTietSanPhams.ToList();
            return _lstChitietSP;
        }
    }
}
