using System;

namespace Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "8";
            Console.WriteLine("What number am I thinking of between 1 and 10?");
            string b = Console.ReadLine();
            if (b == a)
            {
                Console.WriteLine("Yes! You were correct! My number was " + a);
            }
            else 
            {
                Console.WriteLine("No " + b + " wasn't my number.");
            }
            Console.ReadLine();
        }
    }
}
