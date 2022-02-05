using BilgeHotel.Entities.Abstract;
using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class Reservation : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public decimal ExtraTotalPrice { get; set; } //her extradan ne kadar ve kaç adet harcanmışsa
                                                     //Fiyatı Hesaplanıp toplam fiyatı buraya yazılacaktır.
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }

        public virtual List<ReservationOutHotelExtra> ReservationOutHotelExtras { get; set; }
        public virtual List<ReservationDetail> ReservationDetails { get; set; }
    }
}
