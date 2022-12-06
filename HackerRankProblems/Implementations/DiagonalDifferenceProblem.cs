using System;

namespace HackerRankProblems.Implementations
{
    public static class DiagonalDifferenceProblem
    {
        public static int DiagonalDifference(int[][] arr)
        {
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            int j = arr.Length - 1;
            
            for (int i = 0; i < arr.Length; i++)
            {
                primaryDiagonal += arr[i][i];
                secondaryDiagonal += arr[j][i];
                j--;
            }
            
            return Math.Abs(primaryDiagonal - secondaryDiagonal);
        }
    }
}
