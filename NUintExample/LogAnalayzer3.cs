using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public class LogAnalayzer3
    {
        private ILogger logger;

        public int MinNameLength;

        public LogAnalayzer3(ILogger logger)
        {
            this.logger = logger;
        }

        public void Analayze(string fileName)
        {

            if(Path.GetFileNameWithoutExtension(fileName).Length < MinNameLength)
                logger.LogError321("Filename too short: "+fileName);
        }



    }
}
