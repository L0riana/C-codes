using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `Factorio`
            //   that returns it's input's factorial

            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Factorio(input));

            Console.ReadLine();
        }

        private static int Factorio(int x)
        {
            int factorial = 1;
            for (int i = 2; i <= x; i++) {
                factorial *= i;
            }
            return factorial;
        }
    }
}
