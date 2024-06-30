using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class methodOverloading
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Add(params int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }
        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        static float Add(int a, float b)
        {
            return a + b;
        }
        static float Add(float a, int b)
        {
            return a + b;
        }
        static string Add(string a, string b)
        {
            return string.Concat(a, " ", b);
        }
        static void Main()
        {
            Console.WriteLine(Add(4, 4));
            Console.WriteLine(Add(9, 0, 3));
            Console.WriteLine(Add(9, 3.5f));
            Console.WriteLine(Add("a", "b"));
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6, 6, 7, 7, 8, 8));

        }

    }
}
