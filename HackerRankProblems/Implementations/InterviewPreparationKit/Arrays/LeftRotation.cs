namespace HackerRankProblems.Implementations.InterviewPreparationKit.Arrays
{
    public class LeftRotation
    {
        public static int[] RotLeft(int[] a, int d)
        {
            for (int i = 0; i < d; i++)
            {
                RotateOneLeft(a);
            }

            return a;
        }

        private static void RotateOneLeft(int [] a)
        {
            int first = a[0];
            for (int i = 0; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];
            }

            a[a.Length - 1] = first;
        }
    }
}
