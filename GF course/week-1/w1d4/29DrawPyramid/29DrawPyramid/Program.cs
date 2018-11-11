using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int j = i; j <= number; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i * 2; k++)
                {
                    if (k % 2 != 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

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


            Console.ReadLine();
        }
    }
}
