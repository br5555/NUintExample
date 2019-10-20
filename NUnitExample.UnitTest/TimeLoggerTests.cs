using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUintExample;

namespace NUnitExample.UnitTest
{
    [TestFixture]
    public class TimeLoggerTests
    {

        public void SettingSystemTime_Always_ChangeTime()
        {
            //set fake date
            SystemTime.Set(new DateTime(2000, 1, 1));

            string output = TimeLogger.CreateMessage("a branko");

            StringAssert.Contains("01.01.2000", output);
        }

        [TearDown]
        public void afterEachTest()
        {
            //Reset date at end of each test
            SystemTime.Reset();
        }
    }
}
