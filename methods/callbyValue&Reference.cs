﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class callbyValue_Reference
    {
        static void Change1(int x)
        {
            x = 200;
            Console.WriteLine("Value of x in Change1 is " + x);
        }
        static void Change2(ref int x)
        {
            x = 300;
            Console.WriteLine("Value of x in Change2 is " + x);
        }


        static void Main()
        {
            int x = 100;
            Console.WriteLine("Value of x in Main before calling Change1 " + x);
            Change1(x);
            Console.WriteLine("Value of x in Main after calling Change1 " + x);
            Change2(ref x);
            Console.WriteLine("Value of x in Main after calling Change2 " + x);

        }
    }
}
