using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class PartTimeClass : Employee
    {
        string Duration;
        int pay;
        public void getDetails()
        {
            base.getDetails();
            Console.WriteLine("Enter contratc duration");
            Duration = Console.ReadLine();
            Console.WriteLine("Enter pay of employee");
            pay = int.Parse(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Duration: {Duration} , pay: {pay}");
        }
    }
}
