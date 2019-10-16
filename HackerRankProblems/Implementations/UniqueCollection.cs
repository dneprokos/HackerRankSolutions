using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems
{
    public class UniqueCollection
    {
        public static IEnumerable<int> Merge(IEnumerable<int> a, IEnumerable<int> b)
        {
            IEnumerable<int> colA = a.Except(b);
            IEnumerable<int> colB = b.Except(a);

            return colA.Union(colB);
        }

        public static int LengthOfPositive(IEnumerable<int> input)
        {
            return input.SkipWhile(x => x < 0).TakeWhile(p => p > 0).Count();
        }
    }
}
