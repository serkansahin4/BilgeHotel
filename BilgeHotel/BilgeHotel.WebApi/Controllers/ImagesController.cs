using BilgeHotel.Business.Abstract;
using BilgeHotel.Core.MyTools.Abstract;
using BilgeHotel.Entities.Concrete;
using BilgeHotel.WebApi.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageService _ımageService;
        private readonly IImageExtension _ımageExtension;
        public ImagesController(IImageService ımageService, IImageExtension extension)
        {
            _ımageService = ımageService;
            _ımageExtension = extension;
        }


        [HttpGet("Get/{imageId}")]
        
        public IActionResult Get(int imageId)
        {
            Image ımage = _ımageService.Get(imageId);
            string[] a = ımage.Path.Split(".");
            FileStream image = System.IO.File.OpenRead(@"..\BilgeHotel.WebUI\wwwroot\png\" + ımage.Path);
            return File(image, "image/" + a[1]);
        }
        [HttpGet("GetAll/{roomTypeId}")]
        public IActionResult GetAll(int roomTypeId)
        {
           return Ok(_ımageService.GetAll(roomTypeId));
        }



        [HttpPost]
        public async Task<IActionResult> PostImage([FromForm] ImagePostDTO postDTO)
        {
            string sonuc = await _ımageExtension.Add(postDTO.Form);
            if (!string.IsNullOrEmpty(sonuc))
            {
                Image ımage = new Image();
                ımage.RoomTypeId = postDTO.RoomTypeId;
                ımage.Path = sonuc;
                return Ok(await _ımageService.Add(ımage));
            }

            return NotFound(sonuc);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteImage([FromForm] ImageDeleteDTO deleteDTO)
        {
            Image image = _ımageService.Get(deleteDTO.ImageId);
            bool kontrol = await _ımageService.Delete(deleteDTO.RoomTypeId, deleteDTO.ImageId);
            if (kontrol)
            {
                string message = _ımageExtension.Delete(image.Path);
                return Ok(message);
            }
            else
            {
                return NotFound();
            }
        }

    }
}
