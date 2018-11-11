using System;
using System.Collections;

namespace _1QueueStack
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primes = { 2, 3, 5, 7 };
            Stack s = new Stack();
            Queue q = new Queue();

            foreach (var n in primes)
            {
                s.Push(n);
                q.Enqueue(n);
            }

            foreach (var n in s)
            {
                Console.WriteLine("stack: " + n);
            }

            foreach (var n in q)
            {
                Console.WriteLine("queue: " + n);
            }

            Console.ReadLine();
        }
    }
}
