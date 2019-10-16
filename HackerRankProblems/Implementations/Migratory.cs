using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems
{
    public static class Migratory
    {
        public static int MigratoryBirds(List<int> arr)
        {
            int[] tempBirds = new int[5];

            foreach (var bird in arr)
            {
                switch (bird)
                {
                    case 1:
                        tempBirds[0]++;
                        break;
                    case 2:
                        tempBirds[1]++;
                        break;
                    case 3:
                        tempBirds[2]++;
                        break;
                    case 4:
                        tempBirds[3]++;
                        break;
                    case 5:
                        tempBirds[4]++;
                        break;
                    default:
                        break;
                }
            }

            return tempBirds.ToList().IndexOf(tempBirds.Max()) + 1;
        }
    }
}
