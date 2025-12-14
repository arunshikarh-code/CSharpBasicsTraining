using System;

namespace CSharpBasicsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- C# Basics Training ---");
                Console.WriteLine("1. Hello World First Program");
                Console.WriteLine("2. Basic Calculator");
                Console.WriteLine("3. User Input Demo");
                Console.WriteLine("4. Even/Odd Checker");
                Console.WriteLine("5. Print Numbers");
                Console.WriteLine("6. Find Largest In Array");
                Console.WriteLine("7. Sum Function Demo");
                Console.WriteLine("8. Student Class Example");
                Console.WriteLine("9. List & Foreach Example");
                Console.WriteLine("10. Exception Handling Demo");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": HelloWorld.Run(); break;
                    case "2": BasicCalculator.Run(); break;
                    case "3": UserInput.Run(); break;
                    case "4": EvenOddChecker.Run(); break;
                    case "5": PrintNumbers.Run(); break;
                    case "6": FindLargestInArray.Run(); break;
                    case "7": SumFunction.Run(); break;
                    case "8": StudentClassExample.Run(); break;
                    case "9": ListForeachExample.Run(); break;
                    case "10": ExceptionHandlingDemo.Run(); break;
                    case "0": return;
                    default: Console.WriteLine("Invalid option"); break;
                }
            }
        }
    }
}
