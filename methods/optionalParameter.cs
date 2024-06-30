using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class optionalParameter
    {
        static void Profit(int SI, int CI = 450)
        {
            int gain = SI - CI;
            Console.WriteLine(gain);
        }

        static void Main(string[] args)
        {
            Profit(550);
        }
    }
}
