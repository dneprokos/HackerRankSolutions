namespace HackerRankProblems.Implementations
{
    public class ParallelSums
    {
        //Input:1,2,3,4
        //Output:1,4,2,3
        //Input:1,2,1,5
        //Output:-1

        public static int[] ReturnIfParallel(int [] array)
        {
            var defaultResult = new[] { -1 };

            if (array.Length % 2 != 0)
                return defaultResult;

            return defaultResult;
        }
    }
}
