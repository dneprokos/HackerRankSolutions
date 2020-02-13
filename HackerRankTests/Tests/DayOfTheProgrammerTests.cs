using HackerRankProblems.Implementations;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class DayOfTheProgrammerTests
    {
        [Test]
        [TestCase(1700, "12.09.1700")]
        [TestCase(2700, "13.09.2700")]
        [TestCase(1918, "26.09.1918")]
        [TestCase(2016, "12.09.2016")]    
        [TestCase(2018, "13.09.2018")]
        [TestCase(1800, "12.09.1800")]
        public void DayOfProgrammerTest(int year, string expectedResult)
        {
            //Arrange

            //Act
            string actual = DayOfTheProgrammer.DayOfProgrammer(year);

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [Test]
        [TestCase(1, 2020, "01.01.2020")]
        [TestCase(366, 2020, "31.12.2020")]
        [TestCase(365, 2019, "31.12.2019")]
        [TestCase(59, 2019, "28.02.2019")]
        [TestCase(60, 2020, "29.02.2020")]
        [TestCase(1, 1918, "01.01.1918")]
        [TestCase(366, 2019, "")]
        [TestCase(367, 2020, "")]
        [TestCase(0, 2020, "")]
        [TestCase(-1, 2020, "")]
        [TestCase(1, 1918, "01.01.1918")]
        [TestCase(32, 1918, "14.02.1918")]
        [TestCase(46, 1918, "28.02.1918")]
        [TestCase(47, 1918, "01.03.1918")]
        [TestCase(60, 1900, "29.02.1900")]
        [TestCase(60, 1889, "01.03.1889")]
        public void GetDateByDayNumberTest(int dayNumber, int year, string expectedResult)
        {
            //Arrange

            //Act
            string actual = DayOfTheProgrammer.GetDateByDayNumber(dayNumber, year);

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

    }
}
