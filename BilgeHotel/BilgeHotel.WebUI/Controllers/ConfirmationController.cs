using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebUI.Controllers
{
    public class ConfirmationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
