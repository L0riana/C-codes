using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one

            string a = Console.ReadLine();
            string b = Console.ReadLine();
                        
            int x = Convert.ToInt32(a);

            int y = Convert.ToInt32(b);

            if (x > y)
            {
                Console.WriteLine("bigger: " + x);
            }
            else if (x < y)
            {
                Console.WriteLine("bigger: " + y);
            }
            else
            {
                Console.WriteLine("equal");
            }

            Console.ReadLine();
        }
    }
}
