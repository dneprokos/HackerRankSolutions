using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
    public static class DrawingBook
    {
        public static int PageCount(int n, int p)
        {
            int result = 0;
            if (p == 1 || p == n)
                return result;
            if (p == n - 1 && n % 2 == 0)
                return 1;
            if (p <= n/2)
            { 
                for (int i = 2; i <= p; i += 2)
                {
                    result++;                    
                }
                return result;
            }         
            else
            {
                int res = n % 2 == 0 ? n - 1 : n - 2;

                for (int i = res; i >= p; i -= 2)
                {
                    result++;
                }
                return result;
            }
        }
    }
}
