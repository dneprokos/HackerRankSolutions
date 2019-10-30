using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Implementations
{
    public class BreackingRecords
    {
        public static int[] BreakingRecords(int[] scores)
        {
            int[] records = new int[2] { 0, 0 };

            int minScore = scores[0]; 
            int maxScore = scores[0];

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > maxScore)
                {
                    maxScore = scores[i];
                    records[0]++;
                    continue;
                }
                if (scores[i] < minScore)
                {
                    minScore = scores[i];
                    records[1]++;
                }
            }
            return records;
        }
    }
}
