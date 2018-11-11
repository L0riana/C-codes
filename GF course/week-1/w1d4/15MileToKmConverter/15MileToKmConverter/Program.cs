using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it

            Console.WriteLine("Give me a number to convert to mile.");

            try
            {
                string km = Console.ReadLine();
                double miles = 0.621371192 * Convert.ToDouble(km);
                Console.WriteLine("in miles: " + miles);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("forever");
            }

            Console.ReadLine();

        }
    }
}
