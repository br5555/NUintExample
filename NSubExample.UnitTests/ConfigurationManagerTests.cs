using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUintExample;

namespace NSubExample.UnitTests
{
    [TestFixture]
    public class ConfigurationManagerTests : BaseTestsClass
    {
        [Test]
        public void Analyze_EmptyFile_ThrowsException()
        {
            FakeTheLogger();

            ConfigurationManager cm = new ConfigurationManager();
            bool configured = cm.IsConfigured("something");
            //rest of test


        }
    }
}
