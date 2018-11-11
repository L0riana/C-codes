using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            Console.Write("How many number you want: ");

            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Give your number " + i + " : ");
                int x = Convert.ToInt32(Console.ReadLine());
                sum += x;
            }
            double avg = (double) sum / n;
            Console.WriteLine("Sum: " + sum + ", Average: " + avg);
            Console.ReadLine();
        }
    }
}
