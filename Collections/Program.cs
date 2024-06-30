namespace Collections
{
    internal class Program
    {
        static int[] num = new int[10] { 2, 4, 7, 9, 12, 13, 15, 0, 0, 0 };
        static void Main(string[] args)
        {
            string choice = "y";
            while (choice == "y")
            {
                int ch = Menu();
                switch (ch)
                {
                    case 1:
                        {
                            Console.WriteLine("enter element to insert");
                            int x = byte.Parse(Console.ReadLine());
                            Console.WriteLine(InsertElement(x));
                            break;
                        }
                    case 2:
                        {
                            PrintElements();
                            break;
                        }
                }
                Console.WriteLine("Repeat ? ");
                choice = Console.ReadLine();
            }
        }

        static int Menu()
        {
            Console.WriteLine("1. Insert Element");
            Console.WriteLine("2. PrintElements");
            Console.WriteLine("enter choice");
            int ch = byte.Parse(Console.ReadLine());
            return ch;
        }
        static int GetPosition0()
        {
            int i = 0;
            for (i = 0; i < num.Length; i++)
            {
                if (num[i] == 0)
                {
                    i = i;
                    break;
                }
            }
            return i;
        }
        static int InsertElement(int x)
        {
            int pos = 0;
            if (x <= num[0])
            {
                for (int i = GetPosition0(); i > 0; i--)
                {
                    num[i] = num[i - 1];
                }
                num[0] = x;
                return 0;
            }
            else if (x >= num[GetPosition0() - 1])
            {
                num[GetPosition0()] = x;
                return GetPosition0();
            }
            else
            {
                int j;
                for (j = 0; j < num.Length; j++)
                {
                    if (x >= num[j] && x < num[j + 1])
                    {
                        Console.WriteLine("j " + j + " num[j] " + num[j] + " num[j+1] " + num[j + 1]);

                        for (int i = GetPosition0(); i > j; i--)
                        {
                            num[i] = num[i - 1];
                        }
                        break;
                    }
                }
                num[j + 1] = x;
                return j + 1;
            }
        }


        static void PrintElements()
        {
            foreach (int i in num)
                Console.WriteLine(i);
        }
    }
}