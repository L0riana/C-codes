using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.
            string number = Console.ReadLine();

            int nr = Convert.ToInt32(number);

            if (nr % 2 == 1)
            {
                Console.WriteLine("Odd");
            }
            else
            {
                Console.WriteLine("Even");
            }

            Console.ReadLine();
        }
    }
}
