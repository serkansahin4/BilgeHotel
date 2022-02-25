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

        public double PriceGetById(int id)
        {
            return _repository.Get(x => x.Id == id).Price;
        }

        public List<Package> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<bool> AddAsync(Package package)
        {
            bool kontrol = await _repository.Insert(package);
            return kontrol;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            Package package = _repository.Get(x => x.Id == id);
            bool kontrol = await _repository.Delete(package);
            return kontrol;
        }

        public Package GetById(int id)
        {
            return _repository.Get(x => x.Id == id);
        }

        public async Task<bool> UpdateAsync(Package package)
        {
            bool kontrol = await _repository.Update(package);
            return kontrol;
        }
    }
}
