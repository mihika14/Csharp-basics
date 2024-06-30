namespace Oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.GetDetails();
            car.DisplayDetails();


            //array of details
            Car[] cars = new Car[10];

            for (int i = 0; i < 5; i++)
            {
                cars[i] = new Car();
                Console.WriteLine("Enter Details" + i + 1);
                cars[i].GetDetails();
            }

            Console.WriteLine("Details of Students");
            foreach (Car temp in cars)
            {
                if(temp != null)
                temp.DisplayDetails();
            }
        }
    }
       
}
