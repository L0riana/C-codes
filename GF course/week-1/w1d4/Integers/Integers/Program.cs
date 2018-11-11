using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(42);

            Console.WriteLine(3.1415);

            // maximum and minimum value
            // a simple integer is represented in 4 bytes (32bit)

            // maximum value:  2 147 483 647

            int x = 2147483647;
            //int x = 2147483648; -> cannot convert

            Console.WriteLine(x);

            // minimum value: -2 147 483 648
            Console.WriteLine(-2147483648);

            

            Console.ReadLine();
        }
    }
}
