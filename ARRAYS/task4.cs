using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Count no. of characters in the sentence

namespace ARRAYS
{
    internal class task4
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int count = 0;
            foreach(char temp in word)
            {
                if (!char.IsWhiteSpace(temp))
                {
                    count++;
                }
               
            }
            Console.WriteLine(count);
        }  
    }
}
