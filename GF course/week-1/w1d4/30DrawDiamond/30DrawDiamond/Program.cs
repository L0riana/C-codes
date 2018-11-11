using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

          
            Console.WriteLine("Enter your number here: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                for (int j = number - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = (i * 2) - 1; k > 0; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = number - 1; i > 0; i--)
            {
                for (int j = i; j < number; j++)
                {
                    Console.Write(" ");
                }
                for (int k = (i * 2) - 1; k > 0; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}