using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Data;
using EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    public class PizzaController : Controller
    {
        private PizzaContex _pizzaContex;

        public PizzaController (PizzaContex pizzaContex)
        {
            _pizzaContex = pizzaContex;
        }
        public IActionResult Index()
        {
            _pizzaContex.Add(new Pizza());
            _pizzaContex.Update(new Pizza());
            return View();
        }
    }
}