using HackerRankProblems.Implementations;
using HackerRankTests.Infrostructure;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;

namespace HackerRankTests.Tests
{
    public class BonAppetitProblemTests: TestBase
    {
        [Test]
        [TestCase(new int [] { 3, 10, 2, 9 }, 1, 12, "5")]
        [TestCase(new int[] { 3, 10, 2, 9 }, 1, 7, "Bon Appetit")]
        public void BonAppetitTest(int [] bill, int k, int b, string expRes)
        {
            string actualResult;

            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                BonAppetitProblem.BonAppetit(bill.ToList(), k, b);

                actualResult = stringWriter
                    .ToString()
                    .Split(new string[] { "\r", "\n" }, StringSplitOptions.None)
                    .ToList()
                    .First();
            }

            Assert.AreEqual(expRes, actualResult);
        }
    }
}
