﻿using System;
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
            return View();
        }
    }
}