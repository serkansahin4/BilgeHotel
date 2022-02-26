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
    public class ReservationOutHotelExtraManager : IReservationOutHotelExtraService
    {
        private readonly IRepository<ReservationOutHotelExtra> _repository;
        public ReservationOutHotelExtraManager(IRepository<ReservationOutHotelExtra> repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddAsync(Guid reservationId, int hotelExtraId, short quantity)
        {
            return await _repository.Insert(new ReservationOutHotelExtra { HotelExtraId = hotelExtraId, ReservationId = reservationId, Quantity = quantity});
        }

        public async Task<bool> DeleteByIdAsync(Guid reservationId, int hotelExtraId)
        {
            ReservationOutHotelExtra hotelExtra = _repository.Get(x => x.HotelExtraId == hotelExtraId && x.ReservationId == reservationId);
            return await _repository.Delete(hotelExtra);
        }

        public List<ReservationOutHotelExtra> GetAll(Guid reservationId)
        {
            return _repository.GetAll(x => x.ReservationId == reservationId);
        }
    }
}
