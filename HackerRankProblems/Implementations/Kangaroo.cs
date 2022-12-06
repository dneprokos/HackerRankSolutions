namespace HackerRankProblems.Implementations
{
    public class Kangaroo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="v1"></param>
        /// <param name="x2"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static string CanMeetAtOnePoint(int x1, int v1, int x2, int v2)
        {
            if (v1 < v2) return "NO";

            while (x1 <= x2)
            {
                x1 += v1;
                x2 += v2;

                if (x1 == x2) return "YES";
            }

            return "NO";
        }
    }
}
