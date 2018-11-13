using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `Sum` that sums all the numbers
            //   until the given parameter and returns with an integer

            int upToInt = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(Sum(upToInt));
            Console.ReadLine();
        }

        private static int Sum(int upToInt)
        {
            int sum = 0;
            for (int i = 0; i <= upToInt; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
