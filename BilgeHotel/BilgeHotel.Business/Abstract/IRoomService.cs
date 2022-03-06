using BilgeHotel.Entities;
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
        List<ReadyRoomTodayVM> TodayReadyRoom(); //BUGÜN HAZIR VEYA HAZIRLANIYOR OLAN ODALAR GELİCEK.
        IEnumerable<WhichRoomWhichCustomerVM> WhichRoomWhichCustomer();//Programın yönetici kısmında hangi odada hangi müşterinin bulunduğunu, kimin rezervasyon yaptırdığını ve daha önceki senelerde otelimizi ziyaret edip etmediğini de görmek isterim. 
        List<Room> GetAll(); //Bütün Odalar Gelecek.
        Room Get(int roomName);
        Task<bool> AddAsync(Room room);
        Task<bool> DeleteByIdAsync(int roomName);
        Task<bool> UpdateAsync(Room room);

    }
}
