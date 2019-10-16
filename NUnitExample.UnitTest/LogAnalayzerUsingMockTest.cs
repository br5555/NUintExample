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
    public class LogAnalayzerUsingMockTest
    {

        [Test]
        public void Analayze_TooShortFileName_CallsWebService()
        {
            FakeWebService mockService = new FakeWebService();
            LogAnalayzerUsingMock log = new LogAnalayzerUsingMock(mockService);
            string tooShortFileNmae = "abc.ext";

            log.Analayze(tooShortFileNmae);

            StringAssert.Contains("Filename too short:abc.ext", mockService.LastError);
        }

    }
}
