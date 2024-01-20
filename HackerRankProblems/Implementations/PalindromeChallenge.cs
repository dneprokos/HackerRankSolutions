using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Implementations
{
     public static class PalindromeChallenge
     {
         private static List<char> _skipSymbols = new List<char>
         {
             '.', ',', '!', '?', ' '
         };

        //"Mr. Owl ate my metal worm",
        //"Do geese see God?", or
        //"Was it a car or a cat I saw?".
        //Punctuation, capitalization, and spaces are usually ignored.
        //Some, such as
        //"Rats live on no evil star",
        //"Live on time, emit no evil", and
        //"Step on no pets", include the spaces.

        public static bool IsPalindromeSentence(string sentence, bool isCaseSensitive)
        {
            // Remove all skip symbols and optionally convert to the same case
            string cleanedSentence = new string(sentence
                .Where(c => !_skipSymbols.Contains(c))
                .ToArray());

            if (!isCaseSensitive)
            {
                cleanedSentence = cleanedSentence.ToLowerInvariant();
            }

            // Check if the cleaned sentence is a palindrome
            for (int i = 0, j = cleanedSentence.Length - 1; i < j; i++, j--)
            {
                if (cleanedSentence[i] != cleanedSentence[j])
                {
                    return false;
                }
            }

            return true;
        }
     }
}
