using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface ISizeService
    {
        bool Add(KichThuoc obj);
        bool Update(KichThuoc obj);
        bool Delete(KichThuoc obj);
        List<KichThuoc> GetAll();
        List<KichThuoc> GetById(string input);
    }
}
