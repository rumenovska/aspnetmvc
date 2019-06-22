using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContex contex)
        {
            contex.Database.EnsureCreated();

            if (contex.Students.Any())
                return;
            var students = new Student[]
            {
               new Student {FirstMidName= "Marija", LastName= "Rumenovska", EnrollmentDate= DateTime.Now },
               new Student {FirstMidName= "Frosina", LastName= "Rumenovska", EnrollmentDate= DateTime.Now },
               new Student {FirstMidName= "Dejan", LastName= "Rumenovska", EnrollmentDate= DateTime.Now }
               


            };
            foreach (var student in students)
            {
                contex.Students.Add(student);
            }

            var courses = new Course[]
            {
                new Course{Title= "Chemistry", Credits= 3 },
                new Course{Title= "Math", Credits= 5 },
                new Course{Title= "Micro", Credits= 4 },
            };
            foreach (var course in courses)
            {
                contex.Courses.Add(course);
            }

            var enrollments = new Enrollment[]
            {
                new Enrollment{Student= students.ElementAt(0), Course= courses.ElementAt(0), Grade=Grade.A},
                new Enrollment{Student= students.ElementAt(0), Course= courses.ElementAt(1), Grade=Grade.D},
                new Enrollment{Student= students.ElementAt(0), Course= courses.ElementAt(2), Grade=Grade.A},
                new Enrollment{Student= students.ElementAt(1), Course= courses.ElementAt(0), Grade=Grade.B},
                new Enrollment{Student= students.ElementAt(1), Course= courses.ElementAt(1), Grade=Grade.C},
                new Enrollment{Student= students.ElementAt(1), Course= courses.ElementAt(2), Grade=Grade.A},
                new Enrollment{Student= students.ElementAt(2), Course= courses.ElementAt(0), Grade=Grade.A},
                new Enrollment{Student= students.ElementAt(2), Course= courses.ElementAt(1), Grade=Grade.A},
                new Enrollment{Student= students.ElementAt(2), Course= courses.ElementAt(2), Grade=Grade.A},
                new Enrollment{Student= students.ElementAt(3), Course= courses.ElementAt(0), Grade=Grade.A},
                new Enrollment{Student= students.ElementAt(3), Course= courses.ElementAt(1), Grade=Grade.A},
                new Enrollment{Student= students.ElementAt(3), Course= courses.ElementAt(2), Grade=Grade.A}

            };

            foreach (var enroll in enrollments)
            {
                contex.Enrollments.Add(enroll);
            }

            contex.SaveChanges();
        }
    }
}
