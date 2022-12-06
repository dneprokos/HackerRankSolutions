using System;

namespace HackerRankProblems.Implementations
{
    public static class ExtensionExamples
    {
        public static string AddHelloToYourName(this String str)
        {
            return "Hello " + str;
        }

        public static Double DevideByTwo(this Double value)
        {
            return value / 2;
        }
    }
}
