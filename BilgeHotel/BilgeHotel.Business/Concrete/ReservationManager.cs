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
    public class ReservationManager : IReservationService
    {
        private readonly IRepository<Reservation> _repository;
        public ReservationManager(IRepository<Reservation> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Add(Reservation reservation)
        {
            await _repository.Insert(reservation);
            return true;
        }

        public List<Reservation> ReservationsFindByRoomId(int roomId)
        {
            throw new NotImplementedException();
        }
    }
}
