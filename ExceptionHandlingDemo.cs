using System;

namespace CSharpBasicsTraining
{
    public static class ExceptionHandlingDemo
    {
        public static void Run()
        {
            try
            {
                Console.Write("Enter a number to divide 100 by: ");
                if (!int.TryParse(Console.ReadLine(), out var x)) { Console.WriteLine("Invalid input"); return; }
                Console.WriteLine(100 / x);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
