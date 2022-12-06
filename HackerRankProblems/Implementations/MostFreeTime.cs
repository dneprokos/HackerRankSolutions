using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Implementations
{
    public class MostFreeTime
    {
        public static string GetLongestPeriodBetweenSchedules(string[] schedule)
        {
            TimeSpan longestPeriod = default;
            var periods = new Dictionary<DateTime, DateTime>();

            foreach (var period in schedule)
            {
                var twoPeriods = period.Split('-');

                var time1 = twoPeriods[0];
                var time2 = twoPeriods[1];

                var parsedStartTime = DateTime.Parse(time1);
                var parsedEndTime = DateTime.Parse(time2);

                periods.Add(parsedStartTime, parsedEndTime);
            }

            var orderedPeriods = periods
                .OrderBy(d => d.Key)
                .ToList();

            for (int i = 0; i < orderedPeriods.Count -1; i++)
            {
                var currentPeriod = orderedPeriods[i + 1].Key - orderedPeriods[i].Value;

                if (longestPeriod < currentPeriod)
                    longestPeriod = currentPeriod;
            }

            var hoursAsString = longestPeriod.Hours.ToString();
            var minutesAsString = longestPeriod.Minutes.ToString();

            if (hoursAsString.Length == 1)
                hoursAsString = $"0{hoursAsString}";
            if (minutesAsString.Length == 1)
                minutesAsString = $"0{minutesAsString}";
            
            return $"{hoursAsString}:{minutesAsString}";
        }
    }
}
