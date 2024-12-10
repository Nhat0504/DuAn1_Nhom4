using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IMauRepos
    {
        public bool Add(MauSac obj);
        public bool Delete(MauSac obj);
        public List<MauSac> GetAll();
        public bool Update(MauSac obj);
    }
}
