using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.IServices;
using DAL.IRepository;
using DAL.Models;
using DAL.Repository;

namespace BUS.Services
{
    public class SanPhamService : ISanPhamService
    {
        private ISanPhamRepos _isanPhamRepos;
        private List<SanPham> sanPhams;
        public SanPhamService()
        {
            _isanPhamRepos = new SanPhamRepos();
            sanPhams = new List<SanPham>();
        }
        public bool Add(SanPham obj)
        {
            _isanPhamRepos.Add(obj);
            return true;
        }

        public bool Delete(SanPham obj)
        {
            _isanPhamRepos.Delete(obj);
            return true;
        }

        public List<SanPham> GetAll()
        {
            sanPhams = _isanPhamRepos.GetAll();
            return sanPhams;
        }
        public List<SanPham> GetById(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _isanPhamRepos.GetAll().Where(c => c.MaSanPham.ToString().Contains(input.ToLower())).ToList();
        }

        public bool Update(SanPham obj)
        {
            _isanPhamRepos.Update(obj);
            return true;
        }
    }
}
