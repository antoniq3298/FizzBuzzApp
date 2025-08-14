using System;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string input = Console.ReadLine();

            var detector = new FizzBuzzDetector();
            var result = detector.GetOverlappings(input);

            Console.WriteLine("\nOutput string:");
            Console.WriteLine(result.Output);
            Console.WriteLine($"Count: {result.Count}");
        }
    }
}
