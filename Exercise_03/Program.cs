using System;

namespace Exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number between 1 and 10?");
            string a = Console.ReadLine();
            int b = int.Parse(a);
            if (b > 0 && b < 11)
            {
                Console.WriteLine("Thanks");
            }
            else
            {
                Console.WriteLine(b + " is not between 1 and 10.");
            }
            Console.ReadLine();
        }
    }
}
