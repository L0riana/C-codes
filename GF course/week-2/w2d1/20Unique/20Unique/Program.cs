using System;
using System.Linq;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a method that takes an array of integers as a parameter
            //  Returns an array of integers where every integer occurs only once

            //  Example
            Console.WriteLine(Unique(new[] { 1, 11, 34, 11, 52, 61, 1, 34 }));
            //  should print: `[1, 11, 34, 52, 61]`
            Console.ReadLine();
        }

        private static int[] Unique(int[] v)
        {
            int[] unique = new int[v.Length];
            
            return unique;
        }
    }
}
