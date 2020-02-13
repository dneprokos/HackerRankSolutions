using System.Globalization;

namespace HackerRankProblems.Implementations
{
    public class DayOfTheProgrammer
    {
        #region Public methods

        public static string DayOfProgrammer(int year)
        {
            if (year == 1918) 
                return "26.09.1918";

            if (IsLeapYear(year))
            {
                return $"12.09.{year}";
            } 
            else
            {
                return $"13.09.{year}";
            }
        }

        public static string GetDateByDayNumber(int dayNumber, int year)
        {
            string date = string.Empty;
            bool isLeap = IsLeapYear(year);

            if (year == 1918)
            {
                string dateAndMonth = GetDateByDayAndMonthAtTransferYear(dayNumber);
                return $"{dateAndMonth}.{year}";
            }
                

            if ((isLeap && dayNumber > 366) 
                || (!isLeap && dayNumber > 365)
                || dayNumber < 1) 
                    return date;

            int[] daysPerMonth = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (isLeap)
                daysPerMonth[1] += 1;

            string dayAndMonth = CalculateAndReturnDayAndMonth(dayNumber, daysPerMonth);
            return dayAndMonth != string.Empty ? $"{dayAndMonth}.{year}": date;
        }

        #endregion

        #region Private methods

        private static string AddZeroChar(int value)
        {
            string result = value.ToString();
            if (result.Length < 2)
                result = "0" + value;

            return result;
        }

        /// <summary>
        /// 1918 year was a transfer year in Russia from Julian Calendar to Gregorian
        /// This year February was started from 14 and it wasn't a leap year
        /// </summary>
        /// <param name="dayNumber"></param>
        /// <returns></returns>
        private static string GetDateByDayAndMonthAtTransferYear(int dayNumber)
        {
            //If february 
            if (dayNumber > 31 && dayNumber < 47)
            {
                int dayDiff = 18;
                return $"{dayNumber - dayDiff}.02"; 
            }
            //If any execept february
            else
            {
                int[] daysPerMonth = new int[12] { 31, 15, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                return CalculateAndReturnDayAndMonth(dayNumber, daysPerMonth);
            }
        }

        private static bool IsLeapYear(int year) 
        {
            if (year >= 1919)
                //return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
                return new GregorianCalendar().IsLeapYear(year);
            if (year <= 1917)
               //return (year % 4 == 0);
               return new JulianCalendar().IsLeapYear(year, JulianCalendar.JulianEra);
            return false;           
        }

        private static string CalculateAndReturnDayAndMonth(int dayNumber, int[] daysPerMonth)
        {
            for (int i = 0; i < daysPerMonth.Length; i++)
            {
                if (dayNumber <= daysPerMonth[i])
                {
                    string dayNumberAsString = AddZeroChar(dayNumber);
                    string monthAsString = AddZeroChar(i + 1);

                    return $"{dayNumberAsString}.{monthAsString}";
                }
                dayNumber -= daysPerMonth[i];
            }
            return string.Empty;
        }

        #endregion
    }
}
