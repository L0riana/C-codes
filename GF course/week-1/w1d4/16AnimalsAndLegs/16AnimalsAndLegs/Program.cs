using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            Console.WriteLine("Give me the number of chickens: ");
            string chicken = Console.ReadLine();
            int chickenLegs = Convert.ToInt32(chicken) * 2;

            Console.WriteLine("Give me the number of pigs: ");
            string pig = Console.ReadLine();
            int pigLegs = Convert.ToInt32(pig) * 4;

            int legsInTotal = chickenLegs + pigLegs;

            Console.WriteLine("the animals has this number of legs: " + legsInTotal);

            Console.ReadLine();
        }
    }
}
