using System;
using System.Collections.Generic;

namespace CSharpBasicsTraining
{
    public static class ListForeachExample
    {
        public static void Run()
        {
            var items = new List<string> { "apple", "banana", "cherry" };
            foreach (var it in items) Console.WriteLine(it);
        }
    }
}
