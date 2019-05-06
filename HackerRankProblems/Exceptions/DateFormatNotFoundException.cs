using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Exceptions
{
    public class DateFormatNotFoundException: Exception
    {
        public DateFormatNotFoundException()
        {
           
        }

        public DateFormatNotFoundException(string text): base(text)
        {

        }

        public DateFormatNotFoundException(string text, Exception inner) : base(text, inner)
        {

        }
    }
}
