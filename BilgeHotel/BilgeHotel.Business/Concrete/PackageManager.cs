using BilgeHotel.Business.Abstract;
using BilgeHotel.DataAccess.Abstract;
using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Concrete
{
    public class PackageManager : IPackageService
    {
        private readonly IRepository<Package> _repository;
        public PackageManager(IRepository<Package> repository)
        {
            _repository = repository;
        }
        public List<Package> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
