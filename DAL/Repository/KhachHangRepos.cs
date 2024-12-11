using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class KhachHangRepos : IKhachHangRepos
    {
        private QuanLyBanQuanAoContext _dbContext;
        private List<KhachHang> _lstKH;
        public KhachHangRepos()
        {
            _dbContext = new QuanLyBanQuanAoContext();
            _lstKH = new List<KhachHang>();
        }
        public bool Add(KhachHang obj)
        {
            _dbContext.KhachHangs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Update(KhachHang obj)
        {
            _dbContext.KhachHangs.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Delete(KhachHang obj)
        {
            _dbContext.KhachHangs.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public List<KhachHang> GetAll()
        {
            _lstKH = _dbContext.KhachHangs.ToList();
            return _lstKH;
        }
    }
}