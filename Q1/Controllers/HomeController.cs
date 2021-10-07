using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Q1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Q1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static Houses houses = new Houses();
        
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        /*public IActionResult Privacy()
        {
            return View();
        }*/

        [HttpGet]
        public ActionResult CustomerSearch()
        {
            return View(houses.HouseList);
        }

        /*[HttpPost] 
        public ActionResult CustomerSearch()
        {

        }*/

        
        [HttpGet]
        public ActionResult UpdateHouseView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateHouseView(Model model)
        {
            houses.CreateHouse(model);
            return View(houses.HouseList); 
        }

        [HttpGet]
        public ActionResult HouseDetailsView(int id)
        {
            return View(houses.HouseList.FirstOrDefault(x => x.houseID == id));
        }

        [HttpPost] 
        public ActionResult HouseDetailsView()
        {
            return View(houses.HouseList); 
        }

        [HttpGet]
        public ActionResult ContactRealtorView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContactRealtorView(Model model)
        {
            model.realtorName = "Richard Howe";
            model.realtorEmail = "howe24@gmail.com";
            model.realtorPhoneNumber = "(123) 456-7890";
            houses.CreateHouse(model); 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
