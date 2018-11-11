using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%%
            // %    %
            // %    %
            // %    %
            // %    %
            // %%%%%%
            //
            // The square should have as many lines as the number was

            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                if (i == 0 || i == number - 1)
                {
                    for (int j = 0; j < number; j++)
                        Console.Write("%");
                }
                else
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (j == 0 || j == number - 1)
                        {
                            Console.Write("%");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
