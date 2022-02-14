using BilgeHotel.Business.Abstract;
using BilgeHotel.DataAccess.Abstract;
using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Concrete
{
    public class ReservationDetailManager : IReservationDetailService
    {
        private readonly IRepository<ReservationDetail> _repository;
        public ReservationDetailManager(IRepository<ReservationDetail> repository)
        {
            _repository = repository;
        }

        public List<ReservationDetail> GetAll(int roomId)
        {
            return _repository.GetAll(x => x.RoomId == roomId).ToList();
        }
    }
}
