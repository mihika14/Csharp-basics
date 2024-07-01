using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class FullTimeEmployee : Employee
    {
        string dept;
        string desgination;
        int salary;
        public void getDetails()
        {
            base.getDetails();
            Console.WriteLine("Enter Department");
            dept = Console.ReadLine();
            Console.WriteLine("Enter Designation");
            desgination = Console.ReadLine();
            Console.WriteLine("ENTER SALARY");
            salary = int.Parse(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"department:{dept} , Designation: {desgination} , salary: {salary}");
        }
    }
}
