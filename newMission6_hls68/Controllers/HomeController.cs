using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private MovieContext _blahContext { get; set; }
        //constructor 
        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            _blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult movieForm()
        {
            ViewBag.Categories = _blahContext.Categories.ToList();

            return View(new ApplicationResponse()); // pass "new ApplicationResonse" later (learned in class)
        }
        // this goes in HomeController.cs
        [HttpPost]
        public IActionResult movieForm(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                _blahContext.Add(ar);
                _blahContext.SaveChanges();
                return View("confirmation", ar);
            }
            else
            {
                return View();
            }
        }

        public IActionResult myPodcasts()
        {
            return View();
        }

        public IActionResult MovieTable()
        {

           var movies =  _blahContext.responses.Include(x => x.category).OrderBy(x => x.title).ToList();


            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit (int movieId)
        {
            ViewBag.Categories = _blahContext.Categories.ToList();

            var movie = _blahContext.responses.Single(x => x.movieId == movieId);

            return View("movieForm", movie);
        }


        [HttpPost]
        public IActionResult Edit (ApplicationResponse blah)
        {
            _blahContext.Update(blah);
            _blahContext.SaveChanges();
            return RedirectToAction("movieTable");
        }

        [HttpGet]
        public IActionResult Delete(int movieId)
        {
          var movie = _blahContext.responses.Single(x => x.movieId == movieId);
            return View();
        }


        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {

            _blahContext.responses.Remove(ar);
            _blahContext.SaveChanges();
            return RedirectToAction("movieTable");
        }

    }
}
