using Microsoft.EntityFrameworkCore;
using School.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Repositories
{
    public class SchoolContext: DbContext

    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
        // definirame tabeli
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }


    }
}
