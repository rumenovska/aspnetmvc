using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;



namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        private List<Todo> list = new List<Todo> {
               new Todo("First", "Do your homework", DateTime.Today.AddDays(1)),
               new Todo("Second", "Do something", DateTime.Today.AddDays(-1)),
               new Todo("Third", "Do something", DateTime.Today),
               new Todo("First1", "Do your homework", DateTime.Today.AddDays(1)),
               new Todo("Second2", "Do something", DateTime.Today.AddDays(-1)),
               new Todo("Third3", "Do something", DateTime.Today)

            };

        

        public IActionResult GetAll()
        { 
            return View(list);

        }

        public IActionResult Yesterday()
        {
            var yesterday = list.Where(t => t.DueDate == DateTime.Today.AddDays(-1)).ToList();

            return View("~/Views/Todo/GetAll.cshtml", yesterday);
        }

        public IActionResult Tomorrow()
        {
            var tomorrow = list.Where(t => t.DueDate == DateTime.Today.AddDays(1)).ToList();

            return View("~/Views/Todo/GetAll.cshtml", tomorrow);
        }
        public IActionResult Today()
        {
            var today = list.Where(t => t.DueDate == DateTime.Today).ToList();

            return View("~/Views/Todo/GetAll.cshtml", today);
        }
    }
}