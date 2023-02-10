using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using newMission6_hls68.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace newMission6_hls68.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DateApplicationContext _blahContext { get; set; }
        //constructor 
        public HomeController(ILogger<HomeController> logger, DateApplicationContext someName)
        {
            _logger = logger;
            _blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult movieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult movieForm(ApplicationResponse ar)
        {
            _blahContext.Add(ar);
            _blahContext.SaveChanges();
            return View("confirmation", ar);
        }

        public IActionResult myPodcasts()
        {
            return View();
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
