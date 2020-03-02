using System;
using System.Linq;

namespace HackerRankProblems.Implementations
{
    public class ElectronicsShop
    {
        public static int GetMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int sum = -1;

            keyboards = SortAndReverseArray(keyboards);
            drives = SortAndReverseArray(drives);

            for (int k = 0; k < keyboards.Length; k++)
            {
                if (keyboards[k] < b)
                {
                    for (int d = 0; d < drives.Length; d++)
                    {
                        int tempSum = keyboards[k] + drives[d];
                        if (tempSum <= b && tempSum > sum)
                        {
                            sum = tempSum;
                            break;
                        }
                    }
                }                 
            }
            return sum;
        }

        private static int [] SortAndReverseArray(int [] arr)
        {
            Array.Sort(arr);
            return arr.Reverse().ToArray();
        }
    }
}
