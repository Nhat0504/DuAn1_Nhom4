using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IKhachHangRepos
    {
        public bool Add(KhachHang obj);
        public bool Delete(KhachHang obj);
        public List<KhachHang> GetAll();
        public bool Update(KhachHang obj);
    }
}
