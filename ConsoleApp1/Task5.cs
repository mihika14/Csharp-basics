using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Task5
    {

        static void Main()
        {

            int n = Convert.ToInt16(Console.ReadLine());
            int sum = 0;

            for (int i = n + 1; i <= n + 10; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);


        }
    }
}
