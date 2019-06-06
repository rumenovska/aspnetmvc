using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PizzaApp1.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult GetAll()
        {
            var pizzas = new List<string>
            {
                "capri", "tono", "margarita", "vegetariana"
            };
            //ViewBag.pizzas = listOfPizzas;
            //ViewData["pizzas"] = listOfPizzas;

            ViewBag.users = 1;
            return View(pizzas);
        }
    }
}