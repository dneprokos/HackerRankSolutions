using System;
using System.Linq;

namespace HackerRankProblems.Implementations
{
    public class RepeatedStringChalange
    {
        public static long RepeatedString(string s, long n)
        {
            if (s.Equals("a"))
                return n;
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);

            long index = charArray.ToList().LastIndexOf('a');
            long aCount =  index + 1;

            long mainChars = n / s.Length;
            long leftChars = n - mainChars * s.Length;

            long result = aCount * mainChars;

            string subString = s.Substring(0, leftChars);

            char[] charArray2 = subString.ToCharArray();
            Array.Sort(charArray2);
            long aCount2 = charArray2.ToList().LastIndexOf('a') + 1;

            return result += aCount2;
        }
    }
}
