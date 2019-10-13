using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public class LogAnalyzer
    {
        public bool WasLastFileNameValid { get; set; }

        public bool IsValidLogFileName(string fileName)
        {


            WasLastFileNameValid = false;
            

            if(string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("Branac filename has to be provided Branko");
            }

            if(!fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
            {
                return false;
            }

            WasLastFileNameValid = true;
            return true;
        }

    }
}
