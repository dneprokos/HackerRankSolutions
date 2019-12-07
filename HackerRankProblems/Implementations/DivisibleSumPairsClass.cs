using System;

namespace HackerRankProblems.Implementations
{
    public static class DivisibleSumPairsClass
    {
        public static int DivisibleSumPairs(int k, int[] ar)
        {
            var count = 0;

            for (int i = 0; i < ar.Length - 1; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                {                 
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        Console.WriteLine($"({i},{j}) arr[{i}] + arr[{j}] = {ar[i]} + {ar[j]} = {ar[i] + ar[j]}");
                        count++;
                    }                     
                }               
            }

            return count;
        }
    }
}
