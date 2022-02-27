using BilgeHotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Business.Abstract
{
    public interface IImageService
    {
        Task<bool> Add(Image image);
        Task<bool> Delete(int roomTypeId,int imageId);

        List<Image> GetAll(int roomTypeId);
        Image Get(int imageId);
    }
}
