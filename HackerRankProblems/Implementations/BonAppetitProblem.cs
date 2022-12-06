using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Implementations
{
    public class BonAppetitProblem
    {
        public static string okResult = "Bon Appetit";

        public static void BonAppetit(List<int> bill, int k, int b)
        {
            bill.RemoveAt(k);
            int result = b - bill.Sum()/2;

            if (result == 0)
                Console.WriteLine(okResult);
            else
                Console.WriteLine(result);
        }

        public static void BonAppetit(int [] bill, int k, int b)
        {
            bill.ToList().RemoveAt(k);
            int result = b - bill.Sum() / 2;

            if (result == 0)
                Console.WriteLine(okResult);
            else
                Console.WriteLine(result);
        }
    }
}
