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
    class LogAnalayzerTests
    {
       

        [TestCase("filewithgoodextension.slf", true)]
        [TestCase("filewithgoodextension.SLF", true)]
        [TestCase("filewithbadextension.foo", false)]

        public void IsValidLogFileName_VariousExtensions_CheckThem(string file, bool expected)
        {
            LogAnalyzer analayzer = new LogAnalyzer();
            analayzer.ExtensionManager = new FileExtensionManager();

            bool result = analayzer.IsValidLogFileName(file);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsValidFileNmae_NameSuppotedExtension_ReturnsTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;

            LogAnalyzer log = new LogAnalyzer();
            log.ExtensionManager = myFakeManager;

            bool result = log.IsValidLogFileName("short.ext");
            Assert.True(result);
        }
      

    }
}
