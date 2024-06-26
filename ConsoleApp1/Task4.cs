using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Task4
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number;

            if (int.TryParse(input, out number))
            {
                if (number <= 1)
                {
                    Console.WriteLine("Not a prime number");
                }
                else if (number == 2)
                {
                    Console.WriteLine("Prime number");
                }
                else
                {
                    bool isPrime = true;
                    for (int i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine("Prime number");
                    }
                    else
                    {
                        Console.WriteLine("Not a prime number");
                    }
                }
            }
            else
            {
                Console.WriteLine("The input is not a valid number.");
            }


        }
    }
}
