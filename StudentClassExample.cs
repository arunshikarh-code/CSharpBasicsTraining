using System;

namespace CSharpBasicsTraining
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"Name: {Name}, Age: {Age}";
    }

    public static class StudentClassExample
    {
        public static void Run()
        {
            var student = new Student { Name = "Alice", Age = 20 };
            Console.WriteLine(student);
        }
    }
}
