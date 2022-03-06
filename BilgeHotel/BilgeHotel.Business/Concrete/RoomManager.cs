using BilgeHotel.Business.Abstract;
using BilgeHotel.DataAccess.Abstract;
using BilgeHotel.Entities;
using BilgeHotel.Entities.ComplexType;
using BilgeHotel.Entities.Concrete;
using BilgeHotel.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRepository<Room> _repository;
        public RoomManager(IRepository<Room> repository)
        {
            _repository = repository;
        }
        public List<Room> GetAllReady(int roomTypeId)
        {
            return _repository.GetAll(x => x.RoomSituation.Id == 1 && x.RoomTypeId == roomTypeId);
        }

        public double PriceGetById(int RoomName)
        {
            return _repository.Get(x => x.RoomName == RoomName).RoomType.Price;
        }

        public async Task<bool> RoomStatusUpdateAsync(int roomName, int roomSituation)
        {
            Room room = _repository.Get(x => x.RoomName == roomName);
            if (room != null)
            {
                room.RoomSituationId = roomSituation;

                return await _repository.Update(room);
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> AddAsync(Room room)
        {
            bool kontrol = await _repository.Insert(room);
            return kontrol;
        }

        public async Task<bool> DeleteByIdAsync(int roomName)
        {
            Room room = _repository.Get(x => x.RoomName == roomName);
            bool kontrol = await _repository.Delete(room);
            return kontrol;
        }

        public List<Room> GetAll()
        {
            return _repository.GetAll();
        }

        public Room Get(int roomName)
        {
            return _repository.Get(x => x.RoomName == roomName);
        }

        public async Task<bool> UpdateAsync(Room room)
        {
            bool kontrol = await _repository.Update(room);
            return kontrol;
        }

        public List<ReadyRoomTodayVM> TodayReadyRoom()
        {
            List<Room> rooms = _repository.GetAll().ToList();

            DateTime tarih = DateTime.Now;
            DateTime nowStart = new DateTime(tarih.Year, tarih.Month, tarih.Day, 0, 0, 0); //Küçük
            DateTime nowStop = new DateTime(tarih.Year, tarih.Month, tarih.Day, 10, 0, 0); //Büyük
            List<ReadyRoomTodayVM> roomVMs = new List<ReadyRoomTodayVM>();
            foreach (Room room in rooms)
            {
                List<ReservationDetail> reservationDetails = new List<ReservationDetail>();
                reservationDetails = room.ReservationDetails.OrderBy(x => x.CheckInDate).ToList();

                for (int i = 0; i < reservationDetails.Count - 1; i++)
                {
                    DateTime date = reservationDetails.ToList()[i].CheckOutDate.AddHours(4);

                    DateTime date2 = reservationDetails.ToList()[i + 1].CheckInDate;
                    if (nowStart < reservationDetails.ToList()[i].CheckOutDate && reservationDetails.ToList()[i].CheckOutDate == nowStop && reservationDetails.ToList()[i].CheckOutDate.AddHours(4) != reservationDetails.ToList()[i + 1].CheckInDate)
                    {
                        DateTime times = new DateTime(2022, 03, 06, 18, 00, 00);
                        TimeSpan time = DateTime.Now - times;
                        int bosalacakSaat = time.Hours; //KAÇ SAATTİR BOŞ VEYA KAÇ SAATE BOŞALACAK
                        int bosalacakDakika = time.Minutes;
                        int bosalacakSaniye = time.Seconds;
                        if (bosalacakSaat > 0 || bosalacakDakika > 0 || bosalacakSaniye > 0)
                        {
                            roomVMs.Add(new ReadyRoomTodayVM { RoomId = room.RoomName, Hour = bosalacakSaat, Minute = bosalacakDakika, Second = bosalacakSaniye, Situation = RoomVMSituation.Hazır });
                        }
                        else
                        {
                            roomVMs.Add(new ReadyRoomTodayVM { RoomId = room.RoomName, Hour = bosalacakSaat * -1, Minute = bosalacakDakika * -1, Second = bosalacakSaniye * -1, Situation = RoomVMSituation.Boşalacak });
                        }
                    }

                }
            }



            return roomVMs;
        }

        public IEnumerable<WhichRoomWhichCustomerVM> WhichRoomWhichCustomer()
        {
            List<Room> rooms = _repository.GetAll().ToList();

            DateTime tarih = DateTime.Now;
            DateTime nowStart = new DateTime(tarih.Year, tarih.Month, tarih.Day, 0, 0, 0); //Küçük
            DateTime nowStop = new DateTime(tarih.Year, tarih.Month, tarih.Day, 10, 0, 0); //Büyük
            List<WhichRoomWhichCustomerVM> roomVMs = new List<WhichRoomWhichCustomerVM>();
            foreach (Room room in rooms)
            {
                List<ReservationDetail> reservationDetails = new List<ReservationDetail>();
                reservationDetails = room.ReservationDetails.OrderBy(x => x.CheckInDate).ToList();

                for (int i = 0; i < reservationDetails.Count - 1; i++)
                {
                    if (nowStart < reservationDetails.ToList()[i].CheckOutDate && reservationDetails.ToList()[i].CheckOutDate == nowStop)
                    {

                        TimeSpan time = reservationDetails.ToList()[i].CheckOutDate - DateTime.Now;
                        int bosalacakSaat = time.Hours; //KAÇ SAATTİR BOŞ VEYA KAÇ SAATE BOŞALACAK
                        int bosalacakDakika = time.Minutes;
                        int bosalacakSaniye = time.Seconds;

                        if (bosalacakSaat < 0 || bosalacakDakika < 0 || bosalacakSaniye < 0)
                        {
                            Customer customer = reservationDetails.ToList()[i].Reservation.Customer;
                            roomVMs.Add(
                                new WhichRoomWhichCustomerVM
                                {
                                    CustomerId = customer.Id,
                                    FirstName = customer.FirstName,
                                    LastName = customer.LastName,
                                    Email = customer.Email,
                                    RoomName = room.RoomName,
                                });
                        }
                    }

                }
            }




            return roomVMs.AsEnumerable();
        }



    }
}
