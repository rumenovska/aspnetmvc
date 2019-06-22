using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Pizza
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        [MinLength(10)]
        public string Dectription { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public bool IsGlutenFree { get; set; }
        [Required]
        [Range(10, 500)]
        public double Price { get; set; }
    }
}
