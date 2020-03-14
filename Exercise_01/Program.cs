using System;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = " ";
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Tere," + name);

            string age = " ";
            Console.WriteLine("Please enter your age:");
            age = Console.ReadLine();
            int b = int.Parse(age);
            int a = 100;
            Console.WriteLine(a - b + "years from now you will be 100 years old");
            Console.ReadLine();
        }
    }
}
