using System;

namespace CSharpBasicsTraining
{
    public static class UserInput
    {
        public static void Run()
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
