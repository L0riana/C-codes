using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            double a = 30.5;
            double b = 40.5;
            double c = 50.5;

            Console.WriteLine("Surface Area: "+ Convert.ToInt32(2 * (a*b + b*c + a*c)));
            Console.WriteLine("Volume: " + Math.Round(a *b*c));

            Console.ReadLine();


        }
    }
}
