using System;
using System.Collections.Generic;
namespace Entities
{
class Teacher:Person
    {
       public Teacher(int id, string name) : base(id, name) { }
        public void GradeStudent( Student name)
        {
          Console.WriteLine($"Вчитель {Name} оцінив роботу студента {name}");
        }
        public void ExpelStudent( Student name)
        {
          Console.WriteLine($"Вчитель{Name} відрахував студента {name}");
        }
        public void ShowPresentStydents(IEnumerable<Student> students)
        {
          Console.WriteLine($"Поточні студенти");
          foreach (var s in students)
                Console.WriteLine($"- {s.Name}");
        }
    }
}