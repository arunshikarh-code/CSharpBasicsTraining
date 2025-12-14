using System;

namespace CSharpBasicsTraining
{
    public static class SumFunction
    {
        public static int Sum(int a, int b) => a + b;

        public static void Run()
        {
            Console.Write("Enter first integer: ");
            if (!int.TryParse(Console.ReadLine(), out var a)) { Console.WriteLine("Invalid input"); return; }
            Console.Write("Enter second integer: ");
            if (!int.TryParse(Console.ReadLine(), out var b)) { Console.WriteLine("Invalid input"); return; }
            Console.WriteLine($"Sum: {Sum(a, b)}");
        }
    }
}
