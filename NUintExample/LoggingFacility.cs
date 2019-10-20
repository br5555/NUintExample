using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public static class LoggingFacility
    {

        private static ILogger logger;

        public static void Log(string text)
        {
            logger.LogError321(text);    
        }

        public static ILogger Logger
        {
            get { return logger; }
            set { logger = value; }
        }
    }
}
