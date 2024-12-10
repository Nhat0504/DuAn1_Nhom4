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
    public class SizeService : ISizeService
    {
        private ISizeRepos _ISizeRepos;
        private List<KichThuoc> _lstKichThuoc;
        public SizeService()
        {
            _ISizeRepos = new SizeRepos();
            _lstKichThuoc = new List<KichThuoc>();
        }
        public bool Add(KichThuoc obj)
        {
            _ISizeRepos.Add(obj);
            return true;
        }

        public bool Delete(KichThuoc obj)
        {
            _ISizeRepos.Delete(obj);
            return true;
        }

        public List<KichThuoc> GetAll()
        {
            _lstKichThuoc = _ISizeRepos.GetAll();
            return _lstKichThuoc;
        }

        public List<KichThuoc> GetById(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _ISizeRepos.GetAll().Where(c => c.MaKichThuoc.ToString().Contains(input.ToLower())).ToList();
        }

        public bool Update(KichThuoc obj)
        {
            _ISizeRepos.Update(obj);
            return true;
        }
    }
}
