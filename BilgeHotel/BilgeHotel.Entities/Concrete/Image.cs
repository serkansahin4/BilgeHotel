using BilgeHotel.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Entities.Concrete
{
    public class Image:IEntity
    {
        public int Id { get; set; }
        public int RoomTypeId { get; set; }
        public string Path { get; set; }

        public virtual RoomType RoomType { get; set; }
    }
}
