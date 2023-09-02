using System;
using System.Globalization;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myString = "This is a string";

            Console.WriteLine($"String Length: { myString.Length}");

            Console.WriteLine($"String Contains is: {myString.Contains("is")}");

            Console.WriteLine($"Index of is: {myString.IndexOf("is")}");

            Console.WriteLine($"Remove String: {myString.Remove(10, 6)}");

            Console.WriteLine($"Insert String: {myString.Insert(10, "short ")}");

            Console.WriteLine($"Replace String: {myString.Replace("string", "sentence")}");

            Console.WriteLine($"Compare A to B: {String.Compare("A", "B", StringComparison.OrdinalIgnoreCase)}");

            Console.WriteLine($"A = a: {String.Equals("A", "a", StringComparison.OrdinalIgnoreCase)}");

            Console.WriteLine($"Pad Left: {myString.PadLeft(20, '.')}");

            Console.WriteLine($"Pad Right: {myString.PadRight(20, '.')}");

            Console.WriteLine($"Trim: {myString.Trim()}");

            Console.WriteLine($"Uppercase: {myString.ToUpper()}");

            Console.WriteLine($"Lowercase: {myString.ToLower()}");













            Console.ReadLine();
        }
    }
}