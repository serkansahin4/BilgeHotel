using BilgeHotel.Entities.Abstract;
using BilgeHotel.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class Bed : IEntity
    {
        public int Id { get; set; }
        public string BedType { get; set; }

        public virtual List<RoomBed> RoomBeds { get; set; }
    }
}
