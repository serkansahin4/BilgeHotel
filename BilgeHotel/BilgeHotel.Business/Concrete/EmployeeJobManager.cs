using BilgeHotel.Business.Abstract;
using BilgeHotel.DataAccess.Abstract;
using BilgeHotel.Entities.ComplexType;
using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Concrete
{
    public class EmployeeJobManager : IEmployeeJobService
    {
        private readonly IRepository<EmployeeJob> _repository;
        public EmployeeJobManager(IRepository<EmployeeJob> repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddAsync(EmployeeJob employeeJob)
        {
            return await _repository.Insert(employeeJob);
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            EmployeeJob employeeJob = _repository.Get(x => x.EmployeeId == id);
            return await _repository.Delete(employeeJob);
        }

        public double GetEmployeeSalary(int employeeId)
        {
            EmployeeJob employeeJob = _repository.Get(x => x.EmployeeId == employeeId);

            int jobTime = 0;
            int extraJobTime = 0;
            
            switch (employeeJob.Employee.Role.Id)
            {
                case 1:
                    return employeeJob.Employee.Salary;
                case 2:
                    return employeeJob.Employee.Salary;
                default:
                    foreach (Shift item in employeeJob.Shifts)
                    {
                        if (DateTime.Now.AddDays(-30) < item.CreatedDate)
                        {
                            jobTime += (item.StartShift - item.StopShift).Hours;
                            extraJobTime += (item.ExtraTimeStop - item.StopShift).Hours;
                        }
                    }
                    break;
            }
            double salary = (jobTime+extraJobTime) * employeeJob.Employee.Salary;
            return salary;
        }



        public List<EmployeeJob> GetAll()
        {
            return _repository.GetAll();
        }

        public EmployeeJob GetById(int id)
        {
            return _repository.Get(x => x.EmployeeId == id);
        }

        public async Task<bool> UpdateAsync(EmployeeJob employeeJob)
        {
            return await _repository.Update(employeeJob);
        }

        public ShiftTime GetEmployeeShiftTime(int employeeId)
        {
            return _repository.Get(x => x.EmployeeId == employeeId).ShiftTime;
        }
    }
}
