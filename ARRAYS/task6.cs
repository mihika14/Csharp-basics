using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYS
{
    internal class task6
    {
        static void Main()
        {
            string sentence = Console.ReadLine();
            string[] words = sentence.Split();
            string[] rev = words.Reverse().ToArray();
            string reversedSentence = string.Join(" ", rev);
            Console.WriteLine("Reversed Sentence: " + reversedSentence);
        }
    }
}
