using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
    public class AppleOrangeFall
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s">House left position</param>
        /// <param name="t">House right position</param>
        /// <param name="a">Apple tree position</param>
        /// <param name="b">Orange tree position</param>
        /// <param name="apples">Apples fall distance</param>
        /// <param name="oranges">Oranges fall distance</param>
        public static Tuple<int, int> CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int fallApplesCount = 0;
            int fallOrangesCount = 0;

            foreach (var apple in apples)
            {
                if (apple > 0 && (a + apple >= s && a + apple <= t))
                {
                    fallApplesCount++;
                }
            }

            foreach (var orange in oranges)
            {
                if (orange < 0 && (b + orange <= t && b + orange >= s))
                {
                    fallOrangesCount++;
                }
            }

            return new Tuple<int, int>(fallApplesCount, fallOrangesCount);
        }

    }
}
