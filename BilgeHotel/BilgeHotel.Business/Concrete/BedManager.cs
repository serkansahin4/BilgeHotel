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
    public class BedManager : IBedService
    {
        private readonly IRepository<Bed> _repository;
        public BedManager(IRepository<Bed> repository)
        {
            _repository = repository;
        }
        public List<Bed> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
