using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClassFour.Controllers
{
   [Route("seavus-g1")]
    [Route("[controller]")]
    public class PizzaController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        [Route("menu")]
        public IActionResult Menu()
        {
            return View();
        }
        [Route("offers")]
        public IActionResult Offers()
        {
            return View();
        }
    }
}