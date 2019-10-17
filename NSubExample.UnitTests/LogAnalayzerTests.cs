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
    public class LogAnalayzerTests
    {
        [Test]
        public void Analayze_TooShortFileName_CallLogger()
        {
            ILogger logger = Substitute.For<ILogger>();
            LogAnalayzer3 analyzer = new LogAnalayzer3(logger);

            analyzer.MinNameLength = 6;
            analyzer.Analayze("a.txt");

            logger.Received().LogError321("Filename too short: a.txt");
        }

        [Test]
        public void Returns_ByDefault_WorksForHardCodedArgument()
        {
            IFileNameRules fakeRules = Substitute.For<IFileNameRules>();

            fakeRules.IsValidLogFileName("strict.txt").Returns(true);

            Assert.IsTrue(fakeRules.IsValidLogFileName("strict.txt"));
        }

        [Test]
        public void Returns_ByDefault_WorksForHardCodedArgument2()
        {
            IFileNameRules fakeRules= Substitute.For<IFileNameRules>();

            //ignore the argument value
            fakeRules.IsValidLogFileName(Arg.Any<String>()).Returns(true);

            Assert.IsTrue(fakeRules.IsValidLogFileName("anything.txt"));
            
        }
        
        [Test]
        public void Returns_ArgAny_Throws()
        {
            IFileNameRules fakeRules = Substitute.For<IFileNameRules>();

            fakeRules.When(x => x.IsValidLogFileName( Arg.Any<string>() ) )
                     .Do(context => { throw new Exception("fake exception"); });

            Assert.Throws<Exception>(() => fakeRules.IsValidLogFileName("anything"));
        }

        [Test]
        public void Analayze_LoggerThrows_CallsWebService()
        {
            var mockWebService = Substitute.For<IWebService>();
            var stubLogger = Substitute.For<ILogger>();

            stubLogger.When(logger => logger.LogError321(Arg.Any<string>()))
                .Do(info => { throw new Exception("fake exception"); });

            var analayzer = new LogAnalayzer4(mockWebService, stubLogger);

            analayzer.Analayze("Short.txt");

            // checks that the mock web service was called with a string containing "fake exception"
            mockWebService.Received().LogError( Arg.Is<string>(s => s.Contains("fake exception") ) );

        }
    }
}
