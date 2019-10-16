using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
    public static class GradingStudents
    {
        public static int[] Start(int[] grades)
        {
            int length = grades.Length;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                //If value less then 38 it should not be rounded
                if (grades[i] < 38)
                {
                   result[i] = grades[i];
                   continue;
                }
                else
                {
                    //Find next multiple on five
                    int nextMultipleOnFive = grades[i];
                    while (nextMultipleOnFive % 5 != 0)
                    {
                        nextMultipleOnFive += 1;
                    }


                    if (nextMultipleOnFive - grades[i] < 3)
                    {
                        result[i] = nextMultipleOnFive;
                    }
                    else
                    {
                        result[i] = grades[i];
                    }
                }              
            }

            return result;
        }
    }
}
