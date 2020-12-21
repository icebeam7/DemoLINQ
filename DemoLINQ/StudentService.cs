using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLINQ
{
    public static class StudentService
    {

        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student() { ID = 1, FirstName = "Ana", LastName = "Smith", Age = 25, Country = "Belgium"},
                new Student() { ID = 2, FirstName = "Brian", LastName = "McKenzie", Age = 20, Country = "Czech Republic"},
                new Student() { ID = 3, FirstName = "Luis", LastName = "Smith", Age = 30, Country = "Germany"},
                new Student() { ID = 4, FirstName = "Joachim", LastName = "Perez", Age = 25, Country = "Belgium"},
                new Student() { ID = 5, FirstName = "Bety", LastName = "Glesson", Age = 20, Country = "Austria"},
                new Student() { ID = 6, FirstName = "Teresa", LastName = "Smith", Age = 18, Country = "Germany"},
                new Student() { ID = 7, FirstName = "Michal", LastName = "Jones", Age = 22, Country = "Czech Republic"},
            };
        }
    }
}
