public class Solution
{
    public int solution(int K, int[] A)
    {
        int N = A.Length;
        int count = 0;
        int left = 0;
        int right = 0;
        int max = A[0];
        int min = A[0];

        while (right < N)
        {
            while (right < N)
            {
                if (A[right] > max)
                {
                    max = A[right];
                }
                if (A[right] < min)
                {
                    min = A[right];
                }

                if (max - min <= K)
                {
                    count += (right - left + 1);
                    right++;
                }
                else
                {
                    break;
                }
            }
            if (right < N && left <= right)
            {
                left++;
                if (left < N)
                {
                    max = A[left];
                    min = A[left];
                    for (int i = left; i <= right; i++)
                    {
                        if (A[i] > max)
                        {
                            max = A[i];
                        }
                        if (A[i] < min)
                        {
                            min = A[i];
                        }
                    }
                }
            }
        }
        return count > 1_000_000_000 ? 1_000_000_000 : count;
    }

    public static void Main(String[] args)
    {
        Solution sol = new Solution();

        int K = 2;
        int[] A = { 3, 5, 7, 6, 3 };

        int result = sol.solution(K, A);

        Console.WriteLine("Number of bounded slices: " + result);
    }
}
