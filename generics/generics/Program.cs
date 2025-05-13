using System;
using Entities;
using generics.Interfaces;

class Program
{
    static void Main()
    {
        var fpm = new Faculty(1, "ФПМ");

        var kp41 = new Group(1, "КП-41");
        var kp42 = new Group(2, "КП-42");
        var kp43 = new Group(3, "КП-43");

        fpm.AddGroup(kp41);
        fpm.AddGroup(kp42);
        fpm.AddGroup(kp43);

        var s1 = new Student(1, "Смаль Софія");
        var s2 = new Student(2, "Кожина Зоряна");
        var s3 = new Student(3, "Олексій Сидоров");
        var s4= new Student(4,"Мороз Ганна");

        fpm.AddStudentToGroup(1, s1);
        fpm.AddStudentToGroup(1, s2);
        fpm.AddStudentToGroup(2, s3);
         fpm.AddStudentToGroup(2, s4);


        Console.WriteLine("Студенти групи КП-41:");
        foreach (var student in fpm.GetAllStudentsInGroup(1))
        {
            student.SayName();
        }

        Console.WriteLine("Студенти групи КП-42:");
        foreach (var student in fpm.GetAllStudentsInGroup(2))
        {
            student.SayName();
        }
         Console.WriteLine("Студенти групи КП-43");
        foreach (var student in fpm.GetAllStudentsInGroup(3))
       {
            student.SayName();
        }
        // Компілюється
        IRepository<Student, int> repo1 = new InMemoryRepository<Student, int>();

        // IRepository<int, int> repo2 = new InMemoryRepository<int, int>(); закоментовано оскільки не компілюється

        IReadOnlyRepository<Student,int> studRepo = new InMemoryRepository<Student,int>();
        IReadOnlyRepository<Person,int>  persRepo = studRepo;  // компілюється
    }
}
