using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface INhanVienRepos
    {
        public bool Add(NhanVien obj);
        public bool Delete(NhanVien obj);
        public List<NhanVien> GetAll();
        public bool Update(NhanVien obj);
        NhanVien GetCheck(string gmail);
    }
}
