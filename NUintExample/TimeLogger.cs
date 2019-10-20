using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public static class TimeLogger
    {
        public static string CreateMessage(string info)
        {
            //Production code that uses SystemTime
            return SystemTime.Now.ToShortDateString() + " " + info;
        }
    }
}
