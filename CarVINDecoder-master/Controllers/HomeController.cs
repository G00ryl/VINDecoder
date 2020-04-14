using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VIN.Models;
using VIN.Services;

namespace VIN.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVinService _vinService;

        public HomeController(IVinService vinService)
        {
            _vinService = vinService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string vin)
        {
            if(string.IsNullOrEmpty(vin))
            {
                ViewBag.Error = "Please provide the VIN number";
                return View();
            }
            
            try
            {
                var car = await _vinService.GetAsync(vin);
                ViewBag.Car = car;
                return View();
            }
            catch (HttpRequestException)
            {
                ViewBag.Error = "Check your VIN number and try again.";
                return View();
            }
            catch (Exception)
            {
                ViewBag.Error = "Error! Try again later.";
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
      

    }
}
