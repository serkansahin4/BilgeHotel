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
    public class ShiftManager : IShiftService
    {
        private readonly IRepository<Shift> _repository;
        public ShiftManager(IRepository<Shift> repository)
        {
            _repository = repository;
        }

        public async Task<bool> AddAsync(Shift shift)
        {
            return await _repository.Insert(shift);
        }

        public Shift Get(int shiftId)
        {
            return _repository.Get(x => x.Id == shiftId);
        }

        public List<Shift> GetAll(int employeeJobId)
        {
            return _repository.GetAll(x => x.EmployeeJobId == employeeJobId);
        }
    }
}
