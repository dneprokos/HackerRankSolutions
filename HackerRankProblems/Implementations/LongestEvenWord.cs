using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems
{
   /* Consider a string, sentence, of space-separated words where each word is a substring consisting 
    * of English alphabetic letters only.We want to find the first word in sentence whose length 
    * is both even (i.e., contains an even number of characters) and greater than or equal to the length 
    * of any other word in the sentence.For example, if sentence is Time to write great code, 
    * then the word we’re looking for is Time because it’s the first word with a maximal even length; 
    * if sentence is Write code for a great time, then the word we’re looking for is code because it’s 
    * the first word with maximal even length.

      Complete the function from the provided code. It has one parameter: a string, sentence.
      The function must return a string denoting the longest even length word in sentence.
      If there are two such words having the maximum even length, return the word that appears first in 
      sentence; if none of the words in sentence are even in length, return 00 instead.
    */
    public static class LongestEvenWord
    {
        public static string Find(string sentence)
        {
            string expectedWord = "00";
            int maxEvenLength = 0;

            List<string> words = sentence.Split(' ').ToList();

            words.ForEach(word =>
            {
                int length = word.ToCharArray().Length;

                if (length > maxEvenLength && length % 2 == 0)
                {
                    maxEvenLength = length;
                    expectedWord = word;
                }
            });

            return expectedWord;
        }
    }
}
