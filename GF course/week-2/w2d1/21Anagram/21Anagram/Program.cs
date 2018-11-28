using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Anagram
{
    class Program
    {
        static void Main(string[] args)
        {

            String a = Console.ReadLine();
            String b = Console.ReadLine();

            if (IsAnagram(b, a))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            Console.ReadKey();
        }

        private static bool IsAnagram(string a, string b)
        {
            bool isAnagram = true;
            char[] c1 = a.ToCharArray();
            char[] c2 = b.ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);

            if (c1.Length != c2.Length)
            {
                isAnagram = false;
            }
            for (int i = 0; i < c1.Length; i++)
            {
                if (c1[i] != c2[i])
                {
                    isAnagram = false;

                }
            }
            return isAnagram;
        }
    }
}
