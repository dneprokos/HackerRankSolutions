using HackerRankProblems;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class TimeConversionTests:TestBase
    {
        [Test]
        [TestCase("07:05:45AM", "07:05:45")]
        [TestCase("07:05:45PM", "19:05:45")]
        [TestCase("12:40:22AM", "00:40:22")]
        [TestCase("12:40:22PM", "12:40:22")]
        public void TimeConversionTest(string inputTime, string expectedFormat)
        {
            //Arrange

            //Act
            string outputTime = TimeConversion.ConvertToMillitaryFormat(inputTime);

            //Assert
            Assert.AreEqual(expectedFormat, outputTime);
        }
    }
}
