using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class outputParameters
    {
        static void Operations(int a, int b,
            out int sum,
            out int difference,
            out int product,
            out float remainder)
        {
            sum = a + b;
            difference = b - a;
            product = a * b;
            remainder = a % b;
        }
        static void Main()
        {
            int sum, difference, product;
            float remainder;
            Operations(20, 10, out sum, out difference, out product, out remainder);
            Console.WriteLine($"Sum is {sum}\nDifference is {difference}\nProduct is {product}\nRemainder is {remainder}");
        }
    }
}
