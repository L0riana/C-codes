using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            double sum = 0;
            int upTo = 5;

            for (int i = 0; i < upTo; i++)
            {
                string x = Console.ReadLine();
                double y = Convert.ToDouble(x);
                
                sum += y;

            }
            Console.WriteLine("Sum: "+ Convert.ToInt32(sum));
            Console.WriteLine("Average: " + sum/upTo);

            Console.ReadLine();
        }
    }
}
