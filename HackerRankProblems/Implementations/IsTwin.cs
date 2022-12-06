using System;
using System.Linq;

namespace HackerRankProblems.Implementations
{
    public static class IsTwin
    {
        public static bool isTwinLogic(String value1, String value2)
        {
            if (value1.Length != value2.Length) return false;

            var wordA = value1.ToCharArray().ToList();
            var wordB = value2.ToCharArray().ToList();

            return wordA.Except(wordB).ToList().Count == 0;
        }
    }
}
