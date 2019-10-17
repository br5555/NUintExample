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
    public class LogAnalayzer22tests
    {

        [Test]
        public void Analayze_WebServiceThrows_SendsEmail()
        {
            FakeWebService2 stubService = new FakeWebService2();
            stubService.ToThrow = new Exception("fake exception");

            FakeEmailService2 mockEMail = new FakeEmailService2();

            LogAnalayzer22 log = new LogAnalayzer22(stubService, mockEMail);

            string tooShortFileName = "abc.ext";
            log.Analayze(tooShortFileName);

            EmailInfo expectedEmail = new EmailInfo
            {
                Body = "fake exception",
                To = "someone@somewhere.com",
                Subject = "can't log"
            };

            Assert.AreEqual(expectedEmail, mockEMail.email);



        }
    }
}
