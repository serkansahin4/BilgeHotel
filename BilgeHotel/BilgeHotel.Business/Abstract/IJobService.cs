using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IJobService
    {
        List<Job> GetAll();
        Job GetById(int id);
        Task<bool> AddAsync(Job job);
        Task<bool> DeleteByIdAsync(int id);
        Task<bool> UpdateAsync(Job job);
    }
}
