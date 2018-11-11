using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());

            if (first >= second)
            {
                Console.WriteLine("The second number should be bigger");

            }
            else
            {
                Console.WriteLine("first number: " + first + ", second number: " + second + ", should print: ");
                for (int i = first; i <= second; i++)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("solution 2");
            int one = Convert.ToInt32(Console.ReadLine());
            int two = Convert.ToInt32(Console.ReadLine());
            
            while (one >= two)
            {
                Console.WriteLine("The second number should be bigger. Give me your numbers:");
                one = Convert.ToInt32(Console.ReadLine());
                two = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = one; i <= two; i++)
            {
                Console.WriteLine(i);
            }
                Console.ReadLine();

        }
    }
}
