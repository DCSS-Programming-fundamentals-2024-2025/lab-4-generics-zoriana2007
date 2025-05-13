using System;

namespace Entities
{
    class Student : Person
    {
        public Student(int id, string name) : base(id, name) { }

        public Student():base(0,"None")
        {
            
        }

        public void SubmitWork()
        {
            Console.WriteLine($"{Name} здав(ла) роботу.");
        }

        public void SayName()
        {
            Console.WriteLine($"Мене звати {Name}");
        }
    }
}
