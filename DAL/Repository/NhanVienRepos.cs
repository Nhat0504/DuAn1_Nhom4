using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class NhanVienRepos : INhanVienRepos
    {
        private QuanLyBanQuanAoContext _dbContext;
        private List<NhanVien> _lstNv;
        public NhanVienRepos()
        {
            _dbContext = new QuanLyBanQuanAoContext();
            _lstNv = new List<NhanVien>();
        }
        public bool Add(NhanVien obj)
        {
            _dbContext.NhanViens.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Update(NhanVien obj)
        {
            _dbContext.NhanViens.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Delete(NhanVien obj)
        {
            _dbContext.NhanViens.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public List<NhanVien> GetAll()
        {
            _lstNv = _dbContext.NhanViens.ToList();
            return _lstNv;
        }
        public NhanVien GetCheck(string gmail)
        {
            NhanVien nv = _dbContext.NhanViens.FirstOrDefault(p => p.Email == gmail);
            return nv;
        }
    }
}
