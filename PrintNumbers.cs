using System;

namespace CSharpBasicsTraining
{
    public static class PrintNumbers
    {
        public static void Run()
        {
            Console.Write("Enter count: ");
            if (!int.TryParse(Console.ReadLine(), out var count) || count < 1) { Console.WriteLine("Invalid input"); return; }
            for (int i = 1; i <= count; i++) Console.WriteLine(i);
        }
    }
}
