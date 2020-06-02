using System;

namespace HackerRankProblems.Implementations.InterviewPreparationKit.Strings
{
    public class AlternatingCharactersChallenge
    {
        public static int AlternatingCharacters(string s)
        {
            int deletionsCount = 0;
            Char[] chars = s.ToCharArray();
            Char curChar = chars[0];

            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] == curChar) 
                {
                    deletionsCount += 1;
                }
                else
                {
                    curChar = chars[i];
                }

            }
            return deletionsCount;
        }

    }
}
