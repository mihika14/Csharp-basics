using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Take a name and split it into Array
namespace ARRAYS
{
    internal class task3
    {
        static void Main()
        {
            string name = Console.ReadLine();
            string[] array = name.Split();
            foreach (string part in array)
            {
                Console.WriteLine(part);
            }
        }
      
    }
}
