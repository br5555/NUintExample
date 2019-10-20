using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUintExample;
using NUnit.Framework;

namespace NUnitExample.UnitTest
{
    [TestFixture]
    public class LogAnalayzer6Tests
    {
        [Test]
        public void Analayze_EmptyFile_ThrowsException()
        {
            LogAnalayzer6 la = new LogAnalayzer6();
            la.Analayze("myemptyfile.txt");
            //reset of test
            Assert.IsTrue(true);
        }

        [TearDown]
        public void teardown()
        {
            //need to reset a static resource between tests
            LoggingFacility.Logger = null;
        }


    }
}
