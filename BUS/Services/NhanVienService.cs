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
    public class NhanVienService : INhanVienService
    {
        private INhanVienRepos _INhanVienRepository;
        private List<NhanVien> _lstNv;
        public NhanVienService()
        {
            _INhanVienRepository = new NhanVienRepos();
            _lstNv = new List<NhanVien>();
        }
        public bool Add(NhanVien obj)
        {
            _INhanVienRepository.Add(obj);
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            _INhanVienRepository.Delete(obj);
            return true;
        }

        public List<NhanVien> GetAll()
        {
            _lstNv = _INhanVienRepository.GetAll();
            return _lstNv;
        }

        public List<NhanVien> GetById(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _INhanVienRepository.GetAll().Where(c => c.MaNhanVien.ToString().Contains(input.ToLower())).ToList();
        }

        public bool Update(NhanVien obj)
        {
            _INhanVienRepository.Update(obj);
            return true;
        }
    }
}
