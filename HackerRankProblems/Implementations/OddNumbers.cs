using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
    public static class OddNumbers
    {
        static List<int> find(int l, int r)
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
