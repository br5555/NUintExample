using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public class LogAnalayzer22
    {
        public IWebService Service { get; set; }

        public IEmailService2 Email { get; set; }

        public LogAnalayzer22(IWebService service, IEmailService2 email)
        {
            Service = service;
            Email = email;
        }

        public void Analayze(string filename)
        {
            try
            {
                Service.LogError("Filenaem too short:" + filename);
            }
            catch (Exception e)
            {
                Email.SendEmail(new EmailInfo { To = "someone@somewhere.com",
                                                Subject = "can't log",
                                                 Body=  e.Message });
            }
        }
    }
}
