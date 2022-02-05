using BilgeHotel.Business.Abstract;
using BilgeHotel.Entities.Concrete;
using BilgeHotel.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeHotel.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBedService _bedService;
        public HomeController(ILogger<HomeController> logger, IBedService bedService)
        {
            _logger = logger;
            _bedService = bedService;
        }

        public IActionResult Index()
        {
            List<Bed> beds =  _bedService.GetAll();
            return View(beds);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
