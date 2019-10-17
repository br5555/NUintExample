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

    }
}
