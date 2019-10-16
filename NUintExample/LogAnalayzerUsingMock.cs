using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public class LogAnalayzerUsingMock
    {
        private IWebService service;

        public LogAnalayzerUsingMock(IWebService service)
        {
            this.service = service;
        }

        public void Analayze(string fileName)
        {
            if(fileName.Length < 8)
            {
                service.LogError("Filename too short:" + fileName);
            }
        }
    }
}
