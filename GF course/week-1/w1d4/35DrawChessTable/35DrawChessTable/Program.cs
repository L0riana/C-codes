using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //

            int lines = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                for (int j = 1; j <= lines; j++)
                {
                    if (i % 2 == 1)
                    {
                        if (j % 2 == 1)
                        {
                            Console.Write("%");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (j % 2 == 0)
                    {
                        Console.Write("%");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
