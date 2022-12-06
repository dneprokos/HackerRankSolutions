using System.Collections.Generic;
using System.Linq;
using HackerRankProblems.Exceptions;

namespace HackerRankProblems.Implementations
{
    public static class TimeConversion
    {
        public static string ConvertToMillitaryFormat(string time)
        {
            string timeInMillitaryFormat = "";

            List<char> chars = time.ToCharArray().ToList();
            string lastSymbols = new string(chars.Skip(8).ToArray());

            string getFirstTwoSymbols = new string(chars.Take(2).ToArray());
            var firstAsInt = int.Parse(getFirstTwoSymbols);

            string secondPart = new string(chars.Skip(2).Take(6).ToArray());

            if (lastSymbols == "AM" && firstAsInt != 12)
            {
                timeInMillitaryFormat = time.Substring(0, 8);
            }
            else if (lastSymbols == "AM" && firstAsInt == 12)
            {
                timeInMillitaryFormat = "00" + secondPart;
            }
            else if (lastSymbols == "PM" && firstAsInt == 12)
            {
                timeInMillitaryFormat = firstAsInt.ToString() + secondPart;
            }
            else if (lastSymbols == "PM" && firstAsInt != 12)
            {
                timeInMillitaryFormat = (12 + firstAsInt).ToString() + secondPart;
            }
            else
            {
                string text = string.Format("Expected last symbols should be {0} or {1}, but was {2}", "AM", "PM", lastSymbols);
                throw new DateFormatNotFoundException(text);
            }
          
            return timeInMillitaryFormat;
        }

       
    }
}
