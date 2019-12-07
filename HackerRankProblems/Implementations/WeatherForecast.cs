using System;
using System.Linq;

namespace HackerRankProblems.Implementations
{
    public class WeatherForecast
    {
        public enum WeekDay
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }

        public static string GetDayWithTemperatureNearToWeekAverage(int [] weekdayTemperatures)
        {
            if (weekdayTemperatures.Length < 7 || weekdayTemperatures.Length > 7)
                throw new Exception("Array should contain 7 elements");
            
            var expectedDay = string.Empty;
            var minTempDiff = 0;
            int averageWeekTemp = weekdayTemperatures.Sum()/weekdayTemperatures.Count();

            for (int i = 0; i < weekdayTemperatures.Length; i++)
            {
                if (weekdayTemperatures[i] == averageWeekTemp)
                {
                    expectedDay = Enum.GetName(typeof(WeekDay), i);
                    Console.WriteLine("Target day: " + expectedDay);
                    return expectedDay;
                }

                int tempDiff = Math.Abs(averageWeekTemp - weekdayTemperatures[i]);
                if (i == 0) minTempDiff = tempDiff;
                else if (tempDiff < minTempDiff)
                {
                    minTempDiff = tempDiff;
                    expectedDay = Enum.GetName(typeof(WeekDay), i);
                } 
            }
            
            Console.WriteLine("Target day: " + expectedDay);
            return expectedDay;
        }
    }
}
