using BilgeHotel.Core.MyTools.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Core.MyTools.Concrete
{
    public class ImageExtension : IImageExtension
    {
        public async Task<string> Add(IFormFile form)
        {
            if (form.Length > 0)
            {
                string[] permittedExtensions = { ".png", ".jpeg", ".jpg" };

                var ext = Path.GetExtension(form.FileName).ToLowerInvariant();

                if (ext != null || permittedExtensions.Contains(ext))
                {
                    //if (!Directory.Exists(_hostingEnvironment.WebRootPath + "\\uploads\\"))
                    //{
                    //    Directory.CreateDirectory(_hostingEnvironment.WebRootPath + "\\uploads\\"); //KLasör oluşturma.
                    //}
                    Guid imageId = Guid.NewGuid();
                    string filePath = imageId + ext;

                    using (FileStream uploadtream = System.IO.File.Create(@"..\BilgeHotel.WebUI\wwwroot\png\" + filePath))
                    {
                        await form.CopyToAsync(uploadtream);
                        await uploadtream.FlushAsync();

                    }
                    return filePath;
                }
                return null;
            }
            return null;
        }

        public string Delete(string path)
        {
            if (System.IO.File.Exists(@"..\BilgeHotel.WebUI\wwwroot\png\" + path))
            {
                try
                {
                    System.IO.File.Delete(@"..\BilgeHotel.WebUI\wwwroot\png\" + path);
                    return "Dosya Silindi";
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                    return "Dosya Silinemedi";
                }
            }
            return "Yol Bulunamadı.";
        }
    }
}
