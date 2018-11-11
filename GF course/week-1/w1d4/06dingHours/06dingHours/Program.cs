using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52

            int avg = 6;
            int sem = 17;

            int workdays = 5;

            Console.WriteLine(avg * sem * workdays);

            int avgWeekly = 52;

            Console.WriteLine((double) avg * workdays * 100 / avgWeekly);

            Console.ReadLine();
        }
    }
}
