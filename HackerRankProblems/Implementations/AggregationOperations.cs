using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Implementations
{
    public class AggregationOperations
    {
        public static int Poly(int x, IEnumerable<int> coeffs)
        {
            var items = coeffs.ToList();
            var order = items.Count - 1;
            return coeffs.Aggregate(0, (p, c) => p + c * (int)Math.Pow(x, order--));
        }
    }
}
