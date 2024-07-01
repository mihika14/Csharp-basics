namespace dynamicPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = null;
            Console.WriteLine("What type of employee");
            int ch = byte.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:

                    {
                        Console.WriteLine("Creating PartTime Emp");
                        employee = new PartTimeEmployee(); break;
                    }
                case 2:
                    {
                        Console.WriteLine("Creating FullTime Emp");
                        employee = new FullTimeEmployee(); break;
                    }
            }
            employee.GetDetails();
            employee.DisplayDetails();
        }
    }
}
