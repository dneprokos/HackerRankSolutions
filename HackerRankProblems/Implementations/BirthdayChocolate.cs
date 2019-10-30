using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Implementations
{
    public class BirthdayChocolate
    {
        public static int Birthday(List<int> s, int d, int m)
        {
            int ways = 0;
            int maxLength = s.Count == 1 ? 1 : s.Count - m + 1;

            for (int i = 0; i < maxLength; i++)
            {
                var sum = 0;
                for (int k = i; k < i + m; k++)
                {
                    sum += s[k];
                }

                if (sum == d) ways++; 
            }

            return ways;
        }
    }
}
