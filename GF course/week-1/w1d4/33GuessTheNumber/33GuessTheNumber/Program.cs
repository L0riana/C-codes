using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            Random r = new Random();
            int n = r.Next(0, 100);

            int attempt = 0;
            int chance = 10;
            int userInput = Convert.ToInt32(Console.ReadLine());

            while (userInput != n && attempt < chance-1)
            {
                if (userInput > n)
                {
                    Console.WriteLine("The stored number is lower");
                    attempt++;
                }
                else
                {
                    Console.WriteLine("The stored number is higher");
                    attempt++;
                }
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            if (userInput == n && attempt < chance-1)
            {
                Console.WriteLine("You found the number: " + n + ". Congrats!");
            }
            else
            {
                Console.WriteLine("You haven't found the number. Restart if you want to play again.");
            }
            Console.ReadLine();
        }        
    }
}
