using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IRoomService
    {
        List<Room> GetAllReady(int roomTypeId); //Oda Tipine göre(Kategorisine göre) hazır odalar gelecek.
        double PriceGetById(int RoomName); //Oda Id sine göre odanın fiyatı gelecek(RoomType Üzerinden.)

        Task<bool> RoomStatusUpdateAsync(int roomName, int roomSituation); //ODA DURUMLARINI GÜNCELLEMEK.



        List<Room> GetAll(); //Bütün Odalar Gelecek.
        Room Get(int roomName);
        Task<bool> AddAsync(Room room);
        Task<bool> DeleteByIdAsync(int roomName);
        Task<bool> UpdateAsync(Room room);

    }
}
