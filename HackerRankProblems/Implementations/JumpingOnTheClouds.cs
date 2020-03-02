namespace HackerRankProblems.Implementations
{
    public class JumpingOnTheClouds
    {
        public static int JumpingOnClouds(int[] c)
        {
            int jumps = 0;

            for (int i = 0; i < c.Length-1; i++)
            {
                if (i <= c.Length - 3 && c[i + 2] == 0)
                {
                    i++;
                }
                jumps++;
            }
            return jumps;
        }
    }
}
