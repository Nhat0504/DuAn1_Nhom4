using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class SizeRepos : ISizeRepos
    {
        private QuanLyBanQuanAoContext _dbContext;
        private List<KichThuoc> _lstKichThuoc;
        public SizeRepos()
        {
            _dbContext = new QuanLyBanQuanAoContext();
            _lstKichThuoc = new List<KichThuoc>();
        }
        public bool Add(KichThuoc obj)
        {
            _dbContext.KichThuocs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Update(KichThuoc obj)
        {
            _dbContext.KichThuocs.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Delete(KichThuoc obj)
        {
            _dbContext.KichThuocs.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public List<KichThuoc> GetAll()
        {
            _lstKichThuoc = _dbContext.KichThuocs.ToList();
            return _lstKichThuoc;
        }
    }
}