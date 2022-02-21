using BilgeHotel.Entities.Abstract;
using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class Card:IEntity
    {
        public Guid Id { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public string Cv2 { get; set; }
        public string EndDate { get; set; }

        public virtual List<ReservationDetail> ReservationDetails { get; set; }
    }
}
