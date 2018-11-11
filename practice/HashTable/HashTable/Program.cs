using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Monday");
            ht.Add(2, "Tuesday");
            ht.Add(3, "Wednesday");
            ht.Add(4, "Thursday");
            ht.Add(5, "Friday");
            ht.Add(6, "Saturday");
            ht.Add(7, "Sunday");

            ICollection key = ht.Keys;
            foreach (int k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }

            Console.ReadLine();
        }
    }
}
