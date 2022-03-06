using BilgeHotel.Entities.Abstract;
using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class Room : IEntity
    {
        public Room()
        {
            ReservationDetails = new List<ReservationDetail>();
        }
        public int RoomName { get; set; }
        public Int16 RoomSize { get; set; }

        
        public int RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; }
        public int RoomViewId { get; set; }
        public virtual RoomView RoomView { get; set; }
        public int RoomSituationId { get; set; }
        public virtual RoomSituation RoomSituation { get; set; }
        public virtual List<ReservationDetail> ReservationDetails { get; set; }

    }
}
