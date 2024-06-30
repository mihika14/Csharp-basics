using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class nameParameter
    {
        static void child(string child1 , string child2 , string child3)
        {
            Console.WriteLine($"Names of children are {child1}, {child2}, {child3}");
        }

        static void Main(string[] args)
        {
            child(child1: "John" , child2:"Jane" , child3:"Doe");
        }
    }
}
