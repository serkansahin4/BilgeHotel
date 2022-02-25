using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IPackageService
    {
        List<Package> GetAll();
        double PriceGetById(int id);

        Package GetById(int id);
        Task<bool> AddAsync(Package package);
        Task<bool> DeleteByIdAsync(int id);
        Task<bool> UpdateAsync(Package package);
    }
}
