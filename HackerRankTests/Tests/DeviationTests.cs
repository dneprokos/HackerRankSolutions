using HackerRankProblems.Implementations;
using HackerRankTests.Infrostructure;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerRankTests.Tests
{
    /*
     Create tests(using REST API) for:
GET: https://www.random.org/integers/?num=1&min=1&max=1&col=1&base=10&format=plain&rnd=new  
To check the following hypothesis: "For large number of rolls (number of rolls > 1000) distribution of dice points strives to uniform distribution." 
Requirements: tests should check that maximum deviation of dice results is within 5% First test: for 1 dice Second test: for 2 dices (total roll points is a sum of 2 dices)

Hint 1: try 1000, 5000, 10000 number of rolls and see how distribution changes 
Hint 2: think about how to implement the solution in the most efficient way
     */ 

    public class DeviationTests: TestBase
    {
        [Test]
        [TestCase(1000, 1, 6, 1)]
        [TestCase(5000, 1, 6, 1)]
        [TestCase(10000, 1, 6, 1)]
        [TestCase(1000, 1, 6, 2)]
        [TestCase(5000, 1, 6, 2)]
        [TestCase(10000, 1, 6, 2)]
        public async Task CalculateDiceDeviationTestAsync(int num, int min, int max, int col) 
        {
            var service = new RandomIntegersService();
            string content = await service.GetRandomIntegersAsync(num, min, max, col);

            IEnumerable<int> numbers = ConvertStringToNumbers(content);
            double deviation = Deviation.Calculate(numbers);

            Assert.True(deviation <= 5.0);
        }

        private IEnumerable<int> ConvertStringToNumbers(string content)
        {
            List<string> stringArr = content
                .Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            if (stringArr[0].Contains("\t"))
            {
                var finalNumbers = new List<int>();
                stringArr.ForEach(el =>
                {
                    string [] nestedSplit = el.Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                    int sum = nestedSplit.Select(x => int.Parse(x)).Sum();
                    finalNumbers.Add(sum);
                });
                return finalNumbers;
            }
            return stringArr.Select(el => int.Parse(el)).ToList();
        }
    }
}
