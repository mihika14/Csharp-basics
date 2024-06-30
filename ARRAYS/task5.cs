using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYS
{
    internal class task5
    {
        static void Main()
        {
            string sentence = Console.ReadLine();
            string[] newSentence = sentence.Split();
            int count = newSentence.Length;
            Console.WriteLine(count);
        }
    }
}
