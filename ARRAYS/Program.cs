namespace ARRAYS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = Console.ReadLine();
            int count = 0;

            for(int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a' || fullName[i] == 'e' || fullName[i] == 'i' || fullName[i] == 'o' || fullName[i] == 'u' ||
                    fullName[i] == 'A' || fullName[i] == 'E' || fullName[i] == 'I' || fullName[i] == 'O' || fullName[i] == 'U')
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}

//using for each method-task1

