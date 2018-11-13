using System;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 8 };

            // Print the second element of the array
            Console.WriteLine(numbers[1]);

            // Print all the array elements
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }
    }
}
