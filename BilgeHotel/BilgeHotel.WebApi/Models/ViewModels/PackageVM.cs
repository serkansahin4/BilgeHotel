using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebApi.Models.ViewModels
{
    public class PackageVM
    {
        public int Id { get; set; }
        public string PackageName { get; set; }
        public double Price { get; set; }
    }
}
