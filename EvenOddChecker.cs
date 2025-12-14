using System;

namespace CSharpBasicsTraining
{
    public static class EvenOddChecker
    {
        public static void Run()
        {
            Console.Write("Enter an integer: ");
            if (!int.TryParse(Console.ReadLine(), out var n)) { Console.WriteLine("Invalid input"); return; }
            Console.WriteLine(n % 2 == 0 ? "Even" : "Odd");
        }
    }
}
