using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUintExample;
using NSubstitute;

namespace NSubExample.UnitTests
{
    [TestFixture]
    public class BaseTestsClass
    {
        public ILogger FakeTheLogger()
        {
            LoggingFacility.Logger = Substitute.For<ILogger>();
            return LoggingFacility.Logger;
        }

        [TearDown]
        public void teardown()
        {
            //need to reset a static resource between tests
            LoggingFacility.Logger = null;
        }
    }
}
