using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public class LogAnalayzer4
    {
        public IWebService Service { get; set; }

        public ILogger Logger { get; set; }

        public LogAnalayzer4(IWebService service, ILogger logger)
        {
            Service = service;
            Logger = logger;
        }

        public void Analayze(string filename)
        {
            try
            {
                Logger.LogError321("Filename too short:" + filename);
            }
            catch (Exception e)
            {
                Service.LogError("fake exception "+ filename);
            }
        }
    }
}
