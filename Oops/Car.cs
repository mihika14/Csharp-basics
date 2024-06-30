using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Car
    {
        int sn;
        string brand;
        string name;
        int price;

        public void GetDetails()
        {
            Console.WriteLine("Enter Engine number");
            sn = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter brand name");
            brand = Console.ReadLine();
            Console.WriteLine("Enter name of car");
            name = Console.ReadLine();
            Console.WriteLine("Enter price of the car");
            price = byte.Parse(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Engine number is:{sn}");
            Console.WriteLine($"Brand Name is:{brand}");
            Console.WriteLine($"Car name is:{name}");
            Console.WriteLine($"Price of car is:{price}");
        }
    }
}
