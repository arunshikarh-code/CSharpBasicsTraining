using System;

namespace CSharpBasicsTraining
{
    public static class FindLargestInArray
    {
        public static void Run()
        {
            Console.WriteLine("Enter integers separated by spaces:");
            var line = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(line)) { Console.WriteLine("No input"); return; }
            var parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out arr[i])) { Console.WriteLine("Invalid number"); return; }
            }
            int max = arr[0];
            foreach (var v in arr) if (v > max) max = v;
            Console.WriteLine($"Largest: {max}");
        }
    }
}
