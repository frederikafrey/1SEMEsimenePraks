using System;

namespace Exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis koolis sa õpid?");
            Console.WriteLine("1. Tartu Ülikoolis");
            Console.WriteLine("2. Tallinna Ülikoolis");
            Console.WriteLine("3. TalTechis");
 
            string correctAnswer = "3";

            string d = Console.ReadLine();
            if (d == correctAnswer)
            {
                Console.WriteLine("Õige vastus");
            }
            else
            {
                Console.WriteLine("Pange panid, õige on " + correctAnswer + ".");
            }
            Console.ReadLine();
        }
    }
}
