using BilgeHotel.Entities.Abstract;
using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class Package : IEntity
    {
        public int Id { get; set; }
        public string PackageName { get; set; }
        public double Price { get; set; }

        public virtual List<ReservationDetail> ReservationDetails { get; set; }
    }
}
