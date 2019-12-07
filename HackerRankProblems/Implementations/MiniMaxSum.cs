using System;
using System.Collections.Generic;

namespace HackerRankProblems
{
    public static class MiniMaxSum
    {
        public static List<long> MiniMaxSumSolution(int[] arr)
        {
            Array.Sort(arr);

            long minSum = 0;
            long maxSum = 0;

            for (int i = 0; i <= arr.Length - 2; i++)
            {
                minSum += arr[i];
            }

            for (int i = 1; i <= arr.Length - 1; i++)
            {
                maxSum += arr[i];
            }

            List<long> result = new List<long>();
            result.Add(minSum);
            result.Add(maxSum);

            return result;
        }
    }
}
