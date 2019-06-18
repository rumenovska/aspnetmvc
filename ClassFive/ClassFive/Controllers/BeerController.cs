using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassFive.Models;
using Microsoft.AspNetCore.Mvc;


namespace ClassFive.Controllers
{
    public class BeerController : Controller
    {
        [HttpGet]
        public IActionResult AddBeer()
        {
            return View(new Beer());
        }

        [HttpPost]
        public IActionResult AddBeer(Beer beer)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = $"Successfully added {beer.Name}";
                
            }
            return View(new Beer());
        }
        [HttpGet]
        public IActionResult EditBeer()
        {
            var model = new Beer
            {
                Name = "Skopsko",
                Dectription = "Top",
                Price = 50,
                Type = "lager",
                Size = "0.5l",
                IsGlutenFree = true
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult EditBeer(Beer beer)
        {
            ViewBag.Message = $"Successfully edited {beer.Name}";
           
            return View(beer);
        }

    }
}