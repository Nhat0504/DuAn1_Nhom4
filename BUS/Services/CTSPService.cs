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
    public class CTSPService : ICTSPService
    {
        private ICTSPRepos _ICTSPRepos;
        private List<ChiTietSanPham> _lstCTSP;
        public CTSPService()
        {
            _ICTSPRepos = new CTSPRepos();
            _lstCTSP = new List<ChiTietSanPham>();
        }
        public bool Add(ChiTietSanPham obj)
        {
            _ICTSPRepos.Add(obj);
            return true;
        }

        public bool Delete(ChiTietSanPham obj)
        {
            _ICTSPRepos.Delete(obj);
            return true;
        }

        public List<ChiTietSanPham> GetAll()
        {
            _lstCTSP = _ICTSPRepos.GetAll();
            return _lstCTSP;
        }

        public List<ChiTietSanPham> GetById(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _ICTSPRepos.GetAll().Where(c => c.MaChiTietSp.ToString().Contains(input.ToLower())).ToList();
        }

        public bool Update(ChiTietSanPham obj)
        {
            _ICTSPRepos.Update(obj);
            return true;
        }
    }
}
