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
    public class JobManager:IJobService
    {
        private readonly IRepository<Job> _repository;
        public JobManager(IRepository<Job> repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddAsync(Job job)
        {
            bool kontrol = await _repository.Insert(job);
            return kontrol;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            Job job = _repository.Get(x => x.Id == id);
            bool kontrol = await _repository.Delete(job);
            return kontrol;
        }

        public List<Job> GetAll()
        {
            return _repository.GetAll();
        }

        public Job GetById(int id)
        {
            return _repository.Get(x => x.Id == id);
        }

        public async Task<bool> UpdateAsync(Job job)
        {
            bool kontrol = await _repository.Update(job);
            return kontrol;
        }
    }
}
