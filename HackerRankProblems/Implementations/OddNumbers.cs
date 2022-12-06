using System.Collections.Generic;

namespace HackerRankProblems.Implementations
{
    public static class OddNumbers
    {
        static List<int> Find(int l, int r)
        {
            List<int> result = new List<int>();

            for (int i = l; i <= r; i++)
            {
                if (i % 2 != 0) result.Add(i);
            }

            return result;
        }
    }
}
