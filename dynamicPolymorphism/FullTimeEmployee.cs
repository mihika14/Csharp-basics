using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicPolymorphism
{
    internal class FullTimeEmployee : Employee
    {
        string dept;
        string manager;
        float salary;
        public override void GetDetails()
        //public void GetFullTimeEmployeeDetails()
        {
            base.GetDetails();
            Console.WriteLine("enter dept");
            dept = Console.ReadLine();

            Console.WriteLine("enter manager");
            manager = Console.ReadLine();
            Console.WriteLine("enter salary");
            salary = float.Parse(Console.ReadLine());
        }
       
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"dept is {dept}");
            Console.WriteLine($"manager is {manager}");
            Console.WriteLine($"salary is {salary}");
        }
        public FullTimeEmployee() : base() { }
        public FullTimeEmployee(int id, string name, string address,
            string manager, string dept, float salary)
            : base(id, name, address)
        {
            this.dept = dept;
            this.manager = manager;
            this.salary = salary;
        }

    }
}