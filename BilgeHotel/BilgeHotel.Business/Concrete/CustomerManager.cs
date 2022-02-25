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
    public class CustomerManager : ICustomerService
    {
        private readonly IRepository<Customer> _repository;
        public CustomerManager(IRepository<Customer> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Add(Customer customer)
        {
            await _repository.Insert(customer);
            return true;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            Customer customer = _repository.Get(x => x.Id == id);
            bool kontrol = await _repository.Delete(customer);
            return kontrol;
        }

        public List<Customer> GetAll()
        {
            return _repository.GetAll();
        }

        public Customer GetById(int id)
        {
            return _repository.Get(x => x.Id == id);
        }
    }
}
