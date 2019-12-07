using HackerRankProblems.Implementations;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class WetherForecastTests:TestBase
    {
        [Test]
        [TestCase(new int[] { 1, 2, 1, 1, 1, 1, 1 }, "Sunday")]
        [TestCase(new int[] { 3, 1, 0, 2, 1, 2, 5 }, "Wednesday")]
        [TestCase(new int[] { -1, 2, 2, 2, 2, 2, 2 }, "Monday")]
        [TestCase(new int[] { -1, 0, -1, 2, 2, 2, 2 }, "Monday")]
        [TestCase(new int[] { -3, -1, -2, -2, -2, -2, -2 }, "Tuesday")]
        [TestCase(new int[] { -3, -1, -2, 2, 2, 2, 2 }, "Monday")]
        [TestCase(new int[] { -5, 5, -5, 2, 2, 2, 2 }, "Wednesday")]
        public void GetDayWithTemperatureNearToWeekAverage_ShouldReturnDayString(int [] weekTemperature, string expectedDay)
        {
            //Arrange

            //Act
            string actualDay = WeatherForecast.GetDayWithTemperatureNearToWeekAverage(weekTemperature);

            //Assert
            Assert.AreEqual(expectedDay, actualDay);
        }
    }
}
