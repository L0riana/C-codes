using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 23;
            int currentMinutes = 59;
            int currentSeconds = 00;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables

            int secondsInADay = 60 * 60 * 24;

            Console.WriteLine(secondsInADay - currentHours * 60 * 60 - currentMinutes * 60 - currentSeconds);

            Console.ReadKey();
        }
    }
}
