using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class ParamsArray
    {
        static int Add(params int[] array)
        {
            int sum = 0;
            foreach(int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }

        static void Main()
        {
            Console.WriteLine(Add(1));
            Console.WriteLine(Add(10, 3, 4, 5, 4));
            Console.WriteLine(Add(1, 2, 3, 3, 4, 4, 5, 6, 7, 8, 9, 4, 4, 4, 4, 4, 4, 44, 4));

        }
    }
}
