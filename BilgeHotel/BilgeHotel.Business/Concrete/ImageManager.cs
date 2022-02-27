using BilgeHotel.Business.Abstract;
using BilgeHotel.DataAccess.Abstract;
using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Concrete
{
    public class ImageManager : IImageService
    {
        private readonly IRepository<Image> _repository;

        public ImageManager(IRepository<Image> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Add(Image image)
        {
            return await _repository.Insert(image);
        }

        public async Task<bool> Delete(int roomTypeId, int imageId)
        {
            Image ımage = _repository.Get(x => x.RoomTypeId == roomTypeId && x.Id == imageId);
            return await _repository.Delete(ımage);
        }

        public List<Image> GetAll(int roomTypeId)
        {
            return _repository.GetAll(x => x.RoomTypeId == roomTypeId);
        }

        public Image Get(int imageId)
        {
            return _repository.Get(x => x.Id == imageId);
        }
    }
}
