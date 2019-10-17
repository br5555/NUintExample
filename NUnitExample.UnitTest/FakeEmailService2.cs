using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUintExample;

namespace NUnitExample.UnitTest
{
    public class FakeEmailService2 : IEmailService2
    {
        public EmailInfo email = null;
        public void SendEmail(EmailInfo emialInfo)
        {
            this.email = emialInfo;
        }
    }
}
