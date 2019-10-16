using System.Collections.Generic;
using System.Linq;


namespace HackerRankProblems
{
    public static class FindNumber
    {
        public static string Find(List<int> array, int searchCriteria)
        {
            return array.Any(el => el == searchCriteria) ? "YES" : "NO";
        }
    }
}
