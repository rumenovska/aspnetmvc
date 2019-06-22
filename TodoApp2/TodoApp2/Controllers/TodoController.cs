using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApp2.Models;

namespace TodoApp2.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View(new Todo());
        }

        [HttpPost]
        public IActionResult Add(Todo todo )
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = $"Successfully added {todo.Title}";

            }
            return View(new Todo());
        }
        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}