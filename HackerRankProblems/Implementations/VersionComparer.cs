using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems
{
    public static class VersionComparer
    {
        public static int Compare(string version1, string version2)
        {
            List<int> numbers1 = ConvertStringVersionToNumbersArray(version1);
            List<int> numbers2 = ConvertStringVersionToNumbersArray(version2);

            int loopCount = version1.Length >= numbers1.Count ? numbers1.Count : numbers2.Count;

            for (int i = 0; i < loopCount; i++)
            {
                if (numbers1[i] > numbers2[i])
                    return 1;
                if (numbers2[i] > numbers1[i])
                    return -1;

                if (numbers1[i + 1] < numbers1.Count && numbers2[i + 1] == numbers2.Count)
                    return 1;
                if (numbers1[i + 1] == numbers1.Count && numbers2[i + 1] < numbers2.Count)
                    return -1;
                if (numbers1[i + 1] == numbers1.Count && numbers2[i + 1] == numbers2.Count)
                    return 0;
            }
            return 0;
        }

        private static List<int> ConvertStringVersionToNumbersArray(string version1)
        {
            return version1.Split('.').Select(int.Parse).ToList();
        }

    }
}
