namespace HackerRankProblems.Implementations
{
    public class CountingValleysProblem
    {
        public static int CountingValleys(int n, string s)
        {
            int volleys = 0;
            int level = 0;
            char[] steps = s.ToCharArray();

            foreach (var step in steps)
            {
                if (level == 0 && step.Equals('D'))
                {
                    volleys++;
                }
                if (step.Equals('D'))
                {
                    level--;
                }
                if (step.Equals('U'))
                {
                    level++;
                }
            }

            return volleys;
        }
    }
}
