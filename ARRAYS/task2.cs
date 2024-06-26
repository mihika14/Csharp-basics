using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYS
{
    internal class task2
    {
        static void Main()
        {
            string fullName = Console.ReadLine();
            int count = 0;
            string fullName2 = fullName.ToUpper();

            foreach(char temp in fullName2)
            {
                if(temp.Equals('A') || temp.Equals('E') || temp.Equals('I') || temp.Equals('O') || temp.Equals('U'))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
