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
    public class ConfigurationManagerTests
    {
        [Test]
        public void Analayze_EmptyFile_ThrowsException()
        {
            ConfigurationManager cm = new ConfigurationManager();
            bool configured = cm.IsConfigured("something");
            //rest of test
            Assert.IsTrue(configured);
        }

        [TearDown]
        public void teardown()
        {
            //need to reset a static resource between tests
            LoggingFacility.Logger = null;
        }

    }
}
