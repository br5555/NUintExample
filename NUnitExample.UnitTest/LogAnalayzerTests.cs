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

            ExtensionManagerFactory.SetManager(new FileExtensionManager());
            LogAnalyzer analayzer = new LogAnalyzer();

            bool result = analayzer.IsValidLogFileName(file);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsValidFileNmae_NameSuppotedExtension_ReturnsTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;

            ExtensionManagerFactory.SetManager(myFakeManager);
            LogAnalyzer log = new LogAnalyzer();

            bool result = log.IsValidLogFileName("shooort.ext");
            Assert.True(result);
        }
      

    }
}
