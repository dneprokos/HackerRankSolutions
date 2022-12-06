using System.Linq;

namespace HackerRankProblems.Implementations
{
    public class BirthdayCakeCandles
    {
        public static int getTallestCandles(int[] ar)
        {
            int maxValue = ar.Max();
            int tallestCount = 0;
            tallestCount = ar.Where(v => v == maxValue).ToList().Count;

            return tallestCount;
        }
    }
}
