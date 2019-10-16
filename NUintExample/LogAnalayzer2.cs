using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public class LogAnalayzer2
    {
        public IWebService Service { get; set; }

        public IEmailService Email { get; set; }

        public LogAnalayzer2(IWebService service, IEmailService email)
        {
            Service = service;
            Email = email;
        }

        public void Analayze(string filename)
        {
            try
            {
                Service.LogError("Filenaem too short:" + filename);
            }catch(Exception e )
            {
                Email.SendEmail("someone@somewhere.com", "can't log", e.Message);
            }
        }
    }
}
