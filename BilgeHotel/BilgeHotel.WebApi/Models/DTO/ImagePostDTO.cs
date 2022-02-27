using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Models.DTO
{
    public class ImagePostDTO
    {
        public IFormFile Form { get; set; }
        public int RoomTypeId { get; set; }
    }
}
