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
    public class Mauservice : IMauService
    {
        private IMauRepos _IMauRepos;
        private List<MauSac> _lstMau;
        public Mauservice()
        {
            _IMauRepos = new MauRepos();
            _lstMau = new List<MauSac>();
        }
        public bool Add(MauSac obj)
        {
            _IMauRepos.Add(obj);
            return true;
        }

        public bool Delete(MauSac obj)
        {
            _IMauRepos.Delete(obj);
            return true;
        }

        public List<MauSac> GetAll()
        {
            _lstMau = _IMauRepos.GetAll();
            return _lstMau;
        }

        public List<MauSac> GetById(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _IMauRepos.GetAll().Where(c => c.MaMauSac.ToString().Contains(input.ToLower())).ToList();
        }

        public bool Update(MauSac obj)
        {
            _IMauRepos.Update(obj);
            return true;
        }
    }
}
