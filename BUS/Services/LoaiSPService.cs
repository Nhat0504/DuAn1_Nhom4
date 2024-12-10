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
    public class LoaiSPService : ILoaiSPService
    {
        private ILoaiSPRepos _ILoaiSPRepos;
        private List<LoaiSanPham> _lstLoaiSP;
        public LoaiSPService()
        {
            _ILoaiSPRepos = new LoaiSPRepos();
            _lstLoaiSP = new List<LoaiSanPham>();
        }
        public bool Add(LoaiSanPham obj)
        {
            _ILoaiSPRepos.Add(obj);
            return true;
        }

        public bool Delete(LoaiSanPham obj)
        {
            _ILoaiSPRepos.Delete(obj);
            return true;
        }

        public List<LoaiSanPham> GetAll()
        {
            _lstLoaiSP = _ILoaiSPRepos.GetAll();
            return _lstLoaiSP;
        }

        public List<LoaiSanPham> GetById(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _ILoaiSPRepos.GetAll().Where(c => c.MaLoaiSp.ToString().Contains(input.ToLower())).ToList();
        }

        public bool Update(LoaiSanPham obj)
        {
            _ILoaiSPRepos.Update(obj);
            return true;
        }
    }
}
