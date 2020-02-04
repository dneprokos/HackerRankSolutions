using System;

namespace HackerRankProblems.Implementations
{
    public class SockMerchantProblem
    {
        public static int SockMerchant(int n, int[] ar)
        {
            Array.Sort(ar);

            int count = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (ar[i] == ar[i+1])
                {
                    count++;
                    i += 1;
                }
            }
            return count;
        }
    }
}
