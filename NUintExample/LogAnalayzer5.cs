using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public class LogAnalayzer5
    {

        private IWebService2 Service;
        private ILogger Logger;
        public int MinNameLength;
        public LogAnalayzer5(ILogger logger, IWebService2 service)
        {
            Logger = logger;
            Service = service;
        }

        public void Analayze(string fileName)
        {
            if(Path.GetFileNameWithoutExtension(fileName).Length < MinNameLength)
            {
                try
                {
                    Logger.LogError321(fileName);
                }catch(Exception e)
                {
                    Service.Write(new ErrorInfo { Severity = 1000, Message = "fake exception" });
                }
                
            }

        }



    }
}
