using System;

namespace CSharpBasicsTraining
{
    public static class BasicCalculator
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out var a)) { Console.WriteLine("Invalid input"); return; }
            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out var b)) { Console.WriteLine("Invalid input"); return; }

            Console.WriteLine($"Add: {a + b}");
            Console.WriteLine($"Subtract: {a - b}");
            Console.WriteLine($"Multiply: {a * b}");
            if (b != 0) Console.WriteLine($"Divide: {a / b}"); else Console.WriteLine("Divide: undefined (division by zero)");
        }
    }
}
