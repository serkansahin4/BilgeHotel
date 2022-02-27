using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Core.MyTools.Abstract
{
    public interface IImageExtension
    {
        Task<string> Add(IFormFile form);
        string Delete(string path);
    }
}
