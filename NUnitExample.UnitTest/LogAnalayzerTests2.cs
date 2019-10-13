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
    class LogAnalayzerTests2
    {
        private LogAnalyzer m_analayzer = null;

        [SetUp]
        public void Setup()
        {

            ExtensionManagerFactory.SetManager(new FileExtensionManager());
            m_analayzer = new LogAnalyzer();
            
        }

        [Test]
        [Category("Fast test")]
        public void IsValidFileName_validFileNameLowerCased_RetureTrue()
        {
            bool result = m_analayzer.IsValidLogFileName("whatever.slf");

            Assert.IsTrue(result, "filename should be valid!");
        }

        [Test]
        [Category("Fast test")]
        public void IsValidFileName_validFileUpperCased_ReturnsTrue()
        {
            bool result = m_analayzer.IsValidLogFileName("whatever.SLF");

            Assert.IsTrue(result, "filename should be valid!");

        }


        [Test]
        [Ignore("there is a problem with this test")]
        public void IsValidFileName_ValidFile_ReturnsTrue()
        {
            //....
        }

        //[Test]
        //public void IsValidFileName_EMptyFileName_ThrowsFluent()
        //{
        //    LogAnalyzer la = MakeAnalayzer();

        //    var ex = Assert.Catch<Exception>( () => la.IsValidLogFileName("") );

        //    Assert.That(ex.Message, Is.StringContaning("filename has to be provided"));

        //}

        private LogAnalyzer MakeAnalayzer()
        {

            ExtensionManagerFactory.SetManager(new FileExtensionManager());
            LogAnalyzer la = new LogAnalyzer();
            
            return la;
        }


        [TestCase("badfile.foo", false)]
        [TestCase("goodfile.slf", true)]
        [Category("Fast test")]
        public void IsValidFileLogName_WhenCalled_ChangesWasLastFileNamevalid(string file, bool expected)
        {
            LogAnalyzer la = MakeAnalayzer();

            la.IsValidLogFileName(file);

            Assert.AreEqual(expected, la.WasLastFileNameValid);
        }

        [Test]
        [Category("Slow test")]
        public void IsValidFileName_EmptyFileName_Throws()
        {
            LogAnalyzer la = MakeAnalayzer();

            var ex = Assert.Catch<Exception>(() => la.IsValidLogFileName(""));

            StringAssert.Contains("filename has to be provided", ex.Message);
        }

        [Test]
        public void overrideTest()
        {
            

            TestableLogAnalayzer logan = new TestableLogAnalayzer();
            logan.IsSupported = true;

            bool result = logan.IsValidLogFileName("fillee.ext");
            
            Assert.True(result);
        }


        [TearDown]
        public void TearDown()
        {
            //the line below is included to show anti pattern
            //This is not really needed. Do not do it in real life
            m_analayzer = null;
        }


       
    }
}
