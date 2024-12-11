using BUS.IServices;
using DAL.IRepository;
using DAL.Models;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class KhachHangService : IKhachHangService
    {
        private IKhachHangRepos _KHRepos;
        private List<KhachHang> _lstKH;
        public KhachHangService()
        {
            _KHRepos = new KhachHangRepos();
            _lstKH = new List<KhachHang>();
        }
        public bool Add(KhachHang obj)
        {
            _KHRepos.Add(obj);
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            _KHRepos.Delete(obj);
            return true;
        }

        public List<KhachHang> GetAll()
        {
            _lstKH = _KHRepos.GetAll();
            return _lstKH;
        }

        public List<KhachHang> GetById(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _KHRepos.GetAll().Where(c => c.MaKhachHang.ToString().Contains(input.ToLower())).ToList();
        }

        public bool Update(KhachHang obj)
        {
            _KHRepos.Update(obj);
            return true;
        }
    }
}
