using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A 

            string number = Console.ReadLine();

            int nr = Convert.ToInt32(number);

            if (nr <= 0)
            {
                Console.WriteLine("Not enough");
            }
            else if (nr == 1)
            {
                Console.WriteLine("One");
            }
            else if (nr == 2)
            {
                Console.WriteLine("Two");
            }
            else
            {
                Console.WriteLine("A");
            }

            Console.ReadLine();
        }
    }
}
