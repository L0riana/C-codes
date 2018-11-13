using System;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `al` and assign the value `Greenfox` to it
            // - Create a function called `Greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Greenfox`
            // - Greet `al`

            string a1 = "Greenfox";
            Greet(a1);

            Console.ReadLine();
        }

        private static void Greet(string a1)
        {
            Console.WriteLine("Greetings dear, " + a1);
        }
    }
}
