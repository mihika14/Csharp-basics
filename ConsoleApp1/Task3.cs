using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Task3
    {
        static void Main()
        {

            Console.Write("Enter a character: ");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine();


            if ("AEIOUaeiou".IndexOf(inputChar) >= 0)
            {
                Console.WriteLine("Vowel");
            }

            else if (Char.IsLetter(inputChar))
            {
                Console.WriteLine("Consonant");
            }

            else if (Char.IsDigit(inputChar))
            {
                Console.WriteLine("Digit");
            }

            else
            {
                Console.WriteLine("Special character");
            }
        }
    }
}

