using System.Collections.Generic;

namespace HackerRankProblems.Implementations
{
    public static class Staircase
    {
        public static IList<string> StaircaseSolution(int n)
        {
            IList<string> result = new List<string>();
            string space = " ";
            string hyphen = "#";

            for (int i = n - 1; i >= 0; i--)
            {
                string line = string.Empty;
                for (int j = 0; j < n; j++)
                {
                    if (j < i)
                    {
                        line += space;
                    }
                    else
                    {
                        line += hyphen;
                    }
                }

                result.Add(line);
            }

            return result;
        }
    }
}
