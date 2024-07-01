using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee
    {
        int id;
        string name;
        string address;

        public void getDetails()
        {
            Console.WriteLine("Enter empolyee id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter address");
            address = Console.ReadLine();
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"id; {id} , name: {name} , address: {address}");
        }

        public Employee() { }
        public Employee(int id , string name , string address)
        {
           this.id = id;
           this.name = name;
           this.address = address;
        }
    }
}
