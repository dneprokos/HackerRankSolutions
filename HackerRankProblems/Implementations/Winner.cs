using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems
{
    public static class Winner
    {
        public static string Calculate(string erica, string bob)
        {
            List<Char> ericaChars = erica.ToCharArray().ToList();
            List<Char> bobChars = bob.ToCharArray().ToList();

            int ericaScore = 0;
            int bobScore = 0;

            ericaChars.ForEach(sc =>
            {
                if (sc == 'E') ericaScore += 1;
                if (sc == 'M') ericaScore += 3;
                if (sc == 'H') ericaScore += 5;
            });

            bobChars.ForEach(sc =>
            {
                if (sc == 'E') bobScore += 1;
                if (sc == 'M') bobScore += 3;
                if (sc == 'H') bobScore += 5;
            });

            if (ericaScore > bobScore) return "Erica";
            if (ericaScore < bobScore) return "Bob";
            else return "Tie";
        }

    }
}
