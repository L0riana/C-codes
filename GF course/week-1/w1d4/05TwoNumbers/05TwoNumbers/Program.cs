using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints a few operations on two numbers: 22 and 13

            int a = 22;
            int b = 13;

            // Print the result of 13 added to 22

            Console.WriteLine(a + b);

            // Print the result of 13 substracted from 22

            Console.WriteLine(a - b);

            // Print the result of 22 multiplied by 13

            Console.WriteLine(a * b);

            // Print the result of 22 divided by 13 (as a decimal fraction)

            Console.WriteLine((double) a / b);

            // Print the integer part of 22 divided by 13

            Console.WriteLine(a / b);

            // Print the reminder of 22 divided by 13

            Console.WriteLine(a % b);

            Console.ReadLine();
        }
    }
}
