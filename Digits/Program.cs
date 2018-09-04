using System;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string result = Console.ReadLine();
            
            Console.WriteLine("Your number {0} has {1} digits", result, Digits(result));
            Console.ReadLine();
        }
        private static int Digits(string result)
        {
            result = result.Replace(",", "");
            result = result.Replace(".", "");
            return result.Length;

        }
    }
}
