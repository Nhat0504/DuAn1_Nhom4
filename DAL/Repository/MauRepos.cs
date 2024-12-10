using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class MauRepos : IMauRepos
    {
        private QuanLyBanQuanAoContext _dbContext;
        private List<MauSac> _lstMau;
        public MauRepos()
        {
            _dbContext = new QuanLyBanQuanAoContext();
            _lstMau = new List<MauSac>();
        }
        public bool Add(MauSac obj)
        {
            _dbContext.MauSacs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Update(MauSac obj)
        {
            _dbContext.MauSacs.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Delete(MauSac obj)
        {
            _dbContext.MauSacs.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public List<MauSac> GetAll()
        {
            _lstMau = _dbContext.MauSacs.ToList();
            return _lstMau;
        }
    }
}