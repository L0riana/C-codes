using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables
            int a = 123;
            int b = 526;

            int temp = a;

            a = b;

            b = temp;

            Console.WriteLine("a is: " + a);
            Console.WriteLine("b is: " + b);
           
            a = a + b;

            b = a - b;

            a = a - b;

            Console.WriteLine("a is: " + a);
            Console.WriteLine("b is: " + b);

            
            Console.ReadLine();

        }
    }
}
