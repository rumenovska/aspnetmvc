using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class Todo
    {
        public string Title { get; set; }
        public string Dectription { get; set; }
        public DateTime DueDate { get; set; }

        

        public Todo (string title, string dectription, DateTime dueDate)
        {
            Title = title;
            Dectription = dectription;
            DueDate = dueDate;
        }
    }
}
