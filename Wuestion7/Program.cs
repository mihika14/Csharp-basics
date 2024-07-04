namespace Wuestion7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -2,-3 ,5, 6, 7, 10 };
            Console.WriteLine("Original Array:");
            PrintArray(arr);

            int smallestSquare = SquareOfSmallest(arr);
            Console.WriteLine($"{smallestSquare}");
        }
        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static int SquareOfSmallest(int[] arr)
        {
            if (arr.Length == 0) return 0;

            int smallest = arr[0]; 
            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] < 0) continue;
                
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }

            int square = smallest * smallest;
            return square;
        }
    }
}
