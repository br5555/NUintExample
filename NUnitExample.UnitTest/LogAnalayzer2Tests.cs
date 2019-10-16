using NUintExample;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace NUnitExample.UnitTest
{
    [TestFixture]
    class LogAnalayzer2Tests
    {

        [Test]
        public void Analayze_WebServiceThrows_SendsEmail()
        {
            FakeWebService2 stubService = new FakeWebService2();
            stubService.ToThrow = new Exception("fake exception");

            FakeEmailService mockEmail = new FakeEmailService();


            LogAnalayzer2 log = new LogAnalayzer2(stubService, mockEmail);

            string tooShortFileName = "abc.ext";
            log.Analayze(tooShortFileName);

            StringAssert.Contains("someone@somewhere.com", mockEmail.To);
            StringAssert.Contains("fake exception", mockEmail.Body);
            StringAssert.Contains("can't log", mockEmail.Subject);
        }

    }
}
