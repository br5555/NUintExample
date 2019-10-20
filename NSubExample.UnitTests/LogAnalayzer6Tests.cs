using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUintExample;
using NSubstitute;
using NUnit.Framework;

namespace NSubExample.UnitTests
{
    [TestFixture]
    public class LogAnalayzer6Tests : BaseTestsClass
    {
        [Test]
        public void Analyze_EmptyFile_ThrowsException()
        {
            FakeTheLogger();

            LogAnalayzer6 la = new LogAnalayzer6();
            la.Analayze("myemptyfile.txt");
            //rest of test


        }
    }
}
