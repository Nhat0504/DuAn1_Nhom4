using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface ISizeRepos
    {
        public bool Add(KichThuoc obj);
        public bool Delete(KichThuoc obj);
        public List<KichThuoc> GetAll();
        public bool Update(KichThuoc obj);
    }
}
