namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part time employee details");
            PartTimeClass partimeemployee = new PartTimeClass();
            partimeemployee.getDetails();
            partimeemployee.DisplayDetails();

            Console.WriteLine("Full time employee details");
            FullTimeEmployee fulltimeemployee = new FullTimeEmployee();
            fulltimeemployee.getDetails();
            fulltimeemployee.DisplayDetails();
        }
    }
}
