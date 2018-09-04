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
            Console.WriteLine();
            Console.WriteLine("We can also find the length of a random integer.");
            Random rnd = new Random();
            int chosen = rnd.Next(1, 99999999);
            Console.Write("{0:N}", chosen);
            Console.WriteLine(" has " + Digits(chosen) + " digits.");
            Console.ReadLine();

            
        }
        private static int Digits(string result)
        {
            result = result.Replace(",", "");
            return result.Length;

        }
        private static int Digits(int chosen)
        {
            string number = chosen.ToString();
            return number.Length;
        }
    }
}
